using System.Text;

namespace ReverseString
{
  internal class Program
  {
    private static void Main()
    {
      // Get Input
      Console.WriteLine("Please enter an input: ");
      string? text = Console.ReadLine();

      // Create String Builder for efficient append operation in string
      StringBuilder stringBuilder = new();

      // Reverse String
      if (text is not null)
      {
        char[] chars = text.ToCharArray();

        for (int i = text.Length - 1; i >= 0; i--)
          stringBuilder.Append(chars[i]);

        // Print Result
        Console.WriteLine(stringBuilder);
      }
      else Console.WriteLine("Wrong input given!");
    }
  }
}