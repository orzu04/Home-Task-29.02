namespace Inherity;

public class Laptop : Computer
{


public int Weight { get; set; }

   public Laptop(int ram,int storage,string keybord,int weight ) : base (ram,storage,keybord)
     {
               Weight = weight;


     }

     public void WeightChack(int weight)
     {

        Weight = weight;
        var w = Convert.ToInt32(Console.ReadLine());
        if(w>weight || w<weight)
        {
            System.Console.WriteLine($"in Laptop nest");
        }
        else{
            System.Console.WriteLine($" In Laptop ast");
        }

     }


}
