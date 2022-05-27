public class Converter {
    public Converter() {}

    // Converts word to list of letters in char and then to list, and returns it
    public List<string> ConvertWordToList(string randomWord) {
        char[] lettersList = randomWord.ToCharArray();
        var singleLetterList = lettersList.Select(c => c.ToString()).ToList();

        return singleLetterList;
    }
}