namespace All_Sorting_Methods;

public enum SortingArrangement
{
    Ascending, Descending
}

public class AllSortMethods
{
    private static readonly HeapSort Hs = new HeapSort();
    private static readonly MergeSort Ms = new MergeSort();
    private static SortingArrangement _order;
    public static void Main()
    {
        Console.Write("How many items in the array: ");
        var totalNum = Convert.ToInt32(Console.ReadLine());
        var array = new int[totalNum];

        for (var i = 0; i < array.Length; i++)
        {
            Console.Write((i+1) + ": ");

            if (int.TryParse(Console.ReadLine(), out array[i]))
            {
                // add the number
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }

        Hs.DisplayArray("Unsorted Array", array);

        int _sortingMethod = 0;
        int _sortingOrder = 0;
        var success = false;
        
        // Lets user choose if 1 HEAP SORT or 2 MERGE SORT
        do
        {
            Console.WriteLine("Choose sorting method: ");
            Console.WriteLine("Enter 1 for HEAP SORT  | 2 for MERGE SORT");
            Console.Write("Choice: ");

            if (int.TryParse(Console.ReadLine(), out var sortingMethod))
            {
                _sortingMethod = sortingMethod;
                switch (sortingMethod)
                {
                    case 1:
                    {
                        Console.WriteLine("You chose HEAP SORT");
                        success = true;
                    };
                        break;
                    case 2:
                    {
                        Console.WriteLine("You chose MERGE SORT");
                        success = true;
                    };
                        break;
                    default:
                    {
                        Console.WriteLine("Invalid choice, please try again!");
                    };
                        break;
                }
            };
        } while (success == false);
        success = false; // reset the success variable

        // Lets user choose if 1 ASCENDING or 2 DESCENDING
        do
        {
            Console.WriteLine("Choose sorting order: ");
            Console.WriteLine("Enter 1 for ASCENDING  | 2 for DESCENDING");
            Console.Write("Choice: ");

            if (int.TryParse(Console.ReadLine(), out var sortingOrder))
            {
                _sortingOrder = sortingOrder;
                switch (sortingOrder)
                {
                    case 1:
                    {
                        Console.WriteLine("You chose ASCENDING");
                        _order = SortingArrangement.Ascending;
                        success = true;
                    };
                        break;
                    case 2:
                    {
                        Console.WriteLine("You chose DESCENDING");
                        _order = SortingArrangement.Descending;
                        success = true;
                    };
                        break;
                    default:
                    {
                        Console.WriteLine("Invalid choice, please try again!");
                    };
                        break;
                }
            };
        } while (success == false);
        
        // do the actual sorting based on user preferences
        if (_sortingMethod == 1)
        {
            // use heap sort
            var sortedArray = Hs.Sort(array, _order);
            Hs.DisplayArray("\nSorted Array", sortedArray);
        } 
        
        else if (_sortingMethod == 2)
        {
            // use merge sort
            var sortedArray = Ms.Sort(array, _order);
            Hs.DisplayArray("\nSorted Array", sortedArray);
        }
    }
}