namespace Swim
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.lblGetReport = new System.Windows.Forms.Label();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnCompetition = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnCoach = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGetReport
            // 
            this.lblGetReport.AutoSize = true;
            this.lblGetReport.BackColor = System.Drawing.Color.Cyan;
            this.lblGetReport.ForeColor = System.Drawing.Color.Purple;
            this.lblGetReport.Location = new System.Drawing.Point(353, 30);
            this.lblGetReport.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGetReport.Name = "lblGetReport";
            this.lblGetReport.Size = new System.Drawing.Size(120, 30);
            this.lblGetReport.TabIndex = 0;
            this.lblGetReport.Text = "Get Report";
            // 
            // btnEvent
            // 
            this.btnEvent.BackColor = System.Drawing.Color.Yellow;
            this.btnEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEvent.ForeColor = System.Drawing.Color.Green;
            this.btnEvent.Location = new System.Drawing.Point(153, 229);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(86, 36);
            this.btnEvent.TabIndex = 1;
            this.btnEvent.Text = "Events";
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.event_click);
            // 
            // btnCompetition
            // 
            this.btnCompetition.BackColor = System.Drawing.Color.Lime;
            this.btnCompetition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompetition.ForeColor = System.Drawing.Color.Green;
            this.btnCompetition.Location = new System.Drawing.Point(153, 133);
            this.btnCompetition.Name = "btnCompetition";
            this.btnCompetition.Size = new System.Drawing.Size(174, 36);
            this.btnCompetition.TabIndex = 2;
            this.btnCompetition.Text = "Competitors Details";
            this.btnCompetition.UseVisualStyleBackColor = false;
            this.btnCompetition.Click += new System.EventHandler(this.Competition_click);
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlace.ForeColor = System.Drawing.Color.Green;
            this.btnPlace.Location = new System.Drawing.Point(153, 417);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(86, 36);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.place_click);
            // 
            // btnCoach
            // 
            this.btnCoach.BackColor = System.Drawing.Color.Silver;
            this.btnCoach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCoach.ForeColor = System.Drawing.Color.Green;
            this.btnCoach.Location = new System.Drawing.Point(153, 321);
            this.btnCoach.Name = "btnCoach";
            this.btnCoach.Size = new System.Drawing.Size(145, 36);
            this.btnCoach.TabIndex = 4;
            this.btnCoach.Text = "Coach Details";
            this.btnCoach.UseVisualStyleBackColor = false;
            this.btnCoach.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(714, 498);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 613);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCoach);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.btnCompetition);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.lblGetReport);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGetReport;
        private Button btnEvent;
        private Button btnCompetition;
        private Button btnPlace;
        private Button btnCoach;
        private Button btnBack;
    }
}