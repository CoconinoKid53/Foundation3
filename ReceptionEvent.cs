using System.ComponentModel.DataAnnotations;

public class ReceptionEvent : Event
{
    private string _rsvp;

   private List<string> _attendees = new List<string>();


    public ReceptionEvent(DateTime datetime, string eventDescription, List<string> registeredAttendees,
    Address address, string eventTitle, string eventType):
    base(datetime, eventDescription,   address,  eventTitle,  eventType)
    {
        _attendees = registeredAttendees;
    }

        public override void GetFullDetails()
    {
        base.GetFullDetails();
        Console.WriteLine("rsvp to table@rsvp.com");
    }

     public void AddRsvp( string email, string name)
     {
        _attendees.Add($"{email},{name}");
     }

     public void GetAttendees()
     {
        foreach(string attende in _attendees)
        {
            Console.WriteLine(attende);
        }
     }
}