using System.Collections;
using System.Numerics;
using System.Security.Claims;
using System.Timers;
using System.Xml.Linq;

namespace G_Net_34_OOP04
{
    internal class Program
    {
        #region ProcessTicket


        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            //        Q1: What is the difference between static binding and dynamic binding? When does each one happen ?

            //Static binding means the method call is resolved at compile time.When in Compile Time 
            //Dynamic binding means the method call is resolved at runtime based on the actual object.When in Runtime

            //Q2 : What is the difference between method overloading and method overriding?

            //method overloading   Same method name, different parameter lists — within the same class. Resolved at compile time.
            //method overriding Derived class overrides a virtual method from the base class using the override keyword.

            //Q3: What keywords are used for Method Overriding? What does each one mean ?
            //virtual:Base Class.
            //override :Used in the Derived Class.
            //base:Used inside the Derived Class method.

            #endregion

           
            
                #region Practical 
                
                //Cinema myCinema = new Cinema();
                //myCinema.OpenCinema();

                //StandardTicket t1 = new StandardTicket("Inception", 120, "A-5");
                //VIPTicket t2 = new VIPTicket("Avengers", 200, true);
                //IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

                //Console.WriteLine("\n========== SetPrice Test ==========");
                //t1.SetPrice(150);
                //Console.WriteLine("Setting price directly: 150");
                //t1.SetPrice(100, 1.5m);
                //Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");

               
                //myCinema.AddTicket(t1);
                //myCinema.AddTicket(t2);
                //myCinema.AddTicket(t3);
                //myCinema.PrintAllTickets();

                
                //ProcessTicket(t2);

                //myCinema.CloseCinema();
                //Console.WriteLine("\nPress any key to exit...");
                //Console.ReadKey();
                #endregion
            }
        }

        #region Cinema Classes
        //public class Projector
        //{
        //    public void Start() => Console.WriteLine("Projector started.");
        //    public void Stop() => Console.WriteLine("Projector stopped.");
        //}

        //public class Cinema
        //{
        //    private Ticket[] _tickets = new Ticket[20];
        //    private int _count = 0;

        //    public void OpenCinema()
        //    {
        //        Console.WriteLine("========== Cinema Opened ==========");
        //        Console.WriteLine("Projector started.");
        //    }

        //    public void AddTicket(Ticket t) { if (_count < 20) _tickets[_count++] = t; }

        //    public void PrintAllTickets()
        //    {
        //        Console.WriteLine("\n========== All Tickets ==========");
        //        for (int i = 0; i < _count; i++)
        //        {
        //            _tickets[i].PrintTicket();
        //        }
        //    }

        //    public void CloseCinema()
        //    {
        //        Console.WriteLine("\n========== Cinema Closed ==========");
        //        Console.WriteLine("Projector stopped.");
        //    }
        //}
        #endregion

        #region Ticket Base Class
        //public class Ticket
        //{
        //    private static int _ticketCounter = 0;
        //    public string MovieName { get; set; }
        //    private decimal _price;
        //    public int TicketId { get; }

        //    public decimal Price
        //    {
        //        get => _price;
        //        protected set => _price = value > 0 ? value : throw new ArgumentException("Price must be > 0");
        //    }

        //    public decimal PriceAfterTax => Price * 1.14m;

        //    public Ticket(string movieName, decimal price)
        //    {
        //        TicketId = ++_ticketCounter;
        //        MovieName = movieName;
        //        Price = price;
        //    }

        //    public virtual void PrintTicket()
        //    {
        //        Console.WriteLine($"Ticket #{TicketId} | Movie: {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        //    }

        //    public void SetPrice(decimal newPrice) => Price = newPrice;
        //    public void SetPrice(decimal basePrice, decimal multiplier) => Price = basePrice * multiplier;

        //    public static int GetTotalTickets() => _ticketCounter;

        //    public override string ToString() => $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP";
        //}
        #endregion

        #region Three Child Classes
        //public class StandardTicket : Ticket
        //{
        //    public string SeatNumber { get; set; }
        //    public StandardTicket(string movie, decimal price, string seat) : base(movie, price) => SeatNumber = seat;

        //    public override void PrintTicket()
        //    {
        //        base.PrintTicket();
        //        Console.WriteLine($"   Seat: {SeatNumber}");
        //    }
        //}

        //public class VIPTicket : Ticket
        //{
        //    public bool LoungeAccess { get; set; }
        //    public decimal ServiceFee { get; } = 50;
        //    public VIPTicket(string movie, decimal price, bool lounge) : base(movie, price) => LoungeAccess = lounge;
        //    public override void PrintTicket()
        //    {
        //        base.PrintTicket();
        //        Console.WriteLine($"   Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP");
        //    }
        //}

        //public class IMAXTicket : Ticket
        //{
        //    public bool Is3D { get; set; }
        //    public IMAXTicket(string movie, decimal price, bool is3D) : base(movie, price)
        //    {
        //        Is3D = is3D;
        //        if (Is3D) Price += 30;
        //    }

        //    public override void PrintTicket()
        //    {
        //        base.PrintTicket();
        //        Console.WriteLine($"   IMAX 3D: {(Is3D ? "Yes" : "No")}");
        //    }
        //}
        #endregion
    }

