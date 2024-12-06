using System;

namespace LabWork
{
    // Даний проект є шаблоном для виконання лабораторних робіт
    // з курсу "Об'єктно-орієнтоване програмування та патерни проектування"
    // Необхідно змінювати і дописувати код лише в цьому проекті
    // Відео-інструкції щодо роботи з github можна переглянути 
    // за посиланням https://www.youtube.com/@ViktorZhukovskyy/videos 

   
        
        // Клас для одновимірного вектора розмірності 4
        public class Vector4D
        {
            protected double[] vector; // масив для зберігання елементів вектора

            // Конструктор
            public Vector4D()
            {
                vector = new double[4];
            }

            // Метод для задання елементів вектора
            public void SetElements(double[] elements)
            {
                if (elements.Length != 4)
                {
                    throw new ArgumentException("Вектор повинен містити 4 елементи.");
                }
                for (int i = 0; i < 4; i++)
                {
                    vector[i] = elements[i];
                }
            }

            // Метод для виведення вектора на екран
            public void Display()
            {
                Console.WriteLine("Вектор: [" + string.Join(", ", vector) + "]");
            }

            // Метод для знаходження максимального елемента вектора
            public double MaxElement()
            {
                double max = vector[0];
                for (int i = 1; i < vector.Length; i++)
                {
                    if (vector[i] > max)
                    {
                        max = vector[i];
                    }
                }
                return max;
            }
        }

        // Похідний клас для матриці розмірності 4x4
        public class Matrix2D : Vector4D
        {
            private double[,] matrix; // масив для зберігання елементів матриці

            // Конструктор
            public Matrix2D()
            {
                matrix = new double[4, 4];
            }

            // Перевантажений метод для задання елементів матриці
            public void SetElements(double[,] elements)
            {
                if (elements.GetLength(0) != 4 || elements.GetLength(1) != 4)
                {
                    throw new ArgumentException("Матриця повинна мати розмір 4x4.");
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        matrix[i, j] = elements[i, j];
                    }
                }
            }

            // Перевантажений метод для виведення матриці на екран
            public void Display()
            {
                Console.WriteLine("Матриця:");
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            // Перевантажений метод для знаходження максимального елемента матриці
            public double MaxElement()
            {
                double max = matrix[0, 0];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (matrix[i, j] > max)
                        {
                            max = matrix[i, j];
                        }
                    }
                }
                return max;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Встановлюємо кодування UTF-8
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // Створюємо об'єкт вектора
                Vector4D vector = new Vector4D();
                vector.SetElements(new double[] { 1.2, 3.4, 5.6, 2.3 });
                vector.Display();
                Console.WriteLine("Максимальний елемент вектора: " + vector.MaxElement());

                // Створюємо об'єкт матриці
                Matrix2D matrix = new Matrix2D();
                matrix.SetElements(new double[,]
                {
                { 1.1, 2.2, 3.3, 4.4 },
                { 5.5, 6.6, 7.7, 8.8 },
                { 9.9, 10.0, 11.1, 12.2 },
                { 13.3, 14.4, 15.5, 16.6 }
                });
                matrix.Display();
                Console.WriteLine("Максимальний елемент матриці: " + matrix.MaxElement());
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
