﻿using System;
using System.Collections.Generic;
using System.Globalization;
using InterfaceExercise.Services;

namespace InterfaceExercise.Entities
{
    public class Installment
    {
        public DateTime Date {  get; set; }
        public double Amount { get; set; }
        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return Date.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
