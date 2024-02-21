using Saygac;
try
{
    Spidometr spidometr = new Spidometr(99);
    spidometr.decrement();
    spidometr.increment();
    spidometr.increment();
    spidometr.increment();
    spidometr.increment();
    spidometr.Print();
}
catch (Exception x)
{

    Console.WriteLine(x.Message);
}