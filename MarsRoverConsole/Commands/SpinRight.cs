using MarsRoverConsole.Data;
using MarsRoverConsole.Interface;

namespace MarsRoverConsole.Commands
{
    public class SpinRight : ICommand
    {
        /// <summary>
        /// Execute right spin
        /// </summary>
        /// <returns></returns>
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Direction)
            {
                case Directions.N:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.S;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.W;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.N;
                    break;
            }
            return coordinates;
        }
    }
}
