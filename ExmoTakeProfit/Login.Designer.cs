namespace ExmoTakeProfit
{
    partial class Login
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
            this.key = new System.Windows.Forms.TextBox();
            this.secret = new System.Windows.Forms.TextBox();
            this.API_key = new System.Windows.Forms.Label();
            this.API_secret = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.cancle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(12, 25);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(460, 20);
            this.key.TabIndex = 0;
            // 
            // secret
            // 
            this.secret.Location = new System.Drawing.Point(12, 91);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(460, 20);
            this.secret.TabIndex = 1;
            // 
            // API_key
            // 
            this.API_key.AutoSize = true;
            this.API_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.API_key.Location = new System.Drawing.Point(12, 9);
            this.API_key.Name = "API_key";
            this.API_key.Size = new System.Drawing.Size(51, 13);
            this.API_key.TabIndex = 2;
            this.API_key.Text = "API key";
            // 
            // API_secret
            // 
            this.API_secret.AutoSize = true;
            this.API_secret.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.API_secret.Location = new System.Drawing.Point(12, 75);
            this.API_secret.Name = "API_secret";
            this.API_secret.Size = new System.Drawing.Size(66, 13);
            this.API_secret.TabIndex = 3;
            this.API_secret.Text = "API secret";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(124, 137);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // cancle_button
            // 
            this.cancle_button.Location = new System.Drawing.Point(271, 137);
            this.cancle_button.Name = "cancle_button";
            this.cancle_button.Size = new System.Drawing.Size(75, 23);
            this.cancle_button.TabIndex = 5;
            this.cancle_button.Text = "Отмена";
            this.cancle_button.UseVisualStyleBackColor = true;
            this.cancle_button.Click += new System.EventHandler(this.cancle_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 181);
            this.ControlBox = false;
            this.Controls.Add(this.cancle_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.API_secret);
            this.Controls.Add(this.API_key);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.key);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox secret;
        private System.Windows.Forms.Label API_key;
        private System.Windows.Forms.Label API_secret;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button cancle_button;
    }
}