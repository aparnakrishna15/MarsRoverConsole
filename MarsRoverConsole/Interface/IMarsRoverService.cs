using MarsRoverConsole.Data;

namespace MarsRoverConsole.Interface
{
    /// <summary>
    /// Interface for rover movement service
    /// </summary>
    public interface IMarsRoverService
    {
        /// <summary>
        /// Moves the rover in Sync
        /// </summary>
        /// <param name="maxPoints"></param>
        /// <param name="currentLocation"></param>
        /// <param name="movement"></param>
        /// <returns></returns>
        public Coordinates MoveRoverSync(string roverCommand);

    }
}
