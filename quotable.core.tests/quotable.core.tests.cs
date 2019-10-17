using NUnit.Framework;
using quotable.core;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /// <summary>
        /// Tests the getQuotes method
        /// </summary>
        [Test]
        public void Test1()
        {
            SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider();
            int input = 1;
            List<string> expected = new List<string>();
            expected.Add("1. We know what we are, but know not what we may be. By William Shakespeare");
            var actual = simple.getQuotes(input);

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests the getSingleQuote method
        /// </summary>
        public void Test2()
        {
            SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider();
            int input = 2;
            List<string> expected = new List<string>();
            expected.Add("2. No act of kindness, no matter how small, is ever wasted. By Aesop");
            var actual = simple.getSingleQuote(input);

            Assert.AreEqual(expected, actual);
        }
    }
}