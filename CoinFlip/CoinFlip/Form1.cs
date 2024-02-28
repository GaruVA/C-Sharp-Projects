using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private async void btnCoinFlip_Click(object sender, EventArgs e)
        {
            Random coinFlip = new Random();
            btnCoinFlip.Text = "FLIPPING...";
            await Task.Delay(1000);
            int result = coinFlip.Next(1,3);
            if (result == 1)
            {
                lblCoinFlip.Text = "Heads";
                picCoinFlip.ImageLocation = @"C:\Users\User\source\repos\CoinFlip\heads.png";
                picCoinFlip.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                lblCoinFlip.Text = "Tails";
                picCoinFlip.ImageLocation = @"C:\Users\User\source\repos\CoinFlip\tails.png";
                picCoinFlip.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            btnCoinFlip.Text = "FLIP AGAIN";
        }
    }
}
