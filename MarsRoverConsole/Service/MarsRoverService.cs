using MarsRoverConsole.Interface;
using System;
using MarsRoverConsole.Commands;
using MarsRoverConsole.Data;
using MarsRoverConsole.Helper;

namespace MarsRoverConsole.Service
{
    /// <summary>
    /// Rover's Service Class
    /// </summary>
    public class MarsRoverService : IMarsRoverService
    {
        private readonly PlateauSurfaceSize _plateauSurfaceSize;
        private readonly string _roverPosition;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rover"></param>
        public MarsRoverService(IRover rover)
        {
            _roverPosition = rover.RoverPosition;
            _plateauSurfaceSize = new PlateauSurfaceSize()
            {
                Height = Convert.ToInt32(rover.RoversPlateauSurfaceSize.Split(" ")[0]),
                Width = Convert.ToInt32(rover.RoversPlateauSurfaceSize.Split(" ")[1])
            };

        }

        /// <summary>
        /// Moves the Rover with the provided command
        /// </summary>
        /// <param name="roverCommand"></param>
        /// <returns></returns>
        public Coordinates MoveRoverSync(string roverCommand)
        {
            var coordinates = InitializeCoordinates();
            if (IsRoverInsideBoundaries(coordinates))
            {
                var movements = roverCommand.ToCharArray();
         
                ICommand command;
                foreach (var movement in movements)
                {
                    switch (movement)
                    {
                        case 'L':
                            command = new SpinLeft();
                            break;

                        case 'R':
                            command = new SpinRight();
                            break;

                        case 'M':
                            command = new MoveForward();
                            break;

                        default:
                            return null;
                    }
                    var result = command.Execute(coordinates);

                    if (result == null) return null;

                    coordinates.Direction = result.Direction;
                    coordinates.X = result.X;
                    coordinates.Y = result.Y;
                }
            }
            return coordinates;
        }

        /// <summary>
        /// Initializing the coordinates
        /// </summary>
        /// <returns></returns>
        private Coordinates InitializeCoordinates()
        {
            return new Coordinates()
            {
                X = Convert.ToInt32(_roverPosition.Split(" ")[0]),
                Y = Convert.ToInt32(_roverPosition.Split(" ")[1]),
                Direction = _roverPosition.Split(" ")[2].ToEnumValue<Directions>()
            };
        }

        /// <summary>
        /// Check if rover is within the permited boundries
        /// </summary>
        /// <param name="roverCoordinates"></param>
        /// <returns></returns>
        private bool IsRoverInsideBoundaries(Coordinates roverCoordinates)
        {

            if (roverCoordinates.X > _plateauSurfaceSize.Width ||
                roverCoordinates.X < 0 ||
                roverCoordinates.Y > _plateauSurfaceSize.Height ||
                roverCoordinates.Y < 0)
            {
                return false;
            }

            return true;
        }
    }

}
