using System.Security.Cryptography.X509Certificates;

public class Menu
{
    private OutdoorEvent _outDoorEvent;
    private LectureEvent _lectureEvent;

    private ReceptionEvent _receptionEvent;

    public Menu(OutdoorEvent outdoorEvent, LectureEvent lectureEvent, ReceptionEvent receptionEvent)
    {
        _outDoorEvent = outdoorEvent;
        _lectureEvent = lectureEvent;
        _receptionEvent = receptionEvent;
    }

    public void DisplayMenu()
    {
        string eventChoice = "";   // for second menu

        while (eventChoice != "4")
        {
            // Ask the user which type of event they would like to create
            Console.WriteLine("The type of Events are:");
            Console.WriteLine(" 1. Lecture Events");
            Console.WriteLine(" 2. OutDoor Event");
            Console.WriteLine(" 3. Reception Event");
            // Console.WriteLine(" 4. Get Attendees");
            // Console.WriteLine(" 5. Show all Attendees");
            Console.Write("What type of Event would you like to create? ");
            eventChoice = Console.ReadLine();

            // Create a lecture event
            if (eventChoice == "1")
            {
                Console.WriteLine("This is an amazing lecture");
                DateTime dateTime = new DateTime();  // produces the variable that we need
                string eventDescription = "The professor  lecutre will be teaching on how anataomy works and anatomy organs work";
                int capacity = 100;
                Address address = new Address("236 w 3rd S", "Idaho", "Rexburg", 83440);
                string eventTitle = "Anatomy Lecture";
                string eventType = "Lecture";
                string speakerName = "Mr. Witkins";
                _lectureEvent = new LectureEvent(dateTime, eventDescription, capacity, address, eventTitle, eventType, speakerName);
                _lectureEvent.GetFullDetails();//  SimpleGoal object. ship the variables to the grocer
            }
            // Create a Outdoor event
            else if (eventChoice == "2")
            {
                DateTime dateTime = new DateTime();
                string eventDescription = "This event is a paintball tournament that helps devlop teamwork as well having fun";
                string forecast = "Sunny and 75*";
                Address address = new Address("1097 Coconino Dr", "California", "Blythe", 92225);
                string eventTitle = "Blythes annual paintball Tournament";
                string eventType = "Outdoor Event";
                _outDoorEvent = new OutDoorEvent(dateTime, eventDescription, forecast, address, eventTitle, eventType);
                _outDoorEvent.GetFullDetails();
            }
            // Create a new Reception event
            else if (eventChoice == "3")
            {
                DateTime dateTime = new DateTime();
                string eventDescription = " Gias wedding Reception";
                List<string> registeredAttendees = new List<string>(){
                                                        "Shib Dora",
                                                        "Satish Emmerich",
                                                        "Bairre Hirshel",
                                                        "Aste Raffaella",
                                                        "Renata Ildar",
                                                        "Seneca Nazzareno",
                                                        "Avgust Doris",
                                                        "Aliyya Dylan",
                                                        "Gautam Coleen",
                                                        "Fillin Zarifa",
                                                        "Tutankhamon Lelise"
                                                    };
                Address address = new Address("7474 Charmat Dr", "California", "San Diego", 92122);
                string eventTitle = "Gia Wedding Reception";
                string eventType = "Reception";
                _receptionEvent = new ReceptionEvent(dateTime, eventDescription, registeredAttendees, address, eventTitle, eventType);
                _receptionEvent.GetFullDetails();
            }
        }
    }
}
