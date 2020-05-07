using Prism.Commands;

namespace Commands.Core
{
    public interface IApplicationCommands
    {
        CompositeCommand SaveCommand { get; }
        CompositeCommand SaveIActiveAwareCommand { get; }
    }

    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand SaveCommand { get; } = new CompositeCommand();

        public CompositeCommand SaveIActiveAwareCommand { get; } = new CompositeCommand(true);
    }
}
