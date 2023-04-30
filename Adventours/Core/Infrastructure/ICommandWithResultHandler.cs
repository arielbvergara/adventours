namespace Core.Infrastructure;

public interface ICommandWithResultHandler<in TCommand, TResult>
    where TCommand : ICommandWithResult<TResult>
{
    Task<TResult> HandleAsync(TCommand command);
}