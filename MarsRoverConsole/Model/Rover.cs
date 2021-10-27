using MarsRoverConsole.Interface;

namespace MarsRoverConsole.Model
{
    /// <summary>
    /// Rover
    /// </summary>
    public class Rover : IRover
    {
        private string _plateauSurfaceSize;
        private string _roverPosition;

        /// <summary>
        /// Rover's Plateau Surface Size
        /// </summary>
        public string RoversPlateauSurfaceSize { get => this._plateauSurfaceSize; set => this._plateauSurfaceSize = value; }

        /// <summary>
        /// Rover's Position
        /// </summary>
        public string RoverPosition { get => this._roverPosition; set => this._roverPosition = value; }

    }

}
