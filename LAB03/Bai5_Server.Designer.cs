
namespace LAB03
{
    partial class Bai5_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5_Server));
            this.bt_Listen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_Listen
            // 
            this.bt_Listen.Font = new System.Drawing.Font("Century", 16.2F);
            this.bt_Listen.Location = new System.Drawing.Point(435, 49);
            this.bt_Listen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Listen.Name = "bt_Listen";
            this.bt_Listen.Size = new System.Drawing.Size(169, 54);
            this.bt_Listen.TabIndex = 1;
            this.bt_Listen.Text = "Listen";
            this.bt_Listen.UseVisualStyleBackColor = true;
            this.bt_Listen.Click += new System.EventHandler(this.bt_Listen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(47, 145);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(556, 285);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Bai5_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 480);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bt_Listen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai5_Server";
            this.Text = "Bai5_Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai5_Server_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Listen;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}