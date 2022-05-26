public class Jumper {
    string randomWord;
    int count;
    public Jumper() {}

    public void StartGame() {
        var list = new List<string> { "  ____", @" /____\", @" \    /", @"  \  /", "   O", @"  /|\", @"  / \" };
        randomWord = this.getRandomWord();
        List<string> blankSpaces = new List<string>();
        count = list.Count;

        List<string> singleLetterList = this.convertWordToList(randomWord);

        foreach (string letter in singleLetterList) {
            blankSpaces.Add("_ ");
        }

        while (count > 3) {
            this.drawJumper(list);

            foreach (string item in blankSpaces) {
                Console.Write(item);
            }

            string letterEntered = this.getLetter(randomWord);

            if (!singleLetterList.Contains(letterEntered)) {
                list.RemoveAt(0);
            }

            if (singleLetterList.Contains(letterEntered)) {
                for (int i = 0; i < singleLetterList.Count; i++) {
                    if (singleLetterList[i] == letterEntered) {
                        blankSpaces[i] = letterEntered;
                    }
                }
            }
            
            if (!blankSpaces.Contains("_ ")) {
                this.drawJumper(list);
                foreach (string item in blankSpaces) {
                    Console.Write(item);
                }
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Congratulations! You won");
                return;
            }

            count = list.Count;
        }

        list[0] = "   X";
        this.drawJumper(list);
    }

    public string getRandomWord() {
        randomWord = new WordPicker().pickRandomWord();
        Console.WriteLine(randomWord);

        return randomWord;
    }

    public void drawJumper(List<string> list) {
        foreach (string item in list) {
             Console.WriteLine(item);
        }

        Console.WriteLine("^^^^^^^");
    }

    public string getLetter(string randomWord) {
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Guess a letter [a-z]: ");
        string letterGuessed = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("");

        return letterGuessed;
    }

    public List<string> convertWordToList(string randomWord) {
        char[] lettersList = randomWord.ToCharArray();
        var singleLetterList = lettersList.Select(c => c.ToString()).ToList();

        return singleLetterList;
    }
}