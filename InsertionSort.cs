namespace All_Sorting_Methods;

public class InsertionSort
{
    private static SortingArrangement _order;
    
    public int[] Sort(int[] arrayNum, SortingArrangement order)
    {
        _order = order;
        
        int[] newArray = (int[])arrayNum.Clone();

        for (int z = 1; z < newArray.Length; z++) {
            int current = newArray[z];
            int k = z - 1;
        
            // Ascending
            while (k >= 0 && newArray[k] > current && order == SortingArrangement.Ascending) {
                newArray = Swap(k+1, k, newArray);
                k--;
            }
        
            // Descending
            while (k >= 0 && newArray[k] < current && order == SortingArrangement.Descending) {
                newArray = Swap(k+1, k, newArray);
                k--;
            }
            
            newArray[k + 1] = current;
        }
        return newArray;
    }
    
    private static int[] Swap(int fnumIndex, int snumIndex, int[] arrayNum)
    {
        (arrayNum[fnumIndex], arrayNum[snumIndex]) = (arrayNum[snumIndex], arrayNum[fnumIndex]);
        return arrayNum;
    }
}