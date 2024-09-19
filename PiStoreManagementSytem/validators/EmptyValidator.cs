namespace PiStoreManagementSytem.validators
{
    public class EmptyValidator : IStrategyValidator
    {
        public bool Validate(string input)
        {
            return string.IsNullOrEmpty(input);
        }
    }
}
