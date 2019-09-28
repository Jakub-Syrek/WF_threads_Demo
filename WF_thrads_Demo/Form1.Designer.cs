namespace WF_thrads_Demo
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
            this.tb_Console = new System.Windows.Forms.TextBox();
            this.Bt_ThreadStart = new System.Windows.Forms.Button();
            this.Bt_ThreadStartPooled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Console
            // 
            this.tb_Console.Location = new System.Drawing.Point(36, 29);
            this.tb_Console.Multiline = true;
            this.tb_Console.Name = "tb_Console";
            this.tb_Console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Console.Size = new System.Drawing.Size(1368, 709);
            this.tb_Console.TabIndex = 0;
            // 
            // Bt_ThreadStart
            // 
            this.Bt_ThreadStart.Location = new System.Drawing.Point(609, 744);
            this.Bt_ThreadStart.Name = "Bt_ThreadStart";
            this.Bt_ThreadStart.Size = new System.Drawing.Size(115, 23);
            this.Bt_ThreadStart.TabIndex = 1;
            this.Bt_ThreadStart.Text = "returnDate";
            this.Bt_ThreadStart.UseVisualStyleBackColor = true;
            this.Bt_ThreadStart.Click += new System.EventHandler(this.Bt_ThreadStart_Click);
            // 
            // Bt_ThreadStartPooled
            // 
            this.Bt_ThreadStartPooled.Location = new System.Drawing.Point(730, 744);
            this.Bt_ThreadStartPooled.Name = "Bt_ThreadStartPooled";
            this.Bt_ThreadStartPooled.Size = new System.Drawing.Size(167, 23);
            this.Bt_ThreadStartPooled.TabIndex = 2;
            this.Bt_ThreadStartPooled.Text = "Launch5FibonaccisThreads";
            this.Bt_ThreadStartPooled.UseVisualStyleBackColor = true;
            this.Bt_ThreadStartPooled.Click += new System.EventHandler(this.Bt_ThreadStartPooled_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 768);
            this.Controls.Add(this.Bt_ThreadStartPooled);
            this.Controls.Add(this.Bt_ThreadStart);
            this.Controls.Add(this.tb_Console);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Console;
        private System.Windows.Forms.Button Bt_ThreadStart;
        private System.Windows.Forms.Button Bt_ThreadStartPooled;
    }
}

