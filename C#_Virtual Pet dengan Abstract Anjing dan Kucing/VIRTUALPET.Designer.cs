namespace VIRTUAL_PET
{
    partial class VIRTUALPET
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIRTUALPET));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonchangepet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarmood = new System.Windows.Forms.ProgressBar();
            this.progressBarstamina = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonmood = new System.Windows.Forms.Button();
            this.buttonstamina = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxname = new System.Windows.Forms.Label();
            this.textBoxage = new System.Windows.Forms.Label();
            this.textBoxstatus = new System.Windows.Forms.Label();
            this.textBoxresponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(252, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonchangepet
            // 
            this.buttonchangepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonchangepet.Location = new System.Drawing.Point(12, 270);
            this.buttonchangepet.Name = "buttonchangepet";
            this.buttonchangepet.Size = new System.Drawing.Size(92, 48);
            this.buttonchangepet.TabIndex = 2;
            this.buttonchangepet.Text = "CHANGE PET";
            this.buttonchangepet.UseVisualStyleBackColor = true;
            this.buttonchangepet.Click += new System.EventHandler(this.buttonchangepet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Response";
            // 
            // progressBarmood
            // 
            this.progressBarmood.ForeColor = System.Drawing.Color.Coral;
            this.progressBarmood.Location = new System.Drawing.Point(121, 360);
            this.progressBarmood.Name = "progressBarmood";
            this.progressBarmood.Size = new System.Drawing.Size(443, 23);
            this.progressBarmood.TabIndex = 11;
            // 
            // progressBarstamina
            // 
            this.progressBarstamina.ForeColor = System.Drawing.Color.Coral;
            this.progressBarstamina.Location = new System.Drawing.Point(121, 415);
            this.progressBarstamina.Name = "progressBarstamina";
            this.progressBarstamina.Size = new System.Drawing.Size(443, 23);
            this.progressBarstamina.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(31, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "MOOD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(0, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "STAMINA";
            // 
            // buttonmood
            // 
            this.buttonmood.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonmood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmood.Location = new System.Drawing.Point(570, 351);
            this.buttonmood.Name = "buttonmood";
            this.buttonmood.Size = new System.Drawing.Size(75, 49);
            this.buttonmood.TabIndex = 15;
            this.buttonmood.Text = "PLAY";
            this.buttonmood.UseVisualStyleBackColor = false;
            this.buttonmood.Click += new System.EventHandler(this.buttonmood_Click);
            // 
            // buttonstamina
            // 
            this.buttonstamina.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonstamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstamina.Location = new System.Drawing.Point(570, 406);
            this.buttonstamina.Name = "buttonstamina";
            this.buttonstamina.Size = new System.Drawing.Size(75, 49);
            this.buttonstamina.TabIndex = 16;
            this.buttonstamina.Text = "EAT";
            this.buttonstamina.UseVisualStyleBackColor = false;
            this.buttonstamina.Click += new System.EventHandler(this.buttonstamina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxname
            // 
            this.textBoxname.AutoSize = true;
            this.textBoxname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxname.Location = new System.Drawing.Point(76, 12);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(70, 24);
            this.textBoxname.TabIndex = 21;
            this.textBoxname.Text = "NAME";
            // 
            // textBoxage
            // 
            this.textBoxage.AutoSize = true;
            this.textBoxage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxage.Location = new System.Drawing.Point(76, 42);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(53, 24);
            this.textBoxage.TabIndex = 22;
            this.textBoxage.Text = "AGE";
            // 
            // textBoxstatus
            // 
            this.textBoxstatus.AutoSize = true;
            this.textBoxstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxstatus.Location = new System.Drawing.Point(101, 192);
            this.textBoxstatus.Name = "textBoxstatus";
            this.textBoxstatus.Size = new System.Drawing.Size(90, 24);
            this.textBoxstatus.TabIndex = 23;
            this.textBoxstatus.Text = "STATUS";
            // 
            // textBoxresponse
            // 
            this.textBoxresponse.AutoSize = true;
            this.textBoxresponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxresponse.Location = new System.Drawing.Point(101, 218);
            this.textBoxresponse.Name = "textBoxresponse";
            this.textBoxresponse.Size = new System.Drawing.Size(122, 24);
            this.textBoxresponse.TabIndex = 24;
            this.textBoxresponse.Text = "RESPONSE";
            // 
            // VIRTUALPET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.textBoxresponse);
            this.Controls.Add(this.textBoxstatus);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.buttonstamina);
            this.Controls.Add(this.buttonmood);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarstamina);
            this.Controls.Add(this.progressBarmood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonchangepet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VIRTUALPET";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonchangepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarmood;
        private System.Windows.Forms.ProgressBar progressBarstamina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonmood;
        private System.Windows.Forms.Button buttonstamina;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label textBoxname;
        private System.Windows.Forms.Label textBoxage;
        private System.Windows.Forms.Label textBoxstatus;
        private System.Windows.Forms.Label textBoxresponse;
    }
}

