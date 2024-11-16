namespace MapSender
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
            this.btn_push = new System.Windows.Forms.Button();
            this.txt_display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_push
            // 
            this.btn_push.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_push.Location = new System.Drawing.Point(298, 25);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(259, 67);
            this.btn_push.TabIndex = 5;
            this.btn_push.Text = "Push";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_display
            // 
            this.txt_display.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display.Location = new System.Drawing.Point(19, 37);
            this.txt_display.Name = "txt_display";
            this.txt_display.Size = new System.Drawing.Size(232, 40);
            this.txt_display.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 116);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.txt_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mapped File Sender ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.TextBox txt_display;
    }
}

