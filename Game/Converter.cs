public class Converter {
    public Converter() {}

    public List<string> ConvertWordToList(string randomWord) {
        char[] lettersList = randomWord.ToCharArray();
        var singleLetterList = lettersList.Select(c => c.ToString()).ToList();

        return singleLetterList;
    }
}