namespace LifeInsuranceApp
{
    partial class Home
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
            this.Lbl_Header = new System.Windows.Forms.Label();
            this.Btn_Client = new System.Windows.Forms.Button();
            this.Btn_Policy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Header
            // 
            this.Lbl_Header.AutoSize = true;
            this.Lbl_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Header.Location = new System.Drawing.Point(203, 19);
            this.Lbl_Header.Name = "Lbl_Header";
            this.Lbl_Header.Size = new System.Drawing.Size(391, 31);
            this.Lbl_Header.TabIndex = 2;
            this.Lbl_Header.Text = "WELCOME TO INSURE APP";
            // 
            // Btn_Client
            // 
            this.Btn_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Client.Location = new System.Drawing.Point(116, 101);
            this.Btn_Client.Name = "Btn_Client";
            this.Btn_Client.Size = new System.Drawing.Size(212, 92);
            this.Btn_Client.TabIndex = 0;
            this.Btn_Client.Text = "Client Administration";
            this.Btn_Client.UseVisualStyleBackColor = true;
            this.Btn_Client.Click += new System.EventHandler(this.Btn_Client_Click);
            // 
            // Btn_Policy
            // 
            this.Btn_Policy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Policy.Location = new System.Drawing.Point(485, 101);
            this.Btn_Policy.Name = "Btn_Policy";
            this.Btn_Policy.Size = new System.Drawing.Size(212, 92);
            this.Btn_Policy.TabIndex = 1;
            this.Btn_Policy.Text = "Policy Administration";
            this.Btn_Policy.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 435);
            this.Controls.Add(this.Btn_Policy);
            this.Controls.Add(this.Btn_Client);
            this.Controls.Add(this.Lbl_Header);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Header;
        private System.Windows.Forms.Button Btn_Client;
        private System.Windows.Forms.Button Btn_Policy;
    }
}