namespace demo2
{
    partial class Registr
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
            this.lbl_registracia = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_registr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_registracia
            // 
            this.lbl_registracia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_registracia.Location = new System.Drawing.Point(12, 9);
            this.lbl_registracia.Name = "lbl_registracia";
            this.lbl_registracia.Size = new System.Drawing.Size(258, 42);
            this.lbl_registracia.TabIndex = 0;
            this.lbl_registracia.Text = "Регистрация";
            this.lbl_registracia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(12, 39);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(258, 42);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "Введите данные";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.Location = new System.Drawing.Point(12, 84);
            this.txt_name.Name = "txt_name";
            this.txt_name.PlaceholderText = "Имя";
            this.txt_name.Size = new System.Drawing.Size(258, 24);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tel.Location = new System.Drawing.Point(12, 123);
            this.txt_tel.MaxLength = 11;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PlaceholderText = "Номер телефона";
            this.txt_tel.Size = new System.Drawing.Size(258, 24);
            this.txt_tel.TabIndex = 3;
            this.txt_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pass.Location = new System.Drawing.Point(12, 162);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PlaceholderText = "Пароль";
            this.txt_pass.Size = new System.Drawing.Size(258, 24);
            this.txt_pass.TabIndex = 4;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_registr
            // 
            this.btn_registr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_registr.Location = new System.Drawing.Point(47, 192);
            this.btn_registr.Name = "btn_registr";
            this.btn_registr.Size = new System.Drawing.Size(189, 36);
            this.btn_registr.TabIndex = 5;
            this.btn_registr.Text = "Подтвердить";
            this.btn_registr.UseVisualStyleBackColor = true;
            this.btn_registr.Click += new System.EventHandler(this.btn_registr_Click);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 240);
            this.Controls.Add(this.btn_registr);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_registracia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registr_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registr_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_registracia;
        private Label lbl_info;
        private TextBox txt_name;
        private TextBox txt_tel;
        private TextBox txt_pass;
        private Button btn_registr;
    }
}