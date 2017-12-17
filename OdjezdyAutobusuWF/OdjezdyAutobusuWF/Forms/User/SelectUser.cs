using Mapper.SQLMapper;
using Mapper.DataMapper;
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
    public partial class SelectUser : Form
    {
        List<string> uzivatele = new List<string>();
        public SelectUser()
        {
            LoadData();
            InitializeComponent();
            userSelect.DataSource = uzivatele;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateUser uu = new UpdateUser(userSelect.SelectedIndex);
            uu.Show();
        }

        private void LoadData()
        {
            List<Users> users = UsersSQLMapper.GetUsers().ToList();
            uzivatele.Clear();
            foreach (var item in users)
            {
                uzivatele.Add(item.email);
            }
        }
    }
}
