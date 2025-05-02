namespace delegate_practice
{
    internal class DelegateExample
    {
        public void function()
        {
            Console.WriteLine("Function Body");
        }
        public void function1()
        {
            Console.WriteLine("Function 1 Body");
        }
        public delegate void mydelegate();
        static void Main(string[] args)
        {
            DelegateExample obj = new DelegateExample();
            mydelegate del = new mydelegate(obj.function);
            del += obj.function1; //connect function 1 with function
            del -= obj.function1; //disconnect
            del();


        }
    }
}
