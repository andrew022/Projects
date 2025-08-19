namespace c969
{
    partial class UpdateCustomerRecord
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
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cityDropDown = new System.Windows.Forms.ComboBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.postalTxt = new System.Windows.Forms.TextBox();
            this.address2Txt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.postalLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressTxt
            // 
            this.addressTxt.Location = new System.Drawing.Point(86, 56);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(148, 20);
            this.addressTxt.TabIndex = 33;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(12, 56);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 32;
            this.addressLabel.Text = "Address";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(115, 238);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(196, 238);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cityDropDown
            // 
            this.cityDropDown.FormattingEnabled = true;
            this.cityDropDown.Location = new System.Drawing.Point(53, 128);
            this.cityDropDown.Name = "cityDropDown";
            this.cityDropDown.Size = new System.Drawing.Size(121, 21);
            this.cityDropDown.TabIndex = 29;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(86, 200);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(148, 20);
            this.phoneTxt.TabIndex = 28;
            // 
            // postalTxt
            // 
            this.postalTxt.Location = new System.Drawing.Point(113, 166);
            this.postalTxt.Name = "postalTxt";
            this.postalTxt.Size = new System.Drawing.Size(148, 20);
            this.postalTxt.TabIndex = 27;
            // 
            // address2Txt
            // 
            this.address2Txt.Location = new System.Drawing.Point(99, 91);
            this.address2Txt.Name = "address2Txt";
            this.address2Txt.Size = new System.Drawing.Size(148, 20);
            this.address2Txt.TabIndex = 26;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(69, 19);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(148, 20);
            this.nameTxt.TabIndex = 25;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(12, 91);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(81, 20);
            this.address2Label.TabIndex = 24;
            this.address2Label.Text = "Address 2";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(12, 128);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 20);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "City";
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalLabel.Location = new System.Drawing.Point(12, 166);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(95, 20);
            this.postalLabel.TabIndex = 22;
            this.postalLabel.Text = "Postal Code";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 200);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(68, 20);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Phone #";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(12, 19);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(51, 20);
            this.customerNameLabel.TabIndex = 20;
            this.customerNameLabel.Text = "Name";
            // 
            // UpdateCustomerRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 274);
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
            this.Name = "UpdateCustomerRecord";
            this.Text = "UpdateCustomerRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox cityDropDown;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox postalTxt;
        private System.Windows.Forms.TextBox address2Txt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label customerNameLabel;
    }
}