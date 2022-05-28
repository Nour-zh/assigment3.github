namespace assigment3.github
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.lbluserna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(96, 157);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(94, 29);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "log in";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(177, 96);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(125, 27);
            this.txtphone.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(177, 46);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(125, 27);
            this.txtusername.TabIndex = 7;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(23, 99);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(129, 20);
            this.lblphone.TabIndex = 6;
            this.lblphone.Text = "PHONE NUMBER :";
            // 
            // lbluserna
            // 
            this.lbluserna.AutoSize = true;
            this.lbluserna.Location = new System.Drawing.Point(48, 49);
            this.lbluserna.Name = "lbluserna";
            this.lbluserna.Size = new System.Drawing.Size(97, 20);
            this.lbluserna.TabIndex = 5;
            this.lbluserna.Text = "USER NAME :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 240);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lbluserna);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnlogin;
        private TextBox txtphone;
        private TextBox txtusername;
        private Label lblphone;
        private Label lbluserna;
    }
}