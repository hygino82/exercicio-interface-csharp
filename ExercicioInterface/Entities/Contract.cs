using System;
using System.Collections.Generic;

namespace ExercicioInterface.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public List<Installment> Installments { get; private set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
            //adicionado no construtor a lista de parcelas
        }

        public void AddInstallment(Installment installment)
        {//adiciona as parcelas
            Installments.Add(installment);
        }
    }
}
