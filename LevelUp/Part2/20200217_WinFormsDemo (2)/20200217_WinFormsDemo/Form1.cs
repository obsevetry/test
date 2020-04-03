using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200217_WinFormsDemo
{
    public partial class frmMain : Form
    {
        #region Left offset

        private int leftOffset = 0;

        #endregion

        public frmMain()
        {
            InitializeComponent();
            // ...
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            DoLeft();
        }

        private void btnToLeft_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            //btn.Left -= 10;
        }

        private void chbxCancelButton_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = chbxCancelButton.Checked;
        }

        private void btnToLeftSecond_Click(object sender, EventArgs e)
        {
            DoLeft();
        }

        private void DoLeft()
        {
            btnOk.Left -= 5;

            string tmp = btnOk.Text;
            btnOk.Text = btnCancel.Text;
            btnCancel.Text = tmp;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Button btnNewToLeft = new Button();

            btnNewToLeft.Location = new System.Drawing.Point(leftOffset, 357);
            btnNewToLeft.Name = string.Format("btnToLeftSecond{0}", leftOffset);
            btnNewToLeft.Size = new System.Drawing.Size(75, 23);
            btnNewToLeft.TabIndex = 4;
            btnNewToLeft.Text = "<---";
            btnNewToLeft.UseVisualStyleBackColor = true;
            // btnNewToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            btnNewToLeft.Click += delegate (object s, EventArgs ea)
            {
                DoLeft();
            };

            

            Controls.Add(btnNewToLeft);

            leftOffset += btnNewToLeft.Width;
        }

        private void tmrOk_Tick(object sender, EventArgs e)
        {
            btnCancel.Top -= 5;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tmrOk.Start();
        }
    }
}
