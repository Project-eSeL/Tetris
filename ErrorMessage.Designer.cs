namespace WindowsFormsApp17
{
    partial class ErrorMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorMessage));
            this.CmdBack = new System.Windows.Forms.Button();
            this.CmdStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtErrorText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtErrorTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.LblWieLang = new System.Windows.Forms.Label();
            this.LblWieOft = new System.Windows.Forms.Label();
            this.TxtWieOft = new System.Windows.Forms.TextBox();
            this.TxtWieLang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblInSek = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.CmdBack.TabIndex = 30;
            this.CmdBack.Text = "↩";
            this.CmdBack.UseVisualStyleBackColor = false;
            this.CmdBack.Click += new System.EventHandler(this.CmdBack_Click);
            // 
            // CmdStart
            // 
            this.CmdStart.Enabled = false;
            this.CmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdStart.Location = new System.Drawing.Point(262, 511);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(135, 38);
            this.CmdStart.TabIndex = 31;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Was soll in der Fehler Meldung stehen?";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TxtErrorText);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(8, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 143);
            this.panel2.TabIndex = 35;
            // 
            // TxtErrorText
            // 
            this.TxtErrorText.AcceptsReturn = true;
            this.TxtErrorText.AcceptsTab = true;
            this.TxtErrorText.AllowDrop = true;
            this.TxtErrorText.Location = new System.Drawing.Point(14, 46);
            this.TxtErrorText.MaxLength = 275;
            this.TxtErrorText.Multiline = true;
            this.TxtErrorText.Name = "TxtErrorText";
            this.TxtErrorText.Size = new System.Drawing.Size(198, 79);
            this.TxtErrorText.TabIndex = 35;
            this.TxtErrorText.TextChanged += new System.EventHandler(this.TxtErrorText_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TxtErrorTitle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 31);
            this.panel3.TabIndex = 32;
            // 
            // TxtErrorTitle
            // 
            this.TxtErrorTitle.Location = new System.Drawing.Point(13, 3);
            this.TxtErrorTitle.Name = "TxtErrorTitle";
            this.TxtErrorTitle.Size = new System.Drawing.Size(148, 20);
            this.TxtErrorTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Wie soll sie geöffnet werden?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 274);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 37;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bestimmte Anzahl";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 298);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(117, 17);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bestimmte Zeit lang";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 322);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 17);
            this.radioButton3.TabIndex = 39;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ohne zu stoppen";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // LblWieLang
            // 
            this.LblWieLang.AutoSize = true;
            this.LblWieLang.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWieLang.Location = new System.Drawing.Point(4, 368);
            this.LblWieLang.Name = "LblWieLang";
            this.LblWieLang.Size = new System.Drawing.Size(316, 23);
            this.LblWieLang.TabIndex = 40;
            this.LblWieLang.Text = "Wie lange soll sie geöffnet werden?";
            this.LblWieLang.Visible = false;
            // 
            // LblWieOft
            // 
            this.LblWieOft.AutoSize = true;
            this.LblWieOft.Font = new System.Drawing.Font("HelvLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWieOft.Location = new System.Drawing.Point(4, 368);
            this.LblWieOft.Name = "LblWieOft";
            this.LblWieOft.Size = new System.Drawing.Size(288, 23);
            this.LblWieOft.TabIndex = 41;
            this.LblWieOft.Text = "Wie oft soll sie geöffnet werden?";
            this.LblWieOft.Visible = false;
            // 
            // TxtWieOft
            // 
            this.TxtWieOft.Location = new System.Drawing.Point(8, 416);
            this.TxtWieOft.Name = "TxtWieOft";
            this.TxtWieOft.Size = new System.Drawing.Size(150, 20);
            this.TxtWieOft.TabIndex = 42;
            this.TxtWieOft.Visible = false;
            this.TxtWieOft.TextChanged += new System.EventHandler(this.TxtWieOft_TextChanged);
            // 
            // TxtWieLang
            // 
            this.TxtWieLang.Location = new System.Drawing.Point(8, 416);
            this.TxtWieLang.Name = "TxtWieLang";
            this.TxtWieLang.Size = new System.Drawing.Size(150, 20);
            this.TxtWieLang.TabIndex = 43;
            this.TxtWieLang.Visible = false;
            this.TxtWieLang.TextChanged += new System.EventHandler(this.TxtWieLang_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelvLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Wenn die Felder leer bleiben, wird eine ebenso leere Fehlermeldung erscheinen";
            // 
            // LblInSek
            // 
            this.LblInSek.AutoSize = true;
            this.LblInSek.Font = new System.Drawing.Font("HelvLight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInSek.Location = new System.Drawing.Point(8, 391);
            this.LblInSek.Name = "LblInSek";
            this.LblInSek.Size = new System.Drawing.Size(69, 13);
            this.LblInSek.TabIndex = 45;
            this.LblInSek.Text = "In Sekunden";
            this.LblInSek.Visible = false;
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Location = new System.Drawing.Point(8, 440);
            this.LblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 13);
            this.LblError.TabIndex = 46;
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 561);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.LblInSek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtWieLang);
            this.Controls.Add(this.TxtWieOft);
            this.Controls.Add(this.LblWieOft);
            this.Controls.Add(this.LblWieLang);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.CmdBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(425, 600);
            this.Name = "ErrorMessage";
            this.Text = "Tetris-ish";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdBack;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtErrorText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label LblWieLang;
        private System.Windows.Forms.Label LblWieOft;
        private System.Windows.Forms.TextBox TxtWieOft;
        private System.Windows.Forms.TextBox TxtWieLang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtErrorTitle;
        private System.Windows.Forms.Label LblInSek;
        private System.Windows.Forms.Label LblError;
    }
}