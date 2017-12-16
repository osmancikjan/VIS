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
        List<string> zastavky = new List<string>();
        List<int> busy = new List<int>();
        public Zpozdeni()
        {
            LoadData();
            InitializeComponent();
            cisloBus.DataSource = busy;
            Zastavka.DataSource = zastavky;
        }

        private void potvrditZpozdeniButton_Click(object sender, EventArgs e)
        {
            List<TimesAdd> times = new List<TimesAdd>();
            int bid = Int32.Parse(cisloBus.Text);
            int sid = Zastavka.SelectedIndex;
            DateTime dt = dateTimePicker.Value;
            int delay = (Int32)zpozdeniMinut.Value;

            times = TimesSQLMapper.GetTimeForUpdate(sid, bid, dt).ToList();
            if(times.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Zaznam je jiz v databazi. Chcete prepsat zaznam v databazi?", "Upozorneni", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        TimesAdd t = new TimesAdd();
                        t = times.First();
                        t.delay = delay;
                        TimesSQLMapper.Update(t);
                    } catch
                    {
                        MessageBox.Show("Ouha, neco se pokazilo a zaznam nebyl upraven.", "Upozorneni", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void LoadData()
        {
            List<Stops> stops = StopsSQLMapper.GetStops().ToList();
            zastavky.Clear();
            busy.Clear();
            foreach (var item in stops)
            {
                zastavky.Add(item.sname);
            }
            List<Buses> buses = BusesSQLMapper.GetBuses().ToList();
            foreach (var item in buses)
            {
                busy.Add(item.lnumber);
            }
        }
    }
}
