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
    public partial class Tutorial : Form
    {

        int size = 5;
        int x = 0;
        int y = 2;

        PictureBox[,] pictures = new PictureBox[5, 5];


        string imgPlayer = Directory.GetCurrentDirectory() + "/images/monkey.png";
        string imgBackground = Directory.GetCurrentDirectory() + "/images/star.png";


        public Tutorial()
        {
            InitializeComponent();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pictures[i, j] = new PictureBox();
                    pictures[i, j].Image = Image.FromFile(imgBackground);
                    pictures[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    tableLayoutPanel1.Controls.Add(pictures[i, j]);
                }
            }
            pictures[y, x].Image = Image.FromFile(imgPlayer);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string[] allLines = txtMultiLine.Text.Split('\n');

            int count = 1;

            btnGo.Text = allLines[0];

            foreach (string text in allLines)

            { 
                move(text.Replace("\r", "")); 
                // stripping out junk characters to have multiple commands working
                // replace = equivalent to the current string except all intances of old value is replaced by new value
                // /r is a carriage return that returns the cursor or text input to the beginning of the current line
                //Meaning it wont just run the most recent input in the line, but it will go back to the start and run those as well.

                // replacing previous text with new text = old input becomes replaced with new input as each of them run in the code. /r makes it so that instead of just
                // running the most recent input, the code goes back to the beginning of the input and run those as well.

                // previous input is getting skipped over amd remndering them false, so by having /r we run through them aswell.

                count++;
            }

            txtMultiLine.Clear();
        }

        public void move(string playerMove)
        {
            if (playerMove == "player.RIGHT")
            {
                if (x < size - 1)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackground);

                    x++;

                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            else if (playerMove == "player.LEFT")
            {
                if (x > 0)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackground);
                    x--;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            else if (playerMove == "player.UP")
            {
                if (y > 0)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackground);
                    y--;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
            else if (playerMove == "player.DOWN")
            {
                if (y < size - 1)
                {
                    pictures[y, x].Image = Image.FromFile(imgBackground);
                    y++;
                    pictures[y, x].Image = Image.FromFile(imgPlayer);
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            pictures[y, x].Image = Image.FromFile(imgBackground);
            x = 0;
            y = 2;
            pictures[y, x].Image = Image.FromFile(imgPlayer);
        }
    }
}
