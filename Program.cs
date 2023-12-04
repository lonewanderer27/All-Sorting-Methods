namespace All_Sorting_Methods;

public enum SortingArrangement
{
    Ascending, Descending
}

public class AllSortMethods
{
    private static readonly BubbleSort Bs = new BubbleSort();
    private static readonly HeapSort Hs = new HeapSort();
    private static readonly MergeSort Ms = new MergeSort();
    private static readonly InsertionSort Is = new InsertionSort();
    private static readonly SelectionSort Ss = new SelectionSort();
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
            Console.WriteLine("1 for HEAP SORT\n2 for MERGE SORT\n3 for INSERTION SORT\n4 for SELECTION SORT\n5 for BUBBLE SORT");
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
                    case 3:
                    {
                        Console.WriteLine("You chose INSERTION SORT");
                        success = true;
                    };
                        break;
                    case 4:
                    {
                        Console.WriteLine("You chose SELECTION SORT");
                        success = true;
                    };
                        break;
                    case 5:
                    {
                        Console.WriteLine("You chose BUBBLE SORT");
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
        
        else if (_sortingMethod == 3)
        {
            // use selection sort
            var sortedArray = Ss.Sort(array, _order);
            Hs.DisplayArray("\nSorted Array", sortedArray);
        }
        
        else if (_sortingMethod == 4)
        {
            // use insertion sort
            var sortedArray = Is.Sort(array, _order);
            Hs.DisplayArray("\nSorted Array", sortedArray);
        }
        
        else if (_sortingMethod == 5)
        {
            // use bubble sort
            var sortedArray = Bs.Sort(array, _order);
            Hs.DisplayArray("\nSorted Array", sortedArray);
        }
        
        else
        {
            Console.WriteLine("Invalid choice, please try again!");
        }
    }
}