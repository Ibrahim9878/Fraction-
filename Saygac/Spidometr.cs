namespace Saygac;

public class Spidometr
{

    private int _max;
    public int max
    {
        get { return _max; }
        set
        {
            if (value > -1 && value < 101) _max = value;
            else throw new Exception("You entered wrong number");
        }
    }
    public Spidometr()
    {
        max = 0;
    }
    public Spidometr(int a)
    {
        this.max = a;
    }
    public void increment() 
    {
        if (_max == 100)
            max = 0;
        else this._max++; 
    }
    public void decrement() 
    {
        if (_max == 0)
            max = 100;
        else this._max--;
    }
    public void Print()
    {
        Console.WriteLine(max);
    }
}
