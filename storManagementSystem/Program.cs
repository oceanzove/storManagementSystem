using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using storManagementSystem;

internal class Progam : Product
{
    static void Main()
    {
        List<Product> productList = new List<Product>();
        while (true)
        {
            Menu:
            Console.Write("Выберите ваше действие: (1) Добавить товар | (2) Посмотреть товар на складе " +
                          "| (3) Изменить кол-во товара | (4) Изменить цену товара | (5) Удалить товар: ");
            string answer = Console.ReadLine();
                              
            if (answer == "1")
            {
                string name;
                int price, count;
                ProductName:
                Console.Write("Введите название товара: ");
                name = Console.ReadLine();
                if (emptyString(name))
                {
                    Console.WriteLine("Строка названия не может быть пустой");
                    goto ProductName;
                } 
                ProductPrice:
                Console.Write("Введите цену товара: ");
                try
                {
                    price = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto ProductPrice;
                } 
                ProductCount:
                Console.Write("Введите кол-во товара: ");
                try
                {
                    count = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto ProductCount;
                } 
                Product productTmp = new Product();
                productTmp.setProduct(name, price, count);
                productList.Add(productTmp);
                Console.WriteLine("Товар успешно добавлен");
                goto Menu;
            }
            if (answer == "2")
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    Console.Write("Id: {0} ", i);
                    productList[i].getProduct();
                }
                goto Menu;
            }
            if (answer == "3")
            {
                selectId:
                int id, count;
                Console.Write("Введите id товара, количество которого хотите изменить: ");
                try
                {
                    id = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto selectId;
                }
                changeCount:
                Console.Write("Введите количество которое хотите устоновить: "); 
                try
                {
                    count = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto changeCount;
                } 
                productList[id].changeCount(count);
                Console.WriteLine("Количество товар с id {0} успешно измененно на {1}", id,count);
            }

            if (answer == "4")
            {
                selectId:
                int id, price;
                Console.Write("Введите id товара, цену которого хотите изменить: ");
                try
                {
                    id = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto selectId;
                }
                changePrice:
                Console.Write("Введите цену которое хотите устоновить: ");
                try
                {
                    price = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto changePrice;
                }
                productList[id].changePrice(price);
                Console.WriteLine("Цена товара с id {0} успешна измененна на {1}", id,price);

            }

            if (answer == "5")
            {   
                selectId:
                int id;
                Console.Write("Введите id товара, который хотите удалить: ");
                try
                {
                    id = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ввведенное вам значения не является числом");
                    goto selectId;
                }
                productList.Remove(productList[id]);
                Console.WriteLine("Товар с id {0} успешно удалён", id);
            }
        }
        
    }

    public static bool emptyString(string str)
    {
        return (str.Length == 0);
    }
}