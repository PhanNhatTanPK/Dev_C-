
namespace WinForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPNO = new System.Windows.Forms.TextBox();
            this.listS = new System.Windows.Forms.ListBox();
            this.listD = new System.Windows.Forms.ListBox();
            this.txtFD = new System.Windows.Forms.TextBox();
            this.listC = new System.Windows.Forms.ListBox();
            this.ClistS = new System.Windows.Forms.CheckedListBox();
            this.btV = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Reservation Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ticket No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passenger\'s Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Passport No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Source";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Destination";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Flight Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(30, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(30, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Service";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(188, 54);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(163, 32);
            this.txtTK.TabIndex = 9;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(188, 95);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(163, 32);
            this.txtPName.TabIndex = 10;
            // 
            // txtPNO
            // 
            this.txtPNO.Location = new System.Drawing.Point(188, 135);
            this.txtPNO.Name = "txtPNO";
            this.txtPNO.Size = new System.Drawing.Size(163, 32);
            this.txtPNO.TabIndex = 11;
            // 
            // listS
            // 
            this.listS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listS.FormattingEnabled = true;
            this.listS.ItemHeight = 15;
            this.listS.Items.AddRange(new object[] {
            "Brazil",
            "Tokyo"});
            this.listS.Location = new System.Drawing.Point(188, 175);
            this.listS.Name = "listS";
            this.listS.Size = new System.Drawing.Size(163, 34);
            this.listS.TabIndex = 12;
            this.listS.SelectedIndexChanged += new System.EventHandler(this.listS_SelectedIndexChanged);
            // 
            // listD
            // 
            this.listD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listD.FormattingEnabled = true;
            this.listD.ItemHeight = 15;
            this.listD.Items.AddRange(new object[] {
            "Brazil",
            "Tokyo"});
            this.listD.Location = new System.Drawing.Point(188, 217);
            this.listD.Name = "listD";
            this.listD.Size = new System.Drawing.Size(163, 34);
            this.listD.TabIndex = 13;
            this.listD.SelectedIndexChanged += new System.EventHandler(this.listD_SelectedIndexChanged);
            // 
            // txtFD
            // 
            this.txtFD.Location = new System.Drawing.Point(188, 259);
            this.txtFD.Name = "txtFD";
            this.txtFD.Size = new System.Drawing.Size(163, 32);
            this.txtFD.TabIndex = 14;
            // 
            // listC
            // 
            this.listC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listC.FormattingEnabled = true;
            this.listC.ItemHeight = 15;
            this.listC.Items.AddRange(new object[] {
            "First",
            "Business"});
            this.listC.Location = new System.Drawing.Point(188, 299);
            this.listC.Name = "listC";
            this.listC.Size = new System.Drawing.Size(163, 34);
            this.listC.TabIndex = 15;
            this.listC.SelectedIndexChanged += new System.EventHandler(this.listC_SelectedIndexChanged);
            // 
            // ClistS
            // 
            this.ClistS.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClistS.FormattingEnabled = true;
            this.ClistS.Items.AddRange(new object[] {
            "Child Care",
            "Nurse"});
            this.ClistS.Location = new System.Drawing.Point(188, 342);
            this.ClistS.Name = "ClistS";
            this.ClistS.Size = new System.Drawing.Size(163, 36);
            this.ClistS.TabIndex = 16;
            // 
            // btV
            // 
            this.btV.BackColor = System.Drawing.Color.Aqua;
            this.btV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btV.Location = new System.Drawing.Point(80, 404);
            this.btV.Name = "btV";
            this.btV.Size = new System.Drawing.Size(80, 34);
            this.btV.TabIndex = 17;
            this.btV.Text = "Verify";
            this.btV.UseVisualStyleBackColor = false;
            this.btV.Click += new System.EventHandler(this.btV_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.Aqua;
            this.btC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btC.Location = new System.Drawing.Point(237, 404);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(80, 34);
            this.btC.TabIndex = 18;
            this.btC.Text = "Clear";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btV);
            this.Controls.Add(this.ClistS);
            this.Controls.Add(this.listC);
            this.Controls.Add(this.txtFD);
            this.Controls.Add(this.listD);
            this.Controls.Add(this.listS);
            this.Controls.Add(this.txtPNO);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Flight Reservation Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPNO;
        private System.Windows.Forms.ListBox listS;
        private System.Windows.Forms.ListBox listD;
        private System.Windows.Forms.TextBox txtFD;
        private System.Windows.Forms.ListBox listC;
        private System.Windows.Forms.CheckedListBox ClistS;
        private System.Windows.Forms.Button btV;
        private System.Windows.Forms.Button btC;
    }
}

