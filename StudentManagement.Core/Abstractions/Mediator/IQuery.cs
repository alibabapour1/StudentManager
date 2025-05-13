using MediatR;
using StudentManagement.Domain.Abstractions;

namespace StudentManagement.Core.Abstractions.Mediator;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{

}