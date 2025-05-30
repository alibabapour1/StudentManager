﻿using MediatR;
using StudentManagement.Domain.Abstractions;

namespace StudentManagement.Core.Abstractions.Mediator;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result> where TCommand : ICommand
{

}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{

}