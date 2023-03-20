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
            double avgXi = Xi.Average();
            double avgYi = Yi.Average();
            double avgXiYi = XiYi.Average();
            //Найдем средние квадратичные отклонения случайных величин X и Y
            double avgDevX = CalculateStandardDeviation(Xi2, avgXi);
            double avgDevY = CalculateStandardDeviation(Yi2, avgYi);

            //Найдем выборочный коэффициент корреляции
            double rV = Rv(avgXiYi, avgXi, avgYi, avgDevX, avgDevY);
           //string checkrV = CheckConnect(rV);

            //Найдем коэффициенты линейной регрессии
            //Посчитали по Y*X
            double roYX = Ro(avgXiYi, avgXi, avgYi, avgDevX);
            double bYX = Bo(avgYi, avgXi, roYX);
            double[] outputY = new double[Yi.Length];
            double[] outputX = new double[Xi.Length];        
            
            //Посчитали по X*Y
            double roXY = Ro(avgXiYi, avgXi, avgYi, avgDevY); 
            double bXY = Bo(avgXi, avgYi, roXY); 
            LineRegressionOutput(out outputY, Xi, roYX, bYX);
            LineRegressionOutput(out outputX, Yi, roXY, bXY);
            DisplayResult(rV, roXY, bYX, roYX, bXY, avgDevX, avgDevY);
            DrawChart(Xi,Yi, outputY, outputX);
        }

        private void DisplayResult(double rV, double roXY, double bYX, double roYX, double bXY, double avgDevX, double avgDevY)
        {
            textboxAnswer.Clear();
            string result = "Коэффициент корреляции: " + rV.ToString() + " " + CheckConnect(rV)+"\n ";
            result = result + "Коэффициенты линейной регрессии Y*X: ро = " + roXY.ToString() + " b=" + bXY.ToString() + "\n ";
            result = result + "Коэффициенты линейной регрессии X*Y: ро = " + roYX.ToString() + " b=" + bYX.ToString() + "\n ";
            result = result + "Средне-квадратичное отклонения: devX = " + avgDevX.ToString() + " devY=" + avgDevY.ToString() + "\n ";
            textboxAnswer.Text = result;
        }


        public void DrawChart(double[] X, double[] Y, double[] Y1, double[] X1)
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
            Series XY_Point = new Series();
            Series Yx_line = new Series();
            Series Xy_line = new Series();
            XY_Point.ChartType = SeriesChartType.Point;
            Yx_line.ChartType = SeriesChartType.Line;
            Xy_line.ChartType = SeriesChartType.Line;
            XY_Point.Color = Color.Red;
            Yx_line.Color = Color.Green;
            Xy_line.Color = Color.Blue;
            Yx_line.LegendText = "Линейная регрессия Yx";
            XY_Point.LegendText = "Эксперименты(точки)";
            Xy_line.LegendText = "Линейная регрессия Xy";

            // Добавляем точки в Series
            for (int i = 0; i < X.Length; i++)
            {
                XY_Point.Points.AddXY(X[i], Y[i]);
                Yx_line.Points.AddXY(X[i], Y1[i]);
                Xy_line.Points.AddXY(X1[i], Y[i]);
            }

            if (ChartOfFunction.Series.Count > 0)
            {
                ChartOfFunction.Series.Clear();
            };

            // Добавляем Series в Chart
            ChartOfFunction.Series.Add(XY_Point);
            ChartOfFunction.Series.Add(Yx_line);
            ChartOfFunction.Series.Add(Xy_line);
        }

        public static void LineRegressionOutput(out double[] output, double[] InputEl, double roYX, double bYX)
        {
            output = new double[InputEl.Length];
            for (int i=0; i< InputEl.Length;i++)
            {
                output[i] = (roYX * InputEl[i]) - bYX;
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

        private double Ro(double avgXY, double avgX, double avgY, double avgDev)
        {
            return (avgXY - avgX * avgY) / Math.Pow(avgDev, 2);
        }

        private double Bo(double avgX, double avgY, double RoRes)
        {
            return avgY - avgX * RoRes;
        }

        private double Rv(double avgXiYi, double avgXi, double avgYi, double avgDevX, double avgDevY)
        {
            return ((avgXiYi - avgXi * avgYi) / (avgDevX * avgDevY));
        }

        private double CalculateStandardDeviation(double[] ArrayPow2, double ArrayAvg)
        {
            return Math.Sqrt(ArrayPow2.Average() - Math.Pow(ArrayAvg, 2.0));
        }

    }
}
