namespace Swim
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdEvent = new System.Windows.Forms.DataGridView();
            this.chkAdmission = new System.Windows.Forms.CheckBox();
            this.chkRelayEvent = new System.Windows.Forms.CheckBox();
            this.chkEvent9 = new System.Windows.Forms.CheckBox();
            this.chkEvent7 = new System.Windows.Forms.CheckBox();
            this.chkEvent5 = new System.Windows.Forms.CheckBox();
            this.chkEvent4 = new System.Windows.Forms.CheckBox();
            this.chkEvent3 = new System.Windows.Forms.CheckBox();
            this.chkEvent2 = new System.Windows.Forms.CheckBox();
            this.chkEvent1 = new System.Windows.Forms.CheckBox();
            this.chkEvent8 = new System.Windows.Forms.CheckBox();
            this.chkEvent6 = new System.Windows.Forms.CheckBox();
            this.lblhelp = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAdmission = new System.Windows.Forms.TextBox();
            this.lblAdmmission = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.BackColor = System.Drawing.Color.Cyan;
            this.lblEventDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEventDetails.ForeColor = System.Drawing.Color.Purple;
            this.lblEventDetails.Location = new System.Drawing.Point(332, 25);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(139, 30);
            this.lblEventDetails.TabIndex = 0;
            this.lblEventDetails.Text = "Event Details";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(772, 302);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.back_click);
            // 
            // grdEvent
            // 
            this.grdEvent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEvent.Location = new System.Drawing.Point(22, 351);
            this.grdEvent.Name = "grdEvent";
            this.grdEvent.RowTemplate.Height = 25;
            this.grdEvent.Size = new System.Drawing.Size(825, 257);
            this.grdEvent.TabIndex = 12;
            // 
            // chkAdmission
            // 
            this.chkAdmission.AutoSize = true;
            this.chkAdmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkAdmission.Location = new System.Drawing.Point(103, 175);
            this.chkAdmission.Name = "chkAdmission";
            this.chkAdmission.Size = new System.Drawing.Size(101, 19);
            this.chkAdmission.TabIndex = 13;
            this.chkAdmission.Text = "Admission No";
            this.chkAdmission.UseVisualStyleBackColor = true;
            this.chkAdmission.CheckedChanged += new System.EventHandler(this.chkAdmission_CheckedChanged);
            // 
            // chkRelayEvent
            // 
            this.chkRelayEvent.AutoSize = true;
            this.chkRelayEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkRelayEvent.Location = new System.Drawing.Point(615, 236);
            this.chkRelayEvent.Name = "chkRelayEvent";
            this.chkRelayEvent.Size = new System.Drawing.Size(91, 19);
            this.chkRelayEvent.TabIndex = 14;
            this.chkRelayEvent.Text = "Relay Event";
            this.chkRelayEvent.UseVisualStyleBackColor = true;
            this.chkRelayEvent.CheckedChanged += new System.EventHandler(this.chkRelayEvent_CheckedChanged);
            // 
            // chkEvent9
            // 
            this.chkEvent9.AutoSize = true;
            this.chkEvent9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent9.Location = new System.Drawing.Point(496, 236);
            this.chkEvent9.Name = "chkEvent9";
            this.chkEvent9.Size = new System.Drawing.Size(68, 19);
            this.chkEvent9.TabIndex = 15;
            this.chkEvent9.Text = "Event 9";
            this.chkEvent9.UseVisualStyleBackColor = true;
            this.chkEvent9.CheckedChanged += new System.EventHandler(this.chkEvent9_CheckedChanged);
            // 
            // chkEvent7
            // 
            this.chkEvent7.AutoSize = true;
            this.chkEvent7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent7.Location = new System.Drawing.Point(256, 236);
            this.chkEvent7.Name = "chkEvent7";
            this.chkEvent7.Size = new System.Drawing.Size(68, 19);
            this.chkEvent7.TabIndex = 16;
            this.chkEvent7.Text = "Event 7";
            this.chkEvent7.UseVisualStyleBackColor = true;
            this.chkEvent7.CheckedChanged += new System.EventHandler(this.chkEvent7_CheckedChanged);
            // 
            // chkEvent5
            // 
            this.chkEvent5.AutoSize = true;
            this.chkEvent5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent5.Location = new System.Drawing.Point(735, 175);
            this.chkEvent5.Name = "chkEvent5";
            this.chkEvent5.Size = new System.Drawing.Size(68, 19);
            this.chkEvent5.TabIndex = 17;
            this.chkEvent5.Text = "Event 5";
            this.chkEvent5.UseVisualStyleBackColor = true;
            this.chkEvent5.CheckedChanged += new System.EventHandler(this.chkEvent5_CheckedChanged);
            // 
            // chkEvent4
            // 
            this.chkEvent4.AutoSize = true;
            this.chkEvent4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent4.Location = new System.Drawing.Point(615, 175);
            this.chkEvent4.Name = "chkEvent4";
            this.chkEvent4.Size = new System.Drawing.Size(68, 19);
            this.chkEvent4.TabIndex = 18;
            this.chkEvent4.Text = "Event 4";
            this.chkEvent4.UseVisualStyleBackColor = true;
            this.chkEvent4.CheckedChanged += new System.EventHandler(this.chkEvent4_CheckedChanged);
            // 
            // chkEvent3
            // 
            this.chkEvent3.AutoSize = true;
            this.chkEvent3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent3.Location = new System.Drawing.Point(496, 175);
            this.chkEvent3.Name = "chkEvent3";
            this.chkEvent3.Size = new System.Drawing.Size(68, 19);
            this.chkEvent3.TabIndex = 19;
            this.chkEvent3.Text = "Event 3";
            this.chkEvent3.UseVisualStyleBackColor = true;
            this.chkEvent3.CheckedChanged += new System.EventHandler(this.chkEvent3_CheckedChanged);
            // 
            // chkEvent2
            // 
            this.chkEvent2.AutoSize = true;
            this.chkEvent2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent2.Location = new System.Drawing.Point(372, 175);
            this.chkEvent2.Name = "chkEvent2";
            this.chkEvent2.Size = new System.Drawing.Size(68, 19);
            this.chkEvent2.TabIndex = 20;
            this.chkEvent2.Text = "Event 2";
            this.chkEvent2.UseVisualStyleBackColor = true;
            this.chkEvent2.CheckedChanged += new System.EventHandler(this.chkEvent2_CheckedChanged);
            // 
            // chkEvent1
            // 
            this.chkEvent1.AutoSize = true;
            this.chkEvent1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent1.Location = new System.Drawing.Point(256, 175);
            this.chkEvent1.Name = "chkEvent1";
            this.chkEvent1.Size = new System.Drawing.Size(68, 19);
            this.chkEvent1.TabIndex = 21;
            this.chkEvent1.Text = "Event 1";
            this.chkEvent1.UseVisualStyleBackColor = true;
            this.chkEvent1.CheckedChanged += new System.EventHandler(this.chkEvent1_CheckedChanged);
            // 
            // chkEvent8
            // 
            this.chkEvent8.AutoSize = true;
            this.chkEvent8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent8.Location = new System.Drawing.Point(372, 236);
            this.chkEvent8.Name = "chkEvent8";
            this.chkEvent8.Size = new System.Drawing.Size(68, 19);
            this.chkEvent8.TabIndex = 22;
            this.chkEvent8.Text = "Event 8";
            this.chkEvent8.UseVisualStyleBackColor = true;
            this.chkEvent8.CheckedChanged += new System.EventHandler(this.chkEvent8_CheckedChanged);
            // 
            // chkEvent6
            // 
            this.chkEvent6.AutoSize = true;
            this.chkEvent6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEvent6.Location = new System.Drawing.Point(103, 236);
            this.chkEvent6.Name = "chkEvent6";
            this.chkEvent6.Size = new System.Drawing.Size(68, 19);
            this.chkEvent6.TabIndex = 23;
            this.chkEvent6.Text = "Event 6";
            this.chkEvent6.UseVisualStyleBackColor = true;
            this.chkEvent6.CheckedChanged += new System.EventHandler(this.chkEvent6_CheckedChanged);
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.BackColor = System.Drawing.Color.Silver;
            this.lblhelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblhelp.ForeColor = System.Drawing.Color.Black;
            this.lblhelp.Location = new System.Drawing.Point(92, 89);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(680, 20);
            this.lblhelp.TabIndex = 24;
            this.lblhelp.Text = "Now you can get table that what you want. clicking checkbox you can hide the colu" +
    "mns of table.";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(518, 302);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(599, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAdmission
            // 
            this.txtAdmission.Location = new System.Drawing.Point(317, 313);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.Size = new System.Drawing.Size(186, 23);
            this.txtAdmission.TabIndex = 27;
            // 
            // lblAdmmission
            // 
            this.lblAdmmission.AutoSize = true;
            this.lblAdmmission.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmmission.Location = new System.Drawing.Point(203, 315);
            this.lblAdmmission.Name = "lblAdmmission";
            this.lblAdmmission.Size = new System.Drawing.Size(108, 20);
            this.lblAdmmission.TabIndex = 28;
            this.lblAdmmission.Text = "Admission No";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.ForeColor = System.Drawing.Color.Black;
            this.btnDisplay.Location = new System.Drawing.Point(680, 302);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 34);
            this.btnDisplay.TabIndex = 29;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(877, 749);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblAdmmission);
            this.Controls.Add(this.txtAdmission);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.chkEvent6);
            this.Controls.Add(this.chkEvent8);
            this.Controls.Add(this.chkEvent1);
            this.Controls.Add(this.chkEvent2);
            this.Controls.Add(this.chkEvent3);
            this.Controls.Add(this.chkEvent4);
            this.Controls.Add(this.chkEvent5);
            this.Controls.Add(this.chkEvent7);
            this.Controls.Add(this.chkEvent9);
            this.Controls.Add(this.chkRelayEvent);
            this.Controls.Add(this.chkAdmission);
            this.Controls.Add(this.grdEvent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEventDetails);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEventDetails;
        private Button btnBack;
        private DataGridView grdEvent;
        private CheckBox chkAdmission;
        private CheckBox chkRelayEvent;
        private CheckBox chkEvent9;
        private CheckBox chkEvent7;
        private CheckBox chkEvent5;
        private CheckBox chkEvent4;
        private CheckBox chkEvent3;
        private CheckBox chkEvent2;
        private CheckBox chkEvent1;
        private CheckBox chkEvent8;
        private CheckBox chkEvent6;
        private Label lblhelp;
        private Button btnSearch;
        private Button btnDelete;
        private TextBox txtAdmission;
        private Label lblAdmmission;
        private Button btnDisplay;
    }
}