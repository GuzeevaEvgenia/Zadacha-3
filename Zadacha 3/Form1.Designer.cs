namespace Zadacha_3
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
            this.TramGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CapTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ActGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CapacityButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.FuelButton = new System.Windows.Forms.Button();
            this.RepairButton = new System.Windows.Forms.Button();
            this.Комменатрий = new System.Windows.Forms.GroupBox();
            this.ShowCommentButton = new System.Windows.Forms.Button();
            this.CommentnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.AddCommentButton = new System.Windows.Forms.Button();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.TramGroupBox.SuspendLayout();
            this.ActGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Комменатрий.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentnumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // TramGroupBox
            // 
            this.TramGroupBox.Controls.Add(this.AddButton);
            this.TramGroupBox.Controls.Add(this.CostTextBox);
            this.TramGroupBox.Controls.Add(this.label4);
            this.TramGroupBox.Controls.Add(this.label3);
            this.TramGroupBox.Controls.Add(this.label2);
            this.TramGroupBox.Controls.Add(this.label1);
            this.TramGroupBox.Controls.Add(this.CapTextBox);
            this.TramGroupBox.Controls.Add(this.YearTextBox);
            this.TramGroupBox.Controls.Add(this.NameTextBox);
            this.TramGroupBox.Location = new System.Drawing.Point(40, 41);
            this.TramGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TramGroupBox.Name = "TramGroupBox";
            this.TramGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TramGroupBox.Size = new System.Drawing.Size(176, 320);
            this.TramGroupBox.TabIndex = 2;
            this.TramGroupBox.TabStop = false;
            this.TramGroupBox.Text = "Трамвай";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(10, 262);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(159, 48);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(10, 228);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(155, 26);
            this.CostTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоимость проезда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вместимость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Год выпуска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // CapTextBox
            // 
            this.CapTextBox.Location = new System.Drawing.Point(11, 171);
            this.CapTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CapTextBox.Name = "CapTextBox";
            this.CapTextBox.Size = new System.Drawing.Size(155, 26);
            this.CapTextBox.TabIndex = 2;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(10, 115);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(155, 26);
            this.YearTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 59);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(155, 26);
            this.NameTextBox.TabIndex = 0;
            // 
            // ActGroupBox
            // 
            this.ActGroupBox.Controls.Add(this.numericUpDown1);
            this.ActGroupBox.Controls.Add(this.CapacityButton);
            this.ActGroupBox.Controls.Add(this.InfoButton);
            this.ActGroupBox.Controls.Add(this.FuelButton);
            this.ActGroupBox.Controls.Add(this.RepairButton);
            this.ActGroupBox.Location = new System.Drawing.Point(40, 380);
            this.ActGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActGroupBox.Name = "ActGroupBox";
            this.ActGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActGroupBox.Size = new System.Drawing.Size(174, 272);
            this.ActGroupBox.TabIndex = 9;
            this.ActGroupBox.TabStop = false;
            this.ActGroupBox.Text = "Действия";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 239);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(155, 26);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CapacityButton
            // 
            this.CapacityButton.Location = new System.Drawing.Point(9, 185);
            this.CapacityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CapacityButton.Name = "CapacityButton";
            this.CapacityButton.Size = new System.Drawing.Size(155, 45);
            this.CapacityButton.TabIndex = 3;
            this.CapacityButton.Text = "Вместимость";
            this.CapacityButton.UseVisualStyleBackColor = true;
            this.CapacityButton.Click += new System.EventHandler(this.CapacityButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(9, 132);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(155, 45);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.Text = "Информация";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // FuelButton
            // 
            this.FuelButton.Location = new System.Drawing.Point(9, 80);
            this.FuelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FuelButton.Name = "FuelButton";
            this.FuelButton.Size = new System.Drawing.Size(155, 45);
            this.FuelButton.TabIndex = 1;
            this.FuelButton.Text = "Заправить";
            this.FuelButton.UseVisualStyleBackColor = true;
            this.FuelButton.Click += new System.EventHandler(this.FuelButton_Click);
            // 
            // RepairButton
            // 
            this.RepairButton.Location = new System.Drawing.Point(9, 28);
            this.RepairButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepairButton.Name = "RepairButton";
            this.RepairButton.Size = new System.Drawing.Size(155, 45);
            this.RepairButton.TabIndex = 0;
            this.RepairButton.Text = "Починить";
            this.RepairButton.UseVisualStyleBackColor = true;
            this.RepairButton.Click += new System.EventHandler(this.RepairButton_Click);
            // 
            // Комменатрий
            // 
            this.Комменатрий.Controls.Add(this.ShowCommentButton);
            this.Комменатрий.Controls.Add(this.CommentnumericUpDown2);
            this.Комменатрий.Controls.Add(this.AddCommentButton);
            this.Комменатрий.Controls.Add(this.CommentTextBox);
            this.Комменатрий.Location = new System.Drawing.Point(265, 40);
            this.Комменатрий.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Комменатрий.Name = "Комменатрий";
            this.Комменатрий.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Комменатрий.Size = new System.Drawing.Size(176, 601);
            this.Комменатрий.TabIndex = 5;
            this.Комменатрий.TabStop = false;
            this.Комменатрий.Text = "Комментарий";
            // 
            // ShowCommentButton
            // 
            this.ShowCommentButton.Location = new System.Drawing.Point(8, 349);
            this.ShowCommentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowCommentButton.Name = "ShowCommentButton";
            this.ShowCommentButton.Size = new System.Drawing.Size(155, 52);
            this.ShowCommentButton.TabIndex = 6;
            this.ShowCommentButton.Text = "Показать комментарии";
            this.ShowCommentButton.UseVisualStyleBackColor = true;
            this.ShowCommentButton.Click += new System.EventHandler(this.ShowCommentButton_Click);
            // 
            // CommentnumericUpDown2
            // 
            this.CommentnumericUpDown2.Location = new System.Drawing.Point(8, 255);
            this.CommentnumericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommentnumericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CommentnumericUpDown2.Name = "CommentnumericUpDown2";
            this.CommentnumericUpDown2.Size = new System.Drawing.Size(155, 26);
            this.CommentnumericUpDown2.TabIndex = 5;
            this.CommentnumericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddCommentButton
            // 
            this.AddCommentButton.Location = new System.Drawing.Point(7, 290);
            this.AddCommentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCommentButton.Name = "AddCommentButton";
            this.AddCommentButton.Size = new System.Drawing.Size(156, 50);
            this.AddCommentButton.TabIndex = 1;
            this.AddCommentButton.Text = "Добавить";
            this.AddCommentButton.UseVisualStyleBackColor = true;
            this.AddCommentButton.Click += new System.EventHandler(this.AddCommentButton_Click);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(8, 26);
            this.CommentTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(155, 220);
            this.CommentTextBox.TabIndex = 0;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(482, 41);
            this.InfoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(328, 600);
            this.InfoTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 693);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.Комменатрий);
            this.Controls.Add(this.ActGroupBox);
            this.Controls.Add(this.TramGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TramGroupBox.ResumeLayout(false);
            this.TramGroupBox.PerformLayout();
            this.ActGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Комменатрий.ResumeLayout(false);
            this.Комменатрий.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommentnumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TramGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CapTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.GroupBox ActGroupBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button CapacityButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button FuelButton;
        private System.Windows.Forms.Button RepairButton;
        private System.Windows.Forms.GroupBox Комменатрий;
        private System.Windows.Forms.Button ShowCommentButton;
        private System.Windows.Forms.NumericUpDown CommentnumericUpDown2;
        private System.Windows.Forms.Button AddCommentButton;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox InfoTextBox;
    }
}

