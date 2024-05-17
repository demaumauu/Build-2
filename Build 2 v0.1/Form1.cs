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
    public partial class Title_Screen : Form
    {
        public Title_Screen()
        {
            InitializeComponent();
        }

        private void btn1_Start_Click(object sender, EventArgs e)
        {
            Menu f2 = new Menu();
            f2.Owner = this;
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = this.Location;
            f2.Show();
            this.Hide();
        }
    }
}
