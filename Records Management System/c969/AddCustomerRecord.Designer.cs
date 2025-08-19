namespace c969
{
    partial class AddCustomerRecord
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.postalLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.address2Txt = new System.Windows.Forms.TextBox();
            this.postalTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.cityDropDown = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(12, 28);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(51, 20);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Name";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 209);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(68, 20);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone #";
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalLabel.Location = new System.Drawing.Point(12, 175);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(95, 20);
            this.postalLabel.TabIndex = 5;
            this.postalLabel.Text = "Postal Code";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(12, 137);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 20);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(12, 100);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(81, 20);
            this.address2Label.TabIndex = 8;
            this.address2Label.Text = "Address 2";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(69, 28);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(148, 20);
            this.nameTxt.TabIndex = 9;
            // 
            // address2Txt
            // 
            this.address2Txt.Location = new System.Drawing.Point(99, 100);
            this.address2Txt.Name = "address2Txt";
            this.address2Txt.Size = new System.Drawing.Size(148, 20);
            this.address2Txt.TabIndex = 10;
            // 
            // postalTxt
            // 
            this.postalTxt.Location = new System.Drawing.Point(113, 175);
            this.postalTxt.Name = "postalTxt";
            this.postalTxt.Size = new System.Drawing.Size(148, 20);
            this.postalTxt.TabIndex = 13;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(86, 209);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(148, 20);
            this.phoneTxt.TabIndex = 14;
            // 
            // cityDropDown
            // 
            this.cityDropDown.FormattingEnabled = true;
            this.cityDropDown.Location = new System.Drawing.Point(53, 137);
            this.cityDropDown.Name = "cityDropDown";
            this.cityDropDown.Size = new System.Drawing.Size(121, 21);
            this.cityDropDown.TabIndex = 15;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(196, 247);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(115, 247);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(86, 65);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(148, 20);
            this.addressTxt.TabIndex = 19;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(12, 65);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 18;
            this.addressLabel.Text = "Address";
            // 
            // AddCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 284);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cityDropDown);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.postalTxt);
            this.Controls.Add(this.address2Txt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "AddCustomerRecord";
            this.Text = "AddCustomerRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox address2Txt;
        private System.Windows.Forms.TextBox postalTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.ComboBox cityDropDown;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label addressLabel;
    }
}