namespace All_Sorting_Methods;

public class SelectionSort
{
    private static SortingOrder _order;

    public int[] Sort(int[] arrayNum, SortingOrder order)
    {
        _order = order;
        
        int[] newArray = (int[])arrayNum.Clone();
        
        int dex;
        int tar;

        for (int simul = 0; simul < arrayNum.Length - 1; simul++)
        {
            dex = simul;
            tar = dex;
            
            for (int inn = simul + 1; inn < arrayNum.Length; inn++)
            {
                // skip if the numbers are the same
                if (newArray[tar] == newArray[inn])
                    continue;
                
                // Ascending
                if (newArray[tar] > newArray[inn] && order == SortingOrder.Asc)
                {
                    tar = inn;
                    continue;
                }

                // Descending
                if (newArray[tar] < newArray[inn] && order == SortingOrder.Desc)
                {
                    tar = inn;
                    continue;
                }
                
                newArray = Swap(dex, tar, newArray);
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