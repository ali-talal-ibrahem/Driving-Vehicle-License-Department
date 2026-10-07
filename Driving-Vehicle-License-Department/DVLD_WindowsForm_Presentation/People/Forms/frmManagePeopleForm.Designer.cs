namespace DVLD_WindowsForm_Presentation.People
{
    partial class frmManagePeopleForm
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
            this.components = new System.ComponentModel.Container();
            this.dgv_PeopleInformation = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_EditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cms_SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_CallPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ResulrPeopleCount = new System.Windows.Forms.Label();
            this.btn_AddNewPerson = new System.Windows.Forms.Button();
            this.btn_CloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.txb_Filter = new System.Windows.Forms.TextBox();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PeopleInformation
            // 
            this.dgv_PeopleInformation.AllowUserToAddRows = false;
            this.dgv_PeopleInformation.AllowUserToDeleteRows = false;
            this.dgv_PeopleInformation.AllowUserToOrderColumns = true;
            this.dgv_PeopleInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PeopleInformation.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PeopleInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PeopleInformation.ContextMenuStrip = this.contextMenuStrip;
            this.dgv_PeopleInformation.GridColor = System.Drawing.Color.Silver;
            this.dgv_PeopleInformation.Location = new System.Drawing.Point(0, 104);
            this.dgv_PeopleInformation.Name = "dgv_PeopleInformation";
            this.dgv_PeopleInformation.ReadOnly = true;
            this.dgv_PeopleInformation.Size = new System.Drawing.Size(914, 338);
            this.dgv_PeopleInformation.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_ShowDetails,
            this.toolStripSeparator1,
            this.cms_AddNewPerson,
            this.cms_EditPerson,
            this.cms_DeletePerson,
            this.toolStripSeparator2,
            this.cms_SendEmail,
            this.cms_CallPhone});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(169, 208);
            // 
            // cms_ShowDetails
            // 
            this.cms_ShowDetails.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_ShowDetails.Name = "cms_ShowDetails";
            this.cms_ShowDetails.Size = new System.Drawing.Size(168, 32);
            this.cms_ShowDetails.Text = "Show Details";
            this.cms_ShowDetails.Click += new System.EventHandler(this.cms_ShowDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // cms_AddNewPerson
            // 
            this.cms_AddNewPerson.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_AddNewPerson.Name = "cms_AddNewPerson";
            this.cms_AddNewPerson.Size = new System.Drawing.Size(168, 32);
            this.cms_AddNewPerson.Text = "Add New Person";
            this.cms_AddNewPerson.Click += new System.EventHandler(this.cms_AddNewPerson_Click);
            // 
            // cms_EditPerson
            // 
            this.cms_EditPerson.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_EditPerson.Name = "cms_EditPerson";
            this.cms_EditPerson.Size = new System.Drawing.Size(168, 32);
            this.cms_EditPerson.Text = "Edit Person";
            this.cms_EditPerson.Click += new System.EventHandler(this.cms_EditPerson_Click);
            // 
            // cms_DeletePerson
            // 
            this.cms_DeletePerson.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_DeletePerson.Name = "cms_DeletePerson";
            this.cms_DeletePerson.Size = new System.Drawing.Size(168, 32);
            this.cms_DeletePerson.Text = "Delete Person";
            this.cms_DeletePerson.Click += new System.EventHandler(this.cms_DeletePerson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // cms_SendEmail
            // 
            this.cms_SendEmail.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_SendEmail.Name = "cms_SendEmail";
            this.cms_SendEmail.Size = new System.Drawing.Size(168, 32);
            this.cms_SendEmail.Text = "Send Email";
            this.cms_SendEmail.Click += new System.EventHandler(this.cms_SendEmail_Click);
            // 
            // cms_CallPhone
            // 
            this.cms_CallPhone.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_CallPhone.Name = "cms_CallPhone";
            this.cms_CallPhone.Size = new System.Drawing.Size(168, 32);
            this.cms_CallPhone.Text = "Call Phone";
            this.cms_CallPhone.Click += new System.EventHandler(this.cms_CallPhone_Click);
            // 
            // lbl_ResulrPeopleCount
            // 
            this.lbl_ResulrPeopleCount.AutoSize = true;
            this.lbl_ResulrPeopleCount.Font = new System.Drawing.Font("SAHAR", 12F);
            this.lbl_ResulrPeopleCount.ForeColor = System.Drawing.Color.White;
            this.lbl_ResulrPeopleCount.Location = new System.Drawing.Point(4, 444);
            this.lbl_ResulrPeopleCount.Name = "lbl_ResulrPeopleCount";
            this.lbl_ResulrPeopleCount.Size = new System.Drawing.Size(64, 31);
            this.lbl_ResulrPeopleCount.TabIndex = 1;
            this.lbl_ResulrPeopleCount.Text = "Result : ";
            // 
            // btn_AddNewPerson
            // 
            this.btn_AddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNewPerson.Location = new System.Drawing.Point(866, 74);
            this.btn_AddNewPerson.Name = "btn_AddNewPerson";
            this.btn_AddNewPerson.Size = new System.Drawing.Size(36, 27);
            this.btn_AddNewPerson.TabIndex = 2;
            this.btn_AddNewPerson.UseVisualStyleBackColor = true;
            this.btn_AddNewPerson.Click += new System.EventHandler(this.btn_AddNewPerson_Click);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.Location = new System.Drawing.Point(842, 448);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(60, 27);
            this.btn_CloseForm.TabIndex = 3;
            this.btn_CloseForm.Text = "Close";
            this.btn_CloseForm.UseVisualStyleBackColor = true;
            this.btn_CloseForm.Click += new System.EventHandler(this.btn_CloseForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By : ";
            // 
            // cb_Filter
            // 
            this.cb_Filter.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cb_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Filter.Font = new System.Drawing.Font("SAHAR", 8F);
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Items.AddRange(new object[] {
            "PersonID",
            "NO.",
            "FirstName",
            "LastName",
            "PhoneNumber",
            "Email",
            "Country"});
            this.cb_Filter.Location = new System.Drawing.Point(75, 70);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(141, 29);
            this.cb_Filter.TabIndex = 5;
            // 
            // txb_Filter
            // 
            this.txb_Filter.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_Filter.Location = new System.Drawing.Point(222, 70);
            this.txb_Filter.Name = "txb_Filter";
            this.txb_Filter.Size = new System.Drawing.Size(150, 29);
            this.txb_Filter.TabIndex = 6;
            this.txb_Filter.TextChanged += new System.EventHandler(this.txb_Filter_TextChanged);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // frmManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.txb_Filter);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CloseForm);
            this.Controls.Add(this.btn_AddNewPerson);
            this.Controls.Add(this.lbl_ResulrPeopleCount);
            this.Controls.Add(this.dgv_PeopleInformation);
            this.Name = "frmManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - Manage People";
            this.Load += new System.EventHandler(this.frmManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PeopleInformation;
        private System.Windows.Forms.Label lbl_ResulrPeopleCount;
        private System.Windows.Forms.Button btn_AddNewPerson;
        private System.Windows.Forms.Button btn_CloseForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.TextBox txb_Filter;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cms_ShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cms_AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem cms_EditPerson;
        private System.Windows.Forms.ToolStripMenuItem cms_DeletePerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cms_SendEmail;
        private System.Windows.Forms.ToolStripMenuItem cms_CallPhone;
    }
}