namespace class_ev_1
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
            this.btnEv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEv
            // 
            this.btnEv.Location = new System.Drawing.Point(126, 122);
            this.btnEv.Name = "btnEv";
            this.btnEv.Size = new System.Drawing.Size(126, 50);
            this.btnEv.TabIndex = 0;
            this.btnEv.Text = "button1";
            this.btnEv.UseVisualStyleBackColor = true;
            this.btnEv.Click += new System.EventHandler(this.btnEv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEv;
    }
}

