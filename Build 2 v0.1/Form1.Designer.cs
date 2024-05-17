namespace Build_2_v0._1
{
    partial class Title_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Title_Screen));
            this.btn1_Start = new System.Windows.Forms.Button();
            this.title_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1_Start
            // 
            this.btn1_Start.BackColor = System.Drawing.Color.GhostWhite;
            this.btn1_Start.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_Start.Location = new System.Drawing.Point(331, 368);
            this.btn1_Start.Name = "btn1_Start";
            this.btn1_Start.Size = new System.Drawing.Size(134, 29);
            this.btn1_Start.TabIndex = 0;
            this.btn1_Start.Text = "Click to Start!";
            this.btn1_Start.UseVisualStyleBackColor = false;
            this.btn1_Start.Click += new System.EventHandler(this.btn1_Start_Click);
            // 
            // title_box
            // 
            this.title_box.AcceptsTab = true;
            this.title_box.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.title_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_box.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_box.Location = new System.Drawing.Point(244, 308);
            this.title_box.Multiline = true;
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(315, 44);
            this.title_box.TabIndex = 1;
            this.title_box.Text = "Coding Game";
            this.title_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Title_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.btn1_Start);
            this.Name = "Title_Screen";
            this.Text = "Title_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_Start;
        private System.Windows.Forms.TextBox title_box;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

