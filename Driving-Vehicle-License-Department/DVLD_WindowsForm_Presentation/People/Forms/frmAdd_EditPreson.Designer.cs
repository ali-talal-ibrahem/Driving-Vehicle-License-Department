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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TitlePage = new System.Windows.Forms.Label();
            this.ctrAdd_EditPerosn = new DVLD_WindowsForm_Presentation.ctrAdd_EditPerosn();
            this.ctrAdd_EditPerosn1 = new DVLD_WindowsForm_Presentation.ctrAdd_EditPerosn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TitlePage
            // 
            this.lbl_TitlePage.AutoSize = true;
            this.lbl_TitlePage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_TitlePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TitlePage.Font = new System.Drawing.Font("SAHAR", 20F);
            this.lbl_TitlePage.ForeColor = System.Drawing.Color.White;
            this.lbl_TitlePage.Location = new System.Drawing.Point(12, 9);
            this.lbl_TitlePage.Name = "lbl_TitlePage";
            this.lbl_TitlePage.Size = new System.Drawing.Size(0, 53);
            this.lbl_TitlePage.TabIndex = 1;
            // 
            // ctrAdd_EditPerosn
            // 
            this.ctrAdd_EditPerosn.BackColor = System.Drawing.Color.White;
            this.ctrAdd_EditPerosn.Location = new System.Drawing.Point(-4, 75);
            this.ctrAdd_EditPerosn.Name = "ctrAdd_EditPerosn";
            this.ctrAdd_EditPerosn.Size = new System.Drawing.Size(924, 449);
            this.ctrAdd_EditPerosn.TabIndex = 2;
            // 
            // ctrAdd_EditPerosn1
            // 
            this.ctrAdd_EditPerosn1.BackColor = System.Drawing.Color.White;
            this.ctrAdd_EditPerosn1.Location = new System.Drawing.Point(12, 79);
            this.ctrAdd_EditPerosn1.Name = "ctrAdd_EditPerosn1";
            this.ctrAdd_EditPerosn1.Size = new System.Drawing.Size(851, 409);
            this.ctrAdd_EditPerosn1.TabIndex = 2;
            // 
            // frmAdd_EditPreson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.ctrAdd_EditPerosn1);
            this.Controls.Add(this.lbl_TitlePage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAdd_EditPreson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - ";
            this.Load += new System.EventHandler(this.frmAdd_EditPreson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_TitlePage;
        private DVLD_WindowsForm_Presentation.ctrAdd_EditPerosn ctrAdd_EditPerosn;
        private ctrAdd_EditPerosn ctrAdd_EditPerosn1;
    }
}