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
    public partial class GroceryAdminForm : Form
    {
        private TextBox nameTextBox;
        private Button addButton;
        private Button removeButton;

        public GroceryAdminForm()
        {
            InitializeComponent();

            // Set the form properties
            this.Text = "Add/Remove Groceries";
            this.Size = new Size(400, 200);

            // Create the name label and text box
            Label nameLabel = new Label();
            nameLabel.Text = "Name:";
            nameLabel.Location = new Point(10, 10);
            nameLabel.AutoSize = true;
            this.Controls.Add(nameLabel);

            nameTextBox = new TextBox();
            nameTextBox.Location = new Point(100, 10);
            nameTextBox.Size = new Size(200, 20);
            this.Controls.Add(nameTextBox);

            // Create the add button
            addButton = new Button();
            addButton.Text = "Add";
            addButton.Location = new Point(100, 50);
            addButton.Size = new Size(75, 23);
            addButton.Click += addButton_Click;
            this.Controls.Add(addButton);

            // Create the remove button
            removeButton = new Button();
            removeButton.Text = "Remove";
            removeButton.Location = new Point(225, 50);
            removeButton.Size = new Size(75, 23);
            removeButton.Click += removeButton_Click;
            this.Controls.Add(removeButton);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Add a new grocery item to the database
            string name = nameTextBox.Text;
            // ...

            // Refresh the grocery data on the groceries form
            GroceryForm.Instance.LoadGroceryData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Remove a grocery item from the database
            string name = nameTextBox.Text;
            // ...

            // Refresh the grocery data on the groceries form
            GroceryForm.Instance.LoadGroceryData();
        }
    }
}
