using Microsoft.VisualStudio.TestTools.UnitTesting;
using String_Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Converter.Tests
{
    [TestClass()]
    public class NumberConverterTests
    {
        [TestMethod()]
        public void RoundUpTest()
        {
            //Arrange
            NumberConverter numberConverter = new NumberConverter();

            //Act
            float number = numberConverter.RoundUp(3.2);

            //Assert
            Assert.AreEqual(4, number);

        }

        [TestMethod()]
        public void RoundDownTest()
        {
            //Arrange
            NumberConverter numberConverter = new NumberConverter();

            //Act
            float number = numberConverter.RoundDown(3.2);

            //Assert
            Assert.AreEqual(3, number);
        }


    }
}