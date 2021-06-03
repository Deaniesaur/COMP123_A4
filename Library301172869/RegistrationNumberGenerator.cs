using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library301172869
{
    public static class RegistrationNumberGenerator
    {
        private static uint nextRegistrationNumber = 1;
        
        public static uint GetNext()
        {
            return nextRegistrationNumber++;
        }
    }
}
