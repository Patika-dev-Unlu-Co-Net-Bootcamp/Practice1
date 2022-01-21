using System;
using System.Linq;

namespace botcamp_practice1.Auth.concrete
{
    //En az bir upper case character içermeli
    public class UppercaseStrategy : IAuthenticationStrateg
    {
        public bool isValid(string authStr)
        {
            return authStr.Any(Char.IsUpper);
        }
    }
}