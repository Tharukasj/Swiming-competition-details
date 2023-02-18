namespace Swim
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblAdmission = new System.Windows.Forms.Label();
            this.txtAdmissionNo = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.btnMore = new System.Windows.Forms.Button();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.rdb7 = new System.Windows.Forms.RadioButton();
            this.rdb8 = new System.Windows.Forms.RadioButton();
            this.rdb6 = new System.Windows.Forms.RadioButton();
            this.cmb1event3 = new System.Windows.Forms.ComboBox();
            this.gbEvent3 = new System.Windows.Forms.GroupBox();
            this.cmb3Event3 = new System.Windows.Forms.ComboBox();
            this.cmb2Event3 = new System.Windows.Forms.ComboBox();
            this.gbEvent5 = new System.Windows.Forms.GroupBox();
            this.cmb5Event5 = new System.Windows.Forms.ComboBox();
            this.cmb4Event5 = new System.Windows.Forms.ComboBox();
            this.cmb3Event5 = new System.Windows.Forms.ComboBox();
            this.cmb2Event5 = new System.Windows.Forms.ComboBox();
            this.cmb1Event5 = new System.Windows.Forms.ComboBox();
            this.lblRelay = new System.Windows.Forms.Label();
            this.cmbRelay = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cdlEvents = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbEvent3.SuspendLayout();
            this.gbEvent5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.Cyan;
            this.lblTopic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopic.ForeColor = System.Drawing.Color.Purple;
            this.lblTopic.Location = new System.Drawing.Point(302, 36);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(186, 30);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "Add Event Details";
            // 
            // lblAdmission
            // 
            this.lblAdmission.AutoSize = true;
            this.lblAdmission.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmission.Location = new System.Drawing.Point(54, 147);
            this.lblAdmission.Name = "lblAdmission";
            this.lblAdmission.Size = new System.Drawing.Size(82, 15);
            this.lblAdmission.TabIndex = 1;
            this.lblAdmission.Text = "Admission No";
            // 
            // txtAdmissionNo
            // 
            this.txtAdmissionNo.Location = new System.Drawing.Point(176, 139);
            this.txtAdmissionNo.Name = "txtAdmissionNo";
            this.txtAdmissionNo.Size = new System.Drawing.Size(147, 23);
            this.txtAdmissionNo.TabIndex = 2;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEvent.Location = new System.Drawing.Point(54, 214);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(55, 20);
            this.lblEvent.TabIndex = 3;
            this.lblEvent.Text = "Events";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(54, 256);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(79, 15);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Events count";
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb3.ForeColor = System.Drawing.Color.Black;
            this.rdb3.Location = new System.Drawing.Point(176, 254);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(32, 19);
            this.rdb3.TabIndex = 5;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "3";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.Click += new System.EventHandler(this.Select_3);
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb5.Location = new System.Drawing.Point(229, 254);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(32, 19);
            this.rdb5.TabIndex = 6;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "5";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.Click += new System.EventHandler(this.Select_5);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Black;
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Location = new System.Drawing.Point(302, 248);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(75, 25);
            this.btnMore.TabIndex = 7;
            this.btnMore.Text = "More";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.add_count);
            // 
            // rdb9
            // 
            this.rdb9.AutoSize = true;
            this.rdb9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb9.Location = new System.Drawing.Point(592, 254);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(32, 19);
            this.rdb9.TabIndex = 9;
            this.rdb9.TabStop = true;
            this.rdb9.Text = "9";
            this.rdb9.UseVisualStyleBackColor = true;
            this.rdb9.Visible = false;
            this.rdb9.Click += new System.EventHandler(this.Select_9);
            // 
            // rdb7
            // 
            this.rdb7.AutoSize = true;
            this.rdb7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb7.Location = new System.Drawing.Point(463, 254);
            this.rdb7.Name = "rdb7";
            this.rdb7.Size = new System.Drawing.Size(32, 19);
            this.rdb7.TabIndex = 9;
            this.rdb7.TabStop = true;
            this.rdb7.Text = "7";
            this.rdb7.UseVisualStyleBackColor = true;
            this.rdb7.Visible = false;
            this.rdb7.Click += new System.EventHandler(this.Select_7);
            // 
            // rdb8
            // 
            this.rdb8.AutoSize = true;
            this.rdb8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb8.Location = new System.Drawing.Point(529, 254);
            this.rdb8.Name = "rdb8";
            this.rdb8.Size = new System.Drawing.Size(32, 19);
            this.rdb8.TabIndex = 8;
            this.rdb8.TabStop = true;
            this.rdb8.Text = "8";
            this.rdb8.UseVisualStyleBackColor = true;
            this.rdb8.Visible = false;
            this.rdb8.Click += new System.EventHandler(this.Select_8);
            // 
            // rdb6
            // 
            this.rdb6.AutoSize = true;
            this.rdb6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb6.Location = new System.Drawing.Point(397, 254);
            this.rdb6.Name = "rdb6";
            this.rdb6.Size = new System.Drawing.Size(32, 19);
            this.rdb6.TabIndex = 7;
            this.rdb6.TabStop = true;
            this.rdb6.Text = "6";
            this.rdb6.UseVisualStyleBackColor = true;
            this.rdb6.Visible = false;
            this.rdb6.Click += new System.EventHandler(this.Select_6);
            // 
            // cmb1event3
            // 
            this.cmb1event3.FormattingEnabled = true;
            this.cmb1event3.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb1event3.Location = new System.Drawing.Point(6, 22);
            this.cmb1event3.Name = "cmb1event3";
            this.cmb1event3.Size = new System.Drawing.Size(121, 23);
            this.cmb1event3.TabIndex = 9;
            // 
            // gbEvent3
            // 
            this.gbEvent3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbEvent3.Controls.Add(this.cmb3Event3);
            this.gbEvent3.Controls.Add(this.cmb2Event3);
            this.gbEvent3.Controls.Add(this.cmb1event3);
            this.gbEvent3.Location = new System.Drawing.Point(54, 318);
            this.gbEvent3.Name = "gbEvent3";
            this.gbEvent3.Size = new System.Drawing.Size(168, 144);
            this.gbEvent3.TabIndex = 10;
            this.gbEvent3.TabStop = false;
            this.gbEvent3.Visible = false;
            // 
            // cmb3Event3
            // 
            this.cmb3Event3.FormattingEnabled = true;
            this.cmb3Event3.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb3Event3.Location = new System.Drawing.Point(6, 101);
            this.cmb3Event3.Name = "cmb3Event3";
            this.cmb3Event3.Size = new System.Drawing.Size(121, 23);
            this.cmb3Event3.TabIndex = 11;
            // 
            // cmb2Event3
            // 
            this.cmb2Event3.FormattingEnabled = true;
            this.cmb2Event3.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb2Event3.Location = new System.Drawing.Point(6, 61);
            this.cmb2Event3.Name = "cmb2Event3";
            this.cmb2Event3.Size = new System.Drawing.Size(121, 23);
            this.cmb2Event3.TabIndex = 10;
            // 
            // gbEvent5
            // 
            this.gbEvent5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbEvent5.Controls.Add(this.cmb5Event5);
            this.gbEvent5.Controls.Add(this.cmb4Event5);
            this.gbEvent5.Controls.Add(this.cmb3Event5);
            this.gbEvent5.Controls.Add(this.cmb2Event5);
            this.gbEvent5.Controls.Add(this.cmb1Event5);
            this.gbEvent5.Location = new System.Drawing.Point(229, 318);
            this.gbEvent5.Name = "gbEvent5";
            this.gbEvent5.Size = new System.Drawing.Size(159, 230);
            this.gbEvent5.TabIndex = 11;
            this.gbEvent5.TabStop = false;
            this.gbEvent5.Visible = false;
            // 
            // cmb5Event5
            // 
            this.cmb5Event5.FormattingEnabled = true;
            this.cmb5Event5.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb5Event5.Location = new System.Drawing.Point(6, 187);
            this.cmb5Event5.Name = "cmb5Event5";
            this.cmb5Event5.Size = new System.Drawing.Size(121, 23);
            this.cmb5Event5.TabIndex = 13;
            // 
            // cmb4Event5
            // 
            this.cmb4Event5.FormattingEnabled = true;
            this.cmb4Event5.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb4Event5.Location = new System.Drawing.Point(6, 143);
            this.cmb4Event5.Name = "cmb4Event5";
            this.cmb4Event5.Size = new System.Drawing.Size(121, 23);
            this.cmb4Event5.TabIndex = 12;
            // 
            // cmb3Event5
            // 
            this.cmb3Event5.FormattingEnabled = true;
            this.cmb3Event5.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb3Event5.Location = new System.Drawing.Point(6, 101);
            this.cmb3Event5.Name = "cmb3Event5";
            this.cmb3Event5.Size = new System.Drawing.Size(121, 23);
            this.cmb3Event5.TabIndex = 11;
            // 
            // cmb2Event5
            // 
            this.cmb2Event5.FormattingEnabled = true;
            this.cmb2Event5.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb2Event5.Location = new System.Drawing.Point(6, 61);
            this.cmb2Event5.Name = "cmb2Event5";
            this.cmb2Event5.Size = new System.Drawing.Size(121, 23);
            this.cmb2Event5.TabIndex = 10;
            // 
            // cmb1Event5
            // 
            this.cmb1Event5.FormattingEnabled = true;
            this.cmb1Event5.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cmb1Event5.Location = new System.Drawing.Point(6, 22);
            this.cmb1Event5.Name = "cmb1Event5";
            this.cmb1Event5.Size = new System.Drawing.Size(121, 23);
            this.cmb1Event5.TabIndex = 9;
            // 
            // lblRelay
            // 
            this.lblRelay.AutoSize = true;
            this.lblRelay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRelay.Location = new System.Drawing.Point(69, 620);
            this.lblRelay.Name = "lblRelay";
            this.lblRelay.Size = new System.Drawing.Size(72, 15);
            this.lblRelay.TabIndex = 13;
            this.lblRelay.Text = "Relay Event";
            // 
            // cmbRelay
            // 
            this.cmbRelay.FormattingEnabled = true;
            this.cmbRelay.Items.AddRange(new object[] {
            "200 Freestyle",
            "400 Freestyle",
            "200 Medley Relay"});
            this.cmbRelay.Location = new System.Drawing.Point(176, 612);
            this.cmbRelay.Name = "cmbRelay";
            this.cmbRelay.Size = new System.Drawing.Size(121, 23);
            this.cmbRelay.TabIndex = 14;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnContinue.Location = new System.Drawing.Point(529, 629);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(122, 25);
            this.btnContinue.TabIndex = 15;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.Btn_Click);
            this.btnContinue.MouseLeave += new System.EventHandler(this.btnContinue_MouseLeave);
            this.btnContinue.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(442, 631);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_click);
            // 
            // cdlEvents
            // 
            this.cdlEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cdlEvents.FormattingEnabled = true;
            this.cdlEvents.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving"});
            this.cdlEvents.Location = new System.Drawing.Point(411, 332);
            this.cdlEvents.Name = "cdlEvents";
            this.cdlEvents.Size = new System.Drawing.Size(194, 184);
            this.cdlEvents.TabIndex = 17;
            this.cdlEvents.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(669, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cdlEvents);
            this.Controls.Add(this.rdb9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rdb8);
            this.Controls.Add(this.rdb7);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cmbRelay);
            this.Controls.Add(this.rdb6);
            this.Controls.Add(this.lblRelay);
            this.Controls.Add(this.gbEvent5);
            this.Controls.Add(this.gbEvent3);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.rdb5);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.txtAdmissionNo);
            this.Controls.Add(this.lblAdmission);
            this.Controls.Add(this.lblTopic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbEvent3.ResumeLayout(false);
            this.gbEvent5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTopic;
        private Label lblAdmission;
        private TextBox txtAdmissionNo;
        private Label lblEvent;
        private Label lblCount;
        private RadioButton rdb3;
        private RadioButton rdb5;
        private Button btnMore;
        private RadioButton rdb9;
        private RadioButton rdb7;
        private RadioButton rdb8;
        private RadioButton rdb6;
        private ComboBox cmb1event3;
        private GroupBox gbEvent3;
        private ComboBox cmb3Event3;
        private ComboBox cmb2Event3;
        private GroupBox gbEvent5;
        private ComboBox cmb5Event5;
        private ComboBox cmb4Event5;
        private ComboBox cmb3Event5;
        private ComboBox cmb2Event5;
        private ComboBox cmb1Event5;
        private Label lblRelay;
        private ComboBox cmbRelay;
        private Button btnContinue;
        private Button btnBack;
        private CheckedListBox cdlEvents;
        private Button btnSave;
    }
}