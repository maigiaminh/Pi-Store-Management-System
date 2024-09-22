namespace PiStoreManagementSytem.validators
{
    public class PhoneValidator : IStrategyValidator
    {
        public bool Validate(string input)
        {
            return (int.TryParse(input, out _) && input.Length == 10);
        }
    }
}
