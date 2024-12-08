using MediatR;

namespace Application.Features.Excerices.Queries.GetExcercises
{
    //Message being thrown for mediatR to handle in IRequestHandler
    public class GetExerciseQuery : IRequest<ExcerciseDetailVM>
    {
        public Guid ExcerciseId { get; set; }
    }
}
