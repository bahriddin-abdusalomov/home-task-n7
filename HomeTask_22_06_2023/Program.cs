namespace HomeTask_22_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();

            products.AddRange(new[]{
                new Products("Apple", 10000),
                new Products("Cherry", 8000),
                new Products("Apricot", 4000),
                new Products("Pear", 12000)
            });

            Console.WriteLine("\n>>>>>>>>>>Dokonda mavjud mahsulotlar<<<<<<<<<<<<<<<");

            products.ForEach(Console.WriteLine);

            Uzcard uzcard = new Uzcard("944396669", "Bahriddin", 1000000);

            Console.Write("Mahsulot nomini kiritng: ");
            string fruitName = Console.ReadLine();

           
            var fruit = products.FirstOrDefault(product => product.ProductName == fruitName);


            if (!(fruit is null) && uzcard.Pay(fruit.Price))
            {

                Console.WriteLine("Siz Olma sotib oldingiz.");
                products.Remove(fruit);

                uzcard.AddWithBonus(0);
            }
            else
            {
                Console.WriteLine("Dokonda  bunday mahsulot mavjud emas.");
            }



            Console.WriteLine("Hisobingizdagi mablag' : " + uzcard.Money);



        }
    }
}