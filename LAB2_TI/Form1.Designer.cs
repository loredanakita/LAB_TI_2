namespace LAB2_TI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.fileImportButton = new System.Windows.Forms.Button();
            this.fileExportButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.plainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.registerText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileImportButton
            // 
            this.fileImportButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.fileImportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fileImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileImportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.fileImportButton.ForeColor = System.Drawing.Color.Black;
            this.fileImportButton.Location = new System.Drawing.Point(14, 14);
            this.fileImportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileImportButton.Name = "fileImportButton";
            this.fileImportButton.Size = new System.Drawing.Size(261, 51);
            this.fileImportButton.TabIndex = 1;
            this.fileImportButton.Text = "Прочитать из файла";
            this.fileImportButton.UseVisualStyleBackColor = false;
            this.fileImportButton.Click += new System.EventHandler(this.fileImportButton_Click);
            // 
            // fileExportButton
            // 
            this.fileExportButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.fileExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fileExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileExportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.fileExportButton.ForeColor = System.Drawing.Color.Black;
            this.fileExportButton.Location = new System.Drawing.Point(283, 14);
            this.fileExportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileExportButton.Name = "fileExportButton";
            this.fileExportButton.Size = new System.Drawing.Size(234, 51);
            this.fileExportButton.TabIndex = 2;
            this.fileExportButton.Text = "Сохранить в файл";
            this.fileExportButton.UseVisualStyleBackColor = false;
            this.fileExportButton.Click += new System.EventHandler(this.fileExportButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.encodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.encodeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.encodeButton.ForeColor = System.Drawing.Color.Black;
            this.encodeButton.Location = new System.Drawing.Point(525, 14);
            this.encodeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(174, 51);
            this.encodeButton.TabIndex = 3;
            this.encodeButton.Text = "Выполнить";
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // plainText
            // 
            this.plainText.BackColor = System.Drawing.Color.White;
            this.plainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plainText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plainText.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plainText.ForeColor = System.Drawing.Color.Black;
            this.plainText.Location = new System.Drawing.Point(24, 236);
            this.plainText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.ReadOnly = true;
            this.plainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plainText.Size = new System.Drawing.Size(1099, 99);
            this.plainText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исходные данные (первые и последние 72 бита):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ключ (первые и последние 72 бита):";
            // 
            // keyText
            // 
            this.keyText.BackColor = System.Drawing.Color.White;
            this.keyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyText.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyText.ForeColor = System.Drawing.Color.Black;
            this.keyText.Location = new System.Drawing.Point(21, 407);
            this.keyText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyText.Multiline = true;
            this.keyText.Name = "keyText";
            this.keyText.ReadOnly = true;
            this.keyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyText.Size = new System.Drawing.Size(1102, 103);
            this.keyText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 549);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат (первые и последние 72 бита):";
            // 
            // cipherText
            // 
            this.cipherText.BackColor = System.Drawing.Color.White;
            this.cipherText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cipherText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cipherText.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipherText.ForeColor = System.Drawing.Color.Black;
            this.cipherText.Location = new System.Drawing.Point(15, 586);
            this.cipherText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cipherText.Multiline = true;
            this.cipherText.Name = "cipherText";
            this.cipherText.ReadOnly = true;
            this.cipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cipherText.Size = new System.Drawing.Size(1110, 106);
            this.cipherText.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(746, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите начальное состояние регистра (длина должна быть 39):";
            // 
            // registerText
            // 
            this.registerText.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerText.Location = new System.Drawing.Point(20, 117);
            this.registerText.MaxLength = 39;
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(1104, 33);
            this.registerText.TabIndex = 16;
            this.registerText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registerText_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1064, 32);
            this.label9.TabIndex = 27;
            this.label9.Text = "_________________________________________________________________________________" +
    "________________________";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(946, 14);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 51);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Очистить всё";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(707, 14);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(224, 51);
            this.btnShowAll.TabIndex = 31;
            this.btnShowAll.Text = "Вывести все биты";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1064, 32);
            this.label5.TabIndex = 32;
            this.label5.Text = "_________________________________________________________________________________" +
    "________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 515);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1064, 32);
            this.label6.TabIndex = 33;
            this.label6.Text = "_________________________________________________________________________________" +
    "________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1136, 724);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.fileExportButton);
            this.Controls.Add(this.fileImportButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.registerText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainText);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "LAB2_TI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fileImportButton;
        private System.Windows.Forms.Button fileExportButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox registerText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

