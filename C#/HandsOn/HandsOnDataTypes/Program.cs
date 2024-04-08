namespace HandsOnDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value types(allocated memory on stack)
            //numeric types
            byte age = 10;
            short salary = 8909;
            int order_id = 909890;
            long buget = 430294309;
            //floting types
            double discount = 12.34;
            float stock = 78.344F;
            decimal product_price = 78.3334543M;
            //char types
            char gender = 'm';
            //bool types
            bool isAssigned=false;
            bool isBuyable = true;
            //Reference types(Heap Memeory allocated)
            //string types
            string product_name = "Keyboard";
            string project_name = "Insurence";
        }
    }
}
