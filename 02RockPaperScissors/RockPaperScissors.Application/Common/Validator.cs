using RockPaperScissors.Application.Common.Interfaces;
using System.Collections.Generic;

namespace RockPaperScissors.Application.Common
{
    public class Validator : IValidator
    {
        private List<IValidateResult> listValidations;
       
        public Validator()
        {
            listValidations = new List<IValidateResult>();
        }

        public void Add(IValidateResult validation)
        {
            listValidations.Add(validation);
        }

        public void Validate()
        {
            listValidations.ForEach(x =>
            {
                x.Validate();
            });
        }
        
    }
}
