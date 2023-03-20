using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            // Найдем средние значения
            double avgXi = Xi.Sum() / Xi.Length;
            double avgYi = Yi.Sum() / Yi.Length;
            double avgXiYi = XiYi.Sum() / XiYi.Length;
            //Найдем средние квадратичные отклонения случайных величин X и Y
            double avgDevX = Math.Sqrt((Xi2.Sum() / Xi2.Length) - Math.Pow(avgXi, 2.0));
            double avgDevY = Math.Sqrt((Yi2.Sum() / Yi2.Length) - Math.Pow(avgYi, 2.0));
            //Найдем выборочный коэффициент корреляции
            double rV = ((avgXiYi - avgXi * avgYi) / (avgDevX * avgDevY));
            string checkrV = CheckConnect(rV);
            //Найдем коэффициенты линейной регрессии
            double roYX = (avgXiYi - avgXi * avgYi) / Math.Pow(avgDevX, 2);
            double bYX = avgYi - avgXi * roYX;
            double[] outputY = new double[Yi.Length];
            double[] outputX = new double[Xi.Length];
            LineRegressionOutput(out outputY, Xi, roYX, bYX);
            double roXY = (avgXiYi - avgXi * avgYi) / Math.Pow(avgDevY, 2);
            double bXY = avgXi - avgYi * roXY;
            LineRegressionOutput(out outputX, Yi, roXY, bXY);

        }


        public void DrawChart(double[] X, double[] Y, double[] Y1)
        {

            // Устанавливаем размеры и местоположение Chart
            ChartOfFunction.Size = new Size(380, 330);
            //ChartOfFunction.Location = new Point(10, 10);

            // Создаем новую область Chart
            ChartArea chartArea1 = new ChartArea();
            if (ChartOfFunction.ChartAreas.Count > 0)
            {
                ChartOfFunction.ChartAreas.Clear();
            };
            ChartOfFunction.ChartAreas.Add(chartArea1);

            // Создаем новый объект Series для хранения точек графика
            Series series1 = new Series();
            Series series2 = new Series();
            series1.ChartType = SeriesChartType.Point;
            series2.ChartType = SeriesChartType.Line;
            series1.Color = Color.Red;
            series2.Color = Color.Blue;
            series1.LegendText = "Эксперименты";
            series2.LegendText = "Результаты аппроксимации";
            // Добавляем точки в Series
            for (int i = 0; i < X.Length; i++)
            {
                series1.Points.AddXY(X[i], Y[i]);
                series2.Points.AddXY(X[i], Y1[i]);
            }

            if (ChartOfFunction.Series.Count > 0)
            {
                ChartOfFunction.Series.Clear();
            };

            // Добавляем Series в Chart
            ChartOfFunction.Series.Add(series1);
            ChartOfFunction.Series.Add(series2);
        }

        public static void LineRegressionOutput(out double[] output, double[] InEl, double roYX, double bYX)
        {
            output = new double[InEl.Length];
            for (int i=0; i< InEl.Length;i++)
            {
                output[i] = (roYX * InEl[i]) - bYX;
            }
        }
        /*Метод получения данных из таблицы
         * @param таблица DataGridView
         * @return массив Xi и Yi
         */
        private static string CheckConnect(double rV)
        {
            //По шкале Чеддока
            string answer = "";
            answer = rV > 0 ? "Прямая" : "Обратная";
            if ((0.99 < Math.Abs(rV))&&(Math.Abs(rV) <= 1.0))
            {
                answer = answer+" практически функциональная";
                return answer;
            };
            if ((0.9 < Math.Abs(rV)) && (Math.Abs(rV) <= 0.99))
            {
                answer = answer + " очень сильная";
                return answer;
            };
            if ((0.7 < Math.Abs(rV)) && (Math.Abs(rV) <= 0.9))
            {
                answer = answer + " сильная";
                return answer;
            };
            if ((0.5 < Math.Abs(rV)) && (Math.Abs(rV) <= 0.7))
            {
                answer = answer + " заметная";
                return answer;
            };
            if ((0.3 < Math.Abs(rV)) && (Math.Abs(rV) <= 0.5))
            {
                answer = answer + " умеренная";
                return answer;
            };
            if ((0.1 < Math.Abs(rV)) && (Math.Abs(rV) <= 0.3))
            {
                answer = answer + " слабая";
                return answer;
            };
            if ((0.0 < Math.Abs(rV)) && (Math.Abs(rV) <= 0.1))
            {
                answer = answer + " практически отсутствует";
                return answer;
            };
            return answer;
        }

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
