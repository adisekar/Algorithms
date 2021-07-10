using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Graph.Grid
{
    public class WordSearch
    {
        // Word Search 1

        /*
     board =
[
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']
]

Given word = "ABCCED", return true.
Given word = "SEE", return true.
Given word = "ABCB", return false.     * */
        public static bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        if (DFS(board, i, j, word, 0))
                            return true;
                    }
                }
            }
            return false;
        }

        private static bool DFS(char[][] board, int i, int j, string word, int index)
        {

            if (index == word.Length)
            {
                return true;
            }
            // Check Boundary, and if current character matches word, or return false immediately
            if (i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[index])
            {
                return false;
            }

            // Mark current cell as empty for visited
            // Remember to store value, to add it back after recursion
            char temp = board[i][j];
            board[i][j] = '#';

            bool found = DFS(board, i + 1, j, word, index + 1) ||
                DFS(board, i - 1, j, word, index + 1) ||
                DFS(board, i, j + 1, word, index + 1) ||
                DFS(board, i, j - 1, word, index + 1);

            // Restore value of temp
            board[i][j] = temp;
            return found;
        }

        // Word Search 2
        /*
         * 
         * Input: 
        board = [
        ['o','a','a','n'],
        ['e','t','a','e'],
        ['i','h','k','r'],
        ['i','f','l','v']
        ]
        words = ["oath","pea","eat","rain"]

        Output: ["eat","oath"]
        */
        public IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> result = new List<string>();
            foreach (var word in words)
            {
                if (Exist(board, word))
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
