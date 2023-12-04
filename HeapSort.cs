namespace All_Sorting_Methods;

public class HeapSort
{
    private static SortingOrder _order;
    private static int _lastIndex;
    public int[] Sort(int[] arrayNum, SortingOrder order)
    {
        _order = order;
        _lastIndex = arrayNum.Length;
        switch (order)
        {
            case SortingOrder.Asc:
            {
                for (var i = 0; i < arrayNum.Length; i++)
                {
                    arrayNum = MaxHeap(arrayNum);
                    ShowArray("Max Heap[" + (i + 1) + "]", arrayNum);
                    arrayNum = Heapify(arrayNum);
                    ShowArray("Heapify[" + (i + 1) + "]", arrayNum);
                }

                ;
                break;
            }
            case SortingOrder.Desc:
            {
                for (var i = 0; i < arrayNum.Length; i++)
                {
                    arrayNum = MinHeap(arrayNum);
                    ShowArray("Min Heap[" + (i + 1) + "]", arrayNum);
                    arrayNum = Heapify(arrayNum);
                    ShowArray("Heapify[" + (i + 1) + "]", arrayNum);
                }
            }
                ;
                break;
        }

        return arrayNum;
    }
    
    private static int[] MinHeap(int[] arr){
        for (var i = _lastIndex; i > 1; i--)
        {
            var parent = (i / 2);
            var leftChild = (2 * parent);
            var rightChild = (2 * parent + 1);
            parent--;
            leftChild--;
            rightChild--;

            var hasRightChild = false;
            if (parent < _lastIndex)
            {
                // Console.WriteLine("P:" + arr[parent]);
            }
            if (leftChild < _lastIndex)
            {
                // Console.WriteLine("LC:" + arr[LChild]);
            }
            if (rightChild < _lastIndex)
            {
                // Console.WriteLine("RC:" + arr[RChild]);
                hasRightChild = true;
            }
            if (hasRightChild)
            {
                if (arr[parent] > arr[rightChild] && arr[rightChild] < arr[leftChild])
                {
                    (arr[parent], arr[rightChild]) = (arr[rightChild], arr[parent]);
                }
            }
            if (arr[parent] > arr[leftChild])
            {
                (arr[parent], arr[leftChild]) = (arr[leftChild], arr[parent]);
            }
        }

        return arr;
    }
    
    private static int[] MaxHeap(int[] arr){
        for (var i = _lastIndex; i > 1; i--){
            var parent = (i / 2);
            var leftChild = (2 * parent);
            var rightChild = (2 * parent + 1);
            parent--;
            leftChild--;
            rightChild--;
            
            var hasRightChild = false;
            if (parent < _lastIndex){
                // Console.WriteLine("P:" + arr[parent]);
            }
            if (leftChild < _lastIndex){
                // Console.WriteLine("LC:" + arr[LChild]);
                // hasLChild = true;
            }
            if (rightChild < _lastIndex){
                // Console.WriteLine("RC:" + arr[RChild]);
                hasRightChild = true;
            }
            if (hasRightChild){
                if (arr[parent] < arr[rightChild] & arr[rightChild] > arr[leftChild]){
                    (arr[parent], arr[rightChild]) = (arr[rightChild], arr[parent]);
                }
            }
            if (arr[parent] < arr[leftChild]){
                (arr[parent], arr[leftChild]) = (arr[leftChild], arr[parent]);
            }
        }

        return arr;
    }

    private static int[] Heapify(int[] arr){
        (arr[0], arr[_lastIndex - 1]) = (arr[_lastIndex - 1], arr[0]);
        _lastIndex--;
        return arr;
    }
    
    public void ShowArray(string prefix, int[] arr){
        Console.Write(prefix + ": ");
        foreach (var t in arr)
        {
            Console.Write(t + ", ");
        }
        Console.Write("\n");
    }
}