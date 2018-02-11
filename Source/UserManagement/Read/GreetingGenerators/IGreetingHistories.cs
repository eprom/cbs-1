using System;
using System.Collections.Generic;

namespace Read.GreetingGenerators
{
    public interface IGreetingHistories
    {
        GreetingHistory GetByPhoneNumber(string phoneNumber);

        void RemovePhoneNumber(string phoneNumber);
        
        void Save(GreetingHistory greetingHistory);
    }
}