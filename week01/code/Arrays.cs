using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // The idea here is to create a new double array with the given length.
        // To then get all of the numbers in the right sequence we loop over the array and for every index we look at the
        // current number so if it is mutiples of 5, the first index would be 0 because 0 * 5 is still 0 we have to add
        // 1 to it every time. So it would be (0 + 1) * 5 = 5, index 1 would be (1 + 1) * 5 = 10, and so on, until
        // we reach the provided lenght. Each of these values are placed in their index of the array and then the array
        // returned.

        double[] numberArray = new double[length];
        for (var i = 0; i < length; ++i)
        {
            numberArray[i] = (i + 1) * number;
        }
        return numberArray;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // The idea here is to get the end range, or the amount, in this case that is given, in the list and save that as a new list.
        // We do the same thing for the start range of the given list. The difference is in the getRange, on the end we want to start
        // the lengh minus the amount and grab the ones that match the value of the amount so if it was 3, it would be the last 3
        // of the list. The start we start at 0 and then grab everything up to the lengh minus the amount so if the total was 10
        // it would be 7. After this we clear the current data list. We take everything that was in the "right" or end of the list
        // and put that in the data list, and then add what was in the "left" or start of the list. 

        List<int> end = data.GetRange(data.Count - amount, amount);
        List<int> start = data.GetRange(0, data.Count - amount);
        data.Clear();
        data.AddRange(end);
        data.AddRange(start);
    }

}
