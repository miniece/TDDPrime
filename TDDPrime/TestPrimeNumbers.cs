using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDPrime
{
    public class TestPrimeNumbers
    {
        [Fact]
        public void Testing()
        {

            PrimeNumbers p = new PrimeNumbers();
            int expected = 11;


            int actual = p.GetPrimenNum(4);


            Assert.Equal(expected, actual);
        }
    }
}
