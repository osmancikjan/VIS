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
    public partial class SelectStop : Form
    {
        private List<string> zastavky = new List<string>();
        public SelectStop()
        {
            LoadData();
            InitializeComponent();
            select.DataSource = zastavky;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStop us = new UpdateStop(select.SelectedIndex);
            us.Show();
            this.Close();
        }

        private void LoadData()
        {
            List<Stops> stops = StopsSQLMapper.GetStops().ToList();
            zastavky.Clear();
            foreach (var item in stops)
            {
                zastavky.Add(item.sname);
            }
        }
    }
}
