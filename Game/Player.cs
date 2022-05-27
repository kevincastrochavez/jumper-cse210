public class Player {
    string randomWord;
    int count;
    public Player() {}

    public void StartGame() {
        List<string> blankSpaces = new List<string>();

        // Creates instances of clases
        Jumper jumper = new Jumper();
        WordPicker random = new WordPicker();
        Converter converter = new Converter();

        var list = jumper.GetDrawingItems();
        count = jumper.GetCount();

        randomWord = random.pickRandomWord();

        List<string> singleLetterList = converter.ConvertWordToList(randomWord);

        // Creates list with underscores according to random word
        foreach (string letter in singleLetterList) {
            blankSpaces.Add("_ ");
        }

        // Loop while jumper has not died
        while (count > 3) {
            jumper.DrawJumper(list);

            // Displays the underscores in the console
            foreach (string item in blankSpaces) {
                Console.Write(item);
            }

            string letterEntered = this.getLetter(randomWord);

            // If user did not guessed letter, removes an item from the list that draws jumper
            if (!singleLetterList.Contains(letterEntered)) {
                list.RemoveAt(0);
            }

            // If letter is contained in the word, replaces the underscore in the place that belongs
            if (singleLetterList.Contains(letterEntered)) {
                for (int i = 0; i < singleLetterList.Count; i++) {
                    if (singleLetterList[i] == letterEntered) {
                        blankSpaces[i] = letterEntered;
                    }
                }
            }
            
            // If there's no more underscores, draws the jumper for the last time, 
            // shows the complete word and message that player won
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

            // Updates count in list that draws jumper
            count = list.Count;
        }

        // If player loses, replaces the head with an 'X' and draws jumper for the last time
        // Game finishes at this point
        list[0] = "   X";
        jumper.DrawJumper(list);
    }

    // Gets the letter from the user in the console and throws some empty lines
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