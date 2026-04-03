string[] phrases =  [ "simple word", "another word", "yet another word", "many more words" ];
        
string report = MaxVowelReportBuilder.Build(phrases);

Console.WriteLine(report);

static class MaxVowelReportBuilder
{
    // O(n) time, O(1) space
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

        return $"""
        Max Vowel Report 
        Total Phrase Count: {totalPhrases} 
        Total Vowel Count: {totalVowelCount}
        Max Vowel Count: {maxVowelCount}
        Max Vowel Phrase: {maxVowelPhrase}
        """;
    }
}