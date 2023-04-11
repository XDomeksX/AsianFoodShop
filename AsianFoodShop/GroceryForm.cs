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
    public partial class GroceryForm : Form
    {
        public static GroceryForm Instance { get; private set; }
        public GroceryForm()
        {
            InitializeComponent();
            Instance = this;

            // Add columns to the DataGridView
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";
            dataGridView1.Columns.Add(imageColumn);

            DataGridViewTextBoxColumn counterColumn = new DataGridViewTextBoxColumn();
            counterColumn.Name = "Counter";
            counterColumn.HeaderText = "Counter";
            dataGridView1.Columns.Add(counterColumn);

            DataGridViewButtonColumn addButtonColumn = new DataGridViewButtonColumn();
            addButtonColumn.Name = "AddButton";
            addButtonColumn.HeaderText = "Add";
            addButtonColumn.Text = "+";
            addButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(addButtonColumn);

            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "RemoveButton";
            removeButtonColumn.HeaderText = "Remove";
            removeButtonColumn.Text = "-";
            removeButtonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(removeButtonColumn);

            // Load the grocery data from the database
            LoadGroceryData();
        }

        public void LoadGroceryData()
        {
            // Retrieve the grocery data from the database
            DataTable table = new DataTable();
            // Fill the table with data from the database
            // ...

            // Update the data source of the DataGridView
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["AddButton"].Index)
            {
                // Handle add button click
                // ...
            }
            else if (e.ColumnIndex == dataGridView1.Columns["RemoveButton"].Index)
            {
                // Handle remove button click
                // ...
            }
        }
    }
}
