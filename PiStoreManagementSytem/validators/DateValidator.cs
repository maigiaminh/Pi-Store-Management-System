namespace PiStoreManagementSytem.validators
{
    public class DateValidator : IStrategyValidator
    {
        public bool Validate(string input)
        {
            return DateTime.TryParse(input, out _);
        }
    }
}
