// Class that handles logic related to the jumper
public class Jumper {
    public Jumper() {}

    // Creates and returns a list with all the items to draw the jumper in the console
    public List<string> GetDrawingItems() {
        var list = new List<string> { "  ____", @" /____\", @" \    /", @"  \  /", "   O", @"  /|\", @"  / \" };

        return list;
    }

    // Gets the count of the items in the list above
    public int GetCount() {
        return this.GetDrawingItems().Count;
    }

    // Draws the jumper in the console according to the items contained in the list
    public void DrawJumper(List<string> list) {
        foreach (string item in list) {
             Console.WriteLine(item);
        }

        Console.WriteLine("^^^^^^^");
    }
}