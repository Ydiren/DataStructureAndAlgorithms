namespace DataStructuresAndAlgorithms.InsertionSort;

public sealed class InsertionSort
{
    /// <summary>
    /// Sorts the passed array using the insertion sort algorithm.
    /// The passed array is modified
    /// </summary>
    public List<int> Sort(List<int> array)
    {
        for (int startPosition = 1; startPosition < array.Count; startPosition++)
        {
            var currentPosition = startPosition - 1;
            var storedValue = array[startPosition];

            while (currentPosition > 0)
            {
                if (array[currentPosition] > storedValue)
                {
                    array[currentPosition + 1] = array[currentPosition];
                    --currentPosition;
                }
                else
                {
                    break;
                }
                
                array[currentPosition + 1] = storedValue;
            }
        }

        return array;
    }
}