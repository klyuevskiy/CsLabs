
namespace Lab3.Main
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.hasDoorCheckBox = new System.Windows.Forms.CheckBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.shelvesNumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цена:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Длина:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(11, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ширина:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(8, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество полок:";
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.okButton.Location = new System.Drawing.Point(12, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(135, 47);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cancelButton.Location = new System.Drawing.Point(179, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(135, 47);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // hasDoorCheckBox
            // 
            this.hasDoorCheckBox.AutoSize = true;
            this.hasDoorCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hasDoorCheckBox.Location = new System.Drawing.Point(12, 177);
            this.hasDoorCheckBox.Name = "hasDoorCheckBox";
            this.hasDoorCheckBox.Size = new System.Drawing.Size(157, 24);
            this.hasDoorCheckBox.TabIndex = 14;
            this.hasDoorCheckBox.Text = "Наличие дверцы";
            this.hasDoorCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceBox
            // 
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceBox.Location = new System.Drawing.Point(87, 17);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(191, 26);
            this.priceBox.TabIndex = 15;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.heightBox.Location = new System.Drawing.Point(87, 49);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(191, 26);
            this.heightBox.TabIndex = 16;
            // 
            // lengthBox
            // 
            this.lengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lengthBox.Location = new System.Drawing.Point(87, 81);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(191, 26);
            this.lengthBox.TabIndex = 17;
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.widthBox.Location = new System.Drawing.Point(87, 113);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(191, 26);
            this.widthBox.TabIndex = 18;
            // 
            // shelvesNumberBox
            // 
            this.shelvesNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.shelvesNumberBox.Location = new System.Drawing.Point(167, 145);
            this.shelvesNumberBox.Name = "shelvesNumberBox";
            this.shelvesNumberBox.Size = new System.Drawing.Size(111, 26);
            this.shelvesNumberBox.TabIndex = 19;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 285);
            this.Controls.Add(this.shelvesNumberBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.hasDoorCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox hasDoorCheckBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox shelvesNumberBox;
    }
}