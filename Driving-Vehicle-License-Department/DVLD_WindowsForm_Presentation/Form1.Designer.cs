namespace DVLD_WindowsForm_Presentation
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
            this.ctrlSimpleClick2 = new DVLD_WindowsForm_Presentation.ctrlSimpleClick();
            this.ctrlSimpleClick3 = new DVLD_WindowsForm_Presentation.ctrlSimpleClick();
            this.SuspendLayout();
            // 
            // ctrlSimpleClick2
            // 
            this.ctrlSimpleClick2.Location = new System.Drawing.Point(0, 0);
            this.ctrlSimpleClick2.Name = "ctrlSimpleClick2";
            this.ctrlSimpleClick2.Size = new System.Drawing.Size(181, 32);
            this.ctrlSimpleClick2.TabIndex = 0;
            // 
            // ctrlSimpleClick3
            // 
            this.ctrlSimpleClick3.Location = new System.Drawing.Point(0, 0);
            this.ctrlSimpleClick3.Name = "ctrlSimpleClick3";
            this.ctrlSimpleClick3.Size = new System.Drawing.Size(181, 32);
            this.ctrlSimpleClick3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlSimpleClick ctrlSimpleClick2;
        private ctrlSimpleClick ctrlSimpleClick3;
    }
}