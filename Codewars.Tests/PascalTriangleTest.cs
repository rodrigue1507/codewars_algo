using NUnit.Framework;
using System.Collections.Generic;

namespace Codewars.Tests
{
    public class PascalTriangleTest
    {
        [TestCase( 5 )]
        public void PascalTriangle_works(int input)
        {
            List<int>  expected = new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1,1,4,6,4,1 };
            Assert.That(PascalTriangle.Generate(input), Is.EqualTo(expected));
        }
    }
}
