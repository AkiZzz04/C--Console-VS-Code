using System;

class AirlineReservation {
    static string passengerName = "";
    static string flightNumber = "";
    static string destination = "";
    static string flightTime = "";
    static string departureDate = "";
    static double ticketPrice = 0;

    public static void Main(string[] args) {


        Console.WriteLine ("Try clicking the Run button.");
                // FIRST BLOCK: INTRO ========== ========== =========
        int choice;

            do
        {
            Console.Clear();

            Console.WriteLine("┌──────────────────────────⋆⋅☆⋅⋆────────────────────────────┐");
            Console.WriteLine("Welcome to Airline Reservation: Holiday's Special Deals!");
            Console.WriteLine("└──────────────────────────⋆⋅☆⋅⋆────────────────────────────┘");

            Console.WriteLine("1. View Available Flights");
            Console.WriteLine("2. Book a Flight");
            Console.WriteLine("3. View Reservation Details");
            Console.WriteLine("4. Exit");
            Console.WriteLine("================================");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewFlights();
                    break;
                case 2:
                    BookFlight();
                    break;
                case 3:
                    ViewReservation();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using Airline Reservation. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;    
            } 
            if (choice != 4)
            {
                Console.WriteLine("\nPress any key to return to the booking menu...");
                Console.ReadKey();
            }

        }   while (choice != 4);     
    }

                // VIEW FLIGHT BLOCK: Show avaiable flights ========= ========= =========
        static void ViewFlights()
        {
            Console.WriteLine("\nAvailable Flights:");

            Console.WriteLine("1. FL101 - Manila to Boracay - PHP 4500");
            Console.WriteLine("2. FL102 - Manila to Palawan - PHP 4000");
            Console.WriteLine("3. FL103 - Manila to Siargao - PHP 3800");
            Console.WriteLine("4. FL104 - Manila to Ilo-Ilo - PHP 2650");
            Console.WriteLine("5. FL105 - Manila to Cebu - PHP 5000");
        }       
                // BOOK FLIGHT BLOCK: Book a flight ========= ========= =========
        static void BookFlight()
        {
            Console.WriteLine("\nBOOK A FLIGHT");
            
            Console.Write ("Enter your full name: ");
            passengerName = Console.ReadLine();

            while (passengerName == "")
            {
                Console.Write("Invalid input. Please enter your full name: ");
                passengerName = Console.ReadLine();
            }

            Console.WriteLine("\nSelect Destination");
            Console.WriteLine("1. FL101 - Manila to Boracay - PHP 4500");
            Console.WriteLine("2. FL102 - Manila to Palawan - PHP 4000");
            Console.WriteLine("3. FL103 - Manila to Siargao - PHP 3800");
            Console.WriteLine("4. FL104 - Manila to Ilo-Ilo - PHP 2650");
            Console.WriteLine("5. FL105 - Manila to Cebu - PHP 5000");
            
            Console.Write("Please enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please select a valid destination (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            switch (choice)
                {
                case 1:
                    flightNumber = "FL101";
                    destination = "Manila to Boracay";
                    departureDate = "March 15, 2026";
                    flightTime = "10:30 AM";
                    ticketPrice = 4500;
                    break;

                case 2:
                    flightNumber = "FL102";
                    destination = "Manila to Palawan";
                    departureDate = "June 21, 2026";
                    flightTime = "1:00 PM";
                    ticketPrice = 4000;
                    break;

                case 3:
                    flightNumber = "FL103";
                    destination = "Manila to Siargao";
                    departureDate = "September 10, 2026";
                    flightTime = "3:30 PM";
                    ticketPrice = 3800;
                    break;

                case 4:
                    flightNumber = "FL104";
                    destination = "Manila to Ilo-Ilo";
                    departureDate = "";
                    flightTime = "11:30 AM";
                    ticketPrice = 2650;
                    break;

                case 5:
                    flightNumber = "FL105";
                    destination = "Manila to Cebu";
                    departureDate = "November 7, 2026";
                    flightTime = "9:00 AM";
                    ticketPrice = 5000;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
                }
        
        Console.WriteLine("\nFlight successfully booked!");
        Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("Passenger: " + passengerName);
        Console.WriteLine("Flight Number: " + flightNumber);
        Console.WriteLine("Destination: " + destination);
        Console.WriteLine("Departure Date: " + departureDate);
        Console.WriteLine("Flight Time: " + flightTime);
        Console.WriteLine("Ticket Price: PHP " + ticketPrice);
        Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>");
    

    }               
               // RESERVATION BLOCK: Show reservation details ========= ========= =========
        static void ViewReservation()
    {
        Console.Write("Enter your full name to check details: ");
        string inputName = Console.ReadLine();

        if (inputName == "" || inputName != passengerName)
        {
            Console.WriteLine("\nInvalid Name: No reservation found.");
        }
        else
        {
            Console.WriteLine("\nTIKCET DETAILS");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Passenger Name: " + passengerName);
            Console.WriteLine("Flight Number: " + flightNumber);
            Console.WriteLine("Destination: " + destination);
            Console.WriteLine("Departure Date: " + departureDate);
            Console.WriteLine("Flight Time: " + flightTime);
            Console.WriteLine("Ticket Price: PHP " + ticketPrice);
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>");
        }


    }

}
