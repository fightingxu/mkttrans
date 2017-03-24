using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace gzdemo
{
    public partial class FormLogin : Form
    {
        private FormMain parentFrm;

        public FormLogin(FormMain parent)
        {
            InitializeComponent();

            parentFrm = parent;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.Equals(textBoxPassword.Text, textBoxConfirmPassword.Text))
            {
                MessageBox.Show("确认密码有误，请重新输入");
                return;
            }
            parentFrm.loginOracle(textBoxDBName.Text, textBoxUsername.Text, textBoxPassword.Text);
                    
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
       {
//             if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
//             {
//                 e.Handled = true;
//             }
        }

        private void buttonLogin_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
