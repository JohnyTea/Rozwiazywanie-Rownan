using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton2x2.Checked = true;
            x11_TB.Enabled = true;
            x12_TB.Enabled = true;
            x21_TB.Enabled = true;
            x22_TB.Enabled = true;
            wolny1_TB.Enabled = true;
            wolny2_TB.Enabled = true;
        }

        private void radioButton2x2_CheckedChanged(object sender, EventArgs e)
        {
            x11_TB.Enabled = true;
            x12_TB.Enabled = true;
            x13_TB.Enabled = false;
            x14_TB.Enabled = false;
            x15_TB.Enabled = false;
            x16_TB.Enabled = false;
            x21_TB.Enabled = true;
            x22_TB.Enabled = true;
            x23_TB.Enabled = false;
            x24_TB.Enabled = false;
            x25_TB.Enabled = false;
            x26_TB.Enabled = false;
            x31_TB.Enabled = false;
            x32_TB.Enabled = false;
            x33_TB.Enabled = false;
            x34_TB.Enabled = false;
            x35_TB.Enabled = false;
            x36_TB.Enabled = false;
            x41_TB.Enabled = false;
            x42_TB.Enabled = false;
            x43_TB.Enabled = false;
            x44_TB.Enabled = false;
            x45_TB.Enabled = false;
            x46_TB.Enabled = false;
            x51_TB.Enabled = false;
            x52_TB.Enabled = false;
            x53_TB.Enabled = false;
            x54_TB.Enabled = false;
            x55_TB.Enabled = false;
            x56_TB.Enabled = false;
            x61_TB.Enabled = false;
            x62_TB.Enabled = false;
            x63_TB.Enabled = false;
            x64_TB.Enabled = false;
            x65_TB.Enabled = false;
            x66_TB.Enabled = false;
            wolny1_TB.Enabled = true;
            wolny2_TB.Enabled = true;
            wolny3_TB.Enabled = false;
            wolny4_TB.Enabled = false;
            wolny5_TB.Enabled = false;
            wolny6_TB.Enabled = false;
        }

        private void radioButton3x3_CheckedChanged(object sender, EventArgs e)
        {
            x11_TB.Enabled = true;
            x12_TB.Enabled = true;
            x13_TB.Enabled = true;
            x14_TB.Enabled = false;
            x15_TB.Enabled = false;
            x16_TB.Enabled = false;
            x21_TB.Enabled = true;
            x22_TB.Enabled = true;
            x23_TB.Enabled = true;
            x24_TB.Enabled = false;
            x25_TB.Enabled = false;
            x26_TB.Enabled = false;
            x31_TB.Enabled = true;
            x32_TB.Enabled = true;
            x33_TB.Enabled = true;
            x34_TB.Enabled = false;
            x35_TB.Enabled = false;
            x36_TB.Enabled = false;
            x41_TB.Enabled = false;
            x42_TB.Enabled = false;
            x43_TB.Enabled = false;
            x44_TB.Enabled = false;
            x45_TB.Enabled = false;
            x46_TB.Enabled = false;
            x51_TB.Enabled = false;
            x52_TB.Enabled = false;
            x53_TB.Enabled = false;
            x54_TB.Enabled = false;
            x55_TB.Enabled = false;
            x56_TB.Enabled = false;
            x61_TB.Enabled = false;
            x62_TB.Enabled = false;
            x63_TB.Enabled = false;
            x64_TB.Enabled = false;
            x65_TB.Enabled = false;
            x66_TB.Enabled = false;
            wolny1_TB.Enabled = true;
            wolny2_TB.Enabled = true;
            wolny3_TB.Enabled = true;
            wolny4_TB.Enabled = false;
            wolny5_TB.Enabled = false;
            wolny6_TB.Enabled = false;
        }

        private void radioButton4x4_CheckedChanged(object sender, EventArgs e)
        {
            x11_TB.Enabled = true;
            x12_TB.Enabled = true;
            x13_TB.Enabled = true;
            x14_TB.Enabled = true;
            x15_TB.Enabled = false;
            x16_TB.Enabled = false;
            x21_TB.Enabled = true;
            x22_TB.Enabled = true;
            x23_TB.Enabled = true;
            x24_TB.Enabled = true;
            x25_TB.Enabled = false;
            x26_TB.Enabled = false;
            x31_TB.Enabled = true;
            x32_TB.Enabled = true;
            x33_TB.Enabled = true;
            x34_TB.Enabled = true;
            x35_TB.Enabled = false;
            x36_TB.Enabled = false;
            x41_TB.Enabled = true;
            x42_TB.Enabled = true;
            x43_TB.Enabled = true;
            x44_TB.Enabled = true;
            x45_TB.Enabled = false;
            x46_TB.Enabled = false;
            x51_TB.Enabled = false;
            x52_TB.Enabled = false;
            x53_TB.Enabled = false;
            x54_TB.Enabled = false;
            x55_TB.Enabled = false;
            x56_TB.Enabled = false;
            x61_TB.Enabled = false;
            x62_TB.Enabled = false;
            x63_TB.Enabled = false;
            x64_TB.Enabled = false;
            x65_TB.Enabled = false;
            x66_TB.Enabled = false;
            wolny1_TB.Enabled = true;
            wolny2_TB.Enabled = true;
            wolny3_TB.Enabled = true;
            wolny4_TB.Enabled = true;
            wolny5_TB.Enabled = false;
            wolny6_TB.Enabled = false;
        }

        private void radioButton5x5_CheckedChanged(object sender, EventArgs e)
        {
            x11_TB.Enabled = true;
            x12_TB.Enabled = true;
            x13_TB.Enabled = true;
            x14_TB.Enabled = true;
            x15_TB.Enabled = true;
            x16_TB.Enabled = false;
            x21_TB.Enabled = true;
            x22_TB.Enabled = true;
            x23_TB.Enabled = true;
            x24_TB.Enabled = true;
            x25_TB.Enabled = true;
            x26_TB.Enabled = false;
            x31_TB.Enabled = true;
            x32_TB.Enabled = true;
            x33_TB.Enabled = true;
            x34_TB.Enabled = true;
            x35_TB.Enabled = true;
            x36_TB.Enabled = false;
            x41_TB.Enabled = true;
            x42_TB.Enabled = true;
            x43_TB.Enabled = true;
            x44_TB.Enabled = true;
            x45_TB.Enabled = true;
            x46_TB.Enabled = false;
            x51_TB.Enabled = true;
            x52_TB.Enabled = true;
            x53_TB.Enabled = true;
            x54_TB.Enabled = true;
            x55_TB.Enabled = true;
            x56_TB.Enabled = false;
            x61_TB.Enabled = false;
            x62_TB.Enabled = false;
            x63_TB.Enabled = false;
            x64_TB.Enabled = false;
            x65_TB.Enabled = false;
            x66_TB.Enabled = false;
            wolny1_TB.Enabled = true;
            wolny2_TB.Enabled = true;
            wolny3_TB.Enabled = true;
            wolny4_TB.Enabled = true;
            wolny5_TB.Enabled = true;
            wolny6_TB.Enabled = false;
        }

        private void radioButton6x6_CheckedChanged(object sender, EventArgs e)
        {
            x11_TB.Enabled = true;
            x12_TB.Enabled = true;
            x13_TB.Enabled = true;
            x14_TB.Enabled = true;
            x15_TB.Enabled = true;
            x16_TB.Enabled = true;
            x21_TB.Enabled = true;
            x22_TB.Enabled = true;
            x23_TB.Enabled = true;
            x24_TB.Enabled = true;
            x25_TB.Enabled = true;
            x26_TB.Enabled = true;
            x31_TB.Enabled = true;
            x32_TB.Enabled = true;
            x33_TB.Enabled = true;
            x34_TB.Enabled = true;
            x35_TB.Enabled = true;
            x36_TB.Enabled = true;
            x41_TB.Enabled = true;
            x42_TB.Enabled = true;
            x43_TB.Enabled = true;
            x44_TB.Enabled = true;
            x45_TB.Enabled = true;
            x46_TB.Enabled = true;
            x51_TB.Enabled = true;
            x52_TB.Enabled = true;
            x53_TB.Enabled = true;
            x54_TB.Enabled = true;
            x55_TB.Enabled = true;
            x56_TB.Enabled = true;
            x61_TB.Enabled = true;
            x62_TB.Enabled = true;
            x63_TB.Enabled = true;
            x64_TB.Enabled = true;
            x65_TB.Enabled = true;
            x66_TB.Enabled = true;
            wolny1_TB.Enabled = true;
            wolny2_TB.Enabled = true;
            wolny3_TB.Enabled = true;
            wolny4_TB.Enabled = true;
            wolny5_TB.Enabled = true;
            wolny6_TB.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) //start liczenia
        {
            double[,] macierz = stworzMacierz();

            double[] wyniki = RozwiazRownanie(macierz);

            //wypisywanie wyników
            Wynik_x3_TB.Text = String.Format("{0:0.##}", wyniki[6]);
            Wynik_x3_TB.Text = String.Format("{0:0.##}", wyniki[5]);
            Wynik_x3_TB.Text = String.Format("{0:0.##}", wyniki[4]);
            Wynik_x3_TB.Text = String.Format("{0:0.##}", wyniki[3]);
            Wynik_x2_TB.Text = String.Format("{0:0.##}", wyniki[2]);
            Wynik_x1_TB.Text = String.Format("{0:0.##}", wyniki[1]);


        }

        private static double[] RozwiazRownanie(double[,] macierz)
        {
            double m;
            for (int k = 1; k < macierz.GetLength(1); k++) //redukowanie do 0 pod przekatna
            {
                for (int i = k; i < macierz.GetLength(0); i++)
                {
                    m = macierz[i, k] / macierz[k - 1, k];
                    for (int j = 0; j < macierz.GetLength(1); j++)
                    {
                        macierz[i, j] -= m * macierz[k - 1, j];
                    }
                }
            }

            double[] wyniki = new double[7];


            for (int i = macierz.GetLength(0) - 1; i >= 0; i--) //obliczanie kolejnych x od konca
            {
                wyniki[i + 1] = macierz[i, 0] / macierz[i, i + 1];
                for (int j = i + 2; j < macierz.GetLength(1); j++)
                {
                    wyniki[i + 1] -= macierz[i, j] * wyniki[j] / macierz[i, i + 1];
                }
            }

            return wyniki;
        }

        private double[,] stworzMacierz() //czytanie danych i tworzenie macierza pierwsza kolumna to wyraz wolny potem kolejne x. a11 w macierzu znajduje sie w [0,1] wyraz wolny tego rownania w [0,0], a35 w [2,5] wyraz wolny w [2,0];
        {
            string[,] tablicaStr = new string[6, 7];
            #region przypisywanieSTR
            
            tablicaStr[0, 0] = wolny1_TB.Text;
            tablicaStr[1, 0] = wolny2_TB.Text;
            tablicaStr[2, 0] = wolny3_TB.Text;
            tablicaStr[3, 0] = wolny4_TB.Text;
            tablicaStr[4, 0] = wolny5_TB.Text;
            tablicaStr[5, 0] = wolny6_TB.Text;

            tablicaStr[0, 1] = x11_TB.Text;
            tablicaStr[0, 2] = x21_TB.Text;
            tablicaStr[0, 3] = x31_TB.Text;
            tablicaStr[0, 4] = x41_TB.Text;
            tablicaStr[0, 5] = x51_TB.Text;
            tablicaStr[0, 6] = x61_TB.Text;

            tablicaStr[1, 1] = x12_TB.Text;
            tablicaStr[1, 2] = x22_TB.Text;
            tablicaStr[1, 3] = x32_TB.Text;
            tablicaStr[1, 4] = x42_TB.Text;
            tablicaStr[1, 5] = x52_TB.Text;
            tablicaStr[1, 6] = x62_TB.Text;

            tablicaStr[2, 1] = x13_TB.Text;
            tablicaStr[2, 2] = x23_TB.Text;
            tablicaStr[2, 3] = x33_TB.Text;
            tablicaStr[2, 4] = x43_TB.Text;
            tablicaStr[2, 5] = x53_TB.Text;
            tablicaStr[2, 6] = x63_TB.Text;

            tablicaStr[3, 1] = x14_TB.Text;
            tablicaStr[3, 2] = x24_TB.Text;
            tablicaStr[3, 3] = x34_TB.Text;
            tablicaStr[3, 4] = x44_TB.Text;
            tablicaStr[3, 5] = x54_TB.Text;
            tablicaStr[3, 6] = x64_TB.Text;

            tablicaStr[4, 1] = x15_TB.Text;
            tablicaStr[4, 2] = x25_TB.Text;
            tablicaStr[4, 3] = x35_TB.Text;
            tablicaStr[4, 4] = x45_TB.Text;
            tablicaStr[4, 5] = x55_TB.Text;
            tablicaStr[4, 6] = x65_TB.Text;

            tablicaStr[5, 1] = x16_TB.Text;
            tablicaStr[5, 2] = x26_TB.Text;
            tablicaStr[5, 3] = x36_TB.Text;
            tablicaStr[5, 4] = x46_TB.Text;
            tablicaStr[5, 5] = x56_TB.Text;
            tablicaStr[5, 6] = x66_TB.Text;

            #endregion

            double[,] tablicaDouble;
            if (radioButton2x2.Checked)
            {
                tablicaDouble = new double[2, 3];
            }
            else if (radioButton3x3.Checked)
            {
                tablicaDouble = new double[3, 4];
            }
            else if (radioButton4x4.Checked)
            {
                tablicaDouble = new double[4, 5];
            }
            else if (radioButton5x5.Checked)
            {
                tablicaDouble = new double[5, 6];
            }
            else
            {
                tablicaDouble = new double[6, 7];
            }

            for(int i =0; i<tablicaDouble.GetLength(0) ;i++)
            {
                for(int j=0; j < tablicaDouble.GetLength(1); j++)
                {
                    tablicaDouble[i, j] = double.Parse(tablicaStr[i, j]);
                }
            }

            
            return tablicaDouble;
        }
    }
}
