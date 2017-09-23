namespace WinForms6
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
            this.family_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.patronymic_Label = new System.Windows.Forms.Label();
            this.floor_Label = new System.Windows.Forms.Label();
            this.year_Label = new System.Windows.Forms.Label();
            this.status_Label = new System.Windows.Forms.Label();
            this.info_Label = new System.Windows.Forms.Label();
            this.family_TextBox = new System.Windows.Forms.TextBox();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.patronymic_TextBox = new System.Windows.Forms.TextBox();
            this.floor_TextBox = new System.Windows.Forms.TextBox();
            this.year_TextBox = new System.Windows.Forms.TextBox();
            this.status_TextBox = new System.Windows.Forms.TextBox();
            this.info_TextBox = new System.Windows.Forms.TextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.clear_Family = new System.Windows.Forms.Button();
            this.clear_Name = new System.Windows.Forms.Button();
            this.clear_patronymic = new System.Windows.Forms.Button();
            this.clear_Floor = new System.Windows.Forms.Button();
            this.clear_Year = new System.Windows.Forms.Button();
            this.clear_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // family_Label
            // 
            this.family_Label.AutoSize = true;
            this.family_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.family_Label.ForeColor = System.Drawing.Color.White;
            this.family_Label.Location = new System.Drawing.Point(12, 9);
            this.family_Label.Name = "family_Label";
            this.family_Label.Size = new System.Drawing.Size(114, 26);
            this.family_Label.TabIndex = 0;
            this.family_Label.Text = "Фамилия ";
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_Label.ForeColor = System.Drawing.Color.White;
            this.name_Label.Location = new System.Drawing.Point(12, 46);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(56, 26);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Имя";
            // 
            // patronymic_Label
            // 
            this.patronymic_Label.AutoSize = true;
            this.patronymic_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic_Label.ForeColor = System.Drawing.Color.White;
            this.patronymic_Label.Location = new System.Drawing.Point(12, 82);
            this.patronymic_Label.Name = "patronymic_Label";
            this.patronymic_Label.Size = new System.Drawing.Size(108, 26);
            this.patronymic_Label.TabIndex = 2;
            this.patronymic_Label.Text = "Отчество";
            // 
            // floor_Label
            // 
            this.floor_Label.AutoSize = true;
            this.floor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor_Label.ForeColor = System.Drawing.Color.White;
            this.floor_Label.Location = new System.Drawing.Point(12, 119);
            this.floor_Label.Name = "floor_Label";
            this.floor_Label.Size = new System.Drawing.Size(53, 26);
            this.floor_Label.TabIndex = 3;
            this.floor_Label.Text = "Пол";
            // 
            // year_Label
            // 
            this.year_Label.AutoSize = true;
            this.year_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_Label.ForeColor = System.Drawing.Color.White;
            this.year_Label.Location = new System.Drawing.Point(15, 157);
            this.year_Label.Name = "year_Label";
            this.year_Label.Size = new System.Drawing.Size(227, 26);
            this.year_Label.TabIndex = 4;
            this.year_Label.Text = "Год и дата рождения";
            // 
            // status_Label
            // 
            this.status_Label.AutoSize = true;
            this.status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_Label.ForeColor = System.Drawing.Color.White;
            this.status_Label.Location = new System.Drawing.Point(15, 195);
            this.status_Label.Name = "status_Label";
            this.status_Label.Size = new System.Drawing.Size(191, 26);
            this.status_Label.TabIndex = 5;
            this.status_Label.Text = "Семейный статус";
            // 
            // info_Label
            // 
            this.info_Label.AutoSize = true;
            this.info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_Label.ForeColor = System.Drawing.Color.White;
            this.info_Label.Location = new System.Drawing.Point(15, 232);
            this.info_Label.Name = "info_Label";
            this.info_Label.Size = new System.Drawing.Size(323, 26);
            this.info_Label.TabIndex = 6;
            this.info_Label.Text = "Дополнительная информация";
            // 
            // family_TextBox
            // 
            this.family_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.family_TextBox.Location = new System.Drawing.Point(277, 9);
            this.family_TextBox.MaxLength = 20;
            this.family_TextBox.Multiline = true;
            this.family_TextBox.Name = "family_TextBox";
            this.family_TextBox.Size = new System.Drawing.Size(237, 26);
            this.family_TextBox.TabIndex = 7;
            // 
            // name_TextBox
            // 
            this.name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_TextBox.Location = new System.Drawing.Point(277, 46);
            this.name_TextBox.MaxLength = 20;
            this.name_TextBox.Multiline = true;
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(237, 26);
            this.name_TextBox.TabIndex = 8;
            // 
            // patronymic_TextBox
            // 
            this.patronymic_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymic_TextBox.Location = new System.Drawing.Point(277, 82);
            this.patronymic_TextBox.MaxLength = 20;
            this.patronymic_TextBox.Multiline = true;
            this.patronymic_TextBox.Name = "patronymic_TextBox";
            this.patronymic_TextBox.Size = new System.Drawing.Size(237, 26);
            this.patronymic_TextBox.TabIndex = 9;
            // 
            // floor_TextBox
            // 
            this.floor_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floor_TextBox.Location = new System.Drawing.Point(277, 119);
            this.floor_TextBox.MaxLength = 20;
            this.floor_TextBox.Multiline = true;
            this.floor_TextBox.Name = "floor_TextBox";
            this.floor_TextBox.Size = new System.Drawing.Size(237, 26);
            this.floor_TextBox.TabIndex = 10;
            // 
            // year_TextBox
            // 
            this.year_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_TextBox.Location = new System.Drawing.Point(277, 157);
            this.year_TextBox.MaxLength = 20;
            this.year_TextBox.Multiline = true;
            this.year_TextBox.Name = "year_TextBox";
            this.year_TextBox.Size = new System.Drawing.Size(237, 26);
            this.year_TextBox.TabIndex = 11;
            // 
            // status_TextBox
            // 
            this.status_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_TextBox.Location = new System.Drawing.Point(277, 195);
            this.status_TextBox.MaxLength = 20;
            this.status_TextBox.Multiline = true;
            this.status_TextBox.Name = "status_TextBox";
            this.status_TextBox.Size = new System.Drawing.Size(237, 26);
            this.status_TextBox.TabIndex = 12;
            // 
            // info_TextBox
            // 
            this.info_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_TextBox.Location = new System.Drawing.Point(20, 270);
            this.info_TextBox.MaxLength = 50;
            this.info_TextBox.Multiline = true;
            this.info_TextBox.Name = "info_TextBox";
            this.info_TextBox.Size = new System.Drawing.Size(569, 122);
            this.info_TextBox.TabIndex = 13;
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.White;
            this.save_Button.Location = new System.Drawing.Point(580, 407);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(112, 31);
            this.save_Button.TabIndex = 14;
            this.save_Button.Text = "Сохранить";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // clear_Family
            // 
            this.clear_Family.BackColor = System.Drawing.Color.White;
            this.clear_Family.Location = new System.Drawing.Point(536, 9);
            this.clear_Family.Name = "clear_Family";
            this.clear_Family.Size = new System.Drawing.Size(75, 26);
            this.clear_Family.TabIndex = 15;
            this.clear_Family.Text = "Очистить";
            this.clear_Family.UseVisualStyleBackColor = false;
            this.clear_Family.Click += new System.EventHandler(this.clear_Family_Click);
            // 
            // clear_Name
            // 
            this.clear_Name.BackColor = System.Drawing.Color.White;
            this.clear_Name.Location = new System.Drawing.Point(536, 46);
            this.clear_Name.Name = "clear_Name";
            this.clear_Name.Size = new System.Drawing.Size(75, 28);
            this.clear_Name.TabIndex = 16;
            this.clear_Name.Text = "Очистить";
            this.clear_Name.UseVisualStyleBackColor = false;
            this.clear_Name.Click += new System.EventHandler(this.clear_Name_Click);
            // 
            // clear_patronymic
            // 
            this.clear_patronymic.BackColor = System.Drawing.Color.White;
            this.clear_patronymic.Location = new System.Drawing.Point(536, 82);
            this.clear_patronymic.Name = "clear_patronymic";
            this.clear_patronymic.Size = new System.Drawing.Size(75, 28);
            this.clear_patronymic.TabIndex = 17;
            this.clear_patronymic.Text = "Очистить";
            this.clear_patronymic.UseVisualStyleBackColor = false;
            this.clear_patronymic.Click += new System.EventHandler(this.clear_patronymic_Click);
            // 
            // clear_Floor
            // 
            this.clear_Floor.BackColor = System.Drawing.Color.White;
            this.clear_Floor.Location = new System.Drawing.Point(536, 119);
            this.clear_Floor.Name = "clear_Floor";
            this.clear_Floor.Size = new System.Drawing.Size(75, 28);
            this.clear_Floor.TabIndex = 18;
            this.clear_Floor.Text = "Очистить";
            this.clear_Floor.UseVisualStyleBackColor = false;
            this.clear_Floor.Click += new System.EventHandler(this.clear_Floor_Click);
            // 
            // clear_Year
            // 
            this.clear_Year.BackColor = System.Drawing.Color.White;
            this.clear_Year.Location = new System.Drawing.Point(536, 158);
            this.clear_Year.Name = "clear_Year";
            this.clear_Year.Size = new System.Drawing.Size(75, 28);
            this.clear_Year.TabIndex = 19;
            this.clear_Year.Text = "Очистить";
            this.clear_Year.UseVisualStyleBackColor = false;
            this.clear_Year.Click += new System.EventHandler(this.clear_Year_Click);
            // 
            // clear_status
            // 
            this.clear_status.BackColor = System.Drawing.Color.White;
            this.clear_status.Location = new System.Drawing.Point(536, 196);
            this.clear_status.Name = "clear_status";
            this.clear_status.Size = new System.Drawing.Size(75, 28);
            this.clear_status.TabIndex = 20;
            this.clear_status.Text = "Очистить";
            this.clear_status.UseVisualStyleBackColor = false;
            this.clear_status.Click += new System.EventHandler(this.clear_status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.clear_status);
            this.Controls.Add(this.clear_Year);
            this.Controls.Add(this.clear_Floor);
            this.Controls.Add(this.clear_patronymic);
            this.Controls.Add(this.clear_Name);
            this.Controls.Add(this.clear_Family);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.info_TextBox);
            this.Controls.Add(this.status_TextBox);
            this.Controls.Add(this.year_TextBox);
            this.Controls.Add(this.floor_TextBox);
            this.Controls.Add(this.patronymic_TextBox);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.family_TextBox);
            this.Controls.Add(this.info_Label);
            this.Controls.Add(this.status_Label);
            this.Controls.Add(this.year_Label);
            this.Controls.Add(this.floor_Label);
            this.Controls.Add(this.patronymic_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.family_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label family_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label patronymic_Label;
        private System.Windows.Forms.Label floor_Label;
        private System.Windows.Forms.Label year_Label;
        private System.Windows.Forms.Label status_Label;
        private System.Windows.Forms.Label info_Label;
        private System.Windows.Forms.TextBox family_TextBox;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.TextBox patronymic_TextBox;
        private System.Windows.Forms.TextBox floor_TextBox;
        private System.Windows.Forms.TextBox year_TextBox;
        private System.Windows.Forms.TextBox status_TextBox;
        private System.Windows.Forms.TextBox info_TextBox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button clear_Family;
        private System.Windows.Forms.Button clear_Name;
        private System.Windows.Forms.Button clear_patronymic;
        private System.Windows.Forms.Button clear_Floor;
        private System.Windows.Forms.Button clear_Year;
        private System.Windows.Forms.Button clear_status;
    }
}

