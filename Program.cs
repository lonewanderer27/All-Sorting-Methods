namespace All_Sorting_Methods;

public enum SortingOrder
{
    Asc, Desc
}

public abstract class SortingMethods
{
    private static HeapSort Hs;
    private static MergeSort Ms;
    private static SelectionSort Ss;
    private static SortingOrder _order;
    public static void Main()
    {
        // initialize the sorting methods
        Hs = new HeapSort();
        Ms = new MergeSort();
        Ss = new SelectionSort();
        
        // get the total number of items to be sorted
        Console.Write("How many items: ");
        var totalNum = Convert.ToInt32(Console.ReadLine());
        var array = new int[totalNum];

        for (var i = 0; i < array.Length; i++)
        {
            Console.Write((i+1) + ": ");

            if (int.TryParse(Console.ReadLine(), out array[i]))
            {
                // the number is successfully added through out in TryParse above
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--;
            }
        }

        Hs.ShowArray("Initial Array", array);

        int _sortingMethod = 0;
        int _sortingOrder = 0;
        var success = false;
        
        // Lets user choose if 1 HEAP SORT or 2 MERGE SORT
        do
        {
            Console.WriteLine("Choose sorting method: ");
            Console.WriteLine("Enter 0 for HEAP SORT  | 1 for MERGE SORT | 2 for SELECTION SORT: ");

            if (int.TryParse(Console.ReadLine(), out var sortingMethod))
            {
                _sortingMethod = sortingMethod;
                switch (sortingMethod)
                {
                    case 0: success = true;
                        break;
                    case 1:
                        success = true;
                        break;
                    case 2:
                        success = true;
                        break;
                    default: Console.WriteLine("Invalid number, please try again!");
                        break;
                }
            };
        } while (success == false);
        success = false; // reset the success variable

        // Lets user choose if 1 ASCENDING or 2 DESCENDING
        do
        {
            Console.WriteLine("Choose sorting order: ");
            Console.WriteLine("Enter 0 for ASCENDING  | 1 for DESCENDING: ");

            if (int.TryParse(Console.ReadLine(), out var sortingOrder))
            {
                switch (sortingOrder)
                {
                    case 0:
                    {
                        _order = SortingOrder.Asc;
                        success = true;
                    };
                        break;
                    case 1:
                    {
                        _order = SortingOrder.Desc;
                        success = true;
                    };
                        break;
                    default: Console.WriteLine("Invalid number, please try again!");
                        break;
                }
            };
        } while (success == false);

        switch (_sortingMethod)
        {
            // do the actual sorting based on user preferences
            case 0:
            {
                // use heap sort
                var sortedArray = Hs.Sort(array, _order);
                Hs.ShowArray("\nSorted", sortedArray);
                break;
            }
            case 1:
            {
                // use merge sort
                var sortedArray = Ms.Sort(array, _order);
                Hs.ShowArray("\nSorted", sortedArray);
                break;
            }
            case 2:
            {
                // use selection sort
                var sortedArray = Ss.Sort(array, _order);
                Hs.ShowArray("\nSorted", sortedArray);
                break;
            }
        }
    }
}