using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Arrays
{
    public class SearchSuggestions
    {
        /*
         * Given an array of strings products and a string searchWord. We want to design a system that suggests at most three product names from products after each character of searchWord is typed. Suggested products should have common prefix with the searchWord. If there are more than three products with a common prefix return the three lexicographically minimums products.

Return list of lists of the suggested products after each character of searchWord is typed. 

 

Example 1:

Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
Output: [
["mobile","moneypot","monitor"],
["mobile","moneypot","monitor"],
["mouse","mousepad"],
["mouse","mousepad"],
["mouse","mousepad"]
]
Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"]
After typing m and mo all products match and we show user ["mobile","moneypot","monitor"]
After typing mou, mous and mouse the system suggests ["mouse","mousepad"]
         */
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            IList<IList<string>> result = new List<IList<string>>();
            StringBuilder searchStr = new StringBuilder();
            var filteredProducts = products.OrderBy(prod => prod).ToList();
            for (int i = 0; i < searchWord.Length; i++)
            {
                //string searchStr = searchWord.Substring(0, i + 1);
                searchStr.Append(searchWord[i]);
                IList<string> currentList = new List<string>();
                foreach (var product in filteredProducts)
                {
                    if (product.StartsWith(searchStr.ToString()))
                    {
                        currentList.Add(product);
                    }
                }
                result.Add(currentList.Take(3).ToList());
            }
            return result;
        }
    }
}
