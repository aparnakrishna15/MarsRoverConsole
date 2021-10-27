namespace MarsRoverConsole.Interface
{
    /// <summary>
    /// Interface for Rover
    /// </summary>
    public interface IRover
    {
        /// <summary>
        /// Rover's Plateau Surface Size
        /// </summary>
        public string RoversPlateauSurfaceSize { get; set; }

        /// <summary>
        /// Rover's Position
        /// </summary>
        public string RoverPosition { get; set; }

    }
}
