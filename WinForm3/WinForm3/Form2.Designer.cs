
namespace WinForm3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arithmeticCaculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addtionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fnum = new System.Windows.Forms.Label();
            this.Senum = new System.Windows.Forms.Label();
            this.Re = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCL = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arithmeticCaculatorToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arithmeticCaculatorToolStripMenuItem
            // 
            this.arithmeticCaculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addtionToolStripMenuItem,
            this.divisionToolStripMenuItem,
            this.multiplicationToolStripMenuItem,
            this.subtractionToolStripMenuItem});
            this.arithmeticCaculatorToolStripMenuItem.Name = "arithmeticCaculatorToolStripMenuItem";
            this.arithmeticCaculatorToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.arithmeticCaculatorToolStripMenuItem.Text = "&Arithmetic Caculator";
            // 
            // addtionToolStripMenuItem
            // 
            this.addtionToolStripMenuItem.Name = "addtionToolStripMenuItem";
            this.addtionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addtionToolStripMenuItem.Text = "Addtion";
            this.addtionToolStripMenuItem.Click += new System.EventHandler(this.addtionToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.divisionToolStripMenuItem.Text = "Division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // multiplicationToolStripMenuItem
            // 
            this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplicationToolStripMenuItem.Text = "Multiplication";
            this.multiplicationToolStripMenuItem.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.subtractionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Fnum
            // 
            this.Fnum.AutoSize = true;
            this.Fnum.Location = new System.Drawing.Point(29, 31);
            this.Fnum.Name = "Fnum";
            this.Fnum.Size = new System.Drawing.Size(66, 13);
            this.Fnum.TabIndex = 2;
            this.Fnum.Text = "First Number";
            // 
            // Senum
            // 
            this.Senum.AutoSize = true;
            this.Senum.Location = new System.Drawing.Point(28, 88);
            this.Senum.Name = "Senum";
            this.Senum.Size = new System.Drawing.Size(84, 13);
            this.Senum.TabIndex = 3;
            this.Senum.Text = "Second Number";
            // 
            // Re
            // 
            this.Re.AutoSize = true;
            this.Re.Location = new System.Drawing.Point(29, 148);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(37, 13);
            this.Re.TabIndex = 4;
            this.Re.Text = "Result";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(152, 24);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 5;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(152, 145);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 6;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(152, 85);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 20);
            this.txtSN.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Re);
            this.panel1.Controls.Add(this.txtR);
            this.panel1.Controls.Add(this.txtSN);
            this.panel1.Controls.Add(this.Fnum);
            this.panel1.Controls.Add(this.Senum);
            this.panel1.Controls.Add(this.txtFN);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 210);
            this.panel1.TabIndex = 8;
            // 
            // btCL
            // 
            this.btCL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCL.Location = new System.Drawing.Point(110, 323);
            this.btCL.Name = "btCL";
            this.btCL.Size = new System.Drawing.Size(75, 23);
            this.btCL.TabIndex = 9;
            this.btCL.Text = "Clear";
            this.btCL.UseVisualStyleBackColor = true;
            this.btCL.Click += new System.EventHandler(this.btCL_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(311, 358);
            this.Controls.Add(this.btCL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Arthmetic Caculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arithmeticCaculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addtionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label Fnum;
        private System.Windows.Forms.Label Senum;
        private System.Windows.Forms.Label Re;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCL;
    }
}