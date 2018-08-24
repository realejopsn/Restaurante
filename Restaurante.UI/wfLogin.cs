using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.UI
{
    public partial class wfLogin : Form
    {
        public wfLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var pass = GetMD5Hash(txtPass.Text).ToString();

            var query = (from a in Restaurante.BS.clUsuario._Instancia.Get().AsEnumerable()
                         where a.Cedula == Int32.Parse(txtUsuario.Text) && a.Contrasenna == pass.ToString()
                         select new { a.Cedula, a.Contrasenna }

                         ).ToList();

            if (query.Count > 0)
            {
                MessageBox.Show("Bienvenido");
                wfMain screen = new wfMain();
                screen.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválida. Intente de nuevo");
            }
        }

        private object GetMD5Hash(string text)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //byte[] bs = System.Text.Encoding.ASCII.GetBytes(input);
            //byte[] bs = System.Text.Encoding.UTF7.GetBytes(input);
            //byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] bs = System.Text.Encoding.Unicode.GetBytes(text);
            //byte[] bs = System.Text.Encoding.UTF32.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
