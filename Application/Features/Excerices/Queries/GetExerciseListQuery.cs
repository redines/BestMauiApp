using MediatR;

namespace Application.Features.Excerices.Queries
{
    //Message being thrown for mediatR to handle in IRequestHandler
    public class GetExerciseListQuery : IRequest<List<ExcerciseListVm>>
    {


    }
}
