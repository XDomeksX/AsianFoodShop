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
    public partial class GroceriesForm : Form
    {
        public GroceriesForm()
        {
            InitializeComponent();
        }

        private void Groceries_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            Button btnPlus = sender as Button;
            Control parent = btnPlus.Parent;
            TextBox txtCounter = parent.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "TXTCounter");

            if (txtCounter != null)
            {
                int currentValue = int.Parse(txtCounter.Text);
                txtCounter.Text = (currentValue + 1).ToString();
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            Button btnMinus = sender as Button;
            Control parent = btnMinus.Parent;
            TextBox txtCounter = parent.Controls.OfType<TextBox>().FirstOrDefault(t => t.Name == "TXTCounter");

            if (txtCounter != null)
            {
                int currentValue = int.Parse(txtCounter.Text);
                if (currentValue > 0)
                {
                    txtCounter.Text = (currentValue - 1).ToString();
                }
            }
        }
    }
}
