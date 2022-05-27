public class Player {
    string randomWord;
    int count;
    public Player() {}

    public void StartGame() {
        List<string> blankSpaces = new List<string>();

        Jumper jumper = new Jumper();
        WordPicker random = new WordPicker();
        Converter converter = new Converter();

        var list = jumper.GetDrawingItems();
        count = jumper.GetCount();

        randomWord = random.pickRandomWord();

        List<string> singleLetterList = converter.ConvertWordToList(randomWord);

        foreach (string letter in singleLetterList) {
            blankSpaces.Add("_ ");
        }

        while (count > 3) {
            jumper.DrawJumper(list);

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
                jumper.DrawJumper(list);
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
        jumper.DrawJumper(list);
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
}