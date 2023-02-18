namespace Swim
{
    partial class Form29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form29));
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblAdmmission = new System.Windows.Forms.Label();
            this.txtAdmission = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.grdRelay_2 = new System.Windows.Forms.DataGridView();
            this.lblPlaceDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelay_2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Yellow;
            this.btnDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisplay.ForeColor = System.Drawing.Color.Black;
            this.btnDisplay.Location = new System.Drawing.Point(514, 161);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 33);
            this.btnDisplay.TabIndex = 77;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblAdmmission
            // 
            this.lblAdmmission.AutoSize = true;
            this.lblAdmmission.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdmmission.Location = new System.Drawing.Point(37, 171);
            this.lblAdmmission.Name = "lblAdmmission";
            this.lblAdmmission.Size = new System.Drawing.Size(108, 20);
            this.lblAdmmission.TabIndex = 76;
            this.lblAdmmission.Text = "Admission No";
            // 
            // txtAdmission
            // 
            this.txtAdmission.Location = new System.Drawing.Point(151, 171);
            this.txtAdmission.Name = "txtAdmission";
            this.txtAdmission.Size = new System.Drawing.Size(186, 23);
            this.txtAdmission.TabIndex = 75;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(433, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(352, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.Location = new System.Drawing.Point(681, 161);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(75, 32);
            this.btnBlack.TabIndex = 72;
            this.btnBlack.Text = "Back";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // grdRelay_2
            // 
            this.grdRelay_2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdRelay_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRelay_2.Location = new System.Drawing.Point(253, 216);
            this.grdRelay_2.Name = "grdRelay_2";
            this.grdRelay_2.RowTemplate.Height = 25;
            this.grdRelay_2.Size = new System.Drawing.Size(327, 319);
            this.grdRelay_2.TabIndex = 71;
            // 
            // lblPlaceDetails
            // 
            this.lblPlaceDetails.AutoSize = true;
            this.lblPlaceDetails.BackColor = System.Drawing.Color.Cyan;
            this.lblPlaceDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlaceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPlaceDetails.Location = new System.Drawing.Point(174, 54);
            this.lblPlaceDetails.Name = "lblPlaceDetails";
            this.lblPlaceDetails.Size = new System.Drawing.Size(415, 30);
            this.lblPlaceDetails.TabIndex = 70;
            this.lblPlaceDetails.Text = "Place Details of 400 Freestyle Relay Event";
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblAdmmission);
            this.Controls.Add(this.txtAdmission);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.grdRelay_2);
            this.Controls.Add(this.lblPlaceDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form29";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swimming Competition";
            this.Load += new System.EventHandler(this.Form29_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRelay_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisplay;
        private Label lblAdmmission;
        private TextBox txtAdmission;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnBlack;
        private DataGridView grdRelay_2;
        private Label lblPlaceDetails;
    }
}