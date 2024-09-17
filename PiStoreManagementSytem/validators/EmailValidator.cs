namespace PiStoreManagementSytem.validators
{
    public class EmailValidator : IStrategyValidator
    {
        public bool Validate(string input)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }
    }
}
