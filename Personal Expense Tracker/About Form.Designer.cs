namespace Personal_Expense_Tracker
{
    partial class About_Form
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
            label1 = new Label();
            lblTitle = new Label();
            lblVersion = new Label();
            lblDeveloper = new Label();
            lblPurpose = new Label();
            lblContact = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(104, 57);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "PERSONAL EXPENSE TRACKER";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(182, 89);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(80, 20);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Version 1.0";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Location = new Point(131, 123);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(189, 20);
            lblDeveloper.TabIndex = 3;
            lblDeveloper.Text = "Developer: Badere/Cutaran";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(105, 155);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(252, 20);
            lblPurpose.TabIndex = 4;
            lblPurpose.Text = "Purpose: Manage and track expenses";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(105, 190);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(249, 20);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact: BadereCutaran@gmail.com";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(182, 273);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // About_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 353);
            Controls.Add(btnOK);
            Controls.Add(lblContact);
            Controls.Add(lblPurpose);
            Controls.Add(lblDeveloper);
            Controls.Add(lblVersion);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Name = "About_Form";
            Text = "About_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private Label lblVersion;
        private Label lblDeveloper;
        private Label lblPurpose;
        private Label lblContact;
        private Button btnOK;
    }
}