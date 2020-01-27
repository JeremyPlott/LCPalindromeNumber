//The problem actually asked for no strings at the end.
//in that case, something like this should work:

    //if num < 0 return false

    //int reversedNum = 0;

    //while (num < 0) 
    //{
        //num % 10 = digit
        //reversedNum = (reversedNum * 10) + digit;
        //num = num / 10
    //}
    //return (reversedNum == originalNum);



public class Solution
{
    public bool IsPalindrome(int x)
    {

        //cast the integer to a string so we can work with it easily
        var numberString = x.ToString();

        //this variable is only here to avoid typing numberString.Length over and over
        int stringLength = numberString.Length;

        var firstHalf = string.Empty;
        var secondHalf = string.Empty;

        //using modulus operator to check if it is an even or odd length
        if (stringLength % 2 == 0)
        {
            //.substring takes a string from the given starting/ending index
            //in this case, we're dividing the string in half.
            //if no second number is given it is taken as the starting index
            firstHalf = numberString.Substring(0, stringLength / 2);
            secondHalf = numberString.Substring(stringLength / 2);
        }
        else
        {
            //same as before but with +1 to account for the middle number
            //odd integers round down (ex: 3/2 = 1)
            firstHalf = numberString.Substring(0, stringLength / 2);
            secondHalf = numberString.Substring((stringLength / 2) + 1);
        }

        //now that we have the two halves, we will reverse one of them 
        //string.Concat() is necessary because .Reverse() works by using arrays.
        //It will return a character array, so concatenate returns it to a single string.
        var mirroredHalf = string.Concat(secondHalf.Reverse());

        //this will return a boolean
        return (firstHalf.Equals(mirroredHalf));
    }
}