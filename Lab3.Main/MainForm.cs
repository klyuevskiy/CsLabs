using InputString;
using Lab3.Models;
using Lab3.Repository;
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
    public partial class MainForm : Form
    {
        IRepository _repository;

        public MainForm()
        {
            InitializeComponent();

            _repository = new ListRepository();
        }
       

        // вывод записей в data grid view
        void ShowRepository()
        {
            IEnumerable<IFurniture> allFurniture = _repository.GetAll();

            dataGridView1.Rows.Clear();

            foreach (var item in allFurniture)
            {
                int rowIndex = dataGridView1.Rows.Add();

                DataGridViewRow currentRow = dataGridView1.Rows[rowIndex];

                currentRow.Cells[0].Value = item.Id;
                currentRow.Cells[1].Value = item.Price;
                
                // достали книжный шкаф, запишем инфу
                if (item is BookCase)
                {
                    var itembookCase = item as BookCase;

                    currentRow.Cells[2].Value = itembookCase.Height;
                    currentRow.Cells[3].Value = itembookCase.Length;
                    currentRow.Cells[4].Value = itembookCase.Width;
                    currentRow.Cells[5].Value = itembookCase.Volume();
                    currentRow.Cells[6].Value = itembookCase.HasDoor ? "Есть" : "Нет";
                    currentRow.Cells[7].Value = itembookCase.ShelvesNumber;
                    currentRow.Cells[8].Value = itembookCase.HowManyBooksFitOnShelf();
                    currentRow.Cells[9].Value = itembookCase.HowManyBooksFit();
                    currentRow.Cells[10].Value = itembookCase.ArrangeDelivery();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // запрашиваем ввод Id
            InputStringDialog inputId = new InputStringDialog(new NotNegativeIntValidator(), "Введите id шкафа");

            if (inputId.ShowDialog() == DialogResult.OK)
            {
                // id введено, удаление
                try
                {
                    _repository.Delete(Int32.Parse(inputId.Value));
                    ShowRepository();
                }
                catch (ArgumentException exception)
                {
                    // id не найдено
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // добавить = редактировать пустого
            EditForm addBookCase = new EditForm(new BookCase());

            if (addBookCase.ShowDialog() == DialogResult.OK)
            {
                _repository.Add(addBookCase.Value);
                ShowRepository();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputId = new InputStringDialog(new NotNegativeIntValidator(), "Введите id шкафа");
            
            if (inputId.ShowDialog() == DialogResult.OK)
            {
                // ввели id
                try
                {
                    IFurniture editItem = _repository.Get(Int32.Parse(inputId.Value));
                    EditForm editBookCase = new EditForm(editItem as BookCase);

                    if (editBookCase.ShowDialog() == DialogResult.OK)
                        _repository.Update(editBookCase.Value);

                    ShowRepository();
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
