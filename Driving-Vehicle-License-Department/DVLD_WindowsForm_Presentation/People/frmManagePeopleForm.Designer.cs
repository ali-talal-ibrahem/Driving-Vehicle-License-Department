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
            this.dgv_PeopleInformation = new System.Windows.Forms.DataGridView();
            this.lbl_ResulrPeopleCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).BeginInit();
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
            this.dgv_PeopleInformation.GridColor = System.Drawing.Color.Silver;
            this.dgv_PeopleInformation.Location = new System.Drawing.Point(0, 104);
            this.dgv_PeopleInformation.Name = "dgv_PeopleInformation";
            this.dgv_PeopleInformation.ReadOnly = true;
            this.dgv_PeopleInformation.Size = new System.Drawing.Size(914, 338);
            this.dgv_PeopleInformation.TabIndex = 0;
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
            // frmManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(908, 503);
            this.Controls.Add(this.lbl_ResulrPeopleCount);
            this.Controls.Add(this.dgv_PeopleInformation);
            this.Name = "frmManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DVLD - Manage People";
            this.Load += new System.EventHandler(this.frmManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PeopleInformation;
        private System.Windows.Forms.Label lbl_ResulrPeopleCount;
    }
}