namespace assigment3.github
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblmessagphone = new System.Windows.Forms.Label();
            this.lblmessagepass = new System.Windows.Forms.Label();
            this.lblmessagename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmessagphone
            // 
            this.lblmessagphone.AutoSize = true;
            this.lblmessagphone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmessagphone.Location = new System.Drawing.Point(66, 107);
            this.lblmessagphone.Name = "lblmessagphone";
            this.lblmessagphone.Size = new System.Drawing.Size(76, 31);
            this.lblmessagphone.TabIndex = 5;
            this.lblmessagphone.Text = "label2";
            // 
            // lblmessagepass
            // 
            this.lblmessagepass.AutoSize = true;
            this.lblmessagepass.Location = new System.Drawing.Point(66, 87);
            this.lblmessagepass.Name = "lblmessagepass";
            this.lblmessagepass.Size = new System.Drawing.Size(0, 20);
            this.lblmessagepass.TabIndex = 4;
            // 
            // lblmessagename
            // 
            this.lblmessagename.AutoSize = true;
            this.lblmessagename.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmessagename.Location = new System.Drawing.Point(66, 57);
            this.lblmessagename.Name = "lblmessagename";
            this.lblmessagename.Size = new System.Drawing.Size(76, 31);
            this.lblmessagename.TabIndex = 3;
            this.lblmessagename.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(295, 235);
            this.Controls.Add(this.lblmessagphone);
            this.Controls.Add(this.lblmessagepass);
            this.Controls.Add(this.lblmessagename);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblmessagphone;
        private Label lblmessagepass;
        private Label lblmessagename;
    }
}