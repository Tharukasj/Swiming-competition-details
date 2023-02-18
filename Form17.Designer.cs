namespace Swim
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.grdCoach = new System.Windows.Forms.DataGridView();
            this.lblCoach = new System.Windows.Forms.Label();
            this.chkAdmission = new System.Windows.Forms.CheckBox();
            this.chkCoachPhone = new System.Windows.Forms.CheckBox();
            this.chkCoachName = new System.Windows.Forms.CheckBox();
            this.chkMiccPhone = new System.Windows.Forms.CheckBox();
            this.chkMiccName = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHelp = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblAdmmission = new System.Windows.Forms.Label();
            this.txtAdmission = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCoach)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCoach
            // 
            this.grdCoach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdCoach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCoach.Location = new System.Drawing.Point(158, 263);
            this.grdCoach.Name = "grdCoach";
            this.grdCoach.RowTemplate.Height = 25;
            this.grdCoach.Size = new System.Drawing.Size(527, 261);
            this.grdCoach.TabIndex = 0;
            // 
            // lblCoach
            // 
            this.lblCoach.AutoSize = true;
            this.lblCoach.BackColor = System.Drawing.Color.Cyan;
            this.lblCoach.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCoach.ForeColor = System.Drawing.Color.Purple;
            this.lblCoach.Location = new System.Drawing.Point(340, 30);
            this.lblCoach.Name = "lblCoach";
            this.lblCoach.Size = new System.Drawing.Size(145, 30);
            this.lblCoach.TabIndex = 1;
            this.lblCoach.Text = "Coach Details";
            // 
            // chkAdmission
            // 
            this.chkAdmission.AutoSize = true;
            this.chkAdmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkAdmission.Location = new System.Drawing.Point(93, 143);
            this.chkAdmission.Name = "chkAdmission";
            this.chkAdmission.Size = new System.Drawing.Size(101, 19);
            this.chkAdmission.TabIndex = 2;
            this.chkAdmission.Text = "Admission No";
            this.chkAdmission.UseVisualStyleBackColor = true;
            this.chkAdmission.CheckedChanged += new System.EventHandler(this.chkAdmission_CheckedChanged);
            // 
            // chkCoachPhone
            // 
            this.chkCoachPhone.AutoSize = true;
            this.chkCoachPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkCoachPhone.Location = new System.Drawing.Point(648, 143);
            this.chkCoachPhone.Name = "chkCoachPhone";
            this.chkCoachPhone.Size = new System.Drawing.Size(116, 19);
            this.chkCoachPhone.TabIndex = 3;
            this.chkCoachPhone.Text = "Coach Phone No";
            this.chkCoachPhone.UseVisualStyleBackColor = true;
            this.chkCoachPhone.CheckedChanged += new System.EventHandler(this.chkCoachPhone_CheckedChanged);
            // 
            // chkCoachName
            // 
            this.chkCoachName.AutoSize = true;
            this.chkCoachName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkCoachName.Location = new System.Drawing.Point(500, 143);
            this.chkCoachName.Name = "chkCoachName";
            this.chkCoachName.Size = new System.Drawing.Size(95, 19);
            this.chkCoachName.TabIndex = 4;
            this.chkCoachName.Text = "Coach Name";
            this.chkCoachName.UseVisualStyleBackColor = true;
            this.chkCoachName.CheckedChanged += new System.EventHandler(this.chkCoachName_CheckedChanged);
            // 
            // chkMiccPhone
            // 
            this.chkMiccPhone.AutoSize = true;
            this.chkMiccPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkMiccPhone.Location = new System.Drawing.Point(362, 143);
            this.chkMiccPhone.Name = "chkMiccPhone";
            this.chkMiccPhone.Size = new System.Drawing.Size(112, 19);
            this.chkMiccPhone.TabIndex = 5;
            this.chkMiccPhone.Text = "MICC Phone No";
            this.chkMiccPhone.UseVisualStyleBackColor = true;
            this.chkMiccPhone.CheckedChanged += new System.EventHandler(this.chkMiccPhone_CheckedChanged);
            // 
            // chkMiccName
            // 
            this.chkMiccName.AutoSize = true;
            this.chkMiccName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkMiccName.Location = new System.Drawing.Point(227, 143);
            this.chkMiccName.Name = "chkMiccName";
            this.chkMiccName.Size = new System.Drawing.Size(91, 19);
            this.chkMiccName.TabIndex = 6;
            this.chkMiccName.Text = "MICC Name";
            this.chkMiccName.UseVisualStyleBackColor = true;
            this.chkMiccName.CheckedChanged += new System.EventHandler(this.chkMiccName_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(739, 195);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHelp.ForeColor = System.Drawing.Color.Black;
            this.lblHelp.Location = new System.Drawing.Point(93, 77);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(680, 20);
            this.lblHelp.TabIndex = 8;
            this.lblHelp.Text = "Now you can get table that what you want. clicking checkbox you can hide the colu" +
    "mns of table.";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.ForeColor = System.Drawing.Color.Black;
            this.btnDisplay.Location = new System.Drawing.Point(648, 195);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 30);
            this.btnDisplay.TabIndex = 39;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblAdmmission
            // 
            this.lblAdmmission.AutoSize = true;
            this.lblAdmmission.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmmission.Location = new System.Drawing.Point(171, 205);
            this.lblAdmmission.Name = "lblAdmmission";
            this.lblAdmmission.Size = new System.Drawing.Size(108, 20);
            this.lblAdmmission.TabIndex = 38;
            this.lblAdmmission.Text = "Admission No";
            // 
            // txtAdmission
            // 
            this.txtAdmission.Location = new System.Drawing.Point(285, 202);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.Size = new System.Drawing.Size(186, 23);
            this.txtAdmission.TabIndex = 37;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(567, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(486, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 602);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblAdmmission);
            this.Controls.Add(this.txtAdmission);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkMiccName);
            this.Controls.Add(this.chkMiccPhone);
            this.Controls.Add(this.chkCoachName);
            this.Controls.Add(this.chkCoachPhone);
            this.Controls.Add(this.chkAdmission);
            this.Controls.Add(this.lblCoach);
            this.Controls.Add(this.grdCoach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCoach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdCoach;
        private Label lblCoach;
        private CheckBox chkAdmission;
        private CheckBox chkCoachPhone;
        private CheckBox chkCoachName;
        private CheckBox chkMiccPhone;
        private CheckBox chkMiccName;
        private Button btnBack;
        private Label lblHelp;
        private Button btnDisplay;
        private Label lblAdmmission;
        private TextBox txtAdmission;
        private Button btnDelete;
        private Button btnSearch;
    }
}