namespace MapReceivers
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
            this.txt_display = new System.Windows.Forms.TextBox();
            this.btn_pull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_display
            // 
            this.txt_display.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display.Location = new System.Drawing.Point(23, 39);
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(232, 40);
            this.txt_display.TabIndex = 3;
            // 
            // btn_pull
            // 
            this.btn_pull.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pull.Location = new System.Drawing.Point(291, 27);
            this.btn_pull.Name = "btn_pull";
            this.btn_pull.Size = new System.Drawing.Size(259, 67);
            this.btn_pull.TabIndex = 2;
            this.btn_pull.Text = "Pull";
            this.btn_pull.UseVisualStyleBackColor = true;
            this.btn_pull.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 114);
            this.Controls.Add(this.txt_display);
            this.Controls.Add(this.btn_pull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mapped File  Receiver Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_display;
        private System.Windows.Forms.Button btn_pull;
    }
}

