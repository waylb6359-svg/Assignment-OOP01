using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region q1):

            #region a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified? //b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
            //DeliveryAddress address1 = new DeliveryAddress();
            //address1.City = "Los Angeles";
            //address1.Street = "123 Main St";
            //DeliveryAddress address2 = address1;
            //address2.City = "New York";
            //address2.Street = "5th Avenue";
            //Console.WriteLine(address2.City);
            //Console.WriteLine(address2.Street);
            //Console.WriteLine("=============================");
            //Console.WriteLine(address1.City);
            //Console.WriteLine(address1.Street);
            //address1 اللي هيحصل ان مش هيغير القيمة اللي موجوده في   
            //struct  لانها 
            //  value type  هو
            //وده معناه ان كل متغير بيحتوي علي نسخة من البيانات مش علي نفس البيانات 
            #endregion
            #region b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
            //Customer customer1 = new Customer();
            //customer1.Name = "Hamada";
            //Customer customer2 = customer1;
            //customer2.Name = "Ahmed";
            //Console.WriteLine(customer2.Name);
            //Console.WriteLine("=============================");
            //Console.WriteLine(customer1.Name);

            //customer1 اللي هيحصل ان هيغير القيمة اللي موجوده في  
            //class  reference  type    عشان ال
            //فا هما الاتنين بيشاوروا علي نفس المكان في الذاكرة فالما تغير اللي هيحصل في واحد هيظهر في التاني



            #endregion

            #endregion

            #region q2):
            #region a) Identify at least three problems with this design from an encapsulation perspective.
            //1) كل الـ Fields معمولة public، وبالتالي أي كود خارج الكلاس يقدر يغير البيانات مباشرة.
            //2) مفيش Encapsulation، لأن البيانات مش محمية.
            //3) مفيش Validation للقيم، فمثلاً ممكن حد يدخل Weight بقيمة سالبة أو DeliveryFee بقيمة غير صحيحة.
            #endregion
            #region b) How can private fields and public properties improve this design?
            // public properties و private fields  عملت  
            //عشان احمي البيانات و مش اي حد يقدر يوصل للبيانات من بره الكلاس و اقدر اتحكم في البيانات اللي هتدخل و اللي هتخرج من الكلاس
            #endregion

            #endregion

            #region Q3):Smart Delivery Management System.
            #region 1. Create a DeliveryAddress struct with:

            //DeliveryAddress address1 = new DeliveryAddress("Los Angeles", "123 Main St", 90001);
            //DeliveryAddress address2 = new DeliveryAddress("New York", "5th Avenue", 10001);
            //address2 = address2;

            //Console.WriteLine(address1.GetFullAddress());
            //Console.WriteLine(address2.GetFullAddress());
            ////دا STRUCT  وده معناه ان كل متغير بيحتوي علي نسخة من البيانات مش علي نفس البيانات   
            #endregion

            #region 6. In Main, build a Console Application that does the following:  (بمساعدة في بعض الحاجات مش كلو  AI)

            DeliveryCenter center = new DeliveryCenter();

                for (int i = 0; i < 3; i++)
                {
      
                    Console.WriteLine($"Enter Shipment {i + 1} Data");

                    Console.Write("Tracking Code: ");
                    string trackingCode = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    double weight;
                    Console.Write("Weight: ");
                 
                    while (!double.TryParse(Console.ReadLine(), out weight))
                    {
                        Console.Write("Invalid input. Enter Weight again: ");
                    }
                 
                    decimal fee;
                    Console.Write("Delivery Fee: ");
                 
                    while (!decimal.TryParse(Console.ReadLine(), out fee))
                    {
                        Console.Write("Invalid input. Enter Delivery Fee again: ");
                    }
                 
                    Console.Write("City: ");
                        string city = Console.ReadLine();
                 
                        Console.Write("Street: ");
                        string street = Console.ReadLine();
                    int buildingNumber;
                    Console.Write("Building Number: ");
                 
                    while (!int.TryParse(Console.ReadLine(), out buildingNumber))
                    {
                        Console.Write("Invalid input. Enter Building Number again: ");
                    }
                 
                 
                    DeliveryAddress address = new DeliveryAddress(city, street, buildingNumber);
                 
                    Shipment shipment =  new Shipment(trackingCode, description, weight, fee, address);
                 
                        if (center.AddShipment(shipment))
                            Console.WriteLine("Shipment added successfully.");
                        else
                            Console.WriteLine("Delivery Center is full.");
                    }
                 
                    Console.WriteLine("\n------ All Shipments ------");
                 
                    for (int i = 0; i < 3; i++)
                    {
                        if (center[i] != null)
                        {
                            center[i].PrintShipment();
                            Console.WriteLine();
                        }
                    }
                 
                    Console.Write("Enter tracking code to search: ");
                    string code = Console.ReadLine();
                 
                    Shipment result = center[code];
                 
                    if (result != null)
                    {
                        Console.WriteLine("\nShipment Found:");
                        result.PrintShipment();
                    }
                    else
                    {
                        Console.WriteLine("Shipment not found.");
                    }
                 
                    Console.WriteLine("\n------ Struct Copy Test ------");
                 
                    DeliveryAddress address1 =new DeliveryAddress("Cairo", "Tahrir Street", 15);
                 
                    DeliveryAddress address2 = address1;
                 
                    address2.City = "Cairo";
                    address2.Street = "Makram Ebeid Street";
                    address2.BuildingNumber = 20;
                 
                    Console.WriteLine("Original Address:");
                    Console.WriteLine(address1.GetFullAddress());
                 
                    Console.WriteLine("Copied Address:");
                    Console.WriteLine(address2.GetFullAddress());
                 
            #endregion


            #endregion






        }
    }
}
    