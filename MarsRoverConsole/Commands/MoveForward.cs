using MarsRoverConsole.Interface;
using MarsRoverConsole.Data;

namespace MarsRoverConsole.Commands
{
    public class MoveForward : ICommand
    {
        /// <summary>
        /// Execute forward move
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public Coordinates Execute(Coordinates coordinates)
        {
            switch (coordinates.Direction)
            {
                case Directions.N:
                        coordinates.Y += 1;
                    break;

                case Directions.E:
                        coordinates.X += 1;
                    break;

                case Directions.S:
                        coordinates.Y -= 1;
                    break;

                case Directions.W:
                        coordinates.X -= 1;
                    break;
            }
            return coordinates;
        }
    }
}
