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
            string path = "../";
            List<TimesAdd> all = TimesSQLMapper.GetTimesBackup().ToList();
            var xml = new XElement("Times", all.Select(x => new XElement("Time",
                                       new XAttribute("ID", x.id),
                                       new XAttribute("SID", x.s_id),
                                       new XAttribute("BID", x.b_id),
                                       new XAttribute("Leaving", x.leaving),
                                       new XAttribute("Delay", x.delay),
                                       new XAttribute("NextStop", x.next_stop),
                                       new XAttribute("LastKnownStop", x.last_known_stop))));

            foreach (var item in all)
            {
                Save<TimesAdd>(item, path + "/new.xml");
            }
            
            //File.Create(path + "zaloha.xml");
            StreamWriter sw = File.CreateText(path + "zaloha.xml");
            
                
                XmlTextWriter xtw = new XmlTextWriter(sw);

                xtw.WriteStartElement("Times");
            foreach (var item in all)
            {
                xtw.WriteElementString("id", item.id.ToString());
                xtw.WriteElementString("s_id", item.s_id.ToString());
                xtw.WriteElementString("b_id", item.b_id.ToString());
                xtw.WriteElementString("leaving", item.leaving.ToString());
                xtw.WriteElementString("tdelay", item.delay.ToString());
                xtw.WriteElementString("next_stop", item.next_stop.ToString());
                xtw.WriteElementString("last_known_stop", item.last_known_stop.ToString());
            }
            xtw.Close();
            
            MessageBox.Show("Uspech", "Zaloha byla uspesne vytvorena. Cesta k souboru je: " + path, MessageBoxButtons.OK);

        }
        public void Save<T>(T file, String path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, file);
            }
        }
       
    }
}
