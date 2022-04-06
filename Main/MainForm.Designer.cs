
namespace Main
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.baseSportsmanLastName = new System.Windows.Forms.TextBox();
            this.baseSportsmanCompetitionsNumber = new System.Windows.Forms.TextBox();
            this.baseSportsmanCompetitionsPlacesSum = new System.Windows.Forms.TextBox();
            this.baseSportsmanQuality = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.derivedSportsmanCompetitionsNumber = new System.Windows.Forms.TextBox();
            this.derivedSportsmanCompetitionsPlacesSum = new System.Windows.Forms.TextBox();
            this.derivedSportsmanQuality = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.derivedSportsmanRankedFirst = new System.Windows.Forms.TextBox();
            this.derivedSportsmanLastName = new System.Windows.Forms.TextBox();
            this.inputBaseSportsmanButton = new System.Windows.Forms.Button();
            this.printBaseSportsmanButton = new System.Windows.Forms.Button();
            this.printDerivedSportsmanButton = new System.Windows.Forms.Button();
            this.inputDerivedSportsmanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Класс 1 уровня: спортсмен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число соревнований:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма мест, занятых в соревновании:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Качество:";
            // 
            // baseSportsmanLastName
            // 
            this.baseSportsmanLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baseSportsmanLastName.Location = new System.Drawing.Point(16, 64);
            this.baseSportsmanLastName.Name = "baseSportsmanLastName";
            this.baseSportsmanLastName.ReadOnly = true;
            this.baseSportsmanLastName.Size = new System.Drawing.Size(246, 26);
            this.baseSportsmanLastName.TabIndex = 5;
            // 
            // baseSportsmanCompetitionsNumber
            // 
            this.baseSportsmanCompetitionsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baseSportsmanCompetitionsNumber.Location = new System.Drawing.Point(16, 116);
            this.baseSportsmanCompetitionsNumber.Name = "baseSportsmanCompetitionsNumber";
            this.baseSportsmanCompetitionsNumber.ReadOnly = true;
            this.baseSportsmanCompetitionsNumber.Size = new System.Drawing.Size(100, 26);
            this.baseSportsmanCompetitionsNumber.TabIndex = 6;
            // 
            // baseSportsmanCompetitionsPlacesSum
            // 
            this.baseSportsmanCompetitionsPlacesSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baseSportsmanCompetitionsPlacesSum.Location = new System.Drawing.Point(16, 173);
            this.baseSportsmanCompetitionsPlacesSum.Name = "baseSportsmanCompetitionsPlacesSum";
            this.baseSportsmanCompetitionsPlacesSum.ReadOnly = true;
            this.baseSportsmanCompetitionsPlacesSum.Size = new System.Drawing.Size(100, 26);
            this.baseSportsmanCompetitionsPlacesSum.TabIndex = 7;
            // 
            // baseSportsmanQuality
            // 
            this.baseSportsmanQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baseSportsmanQuality.Location = new System.Drawing.Point(16, 225);
            this.baseSportsmanQuality.Name = "baseSportsmanQuality";
            this.baseSportsmanQuality.ReadOnly = true;
            this.baseSportsmanQuality.Size = new System.Drawing.Size(100, 26);
            this.baseSportsmanQuality.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(392, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Класс 2 уровня: спортсмен";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(392, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Фамилия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(392, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Число соревнований:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(392, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сумма мест, занятых в соревновании:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(392, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Качество:";
            // 
            // derivedSportsmanCompetitionsNumber
            // 
            this.derivedSportsmanCompetitionsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.derivedSportsmanCompetitionsNumber.Location = new System.Drawing.Point(396, 116);
            this.derivedSportsmanCompetitionsNumber.Name = "derivedSportsmanCompetitionsNumber";
            this.derivedSportsmanCompetitionsNumber.ReadOnly = true;
            this.derivedSportsmanCompetitionsNumber.Size = new System.Drawing.Size(100, 26);
            this.derivedSportsmanCompetitionsNumber.TabIndex = 15;
            // 
            // derivedSportsmanCompetitionsPlacesSum
            // 
            this.derivedSportsmanCompetitionsPlacesSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.derivedSportsmanCompetitionsPlacesSum.Location = new System.Drawing.Point(396, 173);
            this.derivedSportsmanCompetitionsPlacesSum.Name = "derivedSportsmanCompetitionsPlacesSum";
            this.derivedSportsmanCompetitionsPlacesSum.ReadOnly = true;
            this.derivedSportsmanCompetitionsPlacesSum.Size = new System.Drawing.Size(100, 26);
            this.derivedSportsmanCompetitionsPlacesSum.TabIndex = 16;
            // 
            // derivedSportsmanQuality
            // 
            this.derivedSportsmanQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.derivedSportsmanQuality.Location = new System.Drawing.Point(396, 277);
            this.derivedSportsmanQuality.Name = "derivedSportsmanQuality";
            this.derivedSportsmanQuality.ReadOnly = true;
            this.derivedSportsmanQuality.Size = new System.Drawing.Size(100, 26);
            this.derivedSportsmanQuality.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(392, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(280, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Занимал ли хоть раз первое место:";
            // 
            // derivedSportsmanRankedFirst
            // 
            this.derivedSportsmanRankedFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.derivedSportsmanRankedFirst.Location = new System.Drawing.Point(396, 225);
            this.derivedSportsmanRankedFirst.Name = "derivedSportsmanRankedFirst";
            this.derivedSportsmanRankedFirst.ReadOnly = true;
            this.derivedSportsmanRankedFirst.Size = new System.Drawing.Size(100, 26);
            this.derivedSportsmanRankedFirst.TabIndex = 19;
            // 
            // derivedSportsmanLastName
            // 
            this.derivedSportsmanLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.derivedSportsmanLastName.Location = new System.Drawing.Point(396, 64);
            this.derivedSportsmanLastName.Name = "derivedSportsmanLastName";
            this.derivedSportsmanLastName.ReadOnly = true;
            this.derivedSportsmanLastName.Size = new System.Drawing.Size(246, 26);
            this.derivedSportsmanLastName.TabIndex = 20;
            // 
            // inputBaseSportsmanButton
            // 
            this.inputBaseSportsmanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputBaseSportsmanButton.Location = new System.Drawing.Point(16, 321);
            this.inputBaseSportsmanButton.Name = "inputBaseSportsmanButton";
            this.inputBaseSportsmanButton.Size = new System.Drawing.Size(202, 50);
            this.inputBaseSportsmanButton.TabIndex = 21;
            this.inputBaseSportsmanButton.Text = "Ввести класс первого уровня";
            this.inputBaseSportsmanButton.UseVisualStyleBackColor = true;
            this.inputBaseSportsmanButton.Click += new System.EventHandler(this.inputBaseSportsmanButton_Click);
            // 
            // printBaseSportsmanButton
            // 
            this.printBaseSportsmanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.printBaseSportsmanButton.Location = new System.Drawing.Point(16, 377);
            this.printBaseSportsmanButton.Name = "printBaseSportsmanButton";
            this.printBaseSportsmanButton.Size = new System.Drawing.Size(202, 50);
            this.printBaseSportsmanButton.TabIndex = 22;
            this.printBaseSportsmanButton.Text = "Вывести класс первого уровня";
            this.printBaseSportsmanButton.UseVisualStyleBackColor = true;
            this.printBaseSportsmanButton.Click += new System.EventHandler(this.printBaseSportsmanButton_Click);
            // 
            // printDerivedSportsmanButton
            // 
            this.printDerivedSportsmanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.printDerivedSportsmanButton.Location = new System.Drawing.Point(396, 377);
            this.printDerivedSportsmanButton.Name = "printDerivedSportsmanButton";
            this.printDerivedSportsmanButton.Size = new System.Drawing.Size(202, 50);
            this.printDerivedSportsmanButton.TabIndex = 24;
            this.printDerivedSportsmanButton.Text = "Вывести класс второго уровня";
            this.printDerivedSportsmanButton.UseVisualStyleBackColor = true;
            this.printDerivedSportsmanButton.Click += new System.EventHandler(this.printDerivedSportsmanButton_Click);
            // 
            // inputDerivedSportsmanButton
            // 
            this.inputDerivedSportsmanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inputDerivedSportsmanButton.Location = new System.Drawing.Point(396, 321);
            this.inputDerivedSportsmanButton.Name = "inputDerivedSportsmanButton";
            this.inputDerivedSportsmanButton.Size = new System.Drawing.Size(202, 50);
            this.inputDerivedSportsmanButton.TabIndex = 23;
            this.inputDerivedSportsmanButton.Text = "Ввести класс второго уровня";
            this.inputDerivedSportsmanButton.UseVisualStyleBackColor = true;
            this.inputDerivedSportsmanButton.Click += new System.EventHandler(this.inputDerivedSportsmanButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 441);
            this.Controls.Add(this.printDerivedSportsmanButton);
            this.Controls.Add(this.inputDerivedSportsmanButton);
            this.Controls.Add(this.printBaseSportsmanButton);
            this.Controls.Add(this.inputBaseSportsmanButton);
            this.Controls.Add(this.derivedSportsmanLastName);
            this.Controls.Add(this.derivedSportsmanRankedFirst);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.derivedSportsmanQuality);
            this.Controls.Add(this.derivedSportsmanCompetitionsPlacesSum);
            this.Controls.Add(this.derivedSportsmanCompetitionsNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.baseSportsmanQuality);
            this.Controls.Add(this.baseSportsmanCompetitionsPlacesSum);
            this.Controls.Add(this.baseSportsmanCompetitionsNumber);
            this.Controls.Add(this.baseSportsmanLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Лабараторная 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox baseSportsmanLastName;
        private System.Windows.Forms.TextBox baseSportsmanCompetitionsNumber;
        private System.Windows.Forms.TextBox baseSportsmanCompetitionsPlacesSum;
        private System.Windows.Forms.TextBox baseSportsmanQuality;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox derivedSportsmanCompetitionsNumber;
        private System.Windows.Forms.TextBox derivedSportsmanCompetitionsPlacesSum;
        private System.Windows.Forms.TextBox derivedSportsmanQuality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox derivedSportsmanRankedFirst;
        private System.Windows.Forms.TextBox derivedSportsmanLastName;
        private System.Windows.Forms.Button inputBaseSportsmanButton;
        private System.Windows.Forms.Button printBaseSportsmanButton;
        private System.Windows.Forms.Button printDerivedSportsmanButton;
        private System.Windows.Forms.Button inputDerivedSportsmanButton;
    }
}

