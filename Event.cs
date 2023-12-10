using System.ComponentModel;
using System.Dynamic;

public abstract class Event
{
 
    protected string _eventTitle;

    protected string _eventDescription;
    
    protected string _address;

 

    protected string _eventType;


    protected string _eventDate;

    protected int _eventTime;


    

     protected TimeSpan  _dateTime;
     protected Address address;
    private DateTime time;
    private string eventDescription;

    public Event(DateTime datetime, string eventDescription,  Address address, string eventTitle, string eventType )
    {
        _eventDate = datetime.ToShortDateString();
        _dateTime = datetime.TimeOfDay;
        _eventDescription = eventDescription;
        _address = address.GetAddress();
        _eventTitle = eventTitle;
        _eventType = eventType;
    }


    public virtual void GetFullDetails()
   {
    Console.WriteLine($"{_eventTitle}, {_eventDescription}, {_eventDate}, {_dateTime}, {_address}");
   }

   public virtual void GetStandardDetails()
   {
    Console.WriteLine($"{_eventTitle}, {_eventDescription}, {_eventDate}, {_dateTime}, {_address}");
   }

   public virtual void GetShortDescription()
   {
    Console.WriteLine($"{_eventType},{_eventTitle},{_eventDate}");
   }
   
}