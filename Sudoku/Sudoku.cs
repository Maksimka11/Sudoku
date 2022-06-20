using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class Sudoku
    {
        int[,] Map = new int[9, 9]; // Массив с картой для судоку
        Random rand = new Random();
        public void GenerateMap(int Number) // Метод заполнения карты начальными цифрами
        {
            Map = new int[9, 9];
            int Count = 0;
            while(Count < Number)
            {
                bool Correct = true;
                int Column = rand.Next(0, 9);
                int Row = rand.Next(0, 9);
                int newNumber = rand.Next(0, 9);
                for(int i = 0; i < 9; i++)
                {
                    if (Map[i, Column] == newNumber) { Correct = false;  }
                }

                for(int i = 0; i < 9; i++)
                {
                    if (Map[Row, i] == newNumber) { Correct = false; }
                }

                if (Correct == true)
                {
                    Map[Row, Column] = newNumber;
                    Count++;
                }
            }
        }
        
        public void ReloadMap(DataGridView dgv)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dgv.Rows[i].Cells[j].Value = Map[i, j];
                }
            }
        } //Метод перезагрузки карты на форме

        // Метод проверки на вставку нового числа
        public void CellValueChange(DataGridView dgv,int Row,int Column,int Value) 
        {
            //Проверка числа на соответствие правилам игры
            if (Value > 9 | Value < 1)
            {
                MessageBox.Show("Введите цифру от 1 до 9","Ошибка");
                Map[Row, Column] = 0;
                return;
            }
            
            for (int i = 0; i < 9; i++)
            {
                //Проверка числа на повторение по горизонтали
                if (Map[Row,i] == Value)
                {
                    MessageBox.Show("По горизонтали уже имеется такая цифра");
                    Map[Row, Column] = 0;
                    return;
                }
                //Проверка числа на повторение по вертикали
                else if (Map[i,Column] == Value)
                {
                    MessageBox.Show("По вертикали уже имеется такая цифра");
                    Map[Row, Column] = 0;
                    return;
                }
            }
            Map[Row, Column] = Value;
            //Перезагрузить карту
            ReloadMap(dgv);
        }
    }
}
