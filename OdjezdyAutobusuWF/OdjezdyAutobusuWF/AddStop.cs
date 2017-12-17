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
    public partial class AddStop : Form
    {
        public AddStop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stopName.Text != null && stopName.Text != "")
            {
                try
                {
                    Stops s = new Stops();
                    s.id = StopsSQLMapper.GetCount()+1;
                    s.sname = stopName.Text;
                    StopsSQLMapper.Insert(s);
                    MessageBox.Show("Zastavka uspesne pridana.", "Hotovo", MessageBoxButtons.OK);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Oou neco se pokazilo. Zastavka nebyla uspesne pridana.", "Chyba", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nezadal/a jste nazev!", "Chyba", MessageBoxButtons.OK);
            }
        }

        private void AddStop_Load(object sender, EventArgs e)
        {

        }
    }
}
