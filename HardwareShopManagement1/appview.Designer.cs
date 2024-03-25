namespace HardwareShopManagement1
{
    partial class appview
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appview));
            sidepanel = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ItemType = new Label();
            Category = new Label();
            comboBox2 = new ComboBox();
            Price = new Label();
            comboBox5 = new ComboBox();
            Stock = new Label();
            comboBox3 = new ComboBox();
            Manufacturer = new Label();
            comboBox4 = new ComboBox();
            result = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            S = new Label();
            sidepanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidepanel
            // 
            sidepanel.BackColor = SystemColors.WindowFrame;
            sidepanel.Controls.Add(button1);
            sidepanel.Location = new Point(0, -2);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(234, 609);
            sidepanel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 74);
            button1.Name = "button1";
            button1.Size = new Size(234, 55);
            button1.TabIndex = 0;
            button1.Text = "Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MotherBoard", "Ram", "GPU/VGA" });
            comboBox1.Location = new Point(255, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 1;
            // 
            // ItemType
            // 
            ItemType.AutoSize = true;
            ItemType.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemType.ForeColor = SystemColors.ButtonHighlight;
            ItemType.Location = new Point(255, 108);
            ItemType.Name = "ItemType";
            ItemType.Size = new Size(78, 19);
            ItemType.TabIndex = 2;
            ItemType.Text = "ItemType";
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category.ForeColor = SystemColors.ButtonHighlight;
            Category.Location = new Point(407, 108);
            Category.Name = "Category";
            Category.Size = new Size(79, 19);
            Category.TabIndex = 4;
            Category.Text = "Category";
            Category.Click += label2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "MotherBoard", "Ram", "GPU/VGA" });
            comboBox2.Location = new Point(407, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(135, 23);
            comboBox2.TabIndex = 3;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Price.ForeColor = SystemColors.ButtonHighlight;
            Price.Location = new Point(561, 108);
            Price.Name = "Price";
            Price.Size = new Size(48, 19);
            Price.TabIndex = 10;
            Price.Text = "Price";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "MotherBoard", "Ram", "GPU/VGA" });
            comboBox5.Location = new Point(561, 131);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(135, 23);
            comboBox5.TabIndex = 9;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stock.ForeColor = SystemColors.ButtonHighlight;
            Stock.Location = new Point(712, 108);
            Stock.Name = "Stock";
            Stock.Size = new Size(53, 19);
            Stock.TabIndex = 12;
            Stock.Text = "Stock";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "MotherBoard", "Ram", "GPU/VGA" });
            comboBox3.Location = new Point(712, 131);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(135, 23);
            comboBox3.TabIndex = 11;
            // 
            // Manufacturer
            // 
            Manufacturer.AutoSize = true;
            Manufacturer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Manufacturer.ForeColor = SystemColors.ButtonHighlight;
            Manufacturer.Location = new Point(868, 108);
            Manufacturer.Name = "Manufacturer";
            Manufacturer.Size = new Size(110, 19);
            Manufacturer.TabIndex = 14;
            Manufacturer.Text = "Manufacturer";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "MotherBoard", "Ram", "GPU/VGA" });
            comboBox4.Location = new Point(868, 131);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(135, 23);
            comboBox4.TabIndex = 13;
            // 
            // result
            // 
            result.BackColor = Color.Gray;
            result.ColumnCount = 5;
            result.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            result.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            result.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            result.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            result.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            result.Location = new Point(255, 283);
            result.Name = "result";
            result.RowCount = 2;
            result.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            result.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            result.Size = new Size(748, 100);
            result.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(868, 261);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 20;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(712, 261);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 19;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(561, 261);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(407, 261);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 17;
            label4.Text = "label4";
            // 
            // S
            // 
            S.AutoSize = true;
            S.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            S.ForeColor = SystemColors.ButtonHighlight;
            S.Location = new Point(255, 261);
            S.Name = "S";
            S.Size = new Size(54, 19);
            S.TabIndex = 16;
            S.Text = "label5";
            // 
            // appview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1059, 607);
            Controls.Add(Manufacturer);
            Controls.Add(comboBox4);
            Controls.Add(Stock);
            Controls.Add(comboBox3);
            Controls.Add(Price);
            Controls.Add(comboBox5);
            Controls.Add(Category);
            Controls.Add(comboBox2);
            Controls.Add(ItemType);
            Controls.Add(comboBox1);
            Controls.Add(result);
            Controls.Add(sidepanel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(S);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "appview";
            Text = "HardShop";
            Load += Form1_Load;
            sidepanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidepanel;
        private Button button1;
        private ComboBox comboBox1;
        private Label ItemType;
        private Label Category;
        private ComboBox comboBox2;
        private Label Price;
        private ComboBox comboBox5;
        private Label Stock;
        private ComboBox comboBox3;
        private Label Manufacturer;
        private ComboBox comboBox4;
        private TableLayoutPanel result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label S;
    }
}
