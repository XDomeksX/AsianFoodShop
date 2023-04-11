namespace AsianFoodShop
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.PictureBoxWindowMode = new System.Windows.Forms.PictureBox();
            this.PictureBoxExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroceriesBTN = new System.Windows.Forms.Button();
            this.FoodBTN = new System.Windows.Forms.Button();
            this.DeliveryBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWindowMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.PictureBoxMinimize);
            this.panel1.Controls.Add(this.PictureBoxWindowMode);
            this.panel1.Controls.Add(this.PictureBoxExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 25);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // PictureBoxMinimize
            // 
            this.PictureBoxMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMinimize.Image")));
            this.PictureBoxMinimize.Location = new System.Drawing.Point(394, 0);
            this.PictureBoxMinimize.Name = "PictureBoxMinimize";
            this.PictureBoxMinimize.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMinimize.TabIndex = 3;
            this.PictureBoxMinimize.TabStop = false;
            this.PictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimize_Click);
            // 
            // PictureBoxWindowMode
            // 
            this.PictureBoxWindowMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBoxWindowMode.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxWindowMode.Image")));
            this.PictureBoxWindowMode.Location = new System.Drawing.Point(425, 0);
            this.PictureBoxWindowMode.Name = "PictureBoxWindowMode";
            this.PictureBoxWindowMode.Size = new System.Drawing.Size(25, 25);
            this.PictureBoxWindowMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxWindowMode.TabIndex = 2;
            this.PictureBoxWindowMode.TabStop = false;
            this.PictureBoxWindowMode.Click += new System.EventHandler(this.PictureBoxWindowMode_Click);
            // 
            // PictureBoxExit
            // 
            this.PictureBoxExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxExit.Image")));
            this.PictureBoxExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxExit.InitialImage")));
            this.PictureBoxExit.Location = new System.Drawing.Point(456, 0);
            this.PictureBoxExit.Name = "PictureBoxExit";
            this.PictureBoxExit.Size = new System.Drawing.Size(51, 22);
            this.PictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxExit.TabIndex = 1;
            this.PictureBoxExit.TabStop = false;
            this.PictureBoxExit.Click += new System.EventHandler(this.PictureBoxExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asian Online Shop";
            // 
            // GroceriesBTN
            // 
            this.GroceriesBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GroceriesBTN.BackColor = System.Drawing.Color.Transparent;
            this.GroceriesBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GroceriesBTN.BackgroundImage")));
            this.GroceriesBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroceriesBTN.ForeColor = System.Drawing.Color.Black;
            this.GroceriesBTN.Location = new System.Drawing.Point(104, 310);
            this.GroceriesBTN.Name = "GroceriesBTN";
            this.GroceriesBTN.Size = new System.Drawing.Size(300, 75);
            this.GroceriesBTN.TabIndex = 1;
            this.GroceriesBTN.UseVisualStyleBackColor = false;
            this.GroceriesBTN.Click += new System.EventHandler(this.GroceriesBTN_Click);
            // 
            // FoodBTN
            // 
            this.FoodBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FoodBTN.BackColor = System.Drawing.Color.Transparent;
            this.FoodBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FoodBTN.BackgroundImage")));
            this.FoodBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodBTN.ForeColor = System.Drawing.Color.Black;
            this.FoodBTN.Location = new System.Drawing.Point(104, 404);
            this.FoodBTN.Name = "FoodBTN";
            this.FoodBTN.Size = new System.Drawing.Size(300, 75);
            this.FoodBTN.TabIndex = 2;
            this.FoodBTN.UseVisualStyleBackColor = false;
            this.FoodBTN.Click += new System.EventHandler(this.FoodBTN_Click);
            // 
            // DeliveryBTN
            // 
            this.DeliveryBTN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeliveryBTN.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeliveryBTN.BackgroundImage")));
            this.DeliveryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryBTN.ForeColor = System.Drawing.Color.Black;
            this.DeliveryBTN.Location = new System.Drawing.Point(104, 502);
            this.DeliveryBTN.Name = "DeliveryBTN";
            this.DeliveryBTN.Size = new System.Drawing.Size(300, 75);
            this.DeliveryBTN.TabIndex = 4;
            this.DeliveryBTN.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 624);
            this.Controls.Add(this.DeliveryBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FoodBTN);
            this.Controls.Add(this.GroceriesBTN);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWindowMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBoxMinimize;
        private System.Windows.Forms.PictureBox PictureBoxWindowMode;
        private System.Windows.Forms.PictureBox PictureBoxExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GroceriesBTN;
        private System.Windows.Forms.Button FoodBTN;
        private System.Windows.Forms.Button DeliveryBTN;
    }
}

