namespace Cordinate;

public class Cordinates
{
    public int x { get; set; }
    public int y { get; set; }
    public Cordinates()
    {
        this.x = 0;
        this.y = 0;
    }
    public Cordinates(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Cordinates(Cordinates other)
    {
        this.x = other.x;
        this.y = other.y;
    }
    public void increment()
    {
        this.x++;
        this.y++;
    }
    public void decrement()
    {
        this.x--;
        this.y--;
    }
    public void ShowData()
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}
