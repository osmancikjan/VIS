using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdjezdyAutobusuWF
{
    public partial class Zpozdeni : Form
    {
        List<string> zastavky1 = new List<string>();
        List<string> zastavky2 = new List<string>();
        List<string> zastavky3 = new List<string>();
        List<int> busy = new List<int>();
        public Zpozdeni()
        {
            LoadData();
            InitializeComponent();
            cisloBus.DataSource = busy;
            Zastavka.DataSource = zastavky1;
            nextStop.DataSource = zastavky2;
            lastKnown.DataSource = zastavky3;
        }

        private void potvrditZpozdeniButton_Click(object sender, EventArgs e)
        {
            List<TimesAdd> times = new List<TimesAdd>();
            TimesAdd time = new TimesAdd();
            time.id = TimesSQLMapper.GetCount();
            time.s_id = Zastavka.SelectedIndex;
            time.b_id = Int32.Parse(cisloBus.Text);
            time.leaving = dateTimePicker.Value;
            time.delay = (Int32)zpozdeniMinut.Value;
            time.next_stop = nextStop.SelectedIndex;
            time.last_known_stop = lastKnown.SelectedIndex;

            times = TimesSQLMapper.GetTimeForUpdate(time.s_id, time.b_id, time.leaving).ToList();
            if(times.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Zaznam je jiz v databazi. Chcete prepsat zaznam v databazi?", "Upozorneni", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    try
                    {                       
                        TimesSQLMapper.Update(time);
                        MessageBox.Show("Zaznam byl upraven.", "Hotovo", MessageBoxButtons.OK);
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Ouha, neco se pokazilo a zaznam nebyl upraven.", "Upozorneni", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                try
                {
                    TimesSQLMapper.Insert(time);
                    MessageBox.Show("Zaznam byl upraven.", "Hotovo", MessageBoxButtons.OK);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Ouha, neco se pokazilo a zaznam nebyl vlozen.", "Upozorneni", MessageBoxButtons.OK);
                }
            }
        }

        private void LoadData()
        {
            List<Stops> stops = StopsSQLMapper.GetStops().ToList();
            zastavky1.Clear();
            zastavky2.Clear();
            zastavky3.Clear();
            busy.Clear();
            foreach (var item in stops)
            {
                zastavky1.Add(item.sname);
                zastavky2.Add(item.sname);
                zastavky3.Add(item.sname);
            }
            List<Buses> buses = BusesSQLMapper.GetBuses().ToList();
            foreach (var item in buses)
            {
                busy.Add(item.lnumber);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
