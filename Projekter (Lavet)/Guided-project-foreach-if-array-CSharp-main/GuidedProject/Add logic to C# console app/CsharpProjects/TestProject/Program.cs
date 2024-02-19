using System;

class Program
{
    static void Main()
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        for (int i = 0; i < myStrings.Length; i++)
        {
            string myString = myStrings[i];
            int periodLocation = myString.IndexOf(".");

            while (periodLocation != -1)
            {
                // Extract and display each sentence
                string sentence = myString.Substring(0, periodLocation + 1).TrimStart();
                Console.WriteLine(sentence);

                // Remove the displayed sentence from the string
                myString = myString.Remove(0, periodLocation + 1);

                // Find the next period location in the modified string
                periodLocation = myString.IndexOf(".");
            }

            // Display any remaining text in the string
            if (!string.IsNullOrWhiteSpace(myString))
            {
                Console.WriteLine(myString.Trim());
            }

            Console.WriteLine(); // Add a newline between each array element
        }
    }
}
