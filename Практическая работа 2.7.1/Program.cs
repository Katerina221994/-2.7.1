﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_2._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Кульчицкая Екатерина Геннадьевна";
            byte age = 29;
            string emaill ="rfvb.foto@mail.ru";
            float programminPoints = 13f;
            float mathPoint = 24f;
            float physicsPoints = 16f;

            float summPoints = programminPoints + mathPoint + physicsPoints;
            int GPA = (int)summPoints / 3;



            Console.WriteLine("ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по матиматике: {4} \nБаллы по физике: {5}" ,
                fullName,
                age,
                emaill,
                programminPoints,
                mathPoint,
                physicsPoints);

            Console.ReadKey();

            Console.WriteLine("\nCреденее арифмитическре баллов: {0}",GPA);

            Console.ReadKey();

           

        }
    }
}
