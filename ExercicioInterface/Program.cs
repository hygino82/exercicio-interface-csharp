using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioInterface.Entities;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = 8028;//int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse("25/06/2018");//Console.ReadLine());
            Console.Write("Contract value: ");
            double totalValue = 600.0;//double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);
            List<Installment> list = new List<Installment>();


            Console.Write("Enter number of installments: ");
            int installments = 3;//int.Parse(Console.ReadLine());
            double baseValue = totalValue / installments;
            Console.WriteLine();

            for (int i = 1; i <= installments; i++)
            {
                double amount = baseValue * (1 + i / 100.0);
                amount *= 1.02;
                DateTime dueDate = date.AddMonths(i);

                Installment installment = new Installment(dueDate, amount);
                list.Add(installment);
            }

            Console.WriteLine("Installments:");
            foreach (Installment p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
