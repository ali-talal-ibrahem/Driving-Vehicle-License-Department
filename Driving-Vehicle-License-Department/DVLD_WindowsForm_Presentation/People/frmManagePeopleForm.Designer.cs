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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PeopleInformation
            // 
            this.dgv_PeopleInformation.AllowUserToAddRows = false;
            this.dgv_PeopleInformation.AllowUserToDeleteRows = false;
            this.dgv_PeopleInformation.AllowUserToOrderColumns = true;
            this.dgv_PeopleInformation.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PeopleInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PeopleInformation.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_PeopleInformation.Location = new System.Drawing.Point(0, 154);
            this.dgv_PeopleInformation.Name = "dgv_PeopleInformation";
            this.dgv_PeopleInformation.ReadOnly = true;
            this.dgv_PeopleInformation.Size = new System.Drawing.Size(914, 288);
            this.dgv_PeopleInformation.TabIndex = 0;
            // 
            // frmManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(908, 503);
            this.Controls.Add(this.dgv_PeopleInformation);
            this.Name = "frmManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DVLD - Manage People";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PeopleInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PeopleInformation;
    }
}