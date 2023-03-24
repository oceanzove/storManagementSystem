namespace storManagementSystem;

public class Product
{
    private string _name;
    private int _price;
    private int _count;

    public void setProduct(string name, int price, int count)
    {
        this._name = name;
        this._price = price;
        this._count = count;
    }

    public void getProduct()
    {
        Console.WriteLine(" {0}  Цена: {1}. Количество: {2}", this._name, this._price, this._count);
    }
    public void changeCount(int count)
    {
        this._count = count;
    }

    public void changePrice(int price)
    {
        this._price = price;
    }
    
}