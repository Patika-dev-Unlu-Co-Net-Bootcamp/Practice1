using System;
using System.Linq;

namespace botcamp_practice1.Auth.concrete
{
    public class DigitStrategy : IAuthenticationStrateg
    {
        public bool isValid(string authStr)
        {
            return authStr.Any(Char.IsDigit);
        }
    }
}