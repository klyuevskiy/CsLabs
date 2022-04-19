using Lab3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Main
{
    public partial class EditForm : Form
    {
        public BookCase Value { get; private set; }

        public EditForm(BookCase bookCase)
        {
            InitializeComponent();

            Value = bookCase;

            // копируем информацию на форму

            priceBox.Text = bookCase.Price.ToString();
            heightBox.Text = bookCase.Height.ToString();
            lengthBox.Text = bookCase.Length.ToString();
            widthBox.Text = bookCase.Width.ToString();
            hasDoorCheckBox.Checked = bookCase.HasDoor;
            shelvesNumberBox.Text = bookCase.ShelvesNumber.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                Value.Price = Double.Parse(priceBox.Text);
                Value.Height = Double.Parse(heightBox.Text);
                Value.Length = Double.Parse(lengthBox.Text);
                Value.Width = Double.Parse(widthBox.Text);
                Value.HasDoor = hasDoorCheckBox.Checked;
                Value.ShelvesNumber = Int32.Parse(shelvesNumberBox.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch(ArgumentException exception)
            {
                // ввёден непрравильный аргумент
                MessageBox.Show(exception.Message);
            }
            catch (FormatException)
            {
                // не смогло преобразовать
                MessageBox.Show("Введено не число.\n" +
                    "Проверьте, что во всех полях введены числа");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
