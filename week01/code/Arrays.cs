public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Process 1:
        // Step 1: create an array with enough space to store the length of multiples
        // Step 2: start looping through each position in the array at index 0
        // Step 3: multiply number by the index plus 1 to get the next multiple for each position in the array
        // Step 4: store the results in their respective position of the array
        // Step 5: return the completed array after finishing looping
        
        // Implementation:
        // Step 1: Create an array to store the multiples 
        double [] multiples = new double[length];

        // Step 2: Loop through each in the array  starting from index 0
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple for the current position in the array
            double multiple = number * (i + 1);

            // Step 4: Store the resulting multiple in the array
             multiples[i] = multiple;
        }

        // Return the array containing the multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Process 2:
        // Step 1: calculate the starting index of the elements to move
        // Step 2: keep a copy of the last amount of elements in a temporary list
        // Step 3: remove the actual elements from the original list
        // Step 4: insert the copied elements at the beginning of the original list
        // Step 5: the original list containing the elements rotated to the right is created

        // Implementation:
        // Step 1: Calculate the starting index of the elements to move
        int startIndex = data.Count - amount;

        // Step 2: Keep a copy of the last set of elements in a temporary list
        List <int> lastItems = data.GetRange(startIndex, amount);

        // Step 3: Remove the actual elements from the original list
        data.RemoveRange(startIndex, amount);

        // Step 4: Insert the copied elements at the beginning of the original list
        data.InsertRange(0, lastItems);

        // Step 5: The original list containing the elements rotated to the right is created
    }
}
