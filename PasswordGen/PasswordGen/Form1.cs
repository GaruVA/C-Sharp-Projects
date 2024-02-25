using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trbLength.Value = 8;
            trbLength_ValueChanged(null, null);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void trbLength_ValueChanged(object sender, EventArgs e)
        {
            lblLength.Text = $"Password Length: {trbLength.Value}";
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            string charList = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_+=[]{}|\\;:'\"<>,.?/";
            int index;
            for (int i = 0; i < trbLength.Value; i++)
            {
                index = random.Next(0, charList.Length);
                password.Append(charList[index]);
            }
            lblPassword.Text = password.ToString();
        }
    }
}
