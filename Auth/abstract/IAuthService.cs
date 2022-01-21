
using botcamp_practice1.Auth.concrete;
using botcamp_practice1.Controllers.Extensions;

public interface IAuthService
{
    bool Auth(string str);
}

public class AuthService : IAuthService
{
    public bool Auth(string str)
    {
        var factory = new StrategyDecisionFactory();
        var decisionContext = new StrategyDecisionContext()
        {
            IsUpper = false,
            IsConrainsAnyDigit = true
        };

        var strategyList = factory.GetStrategy(decisionContext);
        return str.IsValid(strategyList);
    }
}
