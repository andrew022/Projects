namespace c968
{
    partial class ModifyPart
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
            this.modPartLabel = new System.Windows.Forms.Label();
            this.modInhouseBtn = new System.Windows.Forms.RadioButton();
            this.modOutsourcedBtn = new System.Windows.Forms.RadioButton();
            this.modIDTxt = new System.Windows.Forms.TextBox();
            this.modMaxTxt = new System.Windows.Forms.TextBox();
            this.modMinTxt = new System.Windows.Forms.TextBox();
            this.ModDynamicTxt = new System.Windows.Forms.TextBox();
            this.modPriceTxt = new System.Windows.Forms.TextBox();
            this.modInvTxt = new System.Windows.Forms.TextBox();
            this.modNameTxt = new System.Windows.Forms.TextBox();
            this.modIDLabel = new System.Windows.Forms.Label();
            this.modNameLabel = new System.Windows.Forms.Label();
            this.modInvLabel = new System.Windows.Forms.Label();
            this.modPriceLabel = new System.Windows.Forms.Label();
            this.modMaxLabel = new System.Windows.Forms.Label();
            this.modMinLabel = new System.Windows.Forms.Label();
            this.modDynamicLabel = new System.Windows.Forms.Label();
            this.modCancelBtn = new System.Windows.Forms.Button();
            this.modSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modPartLabel
            // 
            this.modPartLabel.AutoSize = true;
            this.modPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabel.Location = new System.Drawing.Point(12, 9);
            this.modPartLabel.Name = "modPartLabel";
            this.modPartLabel.Size = new System.Drawing.Size(88, 20);
            this.modPartLabel.TabIndex = 0;
            this.modPartLabel.Text = "Modify Part";
            // 
            // modInhouseBtn
            // 
            this.modInhouseBtn.AutoSize = true;
            this.modInhouseBtn.Location = new System.Drawing.Point(129, 12);
            this.modInhouseBtn.Name = "modInhouseBtn";
            this.modInhouseBtn.Size = new System.Drawing.Size(68, 17);
            this.modInhouseBtn.TabIndex = 1;
            this.modInhouseBtn.TabStop = true;
            this.modInhouseBtn.Text = "In-House";
            this.modInhouseBtn.UseVisualStyleBackColor = true;
            this.modInhouseBtn.CheckedChanged += new System.EventHandler(this.modInhouseBtn_CheckedChanged);
            // 
            // modOutsourcedBtn
            // 
            this.modOutsourcedBtn.AutoSize = true;
            this.modOutsourcedBtn.Location = new System.Drawing.Point(220, 12);
            this.modOutsourcedBtn.Name = "modOutsourcedBtn";
            this.modOutsourcedBtn.Size = new System.Drawing.Size(80, 17);
            this.modOutsourcedBtn.TabIndex = 2;
            this.modOutsourcedBtn.TabStop = true;
            this.modOutsourcedBtn.Text = "Outsourced";
            this.modOutsourcedBtn.UseVisualStyleBackColor = true;
            this.modOutsourcedBtn.CheckedChanged += new System.EventHandler(this.modOutsourcedBtn_CheckedChanged);
            // 
            // modIDTxt
            // 
            this.modIDTxt.Enabled = false;
            this.modIDTxt.Location = new System.Drawing.Point(95, 72);
            this.modIDTxt.Name = "modIDTxt";
            this.modIDTxt.ReadOnly = true;
            this.modIDTxt.Size = new System.Drawing.Size(147, 20);
            this.modIDTxt.TabIndex = 3;
            // 
            // modMaxTxt
            // 
            this.modMaxTxt.Location = new System.Drawing.Point(95, 244);
            this.modMaxTxt.Name = "modMaxTxt";
            this.modMaxTxt.Size = new System.Drawing.Size(84, 20);
            this.modMaxTxt.TabIndex = 4;
            // 
            // modMinTxt
            // 
            this.modMinTxt.Location = new System.Drawing.Point(234, 244);
            this.modMinTxt.Name = "modMinTxt";
            this.modMinTxt.Size = new System.Drawing.Size(84, 20);
            this.modMinTxt.TabIndex = 5;
            // 
            // ModDynamicTxt
            // 
            this.ModDynamicTxt.Location = new System.Drawing.Point(95, 289);
            this.ModDynamicTxt.Name = "ModDynamicTxt";
            this.ModDynamicTxt.Size = new System.Drawing.Size(147, 20);
            this.ModDynamicTxt.TabIndex = 6;
            // 
            // modPriceTxt
            // 
            this.modPriceTxt.Location = new System.Drawing.Point(95, 199);
            this.modPriceTxt.Name = "modPriceTxt";
            this.modPriceTxt.Size = new System.Drawing.Size(147, 20);
            this.modPriceTxt.TabIndex = 7;
            // 
            // modInvTxt
            // 
            this.modInvTxt.Location = new System.Drawing.Point(95, 156);
            this.modInvTxt.Name = "modInvTxt";
            this.modInvTxt.Size = new System.Drawing.Size(147, 20);
            this.modInvTxt.TabIndex = 8;
            // 
            // modNameTxt
            // 
            this.modNameTxt.Location = new System.Drawing.Point(95, 113);
            this.modNameTxt.Name = "modNameTxt";
            this.modNameTxt.Size = new System.Drawing.Size(147, 20);
            this.modNameTxt.TabIndex = 9;
            // 
            // modIDLabel
            // 
            this.modIDLabel.AutoSize = true;
            this.modIDLabel.Location = new System.Drawing.Point(71, 79);
            this.modIDLabel.Name = "modIDLabel";
            this.modIDLabel.Size = new System.Drawing.Size(18, 13);
            this.modIDLabel.TabIndex = 10;
            this.modIDLabel.Text = "ID";
            // 
            // modNameLabel
            // 
            this.modNameLabel.AutoSize = true;
            this.modNameLabel.Location = new System.Drawing.Point(54, 120);
            this.modNameLabel.Name = "modNameLabel";
            this.modNameLabel.Size = new System.Drawing.Size(35, 13);
            this.modNameLabel.TabIndex = 11;
            this.modNameLabel.Text = "Name";
            // 
            // modInvLabel
            // 
            this.modInvLabel.AutoSize = true;
            this.modInvLabel.Location = new System.Drawing.Point(38, 163);
            this.modInvLabel.Name = "modInvLabel";
            this.modInvLabel.Size = new System.Drawing.Size(51, 13);
            this.modInvLabel.TabIndex = 12;
            this.modInvLabel.Text = "Inventory";
            // 
            // modPriceLabel
            // 
            this.modPriceLabel.AutoSize = true;
            this.modPriceLabel.Location = new System.Drawing.Point(26, 206);
            this.modPriceLabel.Name = "modPriceLabel";
            this.modPriceLabel.Size = new System.Drawing.Size(63, 13);
            this.modPriceLabel.TabIndex = 13;
            this.modPriceLabel.Text = "Price / Cost";
            // 
            // modMaxLabel
            // 
            this.modMaxLabel.AutoSize = true;
            this.modMaxLabel.Location = new System.Drawing.Point(62, 251);
            this.modMaxLabel.Name = "modMaxLabel";
            this.modMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.modMaxLabel.TabIndex = 14;
            this.modMaxLabel.Text = "Max";
            // 
            // modMinLabel
            // 
            this.modMinLabel.AutoSize = true;
            this.modMinLabel.Location = new System.Drawing.Point(204, 251);
            this.modMinLabel.Name = "modMinLabel";
            this.modMinLabel.Size = new System.Drawing.Size(24, 13);
            this.modMinLabel.TabIndex = 15;
            this.modMinLabel.Text = "Min";
            // 
            // modDynamicLabel
            // 
            this.modDynamicLabel.AutoSize = true;
            this.modDynamicLabel.Location = new System.Drawing.Point(12, 296);
            this.modDynamicLabel.Name = "modDynamicLabel";
            this.modDynamicLabel.Size = new System.Drawing.Size(62, 13);
            this.modDynamicLabel.TabIndex = 16;
            this.modDynamicLabel.Text = "Machine ID";
            // 
            // modCancelBtn
            // 
            this.modCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modCancelBtn.Location = new System.Drawing.Point(243, 355);
            this.modCancelBtn.Name = "modCancelBtn";
            this.modCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.modCancelBtn.TabIndex = 17;
            this.modCancelBtn.Text = "Cacnel";
            this.modCancelBtn.UseVisualStyleBackColor = true;
            this.modCancelBtn.Click += new System.EventHandler(this.modCancelBtn_Click);
            // 
            // modSaveBtn
            // 
            this.modSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modSaveBtn.Location = new System.Drawing.Point(153, 355);
            this.modSaveBtn.Name = "modSaveBtn";
            this.modSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.modSaveBtn.TabIndex = 18;
            this.modSaveBtn.Text = "Save";
            this.modSaveBtn.UseVisualStyleBackColor = true;
            this.modSaveBtn.Click += new System.EventHandler(this.modSaveBtn_Click);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 390);
            this.Controls.Add(this.modSaveBtn);
            this.Controls.Add(this.modCancelBtn);
            this.Controls.Add(this.modDynamicLabel);
            this.Controls.Add(this.modMinLabel);
            this.Controls.Add(this.modMaxLabel);
            this.Controls.Add(this.modPriceLabel);
            this.Controls.Add(this.modInvLabel);
            this.Controls.Add(this.modNameLabel);
            this.Controls.Add(this.modIDLabel);
            this.Controls.Add(this.modNameTxt);
            this.Controls.Add(this.modInvTxt);
            this.Controls.Add(this.modPriceTxt);
            this.Controls.Add(this.ModDynamicTxt);
            this.Controls.Add(this.modMinTxt);
            this.Controls.Add(this.modMaxTxt);
            this.Controls.Add(this.modIDTxt);
            this.Controls.Add(this.modOutsourcedBtn);
            this.Controls.Add(this.modInhouseBtn);
            this.Controls.Add(this.modPartLabel);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modPartLabel;
        private System.Windows.Forms.RadioButton modInhouseBtn;
        private System.Windows.Forms.RadioButton modOutsourcedBtn;
        private System.Windows.Forms.TextBox modIDTxt;
        private System.Windows.Forms.TextBox modMaxTxt;
        private System.Windows.Forms.TextBox modMinTxt;
        private System.Windows.Forms.TextBox ModDynamicTxt;
        private System.Windows.Forms.TextBox modPriceTxt;
        private System.Windows.Forms.TextBox modInvTxt;
        private System.Windows.Forms.TextBox modNameTxt;
        private System.Windows.Forms.Label modIDLabel;
        private System.Windows.Forms.Label modNameLabel;
        private System.Windows.Forms.Label modInvLabel;
        private System.Windows.Forms.Label modPriceLabel;
        private System.Windows.Forms.Label modMaxLabel;
        private System.Windows.Forms.Label modMinLabel;
        private System.Windows.Forms.Label modDynamicLabel;
        private System.Windows.Forms.Button modCancelBtn;
        private System.Windows.Forms.Button modSaveBtn;
    }
}