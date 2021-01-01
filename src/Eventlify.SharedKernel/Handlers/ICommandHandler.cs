namespace Eventlify.SharedKernel.Handlers
{
    /// <summary>
    /// Handler to execute a command.
    /// </summary>
    /// <typeparam name="TCommand">Type of command to be executed.</typeparam>
    public interface ICommandHandler<in TCommand>
    {
        /// <summary>
        /// Executes a command.
        /// </summary>
        /// <param name="command">Command to be executed.</param>
        void Handle(TCommand command);
    }
}
