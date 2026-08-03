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








        }
    }
}
    