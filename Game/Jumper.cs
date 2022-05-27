public class Jumper {
    public Jumper() {}

    public List<string> GetDrawingItems() {
        var list = new List<string> { "  ____", @" /____\", @" \    /", @"  \  /", "   O", @"  /|\", @"  / \" };

        return list;
    }

    public int GetCount() {
        return this.GetDrawingItems().Count;
    }

    public void DrawJumper(List<string> list) {
        foreach (string item in list) {
             Console.WriteLine(item);
        }

        Console.WriteLine("^^^^^^^");
    }
}