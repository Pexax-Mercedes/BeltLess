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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.Label();
            this.NName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Beltless.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(272, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weight :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sitting Position :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Car Model :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Speed :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Model.ForeColor = System.Drawing.Color.White;
            this.Model.Location = new System.Drawing.Point(77, 18);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(0, 13);
            this.Model.TabIndex = 11;
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Speed.ForeColor = System.Drawing.Color.White;
            this.Speed.Location = new System.Drawing.Point(66, 41);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(0, 13);
            this.Speed.TabIndex = 12;
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Weight.ForeColor = System.Drawing.Color.White;
            this.Weight.Location = new System.Drawing.Point(90, 77);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(0, 13);
            this.Weight.TabIndex = 14;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Position.ForeColor = System.Drawing.Color.White;
            this.Position.Location = new System.Drawing.Point(130, 93);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(0, 13);
            this.Position.TabIndex = 15;
            // 
            // Car
            // 
            this.Car.AutoSize = true;
            this.Car.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Car.ForeColor = System.Drawing.Color.White;
            this.Car.Location = new System.Drawing.Point(79, 24);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(15, 13);
            this.Car.TabIndex = 16;
            this.Car.Text = "..";
            // 
            // NName
            // 
            this.NName.AutoSize = true;
            this.NName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.NName.ForeColor = System.Drawing.Color.White;
            this.NName.Location = new System.Drawing.Point(62, 64);
            this.NName.Name = "NName";
            this.NName.Size = new System.Drawing.Size(11, 13);
            this.NName.TabIndex = 17;
            this.NName.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.NName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Car);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Weight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Speed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Model);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(24, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 128);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Beltless.Properties.Resources.Mercedes_ic;
            this.ClientSize = new System.Drawing.Size(1022, 725);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Demo For Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

