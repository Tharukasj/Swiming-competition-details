namespace Swim
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.grdAthlete = new System.Windows.Forms.DataGridView();
            this.chbAdmission = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.chbDOB = new System.Windows.Forms.CheckBox();
            this.chbBCNo = new System.Windows.Forms.CheckBox();
            this.chbProvince = new System.Windows.Forms.CheckBox();
            this.chbDistrict = new System.Windows.Forms.CheckBox();
            this.chbZonal = new System.Windows.Forms.CheckBox();
            this.chbSchool = new System.Windows.Forms.CheckBox();
            this.chbHouse = new System.Windows.Forms.CheckBox();
            this.chbID = new System.Windows.Forms.CheckBox();
            this.chbSex = new System.Windows.Forms.CheckBox();
            this.chbAgeGroup = new System.Windows.Forms.CheckBox();
            this.chbAge = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblAdmmission = new System.Windows.Forms.Label();
            this.txtAdmission = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAthlete)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAthlete
            // 
            this.grdAthlete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAthlete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdAthlete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAthlete.Location = new System.Drawing.Point(22, 374);
            this.grdAthlete.Name = "grdAthlete";
            this.grdAthlete.RowTemplate.Height = 25;
            this.grdAthlete.Size = new System.Drawing.Size(902, 291);
            this.grdAthlete.TabIndex = 0;
            // 
            // chbAdmission
            // 
            this.chbAdmission.AutoSize = true;
            this.chbAdmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbAdmission.Location = new System.Drawing.Point(80, 171);
            this.chbAdmission.Name = "chbAdmission";
            this.chbAdmission.Size = new System.Drawing.Size(106, 19);
            this.chbAdmission.TabIndex = 1;
            this.chbAdmission.Text = "Admisssion No";
            this.chbAdmission.UseVisualStyleBackColor = true;
            this.chbAdmission.CheckedChanged += new System.EventHandler(this.chbAdmission_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbName.Location = new System.Drawing.Point(229, 171);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(59, 19);
            this.chbName.TabIndex = 2;
            this.chbName.Text = "Name";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.Cyan;
            this.lblTopic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopic.ForeColor = System.Drawing.Color.Purple;
            this.lblTopic.Location = new System.Drawing.Point(348, 45);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(208, 30);
            this.lblTopic.TabIndex = 3;
            this.lblTopic.Text = "Competition Details";
            // 
            // chbDOB
            // 
            this.chbDOB.AutoSize = true;
            this.chbDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbDOB.Location = new System.Drawing.Point(325, 171);
            this.chbDOB.Name = "chbDOB";
            this.chbDOB.Size = new System.Drawing.Size(52, 19);
            this.chbDOB.TabIndex = 4;
            this.chbDOB.Text = "DOB";
            this.chbDOB.UseVisualStyleBackColor = true;
            this.chbDOB.CheckedChanged += new System.EventHandler(this.chbDOB_CheckedChanged);
            // 
            // chbBCNo
            // 
            this.chbBCNo.AutoSize = true;
            this.chbBCNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbBCNo.Location = new System.Drawing.Point(624, 230);
            this.chbBCNo.Name = "chbBCNo";
            this.chbBCNo.Size = new System.Drawing.Size(139, 19);
            this.chbBCNo.TabIndex = 5;
            this.chbBCNo.Text = "Birth_Certificate_No";
            this.chbBCNo.UseVisualStyleBackColor = true;
            this.chbBCNo.CheckedChanged += new System.EventHandler(this.chbBCNo_CheckedChanged);
            // 
            // chbProvince
            // 
            this.chbProvince.AutoSize = true;
            this.chbProvince.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbProvince.Location = new System.Drawing.Point(413, 230);
            this.chbProvince.Name = "chbProvince";
            this.chbProvince.Size = new System.Drawing.Size(75, 19);
            this.chbProvince.TabIndex = 6;
            this.chbProvince.Text = "Province";
            this.chbProvince.UseVisualStyleBackColor = true;
            this.chbProvince.CheckedChanged += new System.EventHandler(this.chbProvince_CheckedChanged);
            // 
            // chbDistrict
            // 
            this.chbDistrict.AutoSize = true;
            this.chbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbDistrict.Location = new System.Drawing.Point(325, 230);
            this.chbDistrict.Name = "chbDistrict";
            this.chbDistrict.Size = new System.Drawing.Size(67, 19);
            this.chbDistrict.TabIndex = 7;
            this.chbDistrict.Text = "District";
            this.chbDistrict.UseVisualStyleBackColor = true;
            this.chbDistrict.CheckedChanged += new System.EventHandler(this.chbDistrict_CheckedChanged);
            // 
            // chbZonal
            // 
            this.chbZonal.AutoSize = true;
            this.chbZonal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbZonal.Location = new System.Drawing.Point(229, 230);
            this.chbZonal.Name = "chbZonal";
            this.chbZonal.Size = new System.Drawing.Size(56, 19);
            this.chbZonal.TabIndex = 8;
            this.chbZonal.Text = "Zonal";
            this.chbZonal.UseVisualStyleBackColor = true;
            this.chbZonal.CheckedChanged += new System.EventHandler(this.chbZonal_CheckedChanged);
            // 
            // chbSchool
            // 
            this.chbSchool.AutoSize = true;
            this.chbSchool.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbSchool.Location = new System.Drawing.Point(80, 230);
            this.chbSchool.Name = "chbSchool";
            this.chbSchool.Size = new System.Drawing.Size(63, 19);
            this.chbSchool.TabIndex = 9;
            this.chbSchool.Text = "School";
            this.chbSchool.UseVisualStyleBackColor = true;
            this.chbSchool.CheckedChanged += new System.EventHandler(this.chbSchool_CheckedChanged);
            // 
            // chbHouse
            // 
            this.chbHouse.AutoSize = true;
            this.chbHouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbHouse.Location = new System.Drawing.Point(793, 171);
            this.chbHouse.Name = "chbHouse";
            this.chbHouse.Size = new System.Drawing.Size(61, 19);
            this.chbHouse.TabIndex = 10;
            this.chbHouse.Text = "House";
            this.chbHouse.UseVisualStyleBackColor = true;
            this.chbHouse.CheckedChanged += new System.EventHandler(this.chbHouse_CheckedChanged);
            // 
            // chbID
            // 
            this.chbID.AutoSize = true;
            this.chbID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbID.Location = new System.Drawing.Point(709, 171);
            this.chbID.Name = "chbID";
            this.chbID.Size = new System.Drawing.Size(39, 19);
            this.chbID.TabIndex = 11;
            this.chbID.Text = "ID";
            this.chbID.UseVisualStyleBackColor = true;
            this.chbID.CheckedChanged += new System.EventHandler(this.chbID_CheckedChanged);
            // 
            // chbSex
            // 
            this.chbSex.AutoSize = true;
            this.chbSex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbSex.Location = new System.Drawing.Point(624, 171);
            this.chbSex.Name = "chbSex";
            this.chbSex.Size = new System.Drawing.Size(47, 19);
            this.chbSex.TabIndex = 12;
            this.chbSex.Text = "Sex";
            this.chbSex.UseVisualStyleBackColor = true;
            this.chbSex.CheckedChanged += new System.EventHandler(this.chbSex_CheckedChanged);
            // 
            // chbAgeGroup
            // 
            this.chbAgeGroup.AutoSize = true;
            this.chbAgeGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbAgeGroup.Location = new System.Drawing.Point(501, 171);
            this.chbAgeGroup.Name = "chbAgeGroup";
            this.chbAgeGroup.Size = new System.Drawing.Size(86, 19);
            this.chbAgeGroup.TabIndex = 13;
            this.chbAgeGroup.Text = "Age Group";
            this.chbAgeGroup.UseVisualStyleBackColor = true;
            this.chbAgeGroup.CheckedChanged += new System.EventHandler(this.chbAgeGroup_CheckedChanged);
            // 
            // chbAge
            // 
            this.chbAge.AutoSize = true;
            this.chbAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbAge.Location = new System.Drawing.Point(413, 171);
            this.chbAge.Name = "chbAge";
            this.chbAge.Size = new System.Drawing.Size(48, 19);
            this.chbAge.TabIndex = 14;
            this.chbAge.Text = "Age";
            this.chbAge.UseVisualStyleBackColor = true;
            this.chbAge.CheckedChanged += new System.EventHandler(this.chbAge_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Now you can get table that what you want. clicking checkbox you can hide the colu" +
    "mns of table.";
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chbDate.Location = new System.Drawing.Point(501, 230);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(53, 19);
            this.chbDate.TabIndex = 16;
            this.chbDate.Text = "Date";
            this.chbDate.UseVisualStyleBackColor = true;
            this.chbDate.CheckedChanged += new System.EventHandler(this.chbDate_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(792, 311);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 31);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.ForeColor = System.Drawing.Color.Black;
            this.btnDisplay.Location = new System.Drawing.Point(697, 311);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 32);
            this.btnDisplay.TabIndex = 34;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblAdmmission
            // 
            this.lblAdmmission.AutoSize = true;
            this.lblAdmmission.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmmission.Location = new System.Drawing.Point(211, 322);
            this.lblAdmmission.Name = "lblAdmmission";
            this.lblAdmmission.Size = new System.Drawing.Size(108, 20);
            this.lblAdmmission.TabIndex = 33;
            this.lblAdmmission.Text = "Admission No";
            // 
            // txtAdmission
            // 
            this.txtAdmission.Location = new System.Drawing.Point(334, 320);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.Size = new System.Drawing.Size(186, 23);
            this.txtAdmission.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(616, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(535, 311);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(936, 735);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblAdmmission);
            this.Controls.Add(this.txtAdmission);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbAge);
            this.Controls.Add(this.chbAgeGroup);
            this.Controls.Add(this.chbSex);
            this.Controls.Add(this.chbID);
            this.Controls.Add(this.chbHouse);
            this.Controls.Add(this.chbSchool);
            this.Controls.Add(this.chbZonal);
            this.Controls.Add(this.chbDistrict);
            this.Controls.Add(this.chbProvince);
            this.Controls.Add(this.chbBCNo);
            this.Controls.Add(this.chbDOB);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.chbName);
            this.Controls.Add(this.chbAdmission);
            this.Controls.Add(this.grdAthlete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAthlete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdAthlete;
        private CheckBox chbAdmission;
        private CheckBox chbName;
        private Label lblTopic;
        private CheckBox chbDOB;
        private CheckBox chbBCNo;
        private CheckBox chbProvince;
        private CheckBox chbDistrict;
        private CheckBox chbZonal;
        private CheckBox chbSchool;
        private CheckBox chbHouse;
        private CheckBox chbID;
        private CheckBox chbSex;
        private CheckBox chbAgeGroup;
        private CheckBox chbAge;
        private Label label1;
        private CheckBox chbDate;
        private Button btnBack;
        private Button btnDisplay;
        private Label lblAdmmission;
        private TextBox txtAdmission;
        private Button btnDelete;
        private Button btnSearch;
    }
}