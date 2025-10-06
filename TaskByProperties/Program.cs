using System;
class Quest
{
    private readonly int _questId;
    private readonly string _questName;

    public Quest(int questId, string questName)
    {
        if (string.IsNullOrEmpty(questName)) throw new ArgumentException("Quest name cannot be empty!");
        this._questId = questId;
        this._questName = questName;
    }
    public int QuestId => _questId;
    public string QuestName => _questName;
    public string Describe() => $"Quest {QuestId}: {QuestName}";
    public void Print()
    {
        Console.WriteLine(Describe());
    }
}
class Program
{
    static void Main()
    {
        Quest quest_1 = new Quest(questId: 1, questName: "Slay the Dragon");
        Quest quest_2 = new Quest(questId: 2, questName: "Find the Treasure");
        
        quest_1.Print();
        quest_2.Print();
    }
}