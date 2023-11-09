//interface'in doğru planlamasını SOLID'in i harfi söyler
//SOLID, Integreface Segregration

IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Worker(),
    new Manager()
};

foreach (var eat in eats)
{
    eat.Eat();
}

interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}
interface ISalary
{
    void GetSalary();
}

class Manager : IWorker, IEat, ISalary            //bir class aynı anda birden fazla interface'i implement edebilir
{
    public void Eat()
    {
        Console.WriteLine("Manager ate");
    }

    public void GetSalary()
    {
        Console.WriteLine("Manager got salary");

    }

    public void Work()
    {
        Console.WriteLine("Manager worked");

    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Worker ate");
    }

    public void GetSalary()
    {
        Console.WriteLine("Worker got salary");
    }

    public void Work()
    {
        Console.WriteLine("Worker worked");
    }
}

class Robot : IWorker
{
    //robot yemek yer. work ve get salary kısmı kendisi için geçerli değil
    public void Work()
    {
        Console.WriteLine("Robot worked");
    }
}