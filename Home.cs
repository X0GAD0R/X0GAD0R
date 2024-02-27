using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageEmployers
{
    public partial class Home : Form
    {
        int move;
        int movx;
        int movy;
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonEmpoyees_Click(object sender, EventArgs e)
        {
            this.Hide();
            Managing managing1  = new Managing();
            managing1.Show();
        }

        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Details details = new Details();
            details.Show();
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            About about = new About();
            about.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelHome_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;

        }
        private void PanelHome_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        private void PanelHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx,MousePosition.Y - movy);
            }
        }

       
    }
}
