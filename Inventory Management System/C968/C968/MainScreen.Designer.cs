namespace c968
{
    partial class MainScreen
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.partDelBtn = new System.Windows.Forms.Button();
            this.partAddBtn = new System.Windows.Forms.Button();
            this.partModBtn = new System.Windows.Forms.Button();
            this.prodAddBtn = new System.Windows.Forms.Button();
            this.prodModBtn = new System.Windows.Forms.Button();
            this.prodDelBtn = new System.Windows.Forms.Button();
            this.prodSearchBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.partSearchBtn = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.prodSearchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(12, 153);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersVisible = false;
            this.dgvParts.RowHeadersWidth = 62;
            this.dgvParts.Size = new System.Drawing.Size(605, 263);
            this.dgvParts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(657, 153);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.Size = new System.Drawing.Size(605, 263);
            this.dgvProducts.TabIndex = 1;
            // 
            // partDelBtn
            // 
            this.partDelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partDelBtn.Location = new System.Drawing.Point(542, 422);
            this.partDelBtn.Name = "partDelBtn";
            this.partDelBtn.Size = new System.Drawing.Size(75, 23);
            this.partDelBtn.TabIndex = 2;
            this.partDelBtn.Text = "Delete";
            this.partDelBtn.UseVisualStyleBackColor = false;
            this.partDelBtn.Click += new System.EventHandler(this.partDelBtn_Click);
            // 
            // partAddBtn
            // 
            this.partAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partAddBtn.Location = new System.Drawing.Point(380, 422);
            this.partAddBtn.Name = "partAddBtn";
            this.partAddBtn.Size = new System.Drawing.Size(75, 23);
            this.partAddBtn.TabIndex = 3;
            this.partAddBtn.Text = "Add";
            this.partAddBtn.UseVisualStyleBackColor = false;
            this.partAddBtn.Click += new System.EventHandler(this.partAddBtn_Click);
            // 
            // partModBtn
            // 
            this.partModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partModBtn.Location = new System.Drawing.Point(461, 422);
            this.partModBtn.Name = "partModBtn";
            this.partModBtn.Size = new System.Drawing.Size(75, 23);
            this.partModBtn.TabIndex = 4;
            this.partModBtn.Text = "Modify";
            this.partModBtn.UseVisualStyleBackColor = false;
            this.partModBtn.Click += new System.EventHandler(this.partModBtn_Click);
            // 
            // prodAddBtn
            // 
            this.prodAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prodAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodAddBtn.Location = new System.Drawing.Point(1025, 422);
            this.prodAddBtn.Name = "prodAddBtn";
            this.prodAddBtn.Size = new System.Drawing.Size(75, 23);
            this.prodAddBtn.TabIndex = 5;
            this.prodAddBtn.Text = "Add";
            this.prodAddBtn.UseVisualStyleBackColor = false;
            this.prodAddBtn.Click += new System.EventHandler(this.prodAddBtn_Click);
            // 
            // prodModBtn
            // 
            this.prodModBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prodModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodModBtn.Location = new System.Drawing.Point(1106, 422);
            this.prodModBtn.Name = "prodModBtn";
            this.prodModBtn.Size = new System.Drawing.Size(75, 23);
            this.prodModBtn.TabIndex = 6;
            this.prodModBtn.Text = "Modify";
            this.prodModBtn.UseVisualStyleBackColor = false;
            this.prodModBtn.Click += new System.EventHandler(this.prodModBtn_Click);
            // 
            // prodDelBtn
            // 
            this.prodDelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prodDelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodDelBtn.Location = new System.Drawing.Point(1187, 422);
            this.prodDelBtn.Name = "prodDelBtn";
            this.prodDelBtn.Size = new System.Drawing.Size(75, 23);
            this.prodDelBtn.TabIndex = 7;
            this.prodDelBtn.Text = "Delete";
            this.prodDelBtn.UseVisualStyleBackColor = false;
            this.prodDelBtn.Click += new System.EventHandler(this.prodDelBtn_Click);
            // 
            // prodSearchBtn
            // 
            this.prodSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.prodSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prodSearchBtn.Location = new System.Drawing.Point(1025, 124);
            this.prodSearchBtn.Name = "prodSearchBtn";
            this.prodSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.prodSearchBtn.TabIndex = 8;
            this.prodSearchBtn.Text = "Search";
            this.prodSearchBtn.UseVisualStyleBackColor = false;
            this.prodSearchBtn.Click += new System.EventHandler(this.prodSearchBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(1187, 540);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // partSearchBtn
            // 
            this.partSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.partSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partSearchBtn.Location = new System.Drawing.Point(380, 124);
            this.partSearchBtn.Name = "partSearchBtn";
            this.partSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.partSearchBtn.TabIndex = 10;
            this.partSearchBtn.Text = "Search";
            this.partSearchBtn.UseVisualStyleBackColor = false;
            this.partSearchBtn.Click += new System.EventHandler(this.partSearchBtn_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(8, 127);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 20);
            this.partsLabel.TabIndex = 11;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(653, 127);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(72, 20);
            this.productsLabel.TabIndex = 12;
            this.productsLabel.Text = "Products";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(389, 31);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Inventory Management System";
            // 
            // partSearchBox
            // 
            this.partSearchBox.Location = new System.Drawing.Point(465, 124);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(152, 20);
            this.partSearchBox.TabIndex = 14;
            // 
            // prodSearchBox
            // 
            this.prodSearchBox.Location = new System.Drawing.Point(1110, 124);
            this.prodSearchBox.Name = "prodSearchBox";
            this.prodSearchBox.Size = new System.Drawing.Size(152, 20);
            this.prodSearchBox.TabIndex = 15;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 575);
            this.Controls.Add(this.prodSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.partSearchBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.prodSearchBtn);
            this.Controls.Add(this.prodDelBtn);
            this.Controls.Add(this.prodModBtn);
            this.Controls.Add(this.prodAddBtn);
            this.Controls.Add(this.partModBtn);
            this.Controls.Add(this.partAddBtn);
            this.Controls.Add(this.partDelBtn);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button partDelBtn;
        private System.Windows.Forms.Button partAddBtn;
        private System.Windows.Forms.Button partModBtn;
        private System.Windows.Forms.Button prodAddBtn;
        private System.Windows.Forms.Button prodModBtn;
        private System.Windows.Forms.Button prodDelBtn;
        private System.Windows.Forms.Button prodSearchBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button partSearchBtn;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox prodSearchBox;
        public System.Windows.Forms.DataGridView dgvParts;
    }
}

