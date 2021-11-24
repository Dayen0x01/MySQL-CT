namespace MySQL_CT
{
    partial class frm_Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.txt_Hostname = new MySQL_CT.TextBoxBottomLine();
            this.txt_Username = new MySQL_CT.TextBoxBottomLine();
            this.txt_Password = new MySQL_CT.TextBoxBottomLine();
            this.txt_Database = new MySQL_CT.TextBoxBottomLine();
            this.txt_Log = new System.Windows.Forms.RichTextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_Port = new MySQL_CT.TextBoxBottomLine();
            this.SuspendLayout();
            // 
            // txt_Hostname
            // 
            this.txt_Hostname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Hostname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Hostname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Hostname.Location = new System.Drawing.Point(12, 24);
            this.txt_Hostname.Name = "txt_Hostname";
            this.txt_Hostname.Size = new System.Drawing.Size(351, 20);
            this.txt_Hostname.TabIndex = 0;
            this.txt_Hostname.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_Hostname.WaterMarkText = "Hostname";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Username.Location = new System.Drawing.Point(12, 65);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(170, 20);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_Username.WaterMarkText = "Username";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Password.Location = new System.Drawing.Point(188, 65);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(180, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_Password.WaterMarkText = "Password";
            // 
            // txt_Database
            // 
            this.txt_Database.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Database.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Database.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Database.Location = new System.Drawing.Point(12, 103);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(170, 20);
            this.txt_Database.TabIndex = 3;
            this.txt_Database.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_Database.WaterMarkText = "Database";
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(12, 139);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.Size = new System.Drawing.Size(351, 246);
            this.txt_Log.TabIndex = 4;
            this.txt_Log.Text = "";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 391);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(351, 33);
            this.btn_Connect.TabIndex = 5;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Port.Location = new System.Drawing.Point(188, 103);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(180, 20);
            this.txt_Port.TabIndex = 6;
            this.txt_Port.WaterMarkColor = System.Drawing.Color.Gray;
            this.txt_Port.WaterMarkText = "Port (default 3306)";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 436);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.txt_Database);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Hostname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 475);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL CT";
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxBottomLine txt_Hostname;
        private TextBoxBottomLine txt_Username;
        private TextBoxBottomLine txt_Password;
        private TextBoxBottomLine txt_Database;
        private System.Windows.Forms.RichTextBox txt_Log;
        private System.Windows.Forms.Button btn_Connect;
        private TextBoxBottomLine txt_Port;
    }
}

