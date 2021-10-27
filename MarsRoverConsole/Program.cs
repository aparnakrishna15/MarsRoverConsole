using MarsRoverConsole.Interface;
using MarsRoverConsole.Model;
using MarsRoverConsole.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MarsRoverConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var PlateauSurfaceSize = Console.ReadLine();
            var currentLocation = Console.ReadLine();
            var movement = Console.ReadLine();

            //Added Serviece Dependencies
            var services = new ServiceCollection();
            services.AddSingleton<IRover, Rover>();
            services.AddSingleton<IMarsRoverService, MarsRoverService>();

            var _serviceProvider = services.BuildServiceProvider(true);
            var _rover = _serviceProvider.GetService<IRover>();

            _rover.RoverPosition = currentLocation;
            _rover.RoversPlateauSurfaceSize = PlateauSurfaceSize;

            var _marsRoverService = _serviceProvider.GetService<IMarsRoverService>();
            var coordinates = _marsRoverService.MoveRoverSync(movement);
            if (coordinates != null)
                Console.WriteLine(coordinates.X + " " + coordinates.Y + " " + coordinates.Direction);
            else
                Console.WriteLine("Bad Request");

           DisposeServices(_serviceProvider);
        }

        /// <summary>
        /// Dispose services
        /// </summary>
        /// <param name="_serviceProvider"></param>
        private static void DisposeServices(ServiceProvider _serviceProvider)
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
