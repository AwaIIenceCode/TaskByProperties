using System;
class Achievement
{
    private readonly string _title;
    private bool _isUnlocked;

    public Achievement(string title, bool isUnlocked)
    {
        if (string.IsNullOrEmpty(title)) throw new ArgumentException("Title cannot be empty!");
        Title = title;
        IsUnlocked = isUnlocked;
    }
    public string Title { get; init; }
    public bool IsUnlocked { get; set; }
    public void Unlock()
    {
        IsUnlocked = true;
        Console.WriteLine($"Achievement '{Title}' unlocked!");
    }
    public void Print()
    {
        string status = IsUnlocked ? "Yes" : "No";
        Console.WriteLine($"Achievement: {Title}, Unlocked: {status}");
    }
}
class Program
{
    static void Main()
    {
        Achievement achievement_1 = new Achievement(title: "First Kill", isUnlocked: true);
        Achievement achievement_2 = new Achievement(title: "Explorer", isUnlocked: false);
        Achievement achievement_3 = new Achievement(title: "Strike while the iron is hot", isUnlocked: true);
        Achievement achievement_4 = new Achievement(title: "Shower me with diamonds", isUnlocked: false);

        Achievement[] titles = { achievement_1, achievement_2, achievement_3, achievement_4 };

        foreach (var title in titles)
        {
            title.Print();
        }
        
        Console.WriteLine();
        achievement_2.Unlock();
        achievement_2.Print();
    }
}