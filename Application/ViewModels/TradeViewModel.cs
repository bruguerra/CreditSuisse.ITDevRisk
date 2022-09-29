using System;

namespace Application.ViewModels
{
    public class TradeViewModel
    {
        public double Value { get; set; }
        public string ClientSector { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public string Category { get; set; }
        // public bool IsPoliticallyExposed { get; set; }
    }
}
