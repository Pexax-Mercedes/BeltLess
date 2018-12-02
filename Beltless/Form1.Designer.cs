namespace Beltless
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CarModel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Speed = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Postion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(475, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Location = new System.Drawing.Point(492, 47);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(129, 54);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start ";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speed :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name :";
            // 
            // CarModel
            // 
            this.CarModel.AutoSize = true;
            this.CarModel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CarModel.Location = new System.Drawing.Point(67, 26);
            this.CarModel.Name = "CarModel";
            this.CarModel.Size = new System.Drawing.Size(13, 13);
            this.CarModel.TabIndex = 9;
            this.CarModel.Text = "..";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(9, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Beltless.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(270, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Speed.Location = new System.Drawing.Point(54, 43);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(13, 13);
            this.Speed.TabIndex = 11;
            this.Speed.Text = "..";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Weight.Location = new System.Drawing.Point(52, 78);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(13, 13);
            this.Weight.TabIndex = 13;
            this.Weight.Text = "..";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name1.Location = new System.Drawing.Point(51, 59);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(13, 13);
            this.Name1.TabIndex = 12;
            this.Name1.Text = "..";
            // 
            // Postion
            // 
            this.Postion.AutoSize = true;
            this.Postion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Postion.Location = new System.Drawing.Point(60, 98);
            this.Postion.Name = "Postion";
            this.Postion.Size = new System.Drawing.Size(13, 13);
            this.Postion.TabIndex = 14;
            this.Postion.Text = "..";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Postion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Name1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Speed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CarModel);
            this.groupBox1.Location = new System.Drawing.Point(28, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 132);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Beltless.Properties.Resources.Mercedes_ic;
            this.ClientSize = new System.Drawing.Size(876, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Demo For Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
     
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CarModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Postion;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

