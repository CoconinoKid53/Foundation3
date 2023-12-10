using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Declare events
        OutdoorEvent outDoorEvent;
        LectureEvent lectureEvent;
        ReceptionEvent receptionEvent;

        string mainMenuChoice = "";   //  for first menu

        while (mainMenuChoice != "5")
        {
            // Let the user make a choice about what type of event they want to 
            // create
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create an Event");
            Console.WriteLine("--------------------");
            Console.WriteLine("2. Display OutDoor Event");
            // there will need to be a second menu 
            // for each of the dispaly options which will give them the choice of displaying one of 
            // three messages: Standard, Full, and Short.
            Console.WriteLine("-------------------");
            Console.WriteLine("3.  Display Lecture Event");
            Console.WriteLine("--------------------");
            Console.WriteLine("4.  Display Reception Event ");
            Console.WriteLine("---------------------");
            Console.WriteLine("5. Quit");

            mainMenuChoice = Console.ReadLine();

            // Create an Event
            if (mainMenuChoice == "1")
            {
                // Second menu

                Menu menu = new Menu(outdoorEvent, lectureEvent, receptionEvent);
                menu.DisplayMenu();
            }

            // Display Outdoor event
            else if (mainMenuChoice == "2")
            {
                // use outdoorEvent here
                
                // GetMessageType();


                // Display standard message

            }

            // Display Lecture event
            else if (mainMenuChoice == "3")
            {
                Console.WriteLine("test!!");
            }

            // Display Reception event
            else if (mainMenuChoice == "4")
            {
                Console.WriteLine("hiiiiiiiiii!!");
            }
        }
    }

    public string GetMessageType()
    {
        string response = "";
        while (response != "4")
        {

            Console.WriteLine("What type of message would you like to display for this event?");
            Console.WriteLine("1. Standard message");
            Console.WriteLine("2. Full message");
            Console.WriteLine("3. Short description ");

            response = Console.ReadLine();

            if (response == "1")
            {
                Console.WriteLine("!!!!!!!!!!!!!!!!");

                //  Lists the title, description, date, time, and address.
                Console.WriteLine("Welcome to the Anatomy Lecture, 11/22/23 ,7:30 pm, 236 w 3rd S", "Idaho", "Rexburg", 83440);

                //lectureEvent?.GetStandardDetails();
            }

            // Display Full message
            else if (response == "2")
            {

                Console.WriteLine("The professor  lecutre will be teaching on how anataomy works and anatomy organs work");

                // Lists all of the above, plus type of event and 
                // information specific to that event type. For 
                // lectures, this includes the speaker name and 
                // capacity. For receptions this includes an email 
                // for RSVP. For outdoor gatherings, this includes 
                // a statement of the weather.
            }
            // Display Short description message
            else if (response == "3")
            {
                Console.WriteLine("This Lecture will be taught by brother Witkins teaching about antaomy");
                // Lists the type of event, title, and the date.
            }// gets the input from the user
        }
        return response;
    }
}
