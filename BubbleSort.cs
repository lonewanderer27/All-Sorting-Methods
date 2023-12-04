namespace All_Sorting_Methods;

public class BubbleSort
{
    private static SortingArrangement _order;
    
    public int[] Sort(int[] arrayNum, SortingArrangement order)
    {
        _order = order;
        
        int[] newArray = (int[])arrayNum.Clone();

        int n = newArray.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {           
                // skip if the numbers are the same
                if (newArray[j] == newArray[j + 1])
                    continue;
            
                // Ascending
                if (newArray[j] > newArray[j + 1] && order == SortingArrangement.Ascending) {
                    newArray = Swap(j, j + 1, newArray);
                    continue;
                }

                // Descending
                if (newArray[j] < newArray[j + 1] && order == SortingArrangement.Descending) {
                    newArray = Swap(j, j + 1, newArray);
                    continue;
                }
            }
        }
        
        return newArray;
    }
    
    private static int[] Swap(int fnumIndex, int snumIndex, int[] arrayNum)
    {
        (arrayNum[fnumIndex], arrayNum[snumIndex]) = (arrayNum[snumIndex], arrayNum[fnumIndex]);
        return arrayNum;
    }
}