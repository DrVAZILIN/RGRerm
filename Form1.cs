using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGRerm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void random_b_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DGV.RowCount = rnd.Next(2, 16);
            DGV.ColumnCount = rnd.Next(2, 16);

            for (int i = 0; i < DGV.RowCount; i++)
            {
                for (int j = 0; j < DGV.ColumnCount; j++)
                {

                    DGV[j, i].Value = rnd.Next(-100, 100) + Math.Round(rnd.NextDouble(), 2);
                }

            }


        }

        private void result_b_Click(object sender, EventArgs e)
        {
            double[,] Matr = new double[DGV.RowCount, DGV.ColumnCount];//создали массив
            for (int i = 0; i < DGV.RowCount; i++)
                for (int j = 0; j < DGV.ColumnCount; j++)
                    Matr[i, j] = Convert.ToDouble(DGV[j, i].Value);

            ////min max
            double[] mas = new double[DGV.RowCount];

            for (int i = 0; i < DGV.RowCount; i++)
            {
                double max = Matr[i, 0];
                for (int j = 1; j < DGV.ColumnCount; j++)
                {
                    if (Matr[i, j] >= max)
                        max = Matr[i, j];
                }
                mas[i] = max;
            }
            double minmax = mas[0];
            for (int i = 1; i < mas.Length; i++)
                if (minmax > mas[i])
                    minmax = mas[i];
            double p = minmax;



            //maxmin
            double[] mas1 = new double[DGV.ColumnCount];
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                double min = Matr[0, i];
                for (int j = 0; j < DGV.RowCount; j++)
                {
                    if (Matr[j, i] <= min)
                        min = Matr[j, i];

                }
                mas1[i] = min;
            }
            double maxmin = mas1[0];
            for (int i = 0; i < DGV.ColumnCount; i++)
                if (maxmin < mas1[i])
                    maxmin = mas1[i];
            double q = maxmin;
            MessageBox.Show($"minmax = {minmax}\nmaxmin = {maxmin}\n" + (p * q).ToString());
            //MessageBox.Show((minmax,maxmin).ToString());
        }



        private void bt_run_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int.TryParse(tb1.Text, out int a);
            int.TryParse(tb2.Text, out int b);
            if (a != 0 && b != 0)
            {
                DGV.RowCount = a;
                DGV.ColumnCount = b;

                for (int i = 0; i < DGV.RowCount; i++)
                {
                    for (int j = 0; j < DGV.ColumnCount; j++)
                    {

                        DGV[j, i].Value = rnd.Next(-100, 100) + Math.Round(rnd.NextDouble(), 2);
                    }

                }
            }
            else
                MessageBox.Show("введите ПРАВИЛЬНЫЕ числа");

        }
        //Сгенерировать квадратную(N≥5, M≥5) матрицу и заполнить вещественными числами(положительными и отрицательными). 
        //    Отсортировать элементы побочной диагонали по убыванию.
        private void bt26_Click(object sender, EventArgs e)
        {
            if (DGV.RowCount == DGV.ColumnCount && DGV.RowCount >= 5)
            {
                double[] tmp = new double[DGV.RowCount];

                for (int i = 0; i < DGV.RowCount; i++)
                {
                    tmp[i] = Convert.ToDouble(DGV[i, DGV.RowCount - 1 - i].Value);
                }
                Array.Sort(tmp);
                Array.Reverse(tmp);
                for (int i = 0; i < DGV.RowCount; i++)
                {
                    DGV[i, DGV.RowCount - 1 - i].Value = tmp[i];
                }
            }
            else
                MessageBox.Show("какой то неправильный базар");
        }
        //Сгенерировать квадратную матрицу с четным количеством столбцов и заполнить вещественными числами(положительными и отрицательными). 
        //    Поменять местами элементы главной и побочной диагонали в нечетных столбцах.
        private void bt43_Click(object sender, EventArgs e)
        {
            if (DGV.RowCount == DGV.ColumnCount && DGV.RowCount % 2 == 0)
            {
                double[] tmpp = new double[DGV.RowCount / 2];
                double[] tmpd = new double[DGV.RowCount / 2];

                for (int i = 0; i < DGV.RowCount / 2; i++)
                {
                    tmpp[i] = Convert.ToDouble(DGV[i * 2, DGV.RowCount - 1 - i * 2].Value);
                    tmpd[i] = Convert.ToDouble(DGV[i * 2, i * 2].Value);

                }

                for (int i = 0; i < DGV.RowCount / 2; i++)
                {
                    DGV[i * 2, DGV.RowCount - 1 - i * 2].Value = tmpd[i];
                    DGV[i * 2, i * 2].Value = tmpp[i];

                }
            }
            else
                MessageBox.Show("неправильные значения....повторите ввод даных");

        }
        //Сгенерировать матрицу(N≥10, M≥10) и заполнить целыми положительными числами в диапазоне от 10 до 20.
        // Определить значение, которые повторяются.Вывести все повторяющиеся значения и количество их повторений.
        private void bt4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DGV.RowCount = rnd.Next(10, 16);
            DGV.ColumnCount = rnd.Next(10, 16);

            for (int i = 0; i < DGV.RowCount; i++)
            {
                for (int j = 0; j < DGV.ColumnCount; j++)
                {

                    DGV[j, i].Value = rnd.Next(10, 20);
                }

            }
            int[] chisla = new int[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Convert.ToInt32(DGV[i, j].Value) == 10)
                        chisla[0]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 11)
                        chisla[1]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 12)
                        chisla[2]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 13)
                        chisla[3]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 14)
                        chisla[4]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 15)
                        chisla[5]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 16)
                        chisla[6]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 17)
                        chisla[7]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 18)
                        chisla[8]++;
                    if (Convert.ToInt32(DGV[i, j].Value) == 19)
                        chisla[9]++;
                }
            }
            MessageBox.Show($" 10- {chisla[0]}\n 11- {chisla[1]}\n 12- {chisla[2]}\n 13- {chisla[3]}\n 14- {chisla[4]}\n 15- {chisla[5]}\n 16- {chisla[6]}\n 17- {chisla[7]}\n 18- {chisla[8]}\n 19- {chisla[9]}\n");

        }
        //Сгенерировать матрицу(N != M) и заполнить вещественными числами(положительными и отрицательными).
        //Реализовать алгоритм нахождения обратной матрицы и вывести обратную матрицу.
        private void bt15_Click(object sender, EventArgs e)
        {
            if (DGV.RowCount == DGV.ColumnCount)
            {
                int n = DGV.RowCount;
                double[,] inverseMatrix = new double[n, n];

                double[,] augmentedMatrix = new double[n, 2 * n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        augmentedMatrix[i, j] = Convert.ToDouble(DGV[i, j].Value);
                    }

                    augmentedMatrix[i, i + n] = 1;
                }

                for (int i = 0; i < n; i++)
                {
                    double pivot = augmentedMatrix[i, i];

                    for (int j = 0; j < 2 * n; j++)
                    {
                        augmentedMatrix[i, j] /= pivot;
                    }

                    for (int k = 0; k < n; k++)
                    {
                        if (k != i)
                        {
                            double coefficient = augmentedMatrix[k, i];

                            for (int j = 0; j < 2 * n; j++)
                            {
                                augmentedMatrix[k, j] -= coefficient * augmentedMatrix[i, j];
                            }
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        DGV[i, j].Value = augmentedMatrix[i, j + n];
                    }
                }
            }
            else
                MessageBox.Show("что то не то....введите новые значения");
        }
        //Сгенерировать матрицу(N≥10, M≥10) и заполнить целыми положительными числами в диапазоне от -2 до 2.
        //    В каждом столбце найти количество нулевых значений и из них сформировать дополнительную строку матрицы.
        private void bt32_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DGV.RowCount = rnd.Next(10, 16);
            DGV.ColumnCount = rnd.Next(10, 16);
            int[] chisla = new int[DGV.ColumnCount];
            for (int i = 0; i < DGV.RowCount; i++)
            {
                for (int j = 0; j < DGV.ColumnCount; j++)
                {

                    DGV[j, i].Value = rnd.Next(-2, 2);
                    if (Convert.ToInt32(DGV[j, i].Value) == 0)
                        chisla[j]++;
                }
            }


            DGV.RowCount = DGV.RowCount;
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                DGV[i, DGV.RowCount - 1].Value = chisla[i];

            }
        }

        private void result_b_Click_1(object sender, EventArgs e)
        {

        }
    }
}
