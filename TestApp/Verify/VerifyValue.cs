using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp.Verify
{
    class VerifyValue
    {
        private string _actual;
        public VerifyValue(string actual)
        {
            _actual = actual;
        }
        public void VerifyEquals(string value)
        {
            if (_actual == value)
            {
                Console.WriteLine("Actual number of vac is "+ _actual+". You enter " +value+". Sucess");
            }
            else
            {
                Console.WriteLine("Actual number of vac is " + _actual + ". You enter " + value + ". Failure");
            }
        }
    }
}
