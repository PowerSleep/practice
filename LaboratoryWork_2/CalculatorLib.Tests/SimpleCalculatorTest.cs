using System;
using System.Collections.Generic;
using Xunit;

namespace CalculatorLib.Tests
{
    public class SimpleCalculatorTest
    {
        [Fact]
        public void SimpleCalculator_Calculate_AdditionOperation_Calculated()
        {
            //Arrange
            List<IOperation> operations = new List<IOperation>
            {
                new AdditionOperation()
            };

            SimpleCalculator simpleCalculator = new SimpleCalculator( operations );

            //Act
            int result = simpleCalculator.Calculate( "2+2" );

            //Assert
            Assert.Equal( 4, result );
        }

        [Fact]
        public void SimpleCalculator_Calculate_SubstructionOperation_Calculated()
        {
            //Arrange
            List<IOperation> operations = new List<IOperation>
            {
                new SubstractionOperation()
            };

            SimpleCalculator simpleCalculator = new SimpleCalculator( operations );

            //Act
            int result = simpleCalculator.Calculate( "2-3" );

            //Assert
            Assert.Equal( -1, result );
        }

        [Fact]
        public void SimpleCalculator_Calculate_MultiplicationOperation_Calculated()
        {
            //Arrange
            List<IOperation> operations = new List<IOperation>
            {
                new MultiplicationOperation()
            };

            SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

            //Act
            int result = simpleCalculator.Calculate( "5*2" );

            //Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void SimpleCalculator_Calculate_ExponentiationOperation_Calculated()
        {
            //Arrange
            List<IOperation> operations = new List<IOperation>
            {
                new ExponentiationOperation()
            };

            SimpleCalculator simpleCalculator = new SimpleCalculator(operations);

            //Act
            int result = simpleCalculator.Calculate( "5^2" );

            //Assert
            Assert.Equal(25, result);
        }
    }
}
