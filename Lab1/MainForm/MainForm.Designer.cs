
namespace MainForm
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
            this.circleCenterX = new System.Windows.Forms.Label();
            this.circleCenterY = new System.Windows.Forms.Label();
            this.circleRadius = new System.Windows.Forms.Label();
            this.createCircleButton = new System.Windows.Forms.Button();
            this.changeCircleCenterButton = new System.Windows.Forms.Button();
            this.changeCircleRadiusButton = new System.Windows.Forms.Button();
            this.PointInCircleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Центр круга:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Радиус круга:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y:";
            // 
            // circleCenterX
            // 
            this.circleCenterX.AutoSize = true;
            this.circleCenterX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circleCenterX.Location = new System.Drawing.Point(42, 50);
            this.circleCenterX.Name = "circleCenterX";
            this.circleCenterX.Size = new System.Drawing.Size(0, 20);
            this.circleCenterX.TabIndex = 4;
            // 
            // circleCenterY
            // 
            this.circleCenterY.AutoSize = true;
            this.circleCenterY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circleCenterY.Location = new System.Drawing.Point(42, 70);
            this.circleCenterY.Name = "circleCenterY";
            this.circleCenterY.Size = new System.Drawing.Size(0, 20);
            this.circleCenterY.TabIndex = 5;
            // 
            // circleRadius
            // 
            this.circleRadius.AutoSize = true;
            this.circleRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.circleRadius.Location = new System.Drawing.Point(12, 127);
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(0, 20);
            this.circleRadius.TabIndex = 6;
            // 
            // createCircleButton
            // 
            this.createCircleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createCircleButton.Location = new System.Drawing.Point(237, 21);
            this.createCircleButton.Name = "createCircleButton";
            this.createCircleButton.Size = new System.Drawing.Size(203, 35);
            this.createCircleButton.TabIndex = 7;
            this.createCircleButton.Text = "Создать новый круг";
            this.createCircleButton.UseVisualStyleBackColor = true;
            this.createCircleButton.Click += new System.EventHandler(this.createCircleButton_Click);
            // 
            // changeCircleCenterButton
            // 
            this.changeCircleCenterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeCircleCenterButton.Location = new System.Drawing.Point(237, 62);
            this.changeCircleCenterButton.Name = "changeCircleCenterButton";
            this.changeCircleCenterButton.Size = new System.Drawing.Size(203, 35);
            this.changeCircleCenterButton.TabIndex = 8;
            this.changeCircleCenterButton.Text = "Изменить центр круга";
            this.changeCircleCenterButton.UseVisualStyleBackColor = true;
            this.changeCircleCenterButton.Click += new System.EventHandler(this.changeCircleCenterButton_Click);
            // 
            // changeCircleRadiusButton
            // 
            this.changeCircleRadiusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.changeCircleRadiusButton.Location = new System.Drawing.Point(237, 103);
            this.changeCircleRadiusButton.Name = "changeCircleRadiusButton";
            this.changeCircleRadiusButton.Size = new System.Drawing.Size(203, 35);
            this.changeCircleRadiusButton.TabIndex = 9;
            this.changeCircleRadiusButton.Text = "Изменить радиус круга";
            this.changeCircleRadiusButton.UseVisualStyleBackColor = true;
            this.changeCircleRadiusButton.Click += new System.EventHandler(this.changeCircleRadiusButton_Click);
            // 
            // PointInCircleButton
            // 
            this.PointInCircleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PointInCircleButton.Location = new System.Drawing.Point(237, 142);
            this.PointInCircleButton.Name = "PointInCircleButton";
            this.PointInCircleButton.Size = new System.Drawing.Size(203, 70);
            this.PointInCircleButton.TabIndex = 10;
            this.PointInCircleButton.Text = "Определить принадлежность точки кругу";
            this.PointInCircleButton.UseVisualStyleBackColor = true;
            this.PointInCircleButton.Click += new System.EventHandler(this.PointInCircleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 224);
            this.Controls.Add(this.PointInCircleButton);
            this.Controls.Add(this.changeCircleRadiusButton);
            this.Controls.Add(this.changeCircleCenterButton);
            this.Controls.Add(this.createCircleButton);
            this.Controls.Add(this.circleRadius);
            this.Controls.Add(this.circleCenterY);
            this.Controls.Add(this.circleCenterX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Круги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label circleCenterX;
        private System.Windows.Forms.Label circleCenterY;
        private System.Windows.Forms.Label circleRadius;
        private System.Windows.Forms.Button createCircleButton;
        private System.Windows.Forms.Button changeCircleCenterButton;
        private System.Windows.Forms.Button changeCircleRadiusButton;
        private System.Windows.Forms.Button PointInCircleButton;
    }
}

