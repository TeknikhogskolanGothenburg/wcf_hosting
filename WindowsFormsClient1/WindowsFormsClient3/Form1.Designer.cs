namespace WindowsFormsClient3
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
            this.btnGetMessage = new System.Windows.Forms.Button();
            this.rdbTcp = new System.Windows.Forms.RadioButton();
            this.rdbHttp = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetMessage
            // 
            this.btnGetMessage.Location = new System.Drawing.Point(268, 59);
            this.btnGetMessage.Name = "btnGetMessage";
            this.btnGetMessage.Size = new System.Drawing.Size(241, 51);
            this.btnGetMessage.TabIndex = 0;
            this.btnGetMessage.Text = "Get Message";
            this.btnGetMessage.UseVisualStyleBackColor = true;
            this.btnGetMessage.Click += new System.EventHandler(this.btnGetMessage_Click);
            // 
            // rdbTcp
            // 
            this.rdbTcp.AutoSize = true;
            this.rdbTcp.Checked = true;
            this.rdbTcp.Location = new System.Drawing.Point(126, 172);
            this.rdbTcp.Name = "rdbTcp";
            this.rdbTcp.Size = new System.Drawing.Size(64, 24);
            this.rdbTcp.TabIndex = 1;
            this.rdbTcp.TabStop = true;
            this.rdbTcp.Text = "TCP";
            this.rdbTcp.UseVisualStyleBackColor = true;
            this.rdbTcp.CheckedChanged += new System.EventHandler(this.rdbTcp_CheckedChanged);
            // 
            // rdbHttp
            // 
            this.rdbHttp.AutoSize = true;
            this.rdbHttp.Location = new System.Drawing.Point(126, 221);
            this.rdbHttp.Name = "rdbHttp";
            this.rdbHttp.Size = new System.Drawing.Size(65, 24);
            this.rdbHttp.TabIndex = 2;
            this.rdbHttp.Text = "Http";
            this.rdbHttp.UseVisualStyleBackColor = true;
            this.rdbHttp.CheckedChanged += new System.EventHandler(this.rdbHttp_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rdbHttp);
            this.Controls.Add(this.rdbTcp);
            this.Controls.Add(this.btnGetMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMessage;
        private System.Windows.Forms.RadioButton rdbTcp;
        private System.Windows.Forms.RadioButton rdbHttp;
        private System.Windows.Forms.TextBox txtName;
    }
}

