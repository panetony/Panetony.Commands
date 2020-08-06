using Panetony.ProblemDetails;

namespace Panetony.Commands
{
    public abstract class Command : ICommand
    {
        public IProblemDetailValidation ProblemDetailValidation { get; set; } = new ProblemDetailValidation();
        public abstract bool IsValid();
    }
}
