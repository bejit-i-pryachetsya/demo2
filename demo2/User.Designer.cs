namespace demo2
{
    partial class User
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.box_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_dop_info = new System.Windows.Forms.TextBox();
            this.lbl_dop_info = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.box_brand = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_info.Location = new System.Drawing.Point(12, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(387, 45);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Заполните данные заявки";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box_type
            // 
            this.box_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_type.FormattingEnabled = true;
            this.box_type.Items.AddRange(new object[] {
            "Корпус",
            "Экран (матрица)",
            "Компоненты телефона",
            "Аккумулятор",
            "",
            ""});
            this.box_type.Location = new System.Drawing.Point(59, 211);
            this.box_type.Name = "box_type";
            this.box_type.Size = new System.Drawing.Size(289, 23);
            this.box_type.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(62, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Подать заявку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_dop_info
            // 
            this.txt_dop_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dop_info.Location = new System.Drawing.Point(9, 310);
            this.txt_dop_info.Multiline = true;
            this.txt_dop_info.Name = "txt_dop_info";
            this.txt_dop_info.Size = new System.Drawing.Size(390, 94);
            this.txt_dop_info.TabIndex = 4;
            // 
            // lbl_dop_info
            // 
            this.lbl_dop_info.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dop_info.Location = new System.Drawing.Point(9, 264);
            this.lbl_dop_info.Name = "lbl_dop_info";
            this.lbl_dop_info.Size = new System.Drawing.Size(390, 43);
            this.lbl_dop_info.TabIndex = 5;
            this.lbl_dop_info.Text = "Дополнительная информация о поломке (не обязательно)";
            this.lbl_dop_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_type
            // 
            this.lbl_type.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_type.Location = new System.Drawing.Point(9, 187);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(390, 21);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.Text = "Выберите тип поломки";
            this.lbl_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_model.Location = new System.Drawing.Point(9, 137);
            this.txt_model.Name = "txt_model";
            this.txt_model.PlaceholderText = "Модель телефона";
            this.txt_model.Size = new System.Drawing.Size(390, 29);
            this.txt_model.TabIndex = 7;
            this.txt_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_brand
            // 
            this.lbl_brand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_brand.Location = new System.Drawing.Point(12, 62);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(387, 21);
            this.lbl_brand.TabIndex = 9;
            this.lbl_brand.Text = "Выберите марку телефона";
            this.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box_brand
            // 
            this.box_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_brand.FormattingEnabled = true;
            this.box_brand.Items.AddRange(new object[] {
            "Iphone",
            "Samsung",
            "Xiaomi",
            "Vivo",
            "Honor",
            "Sony",
            ""});
            this.box_brand.Location = new System.Drawing.Point(62, 86);
            this.box_brand.Name = "box_brand";
            this.box_brand.Size = new System.Drawing.Size(286, 23);
            this.box_brand.TabIndex = 8;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 476);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.box_brand);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_dop_info);
            this.Controls.Add(this.txt_dop_info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box_type);
            this.Controls.Add(this.lbl_info);
            this.Name = "User";
            this.Text = "Подача заявки на ремонт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_info;
        private ComboBox box_type;
        private Button button1;
        private TextBox txt_dop_info;
        private Label lbl_dop_info;
        private Label lbl_type;
        private TextBox txt_model;
        private Label lbl_brand;
        private ComboBox box_brand;
    }
}