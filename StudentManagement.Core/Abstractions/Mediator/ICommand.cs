using MediatR;
using StudentManagement.Domain.Abstractions;

namespace StudentManagement.Core.Abstractions.Mediator;

public interface ICommand : IRequest<Result>, IBaseCommand
{

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{

}

public interface IBaseCommand
{

}