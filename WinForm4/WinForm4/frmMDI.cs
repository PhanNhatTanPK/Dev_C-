using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mnuN_Click(object sender, EventArgs e)
        {
            TextLile txtfile = new TextLile();
            txtfile.MdiParent = this;
            txtfile.Text = "Text File" + this.MdiChildren.Length;
            txtfile.Show();

            if (this.MdiChildren.Length >= 1)
            {
                ContextMenu cmnuText = new ContextMenu();
                cmnuText.MenuItems.Add("Black Color", new EventHandler(mnuItmColor_Click));
                cmnuText.MenuItems.Add("Close", new EventHandler(mnuFileClose_Click));
                this.ActiveMdiChild.ActiveControl.ContextMenu = cmnuText;
                arrangeMenuItems();
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            openFileDialog1.Filter = "Text File|*.txt";
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr.Equals(DialogResult.OK))
            {
                TextLile txtfile = new TextLile();
                txtfile.MdiParent = this;
                txtfile.Text = "Text File" + this.MdiChildren.Length;
                txtfile.Show();

                if(this.ActiveMdiChild.Name=="TextLile")
                {
                    sr = new StreamReader(this.openFileDialog1.FileName);
                    this.ActiveMdiChild.ActiveControl.Text = sr.ReadToEnd();
                    sr.Close();
                }
                ContextMenu cmnuText = new ContextMenu();
                cmnuText.MenuItems.Add("Black Color", new EventHandler(mnuItmColor_Click));
                cmnuText.MenuItems.Add("Close", new EventHandler(mnuFileClose_Click));
                this.ActiveMdiChild.ActiveControl.ContextMenu = cmnuText;
                arrangeMenuItems();
            }

        }
        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length>0)
            {
                this.saveFileDialog1.Filter = "Text Files|*.txt";
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if(dr.Equals(DialogResult.OK))
                   if(this.ActiveMdiChild.Name=="TextLile")
                    {
                        StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName);
                        sw.Write(this.ActiveMdiChild.ActiveControl.Text);
                        sw.Close();
                    }  
            }
        }
        private void arrangeMenuItems()
        {
            if (this.MdiChildren.Length == 0)
            {
                this.menuStrip1.Items[0].OwnerItem.Enabled
            }
        }
    }
}
