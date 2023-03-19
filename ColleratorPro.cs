using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrelatorPro
{
    public partial class frmCorrellatorPro : Form
    {
        public frmCorrellatorPro()
        {
            InitializeComponent();
        }

        private void frmCorrellatorPro_Load(object sender, EventArgs e)
        {

        }

        private void richTextBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int columnCount = (int)numericUpDown1.Value;

            // Очищаем таблицу от предыдущих строк и столбцов
            dgwData.Rows.Clear();
            dgwData.Columns.Clear();

            // Добавляем столбцы с именами от 1 до N
            for (int i = 1; i <= columnCount; i++)
            {
                dgwData.Columns.Add(i.ToString(), i.ToString());
                dgwData.Columns[i - 1].Width = 100; // Фиксированная ширина для столбцов с именами строк
            }

            //// Добавляем две строки
            //dgwData.Rows.Add();
            //dgwData.Rows[0].Cells[0].Value = "Количество Авто";
            //dgwData.Rows.Add();
            //dgwData.Rows[1].Cells[0].Value = "Затраты на рекламу";
        }

        private void btLineRegCount_Click(object sender, EventArgs e)
        {
            int columnCount = dgwData.Columns.Count;
            double[] Xi = new double[columnCount];
            double[] Yi = new double[columnCount];
            //Получим данные из таблицы
            GetDataFromDataGridView(dgwData, out Xi, out Yi);
            double[] XiYi = new double[Xi.Length];
            //Получим результат умножения друг на друга
            XiYi = MultiplyArrays(Xi, Yi);
            double[] Xi2 = new double[Xi.Length];
            double[] Yi2 = new double[Yi.Length];
            //Получим их квадраты
            Xi2 = SquareArrayElements(Xi);
            Yi2 = SquareArrayElements(Yi2);

            WriteToDataGridView(dgvTemp,Xi, Yi, XiYi, Xi2, Yi2, Xi.Length);
        }
        /*Метод получения данных из таблицы
         * @param таблица DataGridView
         * @return массив Xi и Yi
         */

        private void GetDataFromDataGridView(DataGridView dgv, out double[] x, out double[] y)
        {
            int rowCount = dgv.Rows.Count;
            int columnCount = dgv.Columns.Count;

            x = new double[columnCount];
            y = new double[columnCount];

            // Заполняем массивы данными из таблицы
            for (int i = 0; i < columnCount; i++)
            {
                x[i] = double.Parse(dgv.Rows[0].Cells[i].Value.ToString());
                y[i] = double.Parse(dgv.Rows[1].Cells[i].Value.ToString());
            }
        }


        private void WriteToDataGridView(DataGridView dgv, double[] Xi, double[] Yi, double[] XiYi, double[] XiSqr, double[] YiSqr, int size)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.ColumnCount = 6;

            dgv.Columns[0].HeaderText = "Xi";
            dgv.Columns[1].HeaderText = "Yi";
            dgv.Columns[2].HeaderText = "XiYi";
            dgv.Columns[3].HeaderText = "Xi^2";
            dgv.Columns[4].HeaderText = "Yi^2";
            
            for (int i = 0; i < size; i++)
            {
                dgv.Rows.Add(Xi[i], Yi[i], XiYi[i], XiSqr[i], YiSqr[i]);
            }

            dgv.Rows.Add("SumXi", "SumYi", "SumXiYi", "SumXi2", "SumYi2", "");
            dgv.Rows[dgv.Rows.Count - 1].Cells[0].Value = Xi.Sum();
            dgv.Rows[dgv.Rows.Count - 1].Cells[1].Value = Yi.Sum();
            dgv.Rows[dgv.Rows.Count - 1].Cells[2].Value = XiYi.Sum();
            dgv.Rows[dgv.Rows.Count - 1].Cells[3].Value = XiSqr.Sum();
            dgv.Rows[dgv.Rows.Count - 1].Cells[4].Value = YiSqr.Sum();
        }






        //Вот это добро ниже надо бы в отдельный класс.
        //Но на часах уже за полночь
        //Потому это в другой раз
        private double[] MultiplyArrays(double[] x, double[] y)
        {
            int length = x.Length;
            double[] result = new double[length];

            // Умножаем соответствующие элементы массивов X и Y и сохраняем результаты в массиве результатов
            for (int i = 0; i < length; i++)
            {
                result[i] = x[i] * y[i];
            }

            return result;
        }

        private double[] SquareArrayElements(double[] array)
        {
            int length = array.Length;
            double[] result = new double[length];

            // Возводим в квадрат каждый элемент массива и сохраняем результаты в новом массиве
            for (int i = 0; i < length; i++)
            {
                result[i] = Math.Pow(array[i], 2);
            }

            return result;
        }

    }
}
