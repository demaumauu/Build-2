namespace Build_2_v0._1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn2_Back = new System.Windows.Forms.Button();
            this.btn_Tutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2_Back
            // 
            this.btn2_Back.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn2_Back.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_Back.Location = new System.Drawing.Point(72, 269);
            this.btn2_Back.Name = "btn2_Back";
            this.btn2_Back.Size = new System.Drawing.Size(94, 46);
            this.btn2_Back.TabIndex = 0;
            this.btn2_Back.Text = "Back";
            this.btn2_Back.UseVisualStyleBackColor = false;
            this.btn2_Back.Click += new System.EventHandler(this.btn2_Back_Click);
            // 
            // btn_Tutorial
            // 
            this.btn_Tutorial.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Tutorial.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tutorial.Location = new System.Drawing.Point(594, 269);
            this.btn_Tutorial.Name = "btn_Tutorial";
            this.btn_Tutorial.Size = new System.Drawing.Size(100, 45);
            this.btn_Tutorial.TabIndex = 1;
            this.btn_Tutorial.Text = "Tutorial";
            this.btn_Tutorial.UseVisualStyleBackColor = false;
            this.btn_Tutorial.Click += new System.EventHandler(this.btn_Tutorial_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 426);
            this.Controls.Add(this.btn2_Back);
            this.Controls.Add(this.btn_Tutorial);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2_Back;
        private System.Windows.Forms.Button btn_Tutorial;
    }
}