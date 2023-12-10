public class LectureEvent : Event
{
    int _capacity;
    private string _speakerName;

    
    // This is like the grocer that receives the goods
    public LectureEvent(DateTime datetime, string eventDescription, int capacity,
    Address address, string eventTitle, string eventType, string speakerName):
    base(datetime, eventDescription, address, eventTitle, eventType)
    
    {
        _capacity = capacity;
        _speakerName = speakerName;
    }

    public override void GetFullDetails()
    {
        base.GetFullDetails();
        Console.WriteLine($"{_speakerName},{_capacity}");
    }


}