using System.Collections.Generic;

namespace botcamp_practice1.Auth.concrete
{
    public class StrategyDecisionFactory
    {
        public IList<IAuthenticationStrateg> GetStrategy(StrategyDecisionContext context){
            var stragyList = new List<IAuthenticationStrateg>();

            if(context.IsUpper){
                stragyList.Add(new UppercaseStrategy());
            }
            else if(context.IsConrainsAnyDigit){
                stragyList.Add(new DigitStrategy());
            }

            return stragyList;
        }
    }
}