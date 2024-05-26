using MediatR;

namespace Application.Features.Excerices.Queries
{
    //Message being thrown for mediatR to handle in IRequestHandler
    public class GetExerciseQuery : IRequest<ExcerciseListVm>
    {


    }
}
