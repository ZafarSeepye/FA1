namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCitizen = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picCoatOfArms = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(147, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(419, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 299);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter your Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 298);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitizen.Location = new System.Drawing.Point(1, 425);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(135, 17);
            this.lblCitizen.TabIndex = 3;
            this.lblCitizen.Text = "Choose your Citizen:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(42, 363);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 17);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Enter your ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 363);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 23);
            this.txtID.TabIndex = 5;
            // 
            // cmbCitizen
            // 
            this.cmbCitizen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCitizen.FormattingEnabled = true;
            this.cmbCitizen.Items.AddRange(new object[] {
            "South African",
            "",
            "Permanent Resident",
            "",
            "Visitor"});
            this.cmbCitizen.Location = new System.Drawing.Point(152, 425);
            this.cmbCitizen.Name = "cmbCitizen";
            this.cmbCitizen.Size = new System.Drawing.Size(200, 23);
            this.cmbCitizen.TabIndex = 6;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.Green;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(232, 472);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(120, 35);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResult.Location = new System.Drawing.Point(405, 256);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 8;
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.Color.White;
            this.txtSummary.Font = new System.Drawing.Font("Courier New", 8F);
            this.txtSummary.Location = new System.Drawing.Point(358, 299);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(370, 130);
            this.txtSummary.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Green;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(578, 472);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 35);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate Profile";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picCoatOfArms
            // 
            this.picCoatOfArms.BackColor = System.Drawing.Color.Transparent;
            this.picCoatOfArms.Image = ((System.Drawing.Image)(resources.GetObject("picCoatOfArms.Image")));
            this.picCoatOfArms.Location = new System.Drawing.Point(67, 40);
            this.picCoatOfArms.Name = "picCoatOfArms";
            this.picCoatOfArms.Size = new System.Drawing.Size(581, 252);
            this.picCoatOfArms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoatOfArms.TabIndex = 11;
            this.picCoatOfArms.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(740, 532);
            this.Controls.Add(this.picCoatOfArms);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.cmbCitizen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCitizen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Affairs Digital Identity Processor";
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbCitizen;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picCoatOfArms;
    }
}

