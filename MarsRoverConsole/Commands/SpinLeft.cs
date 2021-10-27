using MarsRoverConsole.Data;
using MarsRoverConsole.Interface;

namespace MarsRoverConsole.Commands
{
    public class SpinLeft : ICommand
    {
        /// <summary>
        /// Execute left spin
        /// </summary>
        /// <returns></returns>
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Direction)
            {
                case Directions.N:
                    coordinates.Direction = Directions.W;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.N;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.S;
                    break;
            }
            return coordinates;
        }
    }
}
