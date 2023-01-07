namespace BookShop
{
    partial class Bookshop
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Editione = new System.Windows.Forms.ComboBox();
            this.Pyblisher = new System.Windows.Forms.ComboBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.orderInfo = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Box7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Box8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Box6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Box5 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 562);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.orderInfo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Editione);
            this.tabPage1.Controls.Add(this.Pyblisher);
            this.tabPage1.Controls.Add(this.OrderButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Магазин книг";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(141, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Виберіть видання";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Editione
            // 
            this.Editione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Editione.FormattingEnabled = true;
            this.Editione.Items.AddRange(new object[] {
            "Пусто"});
            this.Editione.Location = new System.Drawing.Point(145, 159);
            this.Editione.Margin = new System.Windows.Forms.Padding(2);
            this.Editione.Name = "Editione";
            this.Editione.Size = new System.Drawing.Size(170, 21);
            this.Editione.TabIndex = 69;
            this.Editione.SelectedIndexChanged += new System.EventHandler(this.Editione_SelectedIndexChanged);
            // 
            // Pyblisher
            // 
            this.Pyblisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pyblisher.FormattingEnabled = true;
            this.Pyblisher.Items.AddRange(new object[] {
            "Пусто"});
            this.Pyblisher.Location = new System.Drawing.Point(145, 85);
            this.Pyblisher.Margin = new System.Windows.Forms.Padding(2);
            this.Pyblisher.Name = "Pyblisher";
            this.Pyblisher.Size = new System.Drawing.Size(170, 21);
            this.Pyblisher.TabIndex = 68;
            this.Pyblisher.SelectedIndexChanged += new System.EventHandler(this.Pyblisher_SelectedIndexChanged);
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(145, 348);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(259, 38);
            this.OrderButton.TabIndex = 11;
            this.OrderButton.Text = "Замовити";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Виберіть назву видавництва";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BookShop.Properties.Resources.photo_2023_01_07_01_16_49;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(898, 536);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Box6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.Box5);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Box8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Box7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Box4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Box3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Box1);
            this.tabPage2.Controls.Add(this.Box2);
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Додавання книги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSave.Location = new System.Drawing.Point(124, 344);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(162, 78);
            this.buttonSave.TabIndex = 58;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // orderInfo
            // 
            this.orderInfo.BackColor = System.Drawing.Color.Bisque;
            this.orderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.orderInfo.Location = new System.Drawing.Point(471, 51);
            this.orderInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(282, 191);
            this.orderInfo.TabIndex = 71;
            this.orderInfo.Click += new System.EventHandler(this.orderInfo_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(475, 348);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 38);
            this.button3.TabIndex = 72;
            this.button3.Text = "Підтвердити замовлення";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(155, 23);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(131, 20);
            this.Box1.TabIndex = 70;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(155, 70);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(131, 20);
            this.Box2.TabIndex = 71;
            this.Box2.TextChanged += new System.EventHandler(this.SonameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(56, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Назва видання";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(36, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Назва видавницвтва";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(56, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Прізвище автора";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(155, 129);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(131, 20);
            this.Box3.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(56, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Ім\'я автора";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box4
            // 
            this.Box4.Location = new System.Drawing.Point(155, 167);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(131, 20);
            this.Box4.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(56, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Ціна";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Box7
            // 
            this.Box7.Location = new System.Drawing.Point(155, 267);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(131, 20);
            this.Box7.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(56, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Кількість сторінок";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box8
            // 
            this.Box8.Location = new System.Drawing.Point(155, 293);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(131, 20);
            this.Box8.TabIndex = 88;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(56, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Жанр";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box6
            // 
            this.Box6.Location = new System.Drawing.Point(155, 236);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(131, 20);
            this.Box6.TabIndex = 92;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(56, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 91;
            this.label10.Text = "Назва книги";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Box5
            // 
            this.Box5.Location = new System.Drawing.Point(155, 210);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(131, 20);
            this.Box5.TabIndex = 90;
            // 
            // Bookshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 563);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Bookshop";
            this.Text = "Shop";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Pyblisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Editione;
        private System.Windows.Forms.Label orderInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Box8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Box7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Box6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Box5;
    }
}

