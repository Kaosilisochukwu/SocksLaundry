using System;
using System.Collections.Generic;

namespace SocksLaundryLib
{
    public class ClassLib
    {

        //Do not delete or edit this method, you can only modify the block
        public int GetMaximumPairOfSocks(int noOfWashes, int[] cleanPile, int[] dirtyPile)
        {
            int maxPairs = 0;
            var listOfCleanPiles = new List<int>(cleanPile);
            var listOfDirtyPiles = new List<int>(dirtyPile);
            listOfCleanPiles.Sort();
            listOfDirtyPiles.Sort();



            for(int i = 0; i < listOfCleanPiles.Count; i += 1)
            {
                if(i < listOfCleanPiles.Count - 1 && listOfCleanPiles[i] == listOfCleanPiles[i+1])
                {
                    maxPairs += 1;
                    listOfCleanPiles.RemoveRange(i, 2);
                    i -= 1;
                }
            }

            for (int i = 0; i < listOfCleanPiles.Count; i += 1)
            {
                if (listOfDirtyPiles.Contains(listOfCleanPiles[i]) && noOfWashes > 0)
                {
                    maxPairs += 1;
                    noOfWashes -= 1;
                    listOfDirtyPiles.RemoveAt(listOfDirtyPiles.IndexOf(listOfCleanPiles[i]));
                    listOfCleanPiles.RemoveAt(i);
                    i -= 1;
                }
            }
            for (int i = 0; i < listOfDirtyPiles.Count; i += 1)
            {
                if (i < listOfDirtyPiles.Count - 1 && listOfDirtyPiles[i] == listOfDirtyPiles[i + 1] && noOfWashes > 1)
                {
                    maxPairs += 1;
                    listOfDirtyPiles.RemoveRange(i, 2);
                    noOfWashes -= 2;
                    i -= 1;
                }
            } 
            return maxPairs;
        }

        /**
         * You can create various helper methods
         * */
    }
}
