internal class Program
{
    private static void Main(string[] args)
    {
        Grass grass = new Grass();
        grass.Efect();
        Wood wood= new Wood();
        wood.Efect();
        Iron iron = new Iron();
        iron.Efect();
    }
}

public interface IDamager
{
    void Efect();
}

public class Wood : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao lo tren go khi dan ban");
    }
}

public class Iron : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao ra lua khi dan ban");
    }
}



public class Grass : IDamager
{
    public void Efect()
    {
        Console.WriteLine("Tao bun dat ban len khi dan ban");
    }
}
public class Bulet
{
    Wood bulletCollider = new Wood();
    //bulletCollider.Efect();
}