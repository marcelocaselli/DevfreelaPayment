﻿namespace Devfreela.Payments.API.Models
{
    public class PaymentInfoInputModel
    {
        public int Id { get; set; }
        public string CreditCardNumer { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAt { get; set; }
        public string FullName { get; set; }
        //public decimal Amount { get; set; }
    }
}


