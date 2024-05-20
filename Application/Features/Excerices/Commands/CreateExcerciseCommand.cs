using MediatR;

namespace Application.Features.Excerices.Commands
{
    public class CreateExcerciseCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string ExampleDescription { get; set; }
    }
}
