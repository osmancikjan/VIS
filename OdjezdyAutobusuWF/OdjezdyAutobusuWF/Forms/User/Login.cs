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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.TextLength > 0 && passwordTextBox.TextLength > 0)
            {
                List<Users> input = UsersSQLMapper.Role(emailTextBox.Text, passwordTextBox.Text, 'A').ToList();
                if (input.Count > 0)
                {
                    if (input.First().email != emailTextBox.Text && input.First().pwd != passwordTextBox.Text)
                    {
                        MessageBox.Show("Chyba", "Nesprávný email nebo heslo.", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Dashboard dash = new Dashboard();
                        dash.Show();
                    }
                }
                else
                {
                    List<Users> input2 = UsersSQLMapper.Role(emailTextBox.Text, passwordTextBox.Text, 'D').ToList();
                    if (input2.Count > 0)
                    {
                        if (input2.First().email != emailTextBox.Text && input2.First().pwd != passwordTextBox.Text)
                        {
                            MessageBox.Show("Chyba", "Nesprávný email nebo heslo.", MessageBoxButtons.OK);
                        }
                        else
                        {
                            Dashboard dash = new Dashboard('D');
                            dash.Show();
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Chyba", "Nesprávný email nebo heslo.", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chyba", "Email a heslo musí být zadáno!", MessageBoxButtons.OK);
            }
        }
    }
}
