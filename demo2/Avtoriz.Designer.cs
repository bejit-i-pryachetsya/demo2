namespace demo2
{
    partial class Avtoriz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_voity = new System.Windows.Forms.Button();
            this.lbl_registr = new System.Windows.Forms.Label();
            this.txt_pas = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.lbl_avtoriz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voity
            // 
            this.btn_voity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_voity.Location = new System.Drawing.Point(43, 151);
            this.btn_voity.Name = "btn_voity";
            this.btn_voity.Size = new System.Drawing.Size(196, 43);
            this.btn_voity.TabIndex = 0;
            this.btn_voity.Text = "Войти";
            this.btn_voity.UseVisualStyleBackColor = true;
            this.btn_voity.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_registr
            // 
            this.lbl_registr.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_registr.Location = new System.Drawing.Point(43, 197);
            this.lbl_registr.Name = "lbl_registr";
            this.lbl_registr.Size = new System.Drawing.Size(196, 23);
            this.lbl_registr.TabIndex = 1;
            this.lbl_registr.Text = "Регистрация";
            this.lbl_registr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_registr.UseCompatibleTextRendering = true;
            this.lbl_registr.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pas
            // 
            this.txt_pas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pas.Location = new System.Drawing.Point(12, 116);
            this.txt_pas.MaxLength = 464446;
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.PasswordChar = '*';
            this.txt_pas.PlaceholderText = "Пароль";
            this.txt_pas.Size = new System.Drawing.Size(258, 29);
            this.txt_pas.TabIndex = 2;
            this.txt_pas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_log
            // 
            this.txt_log.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_log.Location = new System.Drawing.Point(12, 81);
            this.txt_log.MaxLength = 11;
            this.txt_log.Name = "txt_log";
            this.txt_log.PlaceholderText = "Номер телефона";
            this.txt_log.Size = new System.Drawing.Size(258, 29);
            this.txt_log.TabIndex = 3;
            this.txt_log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_avtoriz
            // 
            this.lbl_avtoriz.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avtoriz.Location = new System.Drawing.Point(12, 27);
            this.lbl_avtoriz.Name = "lbl_avtoriz";
            this.lbl_avtoriz.Size = new System.Drawing.Size(258, 35);
            this.lbl_avtoriz.TabIndex = 4;
            this.lbl_avtoriz.Text = "Авторизация";
            this.lbl_avtoriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 240);
            this.Controls.Add(this.lbl_avtoriz);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.lbl_registr);
            this.Controls.Add(this.btn_voity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Avtoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Avtoriz_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_voity;
        private Label lbl_registr;
        private TextBox txt_pas;
        private TextBox txt_log;
        private Label lbl_avtoriz;
    }
}