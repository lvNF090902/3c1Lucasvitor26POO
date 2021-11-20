using _3C1LUCAS26.bll;
using _3C1LUCAS26.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1LUCAS26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        Loginbll userbll = new Loginbll();
        Logindto userdto = new Logindto();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            userdto.login = txtlogin.Text;
            userdto.senha = txtsenha.Text;

            if (userbll.RealizarLogin(userdto) == true)
            {
                Form2 produtos = new Form2();
                produtos.Show();
            }
            else
            {
                MessageBox.Show("Verifique seu login");
            }
        }
    }
}
