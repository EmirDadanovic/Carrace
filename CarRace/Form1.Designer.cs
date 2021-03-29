
namespace CarRace
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvajs1 = new System.Windows.Forms.PictureBox();
            this.dvajs3 = new System.Windows.Forms.PictureBox();
            this.dvajs2 = new System.Windows.Forms.PictureBox();
            this.dvajs4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(182, -73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(182, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 118);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(182, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 118);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(159, 345);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(54, 55);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 3;
            this.car.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(12, 234);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(34, 33);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(120, 57);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(36, 37);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 3;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(270, 130);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(36, 33);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 3;
            this.enemy3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(111, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "GAME OVER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dvajs1
            // 
            this.dvajs1.Image = ((System.Drawing.Image)(resources.GetObject("dvajs1.Image")));
            this.dvajs1.Location = new System.Drawing.Point(32, 154);
            this.dvajs1.Name = "dvajs1";
            this.dvajs1.Size = new System.Drawing.Size(27, 23);
            this.dvajs1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dvajs1.TabIndex = 5;
            this.dvajs1.TabStop = false;
            // 
            // dvajs3
            // 
            this.dvajs3.Image = ((System.Drawing.Image)(resources.GetObject("dvajs3.Image")));
            this.dvajs3.Location = new System.Drawing.Point(235, 57);
            this.dvajs3.Name = "dvajs3";
            this.dvajs3.Size = new System.Drawing.Size(22, 20);
            this.dvajs3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dvajs3.TabIndex = 6;
            this.dvajs3.TabStop = false;
            // 
            // dvajs2
            // 
            this.dvajs2.Image = ((System.Drawing.Image)(resources.GetObject("dvajs2.Image")));
            this.dvajs2.Location = new System.Drawing.Point(32, 18);
            this.dvajs2.Name = "dvajs2";
            this.dvajs2.Size = new System.Drawing.Size(39, 37);
            this.dvajs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dvajs2.TabIndex = 8;
            this.dvajs2.TabStop = false;
            // 
            // dvajs4
            // 
            this.dvajs4.Image = ((System.Drawing.Image)(resources.GetObject("dvajs4.Image")));
            this.dvajs4.Location = new System.Drawing.Point(308, 285);
            this.dvajs4.Name = "dvajs4";
            this.dvajs4.Size = new System.Drawing.Size(21, 22);
            this.dvajs4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dvajs4.TabIndex = 9;
            this.dvajs4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(290, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Feninzi =0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvajs4);
            this.Controls.Add(this.dvajs2);
            this.Controls.Add(this.dvajs3);
            this.Controls.Add(this.dvajs1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvajs4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dvajs1;
        private System.Windows.Forms.PictureBox dvajs3;
        private System.Windows.Forms.PictureBox dvajs2;
        private System.Windows.Forms.PictureBox dvajs4;
        private System.Windows.Forms.Label label2;
    }
}

