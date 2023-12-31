public class Solution 
{
    public int CalPoints(string[] operations) 
    {
        int sum = 0;

        int length = operations.Length;

        List<int> numbers = new List<int>();

        for (int i = 0; i < length; i++)
        {
            switch(operations[i])
            {
                case "+":
                    int previousTwo = numbers[numbers.Count - 1] + numbers[numbers.Count - 2];

                    numbers.Add(previousTwo);

                    break;

                case "D":
                    numbers.Add(numbers[numbers.Count - 1] * 2);

                    break;

                case "C":
                    numbers.Remove(numbers[numbers.Count - 1]);

                    break;

                default:
                    numbers.Add(int.Parse(operations[i]));

                    break;
            }
        }

        return numbers.Sum();
    }
}