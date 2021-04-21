using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCoding
{
    public class Process
    {
        #region variables
        /// <summary>
        /// Count caracters
        /// </summary>
        private int countCaracter = 0;
        /// <summary>
        /// Sentence transformed
        /// </summary>
        private string resultSentence = String.Empty;
        /// <summary>
        /// List of caracters
        /// </summary>
        private List<char> listChar = new List<char>();
        #endregion

        #region Singleton
        /// <summary>
        /// Empty Contructor
        /// </summary>
        private Process() { }

        /// <summary>
        /// Instance
        /// </summary>
        private static Process _instance;

        /// <summary>
        /// Get instance
        /// </summary>
        /// <returns>Instance of the object</returns>
        public static Process GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Process();
            }
            return _instance;
        }

        #endregion
        /// <summary>
        /// Function that process the sentence
        /// </summary>
        /// <param name="inputParam">Sentence to process</param>
        /// <returns>The sentence processed</returns>
        public string transform (string inputParam)
        {

            foreach (char caracter in inputParam)
            {
                countCaracter = countCaracter + 1;
                if (Char.IsLetter(caracter))
                {
                    if (countCaracter == 1)
                    {
                        resultSentence = resultSentence + caracter.ToString();
                    }
                    else
                    {
                        listChar.Add(caracter);
                    }
                }
                else
                {
                    resultSentence = resultSentence + processSpace(listChar) + caracter.ToString();
                    
                    clearVariables();
                }
            }

            resultSentence = resultSentence + processSpace(listChar);

            return resultSentence;
        }

        #region Private methods
        /// <summary>
        /// Clear variables
        /// </summary>
        private void clearVariables()
        {
            this.countCaracter = 0;
            this.listChar = new List<char>();
        }

        /// <summary>
        /// Obtain the total of caracter between the first and last caracter and obtain the last caracter
        /// </summary>
        /// <param name="listCharParam">List of caracter</param>
        /// <returns>A string with the number of distinct caracter and the last letter of the word</returns>
        private string processSpace(List<char> listCharParam)
        {
            string result = string.Empty;
            char obtainCaracter = ' ';

            if (listCharParam.Count > 0)
            {
                obtainCaracter = listCharParam.Last();
                listCharParam.RemoveAt(listCharParam.Count - 1);

                result = listCharParam.Distinct().Count().ToString() + obtainCaracter.ToString();
            }

            return result;
        }
        #endregion
    }
}
