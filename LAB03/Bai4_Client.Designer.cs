namespace LAB03
{
    partial class Bai4_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4_Client));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_Send = new System.Windows.Forms.Button();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(26, 47);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(488, 255);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // bt_Connect
            // 
            this.bt_Connect.Font = new System.Drawing.Font("Century", 16.2F);
            this.bt_Connect.Location = new System.Drawing.Point(569, 47);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(192, 58);
            this.bt_Connect.TabIndex = 5;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.Font = new System.Drawing.Font("Century", 16.2F);
            this.bt_Send.Location = new System.Drawing.Point(569, 145);
            this.bt_Send.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(192, 58);
            this.bt_Send.TabIndex = 6;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click_1);
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Font = new System.Drawing.Font("Century", 16.2F);
            this.bt_Disconnect.Location = new System.Drawing.Point(569, 243);
            this.bt_Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(192, 58);
            this.bt_Disconnect.TabIndex = 7;
            this.bt_Disconnect.Text = "Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            // 
            // Bai4_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.bt_Disconnect);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.bt_Connect);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai4_Client";
            this.Text = "Bai4_Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.Button bt_Disconnect;
    }
}