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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            id.Text = UsersSQLMapper.GetCount().ToString();
        }

        private void pridat_Click(object sender, EventArgs e)
        {
            if(jmeno.Text == "" || prijmeni.Text == "" || email.Text == "" || heslo.Text == "")
            {
                MessageBox.Show("Chyba", "Pole jsou prazdna", MessageBoxButtons.OK);
            } else
            {
                try
                {
                    Users u = new Users();
                    u.id = Int32.Parse(id.Text);
                    u.firstname = jmeno.Text;
                    u.lastname = prijmeni.Text;
                    u.email = email.Text;
                    u.pwd = heslo.Text;
                    u.permision = permision.Text;
                    UsersSQLMapper.Insert(u);
                    MessageBox.Show("Uzivatel byl uspesne pridan", "Uspech", MessageBoxButtons.OK);
                    this.Close();
                } catch
                {
                     MessageBox.Show("Ouha. Neco se pokazilo. Uzivatel nebyl pridan.", "Chyba", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
