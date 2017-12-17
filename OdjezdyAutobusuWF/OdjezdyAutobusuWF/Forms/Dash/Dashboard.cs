using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

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

        public Dashboard(char permision)
        {
            InitializeComponent();
            if(permision == 'D')
            {
                zastávkyToolStripMenuItem.Enabled = true;
                uživateléToolStripMenuItem.Enabled = false;
                nováZastávkaToolStripMenuItem.Enabled = false;
                upravitZastávkuToolStripMenuItem.Enabled = false;
            }
            
            loadDataToGridView();
        }

        [XmlArray("Times"), XmlArrayItem(typeof(Times), ElementName = "Time")]
        private List<Times> all = new List<Times>();

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

        private void zálohovatDoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup bp = new Backup();
            bp.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadDataToGridView();
        }

        private void nováZastávkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStop AS = new AddStop();
            AS.Show();
        }

        private void upravitZastávkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectStop ss = new SelectStop();
            ss.Show();
        }

        private void upravitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectUser su = new SelectUser();
            su.Show();
        }
    }
}
