namespace Inherity2;

public class CargoPlane:Airplane
{
    public int Bor { get; set; }

public CargoPlane (int id,string driver,int posojir,int speed, int par,int borr):base(id,driver,posojir,speed,par)

   {
        Bor = Bor;
      
   }

    public void _CargoPlane(int  borinav)
    {

       var client = Convert.ToInt32(Console.ReadLine());
       if(borinav+client<=Bor)
       {
            System.Console.WriteLine($"Basay pr shid");  
       }
     
      else 
      {
    
             System.Console.WriteLine($"pr k holi");
      }

    }
    
}
