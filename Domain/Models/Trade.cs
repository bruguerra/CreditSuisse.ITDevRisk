using Domain.Interfaces;
using System;

namespace Domain.Models
{
    public class Trade : ITrade
    {
        public double _value;
        public string _clientSector;
        public DateTime _nextPaymentDate;
        public bool _isPoliticallyExposed;

        public double Value { get => _value; }
        public string ClientSector { get => _clientSector; }
        public DateTime NextPaymentDate { get => _nextPaymentDate; }
        //public bool IsPoliticallyExposed { get => _isPoliticallyExposed; }

        public Trade()
        {

        }

        public Trade(double value, string clientSector, DateTime nextPaymetDate)
        {
            _value = value;
            _clientSector = clientSector;
            _nextPaymentDate = nextPaymetDate;
        }
    }
}
