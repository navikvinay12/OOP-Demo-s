namespace OOPSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            L1:
            Console.WriteLine();
            Console.WriteLine("Welcome to OOP Demo : Please choose any one : \n1 Inheritance\n2 MethodOverloading & MethodOverriding\n3 Abstraction\n4 Encapsulation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Dog dog=new Dog();
                    dog.name = "Labrador";
                    dog.display();
                    dog.getName();
                    break;
                case 2:
                    MethodOverloading obj1 = new MethodOverloading();
                    obj1.addNumbers(11, 22);
                    obj1.addNumbers(2.3f, 3.4f);
                    obj1.addNumbers(99, 0.99f);
                    Console.WriteLine("--------------");
                    Parent pObj = new Parent();
                    pObj.show();         //Parent
                    pObj = new Parent();
                    pObj.show();         //Parent
                    pObj = new Child();
                    pObj.show();         //Child  
                    Child cObj = new Child();
                    cObj.show();        //Child
                    cObj = new Child();
                    cObj.show();        //Child
                    break;
                case 3:
                    SBI sbi = new SBI();
                    sbi.ValidateCard();
                    sbi.BankTransfer();
                    sbi.CheckBalance();
                    sbi.MiniStatement();
                    sbi.WithdrawMoney();
                    break;
                case 4:
                    Encapsulation ee = new Encapsulation();
                    ee.PIN = 4567;
                    Console.WriteLine(ee.PIN);
                    break;
                default:
                    Console.WriteLine("please choose numbers within range only");
                    break;
            }
            goto L1;
        }
    }
}