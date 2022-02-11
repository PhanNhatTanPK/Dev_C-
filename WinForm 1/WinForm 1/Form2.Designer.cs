
namespace WinForm_1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btS = new System.Windows.Forms.Button();
            this.btCL = new System.Windows.Forms.Button();
            this.btEX = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtDOJ = new System.Windows.Forms.TextBox();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.cbbD = new System.Windows.Forms.ComboBox();
            this.lbE = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(181, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(74, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(74, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(74, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Joining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(74, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Education";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(74, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // btS
            // 
            this.btS.Location = new System.Drawing.Point(78, 449);
            this.btS.Name = "btS";
            this.btS.Size = new System.Drawing.Size(75, 29);
            this.btS.TabIndex = 6;
            this.btS.Text = "Save";
            this.btS.UseVisualStyleBackColor = true;
            this.btS.Click += new System.EventHandler(this.btS_Click);
            // 
            // btCL
            // 
            this.btCL.Location = new System.Drawing.Point(232, 449);
            this.btCL.Name = "btCL";
            this.btCL.Size = new System.Drawing.Size(75, 29);
            this.btCL.TabIndex = 7;
            this.btCL.Text = "Clear";
            this.btCL.UseVisualStyleBackColor = true;
            this.btCL.Click += new System.EventHandler(this.btCL_Click);
            // 
            // btEX
            // 
            this.btEX.Location = new System.Drawing.Point(395, 449);
            this.btEX.Name = "btEX";
            this.btEX.Size = new System.Drawing.Size(75, 29);
            this.btEX.TabIndex = 8;
            this.btEX.Text = "Exit";
            this.btEX.UseVisualStyleBackColor = true;
            this.btEX.Click += new System.EventHandler(this.btEX_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(278, 95);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(133, 29);
            this.txtN.TabIndex = 9;
            // 
            // txtDOJ
            // 
            this.txtDOJ.Location = new System.Drawing.Point(278, 259);
            this.txtDOJ.Name = "txtDOJ";
            this.txtDOJ.Size = new System.Drawing.Size(133, 29);
            this.txtDOJ.TabIndex = 10;
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(278, 163);
            this.txtAD.Multiline = true;
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(133, 56);
            this.txtAD.TabIndex = 11;
            // 
            // cbbD
            // 
            this.cbbD.FormattingEnabled = true;
            this.cbbD.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3"});
            this.cbbD.Location = new System.Drawing.Point(278, 385);
            this.cbbD.Name = "cbbD";
            this.cbbD.Size = new System.Drawing.Size(133, 30);
            this.cbbD.TabIndex = 12;
            this.cbbD.SelectedIndexChanged += new System.EventHandler(this.cbbD_SelectedIndexChanged);
            // 
            // lbE
            // 
            this.lbE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE.FormattingEnabled = true;
            this.lbE.ItemHeight = 19;
            this.lbE.Items.AddRange(new object[] {
            "The Bachelor",
            "UnderGraduate"});
            this.lbE.Location = new System.Drawing.Point(278, 325);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(133, 23);
            this.lbE.Sorted = true;
            this.lbE.TabIndex = 13;
            this.lbE.SelectedIndexChanged += new System.EventHandler(this.lbE_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 501);
            this.Controls.Add(this.lbE);
            this.Controls.Add(this.cbbD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.txtDOJ);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btEX);
            this.Controls.Add(this.btCL);
            this.Controls.Add(this.btS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Button btS;
        private System.Windows.Forms.Button btCL;
        private System.Windows.Forms.Button btEX;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtDOJ;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.ComboBox cbbD;
        private System.Windows.Forms.ListBox lbE;
    }
}