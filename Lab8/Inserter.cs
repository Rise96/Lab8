using System.Collections.Generic;

namespace Lab8
{
    class Inserter
    {
        public List<List<int>> Insert(List<List<int>> array)
        {
            List<int> lineWithMax = FindLineWithMaxPositiveNumber(array);

            int n = array.Count;
            for(int i = 0; i < n; i++)
            {
                if (IsItContainsNegativeOddNumber(array[i]))
                {
                    array.Insert(i+1,lineWithMax);
                    i++;
                    n++;
                }
            }
            return array;
        }

        private List<int> FindLineWithMaxPositiveNumber(List<List<int>> array)
        {
            int numberOfLine = 0;
            int maxPositiveNumber = 0;
            for(int i = 0; i < array.Count; i++)
            {
                for(int j = 0; j < array.Count; j++)
                {
                    if (array[i][j] > maxPositiveNumber)
                    {
                        maxPositiveNumber = array[i][j];
                        numberOfLine = i;
                    }
                }
            }
            return array[numberOfLine];
        }

        private bool IsItContainsNegativeOddNumber(List<int> array)
        {
            for(int i = 0; i < array.Count; i++)
            {
                if (array[i] < 0 && array[i] % 2 != 0)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
