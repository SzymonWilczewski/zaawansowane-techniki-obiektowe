using System;
using System.Diagnostics;

namespace LiskovSubstitutionPrinciple2
{
    public class CustomContract
    {
        public static void Requires<TException>(bool Predicate, string Message) where TException : Exception, new()
        {
            if (!Predicate)
            {
                Debug.WriteLine(Message);
                throw new TException();
            }
        }
    }
}
