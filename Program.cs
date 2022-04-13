﻿using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Gernerator");
          
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
           
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            double fare2 = invoice.CalculateFare(2.0, 5);
            Console.WriteLine("The total fare for Premium Ride is :" + fare);
           Console.WriteLine("The total fare for Normal Ride is :" + fare2);
        }
    }
}