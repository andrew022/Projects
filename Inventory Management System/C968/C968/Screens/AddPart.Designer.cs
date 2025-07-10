namespace C968.Screens
{
    partial class AddPart
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
            this.AddPartTitle = new System.Windows.Forms.Label();
            this.InHouseBtn = new System.Windows.Forms.RadioButton();
            this.OutsourcedBtn = new System.Windows.Forms.RadioButton();
            this.AddPartIDTxt = new System.Windows.Forms.TextBox();
            this.AddPartInStockTxt = new System.Windows.Forms.TextBox();
            this.AddPartDynamicTxt = new System.Windows.Forms.TextBox();
            this.AddPartPriceTxt = new System.Windows.Forms.TextBox();
            this.AddPartNameTxt = new System.Windows.Forms.TextBox();
            this.AddPartMaxTxt = new System.Windows.Forms.TextBox();
            this.AddPartMinTxt = new System.Windows.Forms.TextBox();
            this.AddPartID = new System.Windows.Forms.Label();
            this.AddPartName = new System.Windows.Forms.Label();
            this.AddPartInStock = new System.Windows.Forms.Label();
            this.AddPartPrice = new System.Windows.Forms.Label();
            this.AddPartMin = new System.Windows.Forms.Label();
            this.AddPartMax = new System.Windows.Forms.Label();
            this.AddPartDynamicLabel = new System.Windows.Forms.Label();
            this.AddPartCancel = new System.Windows.Forms.Button();
            this.AddPartSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartTitle
            // 
            this.AddPartTitle.AutoSize = true;
            this.AddPartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartTitle.Location = new System.Drawing.Point(3, 9);
            this.AddPartTitle.Name = "AddPartTitle";
            this.AddPartTitle.Size = new System.Drawing.Size(71, 20);
            this.AddPartTitle.TabIndex = 0;
            this.AddPartTitle.Text = "Add Part";
            // 
            // InHouseBtn
            // 
            this.InHouseBtn.AutoSize = true;
            this.InHouseBtn.Location = new System.Drawing.Point(98, 12);
            this.InHouseBtn.Name = "InHouseBtn";
            this.InHouseBtn.Size = new System.Drawing.Size(85, 17);
            this.InHouseBtn.TabIndex = 1;
            this.InHouseBtn.TabStop = true;
            this.InHouseBtn.Text = "radioButton1";
            this.InHouseBtn.UseVisualStyleBackColor = true;
            this.InHouseBtn.CheckedChanged += new System.EventHandler(this.InHouseBtn_CheckedChanged);
            // 
            // OutsourcedBtn
            // 
            this.OutsourcedBtn.AutoSize = true;
            this.OutsourcedBtn.Location = new System.Drawing.Point(189, 12);
            this.OutsourcedBtn.Name = "OutsourcedBtn";
            this.OutsourcedBtn.Size = new System.Drawing.Size(85, 17);
            this.OutsourcedBtn.TabIndex = 2;
            this.OutsourcedBtn.TabStop = true;
            this.OutsourcedBtn.Text = "radioButton2";
            this.OutsourcedBtn.UseVisualStyleBackColor = true;
            this.OutsourcedBtn.CheckedChanged += new System.EventHandler(this.OutsourcedBtn_CheckedChanged);
            // 
            // AddPartIDTxt
            // 
            this.AddPartIDTxt.Enabled = false;
            this.AddPartIDTxt.Location = new System.Drawing.Point(118, 74);
            this.AddPartIDTxt.Name = "AddPartIDTxt";
            this.AddPartIDTxt.Size = new System.Drawing.Size(156, 20);
            this.AddPartIDTxt.TabIndex = 3;
            // 
            // AddPartInStockTxt
            // 
            this.AddPartInStockTxt.Location = new System.Drawing.Point(118, 161);
            this.AddPartInStockTxt.Name = "AddPartInStockTxt";
            this.AddPartInStockTxt.Size = new System.Drawing.Size(156, 20);
            this.AddPartInStockTxt.TabIndex = 4;
            // 
            // AddPartDynamicTxt
            // 
            this.AddPartDynamicTxt.Location = new System.Drawing.Point(118, 287);
            this.AddPartDynamicTxt.Name = "AddPartDynamicTxt";
            this.AddPartDynamicTxt.Size = new System.Drawing.Size(156, 20);
            this.AddPartDynamicTxt.TabIndex = 5;
            // 
            // AddPartPriceTxt
            // 
            this.AddPartPriceTxt.Location = new System.Drawing.Point(118, 205);
            this.AddPartPriceTxt.Name = "AddPartPriceTxt";
            this.AddPartPriceTxt.Size = new System.Drawing.Size(156, 20);
            this.AddPartPriceTxt.TabIndex = 6;
            // 
            // AddPartNameTxt
            // 
            this.AddPartNameTxt.Location = new System.Drawing.Point(118, 118);
            this.AddPartNameTxt.Name = "AddPartNameTxt";
            this.AddPartNameTxt.Size = new System.Drawing.Size(156, 20);
            this.AddPartNameTxt.TabIndex = 7;
            // 
            // AddPartMaxTxt
            // 
            this.AddPartMaxTxt.Location = new System.Drawing.Point(118, 246);
            this.AddPartMaxTxt.Name = "AddPartMaxTxt";
            this.AddPartMaxTxt.Size = new System.Drawing.Size(65, 20);
            this.AddPartMaxTxt.TabIndex = 8;
            // 
            // AddPartMinTxt
            // 
            this.AddPartMinTxt.Location = new System.Drawing.Point(246, 246);
            this.AddPartMinTxt.Name = "AddPartMinTxt";
            this.AddPartMinTxt.Size = new System.Drawing.Size(65, 20);
            this.AddPartMinTxt.TabIndex = 9;
            // 
            // AddPartID
            // 
            this.AddPartID.AutoSize = true;
            this.AddPartID.Location = new System.Drawing.Point(94, 81);
            this.AddPartID.Name = "AddPartID";
            this.AddPartID.Size = new System.Drawing.Size(18, 13);
            this.AddPartID.TabIndex = 10;
            this.AddPartID.Text = "ID";
            // 
            // AddPartName
            // 
            this.AddPartName.AutoSize = true;
            this.AddPartName.Location = new System.Drawing.Point(77, 125);
            this.AddPartName.Name = "AddPartName";
            this.AddPartName.Size = new System.Drawing.Size(35, 13);
            this.AddPartName.TabIndex = 11;
            this.AddPartName.Text = "Name";
            // 
            // AddPartInStock
            // 
            this.AddPartInStock.AutoSize = true;
            this.AddPartInStock.Location = new System.Drawing.Point(61, 168);
            this.AddPartInStock.Name = "AddPartInStock";
            this.AddPartInStock.Size = new System.Drawing.Size(51, 13);
            this.AddPartInStock.TabIndex = 12;
            this.AddPartInStock.Text = "Inventory";
            // 
            // AddPartPrice
            // 
            this.AddPartPrice.AutoSize = true;
            this.AddPartPrice.Location = new System.Drawing.Point(49, 212);
            this.AddPartPrice.Name = "AddPartPrice";
            this.AddPartPrice.Size = new System.Drawing.Size(63, 13);
            this.AddPartPrice.TabIndex = 13;
            this.AddPartPrice.Text = "Price / Cost";
            // 
            // AddPartMin
            // 
            this.AddPartMin.AutoSize = true;
            this.AddPartMin.Location = new System.Drawing.Point(215, 253);
            this.AddPartMin.Name = "AddPartMin";
            this.AddPartMin.Size = new System.Drawing.Size(25, 13);
            this.AddPartMin.TabIndex = 14;
            this.AddPartMin.Text = "MIn";
            // 
            // AddPartMax
            // 
            this.AddPartMax.AutoSize = true;
            this.AddPartMax.Location = new System.Drawing.Point(85, 253);
            this.AddPartMax.Name = "AddPartMax";
            this.AddPartMax.Size = new System.Drawing.Size(27, 13);
            this.AddPartMax.TabIndex = 15;
            this.AddPartMax.Text = "Max";
            // 
            // AddPartDynamicLabel
            // 
            this.AddPartDynamicLabel.AutoSize = true;
            this.AddPartDynamicLabel.Location = new System.Drawing.Point(33, 294);
            this.AddPartDynamicLabel.Name = "AddPartDynamicLabel";
            this.AddPartDynamicLabel.Size = new System.Drawing.Size(62, 13);
            this.AddPartDynamicLabel.TabIndex = 16;
            this.AddPartDynamicLabel.Text = "Machine ID";
            // 
            // AddPartCancel
            // 
            this.AddPartCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPartCancel.Location = new System.Drawing.Point(236, 349);
            this.AddPartCancel.Name = "AddPartCancel";
            this.AddPartCancel.Size = new System.Drawing.Size(75, 23);
            this.AddPartCancel.TabIndex = 17;
            this.AddPartCancel.Text = "Cancel";
            this.AddPartCancel.UseVisualStyleBackColor = true;
            this.AddPartCancel.Click += new System.EventHandler(this.AddPartCancel_Click);
            // 
            // AddPartSave
            // 
            this.AddPartSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPartSave.Location = new System.Drawing.Point(155, 349);
            this.AddPartSave.Name = "AddPartSave";
            this.AddPartSave.Size = new System.Drawing.Size(75, 23);
            this.AddPartSave.TabIndex = 18;
            this.AddPartSave.Text = "Save";
            this.AddPartSave.UseVisualStyleBackColor = true;
            this.AddPartSave.Click += new System.EventHandler(this.AddPartSave_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 384);
            this.Controls.Add(this.AddPartSave);
            this.Controls.Add(this.AddPartCancel);
            this.Controls.Add(this.AddPartDynamicLabel);
            this.Controls.Add(this.AddPartMax);
            this.Controls.Add(this.AddPartMin);
            this.Controls.Add(this.AddPartPrice);
            this.Controls.Add(this.AddPartInStock);
            this.Controls.Add(this.AddPartName);
            this.Controls.Add(this.AddPartID);
            this.Controls.Add(this.AddPartMinTxt);
            this.Controls.Add(this.AddPartMaxTxt);
            this.Controls.Add(this.AddPartNameTxt);
            this.Controls.Add(this.AddPartPriceTxt);
            this.Controls.Add(this.AddPartDynamicTxt);
            this.Controls.Add(this.AddPartInStockTxt);
            this.Controls.Add(this.AddPartIDTxt);
            this.Controls.Add(this.OutsourcedBtn);
            this.Controls.Add(this.InHouseBtn);
            this.Controls.Add(this.AddPartTitle);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartTitle;
        private System.Windows.Forms.RadioButton InHouseBtn;
        private System.Windows.Forms.RadioButton OutsourcedBtn;
        private System.Windows.Forms.TextBox AddPartIDTxt;
        private System.Windows.Forms.TextBox AddPartInStockTxt;
        private System.Windows.Forms.TextBox AddPartDynamicTxt;
        private System.Windows.Forms.TextBox AddPartPriceTxt;
        private System.Windows.Forms.TextBox AddPartNameTxt;
        private System.Windows.Forms.TextBox AddPartMaxTxt;
        private System.Windows.Forms.TextBox AddPartMinTxt;
        private System.Windows.Forms.Label AddPartID;
        private System.Windows.Forms.Label AddPartName;
        private System.Windows.Forms.Label AddPartInStock;
        private System.Windows.Forms.Label AddPartPrice;
        private System.Windows.Forms.Label AddPartMin;
        private System.Windows.Forms.Label AddPartMax;
        private System.Windows.Forms.Label AddPartDynamicLabel;
        private System.Windows.Forms.Button AddPartCancel;
        private System.Windows.Forms.Button AddPartSave;
    }
}