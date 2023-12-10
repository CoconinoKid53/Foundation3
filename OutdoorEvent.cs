public class OutDoorEvent: Event
{

    private string _forecast;

    public OutDoorEvent(DateTime datetime, string eventDescription, string forecast,
    Address address, string eventTitle, string eventType ):
    base(datetime, eventDescription,   address,  eventTitle,  eventType)
    {
       _forecast = forecast; 
    }

        public override void GetFullDetails()
    {
        base.GetFullDetails();
        Console.WriteLine($"{_forecast}");
    }

}