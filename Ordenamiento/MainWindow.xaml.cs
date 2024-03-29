﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(58);
            miLista.Add(35);
            miLista.Add(20);
            miLista.Add(16);
            miLista.Add(14);
            miLista.Add(12);
            miLista.Add(60);
            miLista.Add(4);


            alumnos.Add(new Alumno("Robert", 9.1f, 4));
            alumnos.Add(new Alumno("Ian", 9.7f, 1));
            alumnos.Add(new Alumno("Jorge", 9.5f, 1));
            alumnos.Add(new Alumno("Armando", 9.9f, 2));
            alumnos.Add(new Alumno("José", 9.8f, 3));
            alumnos.Add(new Alumno("Emmanuel", 7.9f, 5));
            alumnos.Add(new Alumno("Alejandro", 8.1f, 3));

            lstNumeros.ItemsSource = alumnos;
            //lstNumeros.ItemsSource = miLista;

        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*int i;int j;
            for(i=0; i> miLista.Count; i++)
            {
            |for (j = 1; j > miLista.Count; j++)
                {
                    var temp = miLista[j];
                    miLista[j] = miLista[j+1];
                    miLista[j+1] = temp;
                }
            }*/
            int gap, i;
            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Promedio > alumnos[gap + i].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }

                }
                gap--;
            }

        }

        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1 ; i++)
                {
                    if (alumnos[i].Promedio > alumnos[i + 1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);

        }

        private void BtnOrdenarFaltas_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Faltas > alumnos[gap + i].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }

                }
                gap--;
            }
        }

        private void BtnBubbleFaltas_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Faltas > alumnos[i + 1].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);

        }
    }
}
