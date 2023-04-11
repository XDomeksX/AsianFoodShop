using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsianFoodShop
{
    public partial class MainMenuForm : Form
    {
        bool mousedown;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            this.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ( mousedown )
            {
                int mousex = MousePosition.X - 250;
                int mousey = MousePosition.Y - 0;
                this.SetDesktopLocation( mousex, mousey );
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxWindowMode_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void GroceriesBTN_Click(object sender, EventArgs e)
        {
            GroceriesForm groceriesForm = new GroceriesForm();
            groceriesForm.Show();
        }

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            GroceryAdminForm groceriesForm = new GroceryAdminForm();
            groceriesForm.Show();
        }
    }
}
