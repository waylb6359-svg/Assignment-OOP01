namespace Assignment_oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region q1)

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








        }
    }
}
    