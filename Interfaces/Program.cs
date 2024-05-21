
//Interface ler new lenemez 

//IPersonManager cutomerManager = new CustomerManager();
//IPersonManager employeeManager = new EmployeeManager();

using Console = System.Console;

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());





interface IPersonManager
{
    //Unimlemented operation
    void Add();
    void Update();
}

//Ingerits- class -------------------İmplements - ınterface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Müşteri Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Eklendi");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Çalışan Eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Çalışan Eklendi");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add(); // Personmanagerın add methotdunu çağırdık
    }
}