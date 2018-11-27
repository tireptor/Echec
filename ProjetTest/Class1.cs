using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjetTest
{
    public class Class1
    {
        int Add(int x, int y)
        {
            return x + y;
        }
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal(5, Add(2, 2));
        }
    }
}
