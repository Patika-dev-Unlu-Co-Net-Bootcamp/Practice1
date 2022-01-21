using System.Collections.Generic;
using System.Linq;
namespace botcamp_practice1.Controllers.Extensions
{
    public static class StringExtension
    {
        public static bool IsValid(this string s,IList<IAuthenticationStrateg> strategList){
            
            return strategList.All(x=>x.isValid(s));                    
        }
    }

}