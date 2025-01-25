using System;
using System.Collections.Generic;
using InterfaceExercise.Entities;


namespace InterfaceExercise.Services
{
    public interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);
        public double Interest(double amount, int months);
    }
}
