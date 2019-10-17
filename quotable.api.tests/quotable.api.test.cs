using quotable.core;
using NUnit.Framework;
using quotable.api.Controllers;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            SimpleRandomQuoteProvider simple = new SimpleRandomQuoteProvider();
            QuoteController control = new QuoteController();

            int input = 2;
            var actual = control.Get(input);

            List<string> expected = new List<string>();
            expected.Add("1. We know what we are, but know not what we may be. By William Shakespeare");
            expected.Add("2. No act of kindness, no matter how small, is ever wasted. By Aesop");

            Assert.AreEqual(expected, actual);
        }
    }
}