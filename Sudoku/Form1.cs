using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Создаем образец класса
        Sudoku sudoku = new Sudoku();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Генерируем новую карту при нажатии на кнопку
            Generate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Генерируем новую карту при запуске формы
            Generate();
        }

        //Метод генерации новой карты
        private void Generate()
        {
            sudoku.GenerateMap(Convert.ToInt16(tbNumber.Text));
            sudoku.ReloadMap(dgvSudoku);
            dgvSudoku.AutoResizeRows();
            dgvSudoku.AutoResizeColumns();
        }

        //Добавления нового значения на карту
        private void button1_Click(object sender, EventArgs e)
        {
            int Row, Column, Value;
            try
            {
                Row = Convert.ToInt16(tbRow.Text);
                Column = Convert.ToInt16(tbColumn.Text);
            }
            catch
            {
                MessageBox.Show("Выберите клетку на карте для вставки числа!");
                dgvSudoku.Focus();
                return;
            }
            try
            {
                Value = Convert.ToInt16(tbValue.Text);
            }
            catch
            {
                MessageBox.Show("Значение нового числа введенно не корректно!");
                tbValue.Focus();
                return;
            }
            sudoku.CellValueChange(dgvSudoku, Row, Column, Value);
        }

        //Получаем информацию о координатах клетки при нажатии на нее
        private void dgvSudoku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRow.Text = dgvSudoku.CurrentCell.RowIndex.ToString();
            tbColumn.Text = dgvSudoku.CurrentCell.ColumnIndex.ToString();
        }
    }
}
