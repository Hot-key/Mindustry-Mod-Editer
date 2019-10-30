using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindustryMod
{
    public partial class Form1 : Form
    {
        private bool isFormMove = false;
        private Point basePoint;

        public Form1()
        {
            InitializeComponent();
        }

        #region Title Bar
        private void buttonTitleClose_MouseDown(object sender, MouseEventArgs e)
        {
            buttonTitleClose.BackColor = Color.FromArgb(232, 17, 35);
        }

        private void buttonTitleMax_MouseDown(object sender, MouseEventArgs e)
        {
            buttonTitleMax.BackColor = Color.FromArgb(97, 97, 97);
        }

        private void buttonTitleMin_MouseDown(object sender, MouseEventArgs e)
        {
            buttonTitleMin.BackColor = Color.FromArgb(97, 97, 97);
        }

        private void buttonTitleClose_MouseLeave(object sender, EventArgs e)
        {
            buttonTitleClose.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void buttonTitleMax_MouseLeave(object sender, EventArgs e)
        {
            buttonTitleMax.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void buttonTitleMin_MouseLeave(object sender, EventArgs e)
        {
            buttonTitleMin.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                basePoint = new Point(e.X, e.Y); ;
                isFormMove = true;
            }
        }
        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormMove)
            {
                this.Location = new Point(this.Location.X + (e.X - basePoint.X), this.Location.Y + (e.Y - basePoint.Y));
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormMove = false;
            }
        }

        private void panelTitle_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal);
        }

        private void buttonTitleMax_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal);
        }

        private void buttonTitleMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonTitleClose_Click(object sender, EventArgs e)
        {
            // Todo : 저장 관련 메시지

            this.Close();
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            panelHider.Height = 22;
        }

        private void buttonProject_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void buttonBasic_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 3;
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 4;
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 5;
        }

        private void tabBasic_Click(object sender, EventArgs e)
        {

        }
    }
}
