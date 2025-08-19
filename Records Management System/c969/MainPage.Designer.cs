namespace c969
{
    partial class MainPage
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
            this.customerData = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.customerDelBtn = new System.Windows.Forms.Button();
            this.customerAddBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.appointmentUpdateBtn = new System.Windows.Forms.Button();
            this.appointmentAddBtn = new System.Windows.Forms.Button();
            this.appointmentDelBtn = new System.Windows.Forms.Button();
            this.appointmentRefreshBtn = new System.Windows.Forms.Button();
            this.appointmentCalendarLabel = new System.Windows.Forms.Label();
            this.appointmentCalendarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewAppointmentRfrshBtn = new System.Windows.Forms.Button();
            this.appointmentData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).BeginInit();
            this.SuspendLayout();
            // 
            // customerData
            // 
            this.customerData.AllowUserToResizeColumns = false;
            this.customerData.AllowUserToResizeRows = false;
            this.customerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerData.Location = new System.Drawing.Point(12, 35);
            this.customerData.Name = "customerData";
            this.customerData.ReadOnly = true;
            this.customerData.RowHeadersVisible = false;
            this.customerData.Size = new System.Drawing.Size(465, 224);
            this.customerData.TabIndex = 0;
            this.customerData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerData_CellContentClick);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(8, 9);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(167, 24);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Customer Records";
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLabel.Location = new System.Drawing.Point(502, 9);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(193, 24);
            this.appointmentLabel.TabIndex = 3;
            this.appointmentLabel.Text = "Appointment Records";
            // 
            // customerDelBtn
            // 
            this.customerDelBtn.Location = new System.Drawing.Point(404, 265);
            this.customerDelBtn.Name = "customerDelBtn";
            this.customerDelBtn.Size = new System.Drawing.Size(75, 23);
            this.customerDelBtn.TabIndex = 4;
            this.customerDelBtn.Text = "Delete";
            this.customerDelBtn.UseVisualStyleBackColor = true;
            this.customerDelBtn.Click += new System.EventHandler(this.customerDelBtn_Click);
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Location = new System.Drawing.Point(242, 265);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(75, 23);
            this.customerAddBtn.TabIndex = 5;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Location = new System.Drawing.Point(323, 265);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.customerUpdateBtn.TabIndex = 6;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 346);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(404, 9);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 8;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // appointmentUpdateBtn
            // 
            this.appointmentUpdateBtn.Location = new System.Drawing.Point(916, 265);
            this.appointmentUpdateBtn.Name = "appointmentUpdateBtn";
            this.appointmentUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentUpdateBtn.TabIndex = 11;
            this.appointmentUpdateBtn.Text = "Update";
            this.appointmentUpdateBtn.UseVisualStyleBackColor = true;
            this.appointmentUpdateBtn.Click += new System.EventHandler(this.appointmentUpdateBtn_Click);
            // 
            // appointmentAddBtn
            // 
            this.appointmentAddBtn.Location = new System.Drawing.Point(835, 265);
            this.appointmentAddBtn.Name = "appointmentAddBtn";
            this.appointmentAddBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentAddBtn.TabIndex = 10;
            this.appointmentAddBtn.Text = "Add";
            this.appointmentAddBtn.UseVisualStyleBackColor = true;
            this.appointmentAddBtn.Click += new System.EventHandler(this.appointmentAddBtn_Click);
            // 
            // appointmentDelBtn
            // 
            this.appointmentDelBtn.Location = new System.Drawing.Point(997, 265);
            this.appointmentDelBtn.Name = "appointmentDelBtn";
            this.appointmentDelBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentDelBtn.TabIndex = 9;
            this.appointmentDelBtn.Text = "Delete";
            this.appointmentDelBtn.UseVisualStyleBackColor = true;
            this.appointmentDelBtn.Click += new System.EventHandler(this.appointmentDelBtn_Click);
            // 
            // appointmentRefreshBtn
            // 
            this.appointmentRefreshBtn.Location = new System.Drawing.Point(997, 6);
            this.appointmentRefreshBtn.Name = "appointmentRefreshBtn";
            this.appointmentRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentRefreshBtn.TabIndex = 12;
            this.appointmentRefreshBtn.Text = "Refresh";
            this.appointmentRefreshBtn.UseVisualStyleBackColor = true;
            this.appointmentRefreshBtn.Click += new System.EventHandler(this.appointmentRefreshBtn_Click);
            // 
            // appointmentCalendarLabel
            // 
            this.appointmentCalendarLabel.AutoSize = true;
            this.appointmentCalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCalendarLabel.Location = new System.Drawing.Point(15, 328);
            this.appointmentCalendarLabel.Name = "appointmentCalendarLabel";
            this.appointmentCalendarLabel.Size = new System.Drawing.Size(133, 18);
            this.appointmentCalendarLabel.TabIndex = 13;
            this.appointmentCalendarLabel.Text = "View Appointments";
            // 
            // appointmentCalendarBtn
            // 
            this.appointmentCalendarBtn.Location = new System.Drawing.Point(170, 511);
            this.appointmentCalendarBtn.Name = "appointmentCalendarBtn";
            this.appointmentCalendarBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentCalendarBtn.TabIndex = 14;
            this.appointmentCalendarBtn.Text = "View";
            this.appointmentCalendarBtn.UseVisualStyleBackColor = true;
            this.appointmentCalendarBtn.Click += new System.EventHandler(this.appointmentCalendarBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(257, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(703, 224);
            this.dataGridView1.TabIndex = 15;
            // 
            // viewAppointmentRfrshBtn
            // 
            this.viewAppointmentRfrshBtn.Location = new System.Drawing.Point(885, 317);
            this.viewAppointmentRfrshBtn.Name = "viewAppointmentRfrshBtn";
            this.viewAppointmentRfrshBtn.Size = new System.Drawing.Size(75, 23);
            this.viewAppointmentRfrshBtn.TabIndex = 16;
            this.viewAppointmentRfrshBtn.Text = "Refresh";
            this.viewAppointmentRfrshBtn.UseVisualStyleBackColor = true;
            this.viewAppointmentRfrshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // appointmentData
            // 
            this.appointmentData.AllowUserToResizeColumns = false;
            this.appointmentData.AllowUserToResizeRows = false;
            this.appointmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentData.Location = new System.Drawing.Point(506, 36);
            this.appointmentData.Name = "appointmentData";
            this.appointmentData.ReadOnly = true;
            this.appointmentData.RowHeadersVisible = false;
            this.appointmentData.Size = new System.Drawing.Size(566, 224);
            this.appointmentData.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(257, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "View Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Types per Month Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "User Schedules";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(524, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "View Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Customer Appointment Count";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(784, 624);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 37);
            this.button3.TabIndex = 21;
            this.button3.Text = "View Report";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 680);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewAppointmentRfrshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.appointmentCalendarBtn);
            this.Controls.Add(this.appointmentCalendarLabel);
            this.Controls.Add(this.appointmentRefreshBtn);
            this.Controls.Add(this.appointmentUpdateBtn);
            this.Controls.Add(this.appointmentAddBtn);
            this.Controls.Add(this.appointmentDelBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.customerUpdateBtn);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.customerDelBtn);
            this.Controls.Add(this.appointmentLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.appointmentData);
            this.Controls.Add(this.customerData);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerData;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.Button customerDelBtn;
        private System.Windows.Forms.Button customerAddBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button appointmentUpdateBtn;
        private System.Windows.Forms.Button appointmentAddBtn;
        private System.Windows.Forms.Button appointmentDelBtn;
        private System.Windows.Forms.Button appointmentRefreshBtn;
        private System.Windows.Forms.Label appointmentCalendarLabel;
        private System.Windows.Forms.Button appointmentCalendarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button viewAppointmentRfrshBtn;
        private System.Windows.Forms.DataGridView appointmentData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

