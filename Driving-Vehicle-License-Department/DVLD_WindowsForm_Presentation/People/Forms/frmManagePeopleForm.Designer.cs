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
            this.cms_AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_EditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_CallPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ResulrPeopleCount = new System.Windows.Forms.Label();
            this.btn_AddNewPerson = new System.Windows.Forms.Button();
            this.btn_CloseForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.txb_Filter = new System.Windows.Forms.TextBox();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.cms_AddNewPerson,
            this.cms_EditPerson,
            this.cms_DeletePerson,
            this.cms_SendEmail,
            this.cms_CallPhone});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(169, 196);
            // 
            // cms_ShowDetails
            // 
            this.cms_ShowDetails.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cms_ShowDetails.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_ShowDetails.ForeColor = System.Drawing.Color.White;
            this.cms_ShowDetails.Image = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_supplier_100;
            this.cms_ShowDetails.Name = "cms_ShowDetails";
            this.cms_ShowDetails.Size = new System.Drawing.Size(180, 32);
            this.cms_ShowDetails.Text = "Show Details";
            this.cms_ShowDetails.Click += new System.EventHandler(this.cms_ShowDetails_Click);
            // 
            // cms_AddNewPerson
            // 
            this.cms_AddNewPerson.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cms_AddNewPerson.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_AddNewPerson.ForeColor = System.Drawing.Color.White;
            this.cms_AddNewPerson.Image = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_add_user_male_100;
            this.cms_AddNewPerson.Name = "cms_AddNewPerson";
            this.cms_AddNewPerson.Size = new System.Drawing.Size(180, 32);
            this.cms_AddNewPerson.Text = "Add New Person";
            this.cms_AddNewPerson.Click += new System.EventHandler(this.cms_AddNewPerson_Click);
            // 
            // cms_EditPerson
            // 
            this.cms_EditPerson.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cms_EditPerson.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_EditPerson.ForeColor = System.Drawing.Color.White;
            this.cms_EditPerson.Image = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_registration_100;
            this.cms_EditPerson.Name = "cms_EditPerson";
            this.cms_EditPerson.Size = new System.Drawing.Size(180, 32);
            this.cms_EditPerson.Text = "Edit Person";
            this.cms_EditPerson.Click += new System.EventHandler(this.cms_EditPerson_Click);
            // 
            // cms_DeletePerson
            // 
            this.cms_DeletePerson.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cms_DeletePerson.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_DeletePerson.ForeColor = System.Drawing.Color.White;
            this.cms_DeletePerson.Image = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_cancel_100;
            this.cms_DeletePerson.Name = "cms_DeletePerson";
            this.cms_DeletePerson.Size = new System.Drawing.Size(180, 32);
            this.cms_DeletePerson.Text = "Delete Person";
            this.cms_DeletePerson.Click += new System.EventHandler(this.cms_DeletePerson_Click);
            // 
            // cms_SendEmail
            // 
            this.cms_SendEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cms_SendEmail.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_SendEmail.ForeColor = System.Drawing.Color.White;
            this.cms_SendEmail.Image = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_email_100;
            this.cms_SendEmail.Name = "cms_SendEmail";
            this.cms_SendEmail.Size = new System.Drawing.Size(180, 32);
            this.cms_SendEmail.Text = "Send Email";
            this.cms_SendEmail.Click += new System.EventHandler(this.cms_SendEmail_Click);
            // 
            // cms_CallPhone
            // 
            this.cms_CallPhone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cms_CallPhone.Font = new System.Drawing.Font("SAHAR", 10F);
            this.cms_CallPhone.ForeColor = System.Drawing.Color.White;
            this.cms_CallPhone.Image = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_phone_100;
            this.cms_CallPhone.Name = "cms_CallPhone";
            this.cms_CallPhone.Size = new System.Drawing.Size(180, 32);
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
            this.btn_AddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddNewPerson.BackgroundImage = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_add_user_male_100;
            this.btn_AddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddNewPerson.FlatAppearance.BorderSize = 0;
            this.btn_AddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewPerson.Location = new System.Drawing.Point(863, 73);
            this.btn_AddNewPerson.Name = "btn_AddNewPerson";
            this.btn_AddNewPerson.Size = new System.Drawing.Size(33, 27);
            this.btn_AddNewPerson.TabIndex = 2;
            this.btn_AddNewPerson.UseVisualStyleBackColor = false;
            this.btn_AddNewPerson.Click += new System.EventHandler(this.btn_AddNewPerson_Click);
            // 
            // btn_CloseForm
            // 
            this.btn_CloseForm.BackColor = System.Drawing.Color.Crimson;
            this.btn_CloseForm.BackgroundImage = global::DVLD_WindowsForm_Presentation.Properties.Resources.icons8_cancel_100;
            this.btn_CloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseForm.FlatAppearance.BorderSize = 0;
            this.btn_CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseForm.Location = new System.Drawing.Point(863, 448);
            this.btn_CloseForm.Name = "btn_CloseForm";
            this.btn_CloseForm.Size = new System.Drawing.Size(33, 27);
            this.btn_CloseForm.TabIndex = 3;
            this.btn_CloseForm.UseVisualStyleBackColor = false;
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
            "Phone",
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
            this.txb_Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Filter_KeyPress);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - Manage People";
            this.Load += new System.EventHandler(this.frmManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem cms_AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem cms_EditPerson;
        private System.Windows.Forms.ToolStripMenuItem cms_DeletePerson;
        private System.Windows.Forms.ToolStripMenuItem cms_SendEmail;
        private System.Windows.Forms.ToolStripMenuItem cms_CallPhone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}