using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Build_2_v0._1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            Console.WriteLine("Welcome to Game!");
        }

        private void btn2_Back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_Tutorial_Click(object sender, EventArgs e)
        {
            Tutorial f2 = new Tutorial();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();

            
        }

    }
}
