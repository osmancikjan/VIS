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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        public UpdateUser(int id)
        {
            InitializeComponent();
            Users u = new Users();
            u = UsersSQLMapper.GetUser(id).FirstOrDefault();
            uID.Text = u.id.ToString();
            uemail.Text = u.email;
            ujmeno.Text = u.firstname;
            uprijmeni.Text = u.lastname;
            upwd.Text = u.pwd;
            uperm.Text = u.permision;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Users u = new Users();
                u.id = Int32.Parse(uID.Text);
                u.email = uemail.Text;
                u.firstname = ujmeno.Text;
                u.lastname = uprijmeni.Text;
                u.pwd = upwd.Text;
                u.permision = uperm.Text;
                UsersSQLMapper.Update(u);
                MessageBox.Show("Zaznam byl uspesne upraven.","Hotovo",MessageBoxButtons.OK);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Oou, nekde se stala chyba. Zaznam nebyl pridan.", "Chyba", MessageBoxButtons.OK);
            }
        }
    }
}
