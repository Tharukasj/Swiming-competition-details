namespace Swim
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.lblAddResult = new System.Windows.Forms.Label();
            this.lblAdmissionNo = new System.Windows.Forms.Label();
            this.txtAdmission = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.btn100Backstroke = new System.Windows.Forms.Button();
            this.btn100Butterfly = new System.Windows.Forms.Button();
            this.btn500Freestyle = new System.Windows.Forms.Button();
            this.btn200MeedleyRelay = new System.Windows.Forms.Button();
            this.btn400FreestyleRelay = new System.Windows.Forms.Button();
            this.btn200FreestyleRelay = new System.Windows.Forms.Button();
            this.btn1MeterDriving = new System.Windows.Forms.Button();
            this.btn200IndividualMedley = new System.Windows.Forms.Button();
            this.btn100Breakstroke = new System.Windows.Forms.Button();
            this.btn200Freestyle = new System.Windows.Forms.Button();
            this.btn100Freestyle = new System.Windows.Forms.Button();
            this.btn50Freestyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddResult
            // 
            this.lblAddResult.AutoSize = true;
            this.lblAddResult.BackColor = System.Drawing.Color.Cyan;
            this.lblAddResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAddResult.Location = new System.Drawing.Point(331, 30);
            this.lblAddResult.Name = "lblAddResult";
            this.lblAddResult.Size = new System.Drawing.Size(158, 30);
            this.lblAddResult.TabIndex = 0;
            this.lblAddResult.Text = "Add the Result";
            // 
            // lblAdmissionNo
            // 
            this.lblAdmissionNo.AutoSize = true;
            this.lblAdmissionNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmissionNo.Location = new System.Drawing.Point(74, 142);
            this.lblAdmissionNo.Name = "lblAdmissionNo";
            this.lblAdmissionNo.Size = new System.Drawing.Size(82, 15);
            this.lblAdmissionNo.TabIndex = 1;
            this.lblAdmissionNo.Text = "Admission No";
            // 
            // txtAdmission
            // 
            this.txtAdmission.Location = new System.Drawing.Point(207, 134);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.Size = new System.Drawing.Size(170, 23);
            this.txtAdmission.TabIndex = 2;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEvent.Location = new System.Drawing.Point(74, 210);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(39, 15);
            this.lblEvent.TabIndex = 8;
            this.lblEvent.Text = "Event";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(77, 276);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 15);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(676, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(210, 268);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 23);
            this.txtTime.TabIndex = 17;
            // 
            // cmbEvent
            // 
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Items.AddRange(new object[] {
            "50 Freestyle",
            "100 Freestyle",
            "200 Freestyle",
            "500 Freestyle",
            "100 Butterfly",
            "100 Backstroke",
            "100 Breakstroke",
            "200 Individual Medley",
            "1 Meter Driving",
            "200 Freestyle Relay",
            "400 Freestyle Relay",
            "200 Medley Relay"});
            this.cmbEvent.Location = new System.Drawing.Point(207, 202);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(121, 23);
            this.cmbEvent.TabIndex = 21;
            // 
            // btn100Backstroke
            // 
            this.btn100Backstroke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn100Backstroke.ForeColor = System.Drawing.Color.Black;
            this.btn100Backstroke.Location = new System.Drawing.Point(676, 321);
            this.btn100Backstroke.Name = "btn100Backstroke";
            this.btn100Backstroke.Size = new System.Drawing.Size(75, 46);
            this.btn100Backstroke.TabIndex = 22;
            this.btn100Backstroke.Text = "100 Backstroke";
            this.btn100Backstroke.UseVisualStyleBackColor = false;
            this.btn100Backstroke.Click += new System.EventHandler(this.btn100Backstroke_Click);
            // 
            // btn100Butterfly
            // 
            this.btn100Butterfly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn100Butterfly.ForeColor = System.Drawing.Color.Black;
            this.btn100Butterfly.Location = new System.Drawing.Point(559, 321);
            this.btn100Butterfly.Name = "btn100Butterfly";
            this.btn100Butterfly.Size = new System.Drawing.Size(75, 46);
            this.btn100Butterfly.TabIndex = 23;
            this.btn100Butterfly.Text = "100 Butterfly";
            this.btn100Butterfly.UseVisualStyleBackColor = false;
            this.btn100Butterfly.Click += new System.EventHandler(this.btn100Butterfly_Click);
            // 
            // btn500Freestyle
            // 
            this.btn500Freestyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn500Freestyle.ForeColor = System.Drawing.Color.Black;
            this.btn500Freestyle.Location = new System.Drawing.Point(444, 321);
            this.btn500Freestyle.Name = "btn500Freestyle";
            this.btn500Freestyle.Size = new System.Drawing.Size(75, 46);
            this.btn500Freestyle.TabIndex = 24;
            this.btn500Freestyle.Text = "500 Freestyle";
            this.btn500Freestyle.UseVisualStyleBackColor = false;
            this.btn500Freestyle.Click += new System.EventHandler(this.btn500Freestyle_Click);
            // 
            // btn200MeedleyRelay
            // 
            this.btn200MeedleyRelay.BackColor = System.Drawing.Color.Olive;
            this.btn200MeedleyRelay.ForeColor = System.Drawing.Color.Black;
            this.btn200MeedleyRelay.Location = new System.Drawing.Point(676, 392);
            this.btn200MeedleyRelay.Name = "btn200MeedleyRelay";
            this.btn200MeedleyRelay.Size = new System.Drawing.Size(75, 57);
            this.btn200MeedleyRelay.TabIndex = 25;
            this.btn200MeedleyRelay.Text = "200 Meedley Relay";
            this.btn200MeedleyRelay.UseVisualStyleBackColor = false;
            this.btn200MeedleyRelay.Click += new System.EventHandler(this.btn200MeedleyRelay_Click);
            // 
            // btn400FreestyleRelay
            // 
            this.btn400FreestyleRelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn400FreestyleRelay.ForeColor = System.Drawing.Color.Black;
            this.btn400FreestyleRelay.Location = new System.Drawing.Point(559, 394);
            this.btn400FreestyleRelay.Name = "btn400FreestyleRelay";
            this.btn400FreestyleRelay.Size = new System.Drawing.Size(75, 55);
            this.btn400FreestyleRelay.TabIndex = 26;
            this.btn400FreestyleRelay.Text = "400 Freestyle Relay";
            this.btn400FreestyleRelay.UseVisualStyleBackColor = false;
            this.btn400FreestyleRelay.Click += new System.EventHandler(this.btn400FreestyleRelay_Click);
            // 
            // btn200FreestyleRelay
            // 
            this.btn200FreestyleRelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn200FreestyleRelay.ForeColor = System.Drawing.Color.Black;
            this.btn200FreestyleRelay.Location = new System.Drawing.Point(444, 394);
            this.btn200FreestyleRelay.Name = "btn200FreestyleRelay";
            this.btn200FreestyleRelay.Size = new System.Drawing.Size(75, 55);
            this.btn200FreestyleRelay.TabIndex = 27;
            this.btn200FreestyleRelay.Text = "200 Freestyle Relay";
            this.btn200FreestyleRelay.UseVisualStyleBackColor = false;
            this.btn200FreestyleRelay.Click += new System.EventHandler(this.btn200FreestyleRelay_Click);
            // 
            // btn1MeterDriving
            // 
            this.btn1MeterDriving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn1MeterDriving.ForeColor = System.Drawing.Color.Black;
            this.btn1MeterDriving.Location = new System.Drawing.Point(322, 392);
            this.btn1MeterDriving.Name = "btn1MeterDriving";
            this.btn1MeterDriving.Size = new System.Drawing.Size(75, 57);
            this.btn1MeterDriving.TabIndex = 28;
            this.btn1MeterDriving.Text = "1 Meter Driving";
            this.btn1MeterDriving.UseVisualStyleBackColor = false;
            this.btn1MeterDriving.Click += new System.EventHandler(this.btn1MeterDriving_Click);
            // 
            // btn200IndividualMedley
            // 
            this.btn200IndividualMedley.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn200IndividualMedley.ForeColor = System.Drawing.Color.Black;
            this.btn200IndividualMedley.Location = new System.Drawing.Point(198, 388);
            this.btn200IndividualMedley.Name = "btn200IndividualMedley";
            this.btn200IndividualMedley.Size = new System.Drawing.Size(84, 61);
            this.btn200IndividualMedley.TabIndex = 29;
            this.btn200IndividualMedley.Text = "200 Individual Medley";
            this.btn200IndividualMedley.UseVisualStyleBackColor = false;
            this.btn200IndividualMedley.Click += new System.EventHandler(this.btn200IndividualMedley_Click);
            // 
            // btn100Breakstroke
            // 
            this.btn100Breakstroke.BackColor = System.Drawing.Color.Teal;
            this.btn100Breakstroke.ForeColor = System.Drawing.Color.Black;
            this.btn100Breakstroke.Location = new System.Drawing.Point(67, 388);
            this.btn100Breakstroke.Name = "btn100Breakstroke";
            this.btn100Breakstroke.Size = new System.Drawing.Size(82, 61);
            this.btn100Breakstroke.TabIndex = 30;
            this.btn100Breakstroke.Text = "100 Breakstroke";
            this.btn100Breakstroke.UseVisualStyleBackColor = false;
            this.btn100Breakstroke.Click += new System.EventHandler(this.btn100Breakstroke_Click);
            // 
            // btn200Freestyle
            // 
            this.btn200Freestyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn200Freestyle.ForeColor = System.Drawing.Color.Black;
            this.btn200Freestyle.Location = new System.Drawing.Point(322, 321);
            this.btn200Freestyle.Name = "btn200Freestyle";
            this.btn200Freestyle.Size = new System.Drawing.Size(75, 46);
            this.btn200Freestyle.TabIndex = 31;
            this.btn200Freestyle.Text = "200 Freestyle";
            this.btn200Freestyle.UseVisualStyleBackColor = false;
            this.btn200Freestyle.Click += new System.EventHandler(this.btn200Freestyle_Click);
            // 
            // btn100Freestyle
            // 
            this.btn100Freestyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn100Freestyle.ForeColor = System.Drawing.Color.Black;
            this.btn100Freestyle.Location = new System.Drawing.Point(198, 321);
            this.btn100Freestyle.Name = "btn100Freestyle";
            this.btn100Freestyle.Size = new System.Drawing.Size(84, 46);
            this.btn100Freestyle.TabIndex = 32;
            this.btn100Freestyle.Text = "100 Freestyle";
            this.btn100Freestyle.UseVisualStyleBackColor = false;
            this.btn100Freestyle.Click += new System.EventHandler(this.btn100Freestyle_Click);
            // 
            // btn50Freestyle
            // 
            this.btn50Freestyle.BackColor = System.Drawing.Color.Red;
            this.btn50Freestyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn50Freestyle.ForeColor = System.Drawing.Color.Black;
            this.btn50Freestyle.Location = new System.Drawing.Point(67, 321);
            this.btn50Freestyle.Name = "btn50Freestyle";
            this.btn50Freestyle.Size = new System.Drawing.Size(82, 46);
            this.btn50Freestyle.TabIndex = 33;
            this.btn50Freestyle.Text = "50 Freestyle";
            this.btn50Freestyle.UseVisualStyleBackColor = false;
            this.btn50Freestyle.Click += new System.EventHandler(this.btn50Freestyle_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.btn50Freestyle);
            this.Controls.Add(this.btn100Freestyle);
            this.Controls.Add(this.btn200Freestyle);
            this.Controls.Add(this.btn100Breakstroke);
            this.Controls.Add(this.btn200IndividualMedley);
            this.Controls.Add(this.btn1MeterDriving);
            this.Controls.Add(this.btn200FreestyleRelay);
            this.Controls.Add(this.btn400FreestyleRelay);
            this.Controls.Add(this.btn200MeedleyRelay);
            this.Controls.Add(this.btn500Freestyle);
            this.Controls.Add(this.btn100Butterfly);
            this.Controls.Add(this.btn100Backstroke);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.txtAdmission);
            this.Controls.Add(this.lblAdmissionNo);
            this.Controls.Add(this.lblAddResult);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAddResult;
        private Label lblAdmissionNo;
        private TextBox txtAdmission;
        private Label lblEvent;
        private Label lblTime;
        private Button btnBack;
        private TextBox txtTime;
        private ComboBox cmbEvent;
        private Button btn100Backstroke;
        private Button btn100Butterfly;
        private Button btn500Freestyle;
        private Button btn200MeedleyRelay;
        private Button btn400FreestyleRelay;
        private Button btn200FreestyleRelay;
        private Button btn1MeterDriving;
        private Button btn200IndividualMedley;
        private Button btn100Breakstroke;
        private Button btn200Freestyle;
        private Button btn100Freestyle;
        private Button btn50Freestyle;
    }
}