using System;

class AirlineReservation
{
    static string passengerName;
    static string destination;
    static string flightNumber;
    static int ticketPrice;

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("     AIRLINE RESERVATION SYSTEM");
            Console.WriteLine("================================");
            Console.WriteLine("1. View Available Flights");
            Console.WriteLine("2. Book a Flight");
            Console.WriteLine("3. View Reservation");
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
                    Console.WriteLine("Thank you for using our system!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 4);
    }

    static void ViewFlights()
    {
        Console.WriteLine("\nAVAILABLE FLIGHTS");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("1. FL101 - Manila to Cebu - PHP 2500");
        Console.WriteLine("2. FL102 - Manila to Davao - PHP 3500");
        Console.WriteLine("3. FL103 - Manila to Palawan - PHP 4000");
        Console.WriteLine("--------------------------------");
    }

    static void BookFlight()
    {
        Console.WriteLine("\nBOOK A FLIGHT");

        Console.Write("Enter Passenger Name: ");
        passengerName = Console.ReadLine();

        Console.WriteLine("\nSelect Destination:");
        Console.WriteLine("1. Cebu - PHP 2500");
        Console.WriteLine("2. Davao - PHP 3500");
        Console.WriteLine("3. Palawan - PHP 4000");

        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                flightNumber = "FL101";
                destination = "Cebu";
                ticketPrice = 2500;
                break;

            case 2:
                flightNumber = "FL102";
                destination = "Davao";
                ticketPrice = 3500;
                break;

            case 3:
                flightNumber = "FL103";
                destination = "Palawan";
                ticketPrice = 4000;
                break;

            default:
                Console.WriteLine("Invalid destination!");
                return;
        }

        Console.WriteLine("\nFlight successfully booked!");
        Console.WriteLine("Passenger: " + passengerName);
        Console.WriteLine("Flight Number: " + flightNumber);
        Console.WriteLine("Destination: " + destination);
        Console.WriteLine("Ticket Price: PHP " + ticketPrice);
    }

    static void ViewReservation()
    {
        if (passengerName == null)
        {
            Console.WriteLine("\nNo reservation found!");
        }
        else
        {
            Console.WriteLine("\nRESERVATION DETAILS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Passenger Name: " + passengerName);
            Console.WriteLine("Flight Number: " + flightNumber);
            Console.WriteLine("Destination: " + destination);
            Console.WriteLine("Ticket Price: PHP " + ticketPrice);
            Console.WriteLine("--------------------------------");
        }
    }
}