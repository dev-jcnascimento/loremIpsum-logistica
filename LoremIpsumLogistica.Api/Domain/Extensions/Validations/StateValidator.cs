using System.ComponentModel.DataAnnotations;

namespace LoremIpsumLogistica.Api.Domain.Extensions.Validations
{
    public class StateValidator
    {
        public static string Validating(string state)
        {
            if (string.IsNullOrEmpty(state) || state.Length < 0)
            {
                throw new ValidationException("State cannot be empty");
            }
            if (state.Length < 2 || state.Length > 2)
            {
                throw new ValidationException("State must contain 2 characters");
            }
            if (state.Any(x => char.IsNumber(x) || char.IsWhiteSpace(x) || char.IsSymbol(x)))
            {
                throw new ValidationException("State cannot contain numbers and special characters");
            }
            return state;
        }
    }
}
