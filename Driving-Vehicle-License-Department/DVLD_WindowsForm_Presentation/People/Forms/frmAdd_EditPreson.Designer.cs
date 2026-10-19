namespace DVLD_WindowsForm_Presentation
{
    partial class frmAdd_EditPreson
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
            this.btn_Cansel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_Countries = new System.Windows.Forms.ComboBox();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_SecondName = new System.Windows.Forms.TextBox();
            this.txb_FirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.txb_ThirdName = new System.Windows.Forms.TextBox();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txb_NO = new System.Windows.Forms.TextBox();
            this.txb_LastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PersonID = new System.Windows.Forms.Label();
            this.lbl_TitleForm = new System.Windows.Forms.Label();
            this.pb_PersonImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cansel
            // 
            this.btn_Cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cansel.Location = new System.Drawing.Point(807, 475);
            this.btn_Cansel.Name = "btn_Cansel";
            this.btn_Cansel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cansel.TabIndex = 3;
            this.btn_Cansel.Text = "cansel";
            this.btn_Cansel.UseVisualStyleBackColor = true;
            this.btn_Cansel.Click += new System.EventHandler(this.btn_Cansel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(726, 475);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_Countries
            // 
            this.cb_Countries.Font = new System.Drawing.Font("SAHAR", 8F);
            this.cb_Countries.FormattingEnabled = true;
            this.cb_Countries.ItemHeight = 21;
            this.cb_Countries.Location = new System.Drawing.Point(243, 328);
            this.cb_Countries.Name = "cb_Countries";
            this.cb_Countries.Size = new System.Drawing.Size(200, 29);
            this.cb_Countries.TabIndex = 42;
            // 
            // txb_Address
            // 
            this.txb_Address.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_Address.Location = new System.Drawing.Point(22, 388);
            this.txb_Address.Multiline = true;
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(609, 94);
            this.txb_Address.TabIndex = 44;
            this.txb_Address.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txb_Email
            // 
            this.txb_Email.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_Email.Location = new System.Drawing.Point(22, 328);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(138, 29);
            this.txb_Email.TabIndex = 38;
            this.txb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txb_SecondName
            // 
            this.txb_SecondName.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_SecondName.Location = new System.Drawing.Point(243, 145);
            this.txb_SecondName.Name = "txb_SecondName";
            this.txb_SecondName.Size = new System.Drawing.Size(138, 29);
            this.txb_SecondName.TabIndex = 25;
            this.txb_SecondName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txb_FirstName
            // 
            this.txb_FirstName.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_FirstName.Location = new System.Drawing.Point(22, 145);
            this.txb_FirstName.Name = "txb_FirstName";
            this.txb_FirstName.Size = new System.Drawing.Size(138, 29);
            this.txb_FirstName.TabIndex = 22;
            this.txb_FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label11.Location = new System.Drawing.Point(237, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 31);
            this.label11.TabIndex = 43;
            this.label11.Text = "Country";
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdb_Male.Font = new System.Drawing.Font("SAHAR", 10F);
            this.rdb_Male.Location = new System.Drawing.Point(23, 265);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(54, 31);
            this.rdb_Male.TabIndex = 23;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "Male";
            this.rdb_Male.UseVisualStyleBackColor = true;
            this.rdb_Male.CheckedChanged += new System.EventHandler(this.rdb_Male_CheckedChanged);
            // 
            // txb_ThirdName
            // 
            this.txb_ThirdName.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_ThirdName.Location = new System.Drawing.Point(493, 145);
            this.txb_ThirdName.Name = "txb_ThirdName";
            this.txb_ThirdName.Size = new System.Drawing.Size(138, 29);
            this.txb_ThirdName.TabIndex = 28;
            this.txb_ThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdb_Female.Font = new System.Drawing.Font("SAHAR", 10F);
            this.rdb_Female.Location = new System.Drawing.Point(96, 265);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(67, 31);
            this.rdb_Female.TabIndex = 26;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "Female";
            this.rdb_Female.UseVisualStyleBackColor = true;
            this.rdb_Female.CheckedChanged += new System.EventHandler(this.rdb_Female_CheckedChanged);
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(243, 206);
            this.dtp_DateOfBirth.MaxDate = new System.DateTime(2007, 1, 1, 0, 0, 0, 0);
            this.dtp_DateOfBirth.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtp_DateOfBirth.TabIndex = 34;
            this.dtp_DateOfBirth.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_PhoneNumber.Location = new System.Drawing.Point(243, 267);
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(138, 29);
            this.txb_PhoneNumber.TabIndex = 37;
            this.txb_PhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txb_NO
            // 
            this.txb_NO.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_NO.Location = new System.Drawing.Point(22, 206);
            this.txb_NO.Name = "txb_NO";
            this.txb_NO.Size = new System.Drawing.Size(138, 29);
            this.txb_NO.TabIndex = 32;
            this.txb_NO.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txb_LastName
            // 
            this.txb_LastName.Font = new System.Drawing.Font("SAHAR", 8F);
            this.txb_LastName.Location = new System.Drawing.Point(723, 145);
            this.txb_LastName.Name = "txb_LastName";
            this.txb_LastName.Size = new System.Drawing.Size(138, 29);
            this.txb_LastName.TabIndex = 29;
            this.txb_LastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label12.Location = new System.Drawing.Point(16, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 31);
            this.label12.TabIndex = 40;
            this.label12.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label10.Location = new System.Drawing.Point(16, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 31);
            this.label10.TabIndex = 41;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label9.Location = new System.Drawing.Point(237, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 31);
            this.label9.TabIndex = 39;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label8.Location = new System.Drawing.Point(16, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 31);
            this.label8.TabIndex = 36;
            this.label8.Text = "Gendor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label7.Location = new System.Drawing.Point(237, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 31);
            this.label7.TabIndex = 35;
            this.label7.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label6.Location = new System.Drawing.Point(16, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "National NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label5.Location = new System.Drawing.Point(717, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label4.Location = new System.Drawing.Point(487, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Third Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label3.Location = new System.Drawing.Point(237, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Second Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("SAHAR", 12F);
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Person ID : ";
            // 
            // lbl_PersonID
            // 
            this.lbl_PersonID.AutoSize = true;
            this.lbl_PersonID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PersonID.Font = new System.Drawing.Font("SAHAR", 12F);
            this.lbl_PersonID.Location = new System.Drawing.Point(96, 81);
            this.lbl_PersonID.Name = "lbl_PersonID";
            this.lbl_PersonID.Size = new System.Drawing.Size(39, 31);
            this.lbl_PersonID.TabIndex = 45;
            this.lbl_PersonID.Text = "N/A";
            // 
            // lbl_TitleForm
            // 
            this.lbl_TitleForm.AutoSize = true;
            this.lbl_TitleForm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_TitleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TitleForm.Font = new System.Drawing.Font("SAHAR", 15F);
            this.lbl_TitleForm.ForeColor = System.Drawing.Color.White;
            this.lbl_TitleForm.Location = new System.Drawing.Point(15, 18);
            this.lbl_TitleForm.Name = "lbl_TitleForm";
            this.lbl_TitleForm.Size = new System.Drawing.Size(143, 39);
            this.lbl_TitleForm.TabIndex = 46;
            this.lbl_TitleForm.Text = "Add New Person";
            // 
            // pb_PersonImage
            // 
            this.pb_PersonImage.BackColor = System.Drawing.Color.Transparent;
            this.pb_PersonImage.BackgroundImage = global::DVLD_WindowsForm_Presentation.Properties.Resources.Male;
            this.pb_PersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_PersonImage.Location = new System.Drawing.Point(727, 207);
            this.pb_PersonImage.Name = "pb_PersonImage";
            this.pb_PersonImage.Size = new System.Drawing.Size(134, 150);
            this.pb_PersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PersonImage.TabIndex = 47;
            this.pb_PersonImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.BackColor = System.Drawing.Color.Goldenrod;
            this.llSetImage.Location = new System.Drawing.Point(808, 372);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(53, 13);
            this.llSetImage.TabIndex = 50;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "set image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.BackColor = System.Drawing.Color.Maroon;
            this.llRemoveImage.LinkColor = System.Drawing.Color.Red;
            this.llRemoveImage.Location = new System.Drawing.Point(743, 372);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(46, 13);
            this.llRemoveImage.TabIndex = 51;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // frmAdd_EditPreson
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Cansel;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.llRemoveImage);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.pb_PersonImage);
            this.Controls.Add(this.lbl_TitleForm);
            this.Controls.Add(this.cb_Countries);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_SecondName);
            this.Controls.Add(this.txb_FirstName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.txb_ThirdName);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.dtp_DateOfBirth);
            this.Controls.Add(this.txb_PhoneNumber);
            this.Controls.Add(this.txb_NO);
            this.Controls.Add(this.txb_LastName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_PersonID);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cansel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAdd_EditPreson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - ";
            this.Load += new System.EventHandler(this.frmAdd_EditPreson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cansel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_Countries;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_SecondName;
        private System.Windows.Forms.TextBox txb_FirstName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.TextBox txb_ThirdName;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.TextBox txb_PhoneNumber;
        private System.Windows.Forms.TextBox txb_NO;
        private System.Windows.Forms.TextBox txb_LastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_PersonID;
        private System.Windows.Forms.Label lbl_TitleForm;
        private System.Windows.Forms.PictureBox pb_PersonImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemoveImage;
    }
}