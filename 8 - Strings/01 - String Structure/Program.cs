string[] phrases =  [ "simple word", "another word", "yet another word", "many more words" ];
        
string report = MaxVowelReportBuilder.Build(phrases);

Console.WriteLine(report);

static class MaxVowelReportBuilder
{
    // Time O(n), Space O(1)
    public static string Build(string[] phrases)
    {
        int totalPhrases = phrases.Length;
        int totalVowelCount = 0;
        int maxVowelCount = 0;
        string maxVowelPhrase = string.Empty;

        foreach (string currentPhrase in phrases)
        {
            int vowelCount = 0;

            foreach (char c in currentPhrase)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                    totalVowelCount++;
                }
            }

            if (vowelCount > maxVowelCount)
            {
                maxVowelCount = vowelCount;
                maxVowelPhrase = currentPhrase;
            }
        }

        // There are better ways to format a multi-line string, covered later in this section
        return $"Max Vowel Report\n" +
               "Total Phrase Count: " + totalPhrases + "\n" +
               "Total Vowel Count: " + totalVowelCount + "\n" +
               "Max Vowel Count: " + maxVowelCount + "\n" +
               "Max Vowel Phrase: " + maxVowelPhrase + "\n";
    }
}