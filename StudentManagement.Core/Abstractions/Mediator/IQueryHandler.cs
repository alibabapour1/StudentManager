using MediatR;
using StudentManagement.Domain.Abstractions;

namespace StudentManagement.Core.Abstractions.Mediator;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>> where TQuery : IQuery<TResponse>
{

}