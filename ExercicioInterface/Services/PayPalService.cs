using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Services
{
    class PayPalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;//taxa de pagamento
        private const double MonthlyInterest = 0.01;//taxa mensal

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
