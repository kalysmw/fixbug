namespace LAB03
{
    partial class Bai4_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai4_Form));
            this.bt_ServerBox = new System.Windows.Forms.Button();
            this.bt_ClientBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_ServerBox
            // 
            this.bt_ServerBox.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ServerBox.Location = new System.Drawing.Point(63, 63);
            this.bt_ServerBox.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ServerBox.Name = "bt_ServerBox";
            this.bt_ServerBox.Size = new System.Drawing.Size(200, 74);
            this.bt_ServerBox.TabIndex = 1;
            this.bt_ServerBox.Text = "Get server";
            this.bt_ServerBox.UseVisualStyleBackColor = true;
            this.bt_ServerBox.Click += new System.EventHandler(this.bt_ServerBox_Click);
            // 
            // bt_ClientBox
            // 
            this.bt_ClientBox.Font = new System.Drawing.Font("Century", 15F);
            this.bt_ClientBox.Location = new System.Drawing.Point(316, 63);
            this.bt_ClientBox.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ClientBox.Name = "bt_ClientBox";
            this.bt_ClientBox.Size = new System.Drawing.Size(200, 74);
            this.bt_ClientBox.TabIndex = 2;
            this.bt_ClientBox.Text = "Get client";
            this.bt_ClientBox.UseVisualStyleBackColor = true;
            this.bt_ClientBox.Click += new System.EventHandler(this.bt_ClientBox_Click_1);
            // 
            // Bai4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(597, 191);
            this.Controls.Add(this.bt_ClientBox);
            this.Controls.Add(this.bt_ServerBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bai4_Form";
            this.Text = "Bai4_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ServerBox;
        private System.Windows.Forms.Button bt_ClientBox;
    }
}