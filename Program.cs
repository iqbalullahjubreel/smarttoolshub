// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


        Console.Write("Enter first word: ");
        string word1 = Console.ReadLine().ToLower();
        
        Console.Write("Enter second word: ");
        string word2 = Console.ReadLine().ToLower();

        bool areAnagrams = AreAnagrams(word1, word2);

        Console.WriteLine($"\"{word1}\" and \"{word2}\" are {(areAnagrams ? "anagrams" : "not anagrams")}.");

    static bool AreAnagrams(string word1, string word2)
    {
        if (word1.Length != word2.Length)
            return false;

        int[] charCount = new int[256]; // Assuming ASCII

        foreach (char c in word1)
            charCount[c]++;

        foreach (char c in word2)
            charCount[c]--;

        foreach (int count in charCount)
        {
            if (count != 0)
                return false;
        }

        return true;
    }




