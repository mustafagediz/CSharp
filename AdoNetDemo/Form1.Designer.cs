namespace AdoNetDemo
{
    partial class Form1
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
            dgwProducts = new DataGridView();
            lblName = new Label();
            lblUnitPrice = new Label();
            lblStockAmount = new Label();
            tbxName = new TextBox();
            tbxUnitPrice = new TextBox();
            tbxStockAmount = new TextBox();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            tbxUnitPriceUpdate = new TextBox();
            tbxStockAmountUpdate = new TextBox();
            lblNameUpdate = new Label();
            lblUnitPriceUpdate = new Label();
            tbxNameUpdate = new TextBox();
            lblStockAmountUpdate = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 12);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowHeadersWidth = 51;
            dgwProducts.Size = new Size(776, 177);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 24);
            lblName.Name = "lblName";
            lblName.Size = new Size(47, 18);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(23, 57);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(68, 18);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(23, 91);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(99, 18);
            lblStockAmount.TabIndex = 3;
            lblStockAmount.Text = "Stock Amount";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(133, 24);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(125, 26);
            tbxName.TabIndex = 4;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(133, 57);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(125, 26);
            tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(133, 88);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(125, 26);
            tbxStockAmount.TabIndex = 6;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(lblUnitPrice);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(lblStockAmount);
            gbxAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gbxAdd.Location = new Point(12, 208);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(378, 167);
            gbxAdd.TabIndex = 7;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(133, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            gbxUpdate.Location = new Point(396, 208);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(392, 167);
            gbxUpdate.TabIndex = 8;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Updat a product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(133, 120);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(133, 57);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(125, 26);
            tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(133, 88);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(125, 26);
            tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(23, 24);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(47, 18);
            lblNameUpdate.TabIndex = 1;
            lblNameUpdate.Text = "Name";
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(23, 57);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(68, 18);
            lblUnitPriceUpdate.TabIndex = 2;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(133, 24);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(125, 26);
            tbxNameUpdate.TabIndex = 4;
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(23, 91);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(99, 18);
            lblStockAmountUpdate.TabIndex = 3;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(529, 409);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(125, 29);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemove);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private Label lblName;
        private Label lblUnitPrice;
        private Label lblStockAmount;
        private TextBox tbxName;
        private TextBox tbxUnitPrice;
        private TextBox tbxStockAmount;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxStockAmountUpdate;
        private Label lblNameUpdate;
        private Label lblUnitPriceUpdate;
        private TextBox tbxNameUpdate;
        private Label lblStockAmountUpdate;
        private Button btnRemove;
    }
}
