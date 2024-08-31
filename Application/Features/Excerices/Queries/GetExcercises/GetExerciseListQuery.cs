using MediatR;

namespace Application.Features.Excerices.Queries.GetExcercises
{
    //Message being thrown for mediatR to handle in IRequestHandler
    public class GetExerciseListQuery : IRequest<List<ExcerciseDetailVM>>
    {


    }
}
