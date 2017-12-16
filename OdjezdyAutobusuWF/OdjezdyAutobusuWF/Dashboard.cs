using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdjezdyAutobusuWF
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            /*Login l = new Login();
            l.Show();
            l.TopMost = true;*/
            
            InitializeComponent();
            loadDataToGridView();
        }

        private void přidatZpožděníToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zpozdeni zp = new Zpozdeni();
            zp.Show();
        }

        public bool loadDataToGridView()
        {
            List<Times> times = TimesSQLMapper.GetTimesAll().ToList();

            dataGridView.DataSource = times;
            dataGridView.Refresh();
            return false;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void přidatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.Show();
        }
    }
}
