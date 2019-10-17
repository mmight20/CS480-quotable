using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// Implements the RandomQuoteProveider interface
    /// contains a method that returns a list of quotes based on the number of quotes that are requested
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        /// <summary>
        /// /// This method accepts a long that represents the number of quotes the user wants
        /// It will retun a list of quotes
        /// </summary>
        /// <param name="numOfQuotes">A long that represesnts the number of quotes the user wants</param>
        /// <returns>An IEnumberable string list of quotes with their IDs and atuhors</returns>
        public IEnumerable<string> getQuotes(long numOfQuotes)
        {
            List<string> myQuotes = new List<string>();

            switch (numOfQuotes)
            {
                case 1:
                    myQuotes.Add("1. We know what we are, but know not what we may be. By William Shakespeare");
                    break;
                case 2:
                    myQuotes.Add("1. We know what we are, but know not what we may be. By William Shakespeare");
                    myQuotes.Add("2. No act of kindness, no matter how small, is ever wasted. By Aesop");
                    break;
                case 3:
                    myQuotes.Add("1. We know what we are, but know not what we may be. By William Shakespeare");
                    myQuotes.Add("2. No act of kindness, no matter how small, is ever wasted. By Aesop");
                    myQuotes.Add("3. You must do the things you think you cannot do. By Eleanor Roosevelt");
                    break;
                default:
                    myQuotes.Add("");
                    break;
            }
            
            return myQuotes;

            throw new NotImplementedException();
        }

        /// <summary>
        /// returns a single quote based on the id number passed in
        /// </summary>
        /// <param name="num">The ID number of the quote</param>
        /// <returns>An IEnumerable string of the desired quote</returns>
        public IEnumerable<string> getSingleQuote(int num)
        {
            List<string> myQuotes = new List<string>();

            switch (num)
            {
                case 1:
                    myQuotes.Add("1. We know what we are, but know not what we may be. By William Shakespeare");
                    break;
                case 2:
                    myQuotes.Add("2. No act of kindness, no matter how small, is ever wasted. By Aesop");
                    break;
                case 3:
                    myQuotes.Add("3. You must do the things you think you cannot do. By Eleanor Roosevelt");
                    break;
                default:
                    myQuotes.Add("");
                    break;
            }

            return myQuotes;

            throw new NotImplementedException();
        }
    }
}
