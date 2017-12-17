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
    public partial class UpdateStop : Form
    {
        private int id { get; set; }
        public UpdateStop(int id)
        {
            this.id = id;
            InitializeComponent();
            List<Stops> list = new List<Stops>();
            list = StopsSQLMapper.GetStop(id).ToList();
            Stops s = list.FirstOrDefault();
            idStopUpdate.Text = s.id.ToString();
            nazevStopUpdate.Text = s.sname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Stops st = new Stops();
                st.id = id;
                st.sname = nazevStopUpdate.Text;
                StopsSQLMapper.Update(st);
                MessageBox.Show("Zaznam aktualizovan.", "Hotovo", MessageBoxButtons.OK);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Neco se pokazilo.", "Ou damn", MessageBoxButtons.OK);
            }
        }
    }
}
