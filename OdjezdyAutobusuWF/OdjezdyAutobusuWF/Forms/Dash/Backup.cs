using Mapper.DataMapper;
using Mapper.SQLMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace OdjezdyAutobusuWF
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = ReplaceFileName(fileName.Text);
            if(filename != "" || filename != null)
            {
                string path = @"..\..\Zaloha\";
                
                List <TimesAdd> all = TimesSQLMapper.GetTimesBackup().ToList();

                XmlSerializer ser = new XmlSerializer(typeof(List<TimesAdd>));
                try
                {
                    using (FileStream fs = new FileStream(path + filename + ".xml", FileMode.Create))
                    {
                        ser.Serialize(fs, all);
                    }

                    MessageBox.Show("Zaloha byla uspesne vytvorena. Cesta k souboru je: " + path, "Uspech", MessageBoxButtons.OK);
                } catch
                {
                    MessageBox.Show("Ouha! Neco se pokazilo. Zaloha nemohla byt vytvorena! V pripade pretrvavajicich problemu se obratte na spravce systemu.","Neco se pokazilo", MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show("Nezadal/a jste platny nazev souboru.", "Chyba", MessageBoxButtons.OK);
            }
        }
        private string ReplaceFileName(string filename)
        {
            filename = filename.Replace(".", "");
            filename = filename.Replace(@"\", "");
            filename = filename.Replace("/", "");
            filename = filename.Replace(":", "");
            filename = filename.Replace("*", "");
            filename = filename.Replace("?", "");
            filename = filename.Replace("\"", "");
            filename = filename.Replace("<", "");
            filename = filename.Replace(">", "");
            filename = filename.Replace("|", "");
            return filename;
        }
    }
}
