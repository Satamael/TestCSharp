namespace WindowsFormsApp1
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

        private void InitializeComponent()
        {
            this.batnotback = new System.Windows.Forms.Button();
            this.batback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // batnotback
            // 
            this.batnotback.Location = new System.Drawing.Point(470, 480);
            this.batnotback.Name = "batnotback";
            this.batnotback.Size = new System.Drawing.Size(100, 40);
            this.batnotback.TabIndex = 0;
            this.batnotback.Text = ">>";
            this.batnotback.UseVisualStyleBackColor = true;
            this.batnotback.Click += new System.EventHandler(this.batnotback_Click);
            // 
            // batback
            // 
            this.batback.Location = new System.Drawing.Point(12, 480);
            this.batback.Name = "batback";
            this.batback.Size = new System.Drawing.Size(100, 40);
            this.batback.TabIndex = 0;
            this.batback.Text = "<<";
            this.batback.UseVisualStyleBackColor = true;
            this.batback.Click += new System.EventHandler(this.batback_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(582, 555);
            this.Controls.Add(this.batnotback);
            this.Controls.Add(this.batback);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
 
        #endregion

        private System.Windows.Forms.Button batnotback;
        private System.Windows.Forms.Button batback;
    }
}