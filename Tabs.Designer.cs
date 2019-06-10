namespace WindowsFormsApp17
{
    partial class Tabs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabs));
            this.LblError = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            this.OptNein = new System.Windows.Forms.RadioButton();
            this.OptJa = new System.Windows.Forms.RadioButton();
            this.LblInSek = new System.Windows.Forms.Label();
            this.TxtWieLang = new System.Windows.Forms.TextBox();
            this.TxtWieOft = new System.Windows.Forms.TextBox();
            this.LblWieOft = new System.Windows.Forms.Label();
            this.LblWieLang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanWebsite = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.PanWebsite.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(16, 448);
            this.LblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 77;
            // 
            // CmdStart
            // 
            this.CmdStart.Enabled = false;
            this.CmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdStart.Location = new System.Drawing.Point(262, 511);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(135, 38);
            this.CmdStart.TabIndex = 76;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // OptNein
            // 
            this.OptNein.AutoSize = true;
            this.OptNein.Location = new System.Drawing.Point(61, 74);
            this.OptNein.Name = "OptNein";
            this.OptNein.Size = new System.Drawing.Size(47, 17);
            this.OptNein.TabIndex = 67;
            this.OptNein.TabStop = true;
            this.OptNein.Text = "Nein";
            this.OptNein.UseVisualStyleBackColor = true;
            this.OptNein.CheckedChanged += new System.EventHandler(this.OptNein_CheckedChanged);
            // 
            // OptJa
            // 
            this.OptJa.AutoSize = true;
            this.OptJa.Location = new System.Drawing.Point(19, 73);
            this.OptJa.Name = "OptJa";
            this.OptJa.Size = new System.Drawing.Size(36, 17);
            this.OptJa.TabIndex = 0;
            this.OptJa.TabStop = true;
            this.OptJa.Text = "Ja";
            this.OptJa.UseVisualStyleBackColor = true;
            this.OptJa.CheckedChanged += new System.EventHandler(this.OptJa_CheckedChanged);
            // 
            // LblInSek
            // 
            this.LblInSek.AutoSize = true;
            this.LblInSek.Font = new System.Drawing.Font("HelvLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInSek.Location = new System.Drawing.Point(16, 400);
            this.LblInSek.Name = "LblInSek";
            this.LblInSek.Size = new System.Drawing.Size(69, 13);
            this.LblInSek.TabIndex = 74;
            this.LblInSek.Text = "In Sekunden";
            this.LblInSek.Visible = false;
            // 
            // TxtWieLang
            // 
            this.TxtWieLang.Location = new System.Drawing.Point(16, 425);
            this.TxtWieLang.Name = "TxtWieLang";
            this.TxtWieLang.Size = new System.Drawing.Size(150, 20);
            this.TxtWieLang.TabIndex = 73;
            this.TxtWieLang.Visible = false;
            this.TxtWieLang.TextChanged += new System.EventHandler(this.TxtWieLang_TextChanged);
            // 
            // TxtWieOft
            // 
            this.TxtWieOft.Location = new System.Drawing.Point(16, 425);
            this.TxtWieOft.Name = "TxtWieOft";
            this.TxtWieOft.Size = new System.Drawing.Size(150, 20);
            this.TxtWieOft.TabIndex = 72;
            this.TxtWieOft.Visible = false;
            this.TxtWieOft.TextChanged += new System.EventHandler(this.TxtWieOft_TextChanged);
            // 
            // LblWieOft
            // 
            this.LblWieOft.AutoSize = true;
            this.LblWieOft.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWieOft.Location = new System.Drawing.Point(12, 377);
            this.LblWieOft.Name = "LblWieOft";
            this.LblWieOft.Size = new System.Drawing.Size(348, 23);
            this.LblWieOft.TabIndex = 71;
            this.LblWieOft.Text = "Wie viele Tabs sollen geöffnet werden?";
            this.LblWieOft.Visible = false;
            // 
            // LblWieLang
            // 
            this.LblWieLang.AutoSize = true;
            this.LblWieLang.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWieLang.Location = new System.Drawing.Point(12, 377);
            this.LblWieLang.Name = "LblWieLang";
            this.LblWieLang.Size = new System.Drawing.Size(383, 23);
            this.LblWieLang.TabIndex = 70;
            this.LblWieLang.Text = "Wie lange sollen die tabs geöffnet werden?";
            this.LblWieLang.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Wie soll sie geöffnet werden?";
            // 
            // PanWebsite
            // 
            this.PanWebsite.BackColor = System.Drawing.SystemColors.Control;
            this.PanWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanWebsite.Controls.Add(this.panel7);
            this.PanWebsite.Controls.Add(this.label2);
            this.PanWebsite.Controls.Add(this.panel3);
            this.PanWebsite.Location = new System.Drawing.Point(165, 73);
            this.PanWebsite.Name = "PanWebsite";
            this.PanWebsite.Size = new System.Drawing.Size(232, 143);
            this.PanWebsite.TabIndex = 68;
            this.PanWebsite.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(47, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(131, 19);
            this.panel7.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Google";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 31);
            this.panel3.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Reddit.com",
            "Google.com",
            "Wikipedia.com",
            "YouTube.com"});
            this.comboBox1.Location = new System.Drawing.Point(51, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(22, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "www.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(15, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 25);
            this.textBox1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(202, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelvLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Wenn nicht, werden nur Google Tabs geöffnet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Möchtest du eine bestimmte Website öffnen?";
            // 
            // CmdBack
            // 
            this.CmdBack.BackColor = System.Drawing.Color.White;
            this.CmdBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdBack.ForeColor = System.Drawing.Color.Maroon;
            this.CmdBack.Location = new System.Drawing.Point(11, 526);
            this.CmdBack.Margin = new System.Windows.Forms.Padding(2);
            this.CmdBack.Name = "CmdBack";
            this.CmdBack.Size = new System.Drawing.Size(27, 24);
            this.CmdBack.TabIndex = 64;
            this.CmdBack.Text = "↩";
            this.CmdBack.UseVisualStyleBackColor = false;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(14, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 75;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 17);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bestimmte Zeit lang";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bestimmte Anzahl";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 17);
            this.radioButton3.TabIndex = 53;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ohne zu stoppen";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Tabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 561);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.OptNein);
            this.Controls.Add(this.OptJa);
            this.Controls.Add(this.LblInSek);
            this.Controls.Add(this.TxtWieLang);
            this.Controls.Add(this.TxtWieOft);
            this.Controls.Add(this.LblWieLang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PanWebsite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblWieOft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(425, 600);
            this.Name = "Tabs";
            this.Text = "Tetris-ish";
            this.PanWebsite.ResumeLayout(false);
            this.PanWebsite.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.RadioButton OptNein;
        private System.Windows.Forms.RadioButton OptJa;
        private System.Windows.Forms.Label LblInSek;
        private System.Windows.Forms.TextBox TxtWieLang;
        private System.Windows.Forms.TextBox TxtWieOft;
        private System.Windows.Forms.Label LblWieOft;
        private System.Windows.Forms.Label LblWieLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanWebsite;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}