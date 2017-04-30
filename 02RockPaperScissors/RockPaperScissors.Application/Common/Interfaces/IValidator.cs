namespace RockPaperScissors.Application.Common.Interfaces
{
    public interface IValidator
    {
        void Add(IValidateResult validation);
        void Validate();
    }
}