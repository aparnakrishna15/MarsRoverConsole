using MarsRoverConsole.Commands;
using MarsRoverConsole.Data;
using MarsRoverConsole.Interface;
using MarsRoverConsole.Model;
using MarsRoverConsole.Service;
using System;
using Xunit;

namespace MarsRoverXUnitTest
{
    public class MarsRoverTest
    {
        [Theory]
        [InlineData(new object[] { "5 5", "1 2 N", "LMLMLMLMM", 1, 3, Directions.N })]
        [InlineData(new object[] { "5 5", "3 3 E", "MMRMMRMRRM", 5, 1, Directions.E })]
        public void MarsRoverServiceTest_ShouldRun(string plateauSurfaceSize, string roverPosition, string roverCommand, int expectedX, int exceptedY, Directions direction)
        {
            //Arrange
            IRover rover = new Rover() {
                RoverPosition = roverPosition,
                RoversPlateauSurfaceSize = plateauSurfaceSize 
            };
            MarsRoverService marsRoverService = new MarsRoverService(rover);

            //Act
            var coordinates = marsRoverService.MoveRoverSync(roverCommand);

            //Assert
            Assert.Equal(expectedX, coordinates.X);
            Assert.Equal(exceptedY, coordinates.Y);
            Assert.Equal(direction, coordinates.Direction);

        }

        [Theory]
        [InlineData(Directions.N)]
        [InlineData(Directions.E)]
        [InlineData(Directions.S)]
        [InlineData(Directions.W)]
        public void MoveForward_ShouldRun(Directions directions)
        {
            //Arrange
            var coordinates = GetMockCoordinatesData();
            MoveForward moveForward = new MoveForward();

            switch (directions)
            {
                case Directions.N:
                    coordinates.Direction = Directions.N;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.W;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.S;
                    break;
            }

            //Act
            var result = moveForward.Execute(coordinates);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(coordinates, result);

        }

        [Theory]
        [InlineData(Directions.N)]
        [InlineData(Directions.E)]
        [InlineData(Directions.S)]
        [InlineData(Directions.W)]
        public void SpinRight_ShouldRun(Directions directions)
        {
            //Arrange
            var coordinates = GetMockCoordinatesData();
            SpinRight spinRight = new SpinRight();

            switch (directions)
            {
                case Directions.N:
                    coordinates.Direction = Directions.N;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.S;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.W;
                    break;
            }

            //Act
            var result = spinRight.Execute(coordinates);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(coordinates, result);
        }

        [Theory]
        [InlineData(Directions.N)]
        [InlineData(Directions.E)]
        [InlineData(Directions.S)]
        [InlineData(Directions.W)]
        public void SpinLeft_ShouldRun(Directions directions)
        {
            //Arrange
            var coordinates = GetMockCoordinatesData();
            SpinLeft spinLeft = new SpinLeft();

            switch (directions)
            {
                case Directions.N:
                    coordinates.Direction = Directions.N;
                    break;

                case Directions.E:
                    coordinates.Direction = Directions.E;
                    break;

                case Directions.S:
                    coordinates.Direction = Directions.S;
                    break;

                case Directions.W:
                    coordinates.Direction = Directions.W;
                    break;
            }

            //Act
            var result = spinLeft.Execute(coordinates);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(coordinates, result);
        }

        private Coordinates GetMockCoordinatesData()
        {
            return new Coordinates()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };
        }
    }
}
