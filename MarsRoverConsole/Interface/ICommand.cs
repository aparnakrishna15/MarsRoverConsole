using MarsRoverConsole.Data;

namespace MarsRoverConsole.Interface
{
    /// <summary>
    /// Interface for commands
    /// </summary>
    public interface ICommand
    {

        /// <summary>
        /// execute rover rotation/movement
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public Coordinates Execute(Coordinates coordinates);

    }
}
