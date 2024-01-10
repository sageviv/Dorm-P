namespace LoginDORM
{
    partial class loginSuccess
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
            this.log_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_out
            // 
            this.log_out.Location = new System.Drawing.Point(359, 203);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(75, 23);
            this.log_out.TabIndex = 0;
            this.log_out.Text = "LOG OUT";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // loginSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log_out);
            this.Name = "loginSuccess";
            this.Text = "loginSuccess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button log_out;
    }
}