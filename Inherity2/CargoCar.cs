namespace Inherity2;

public class CargoCar:Avto
{

   public int Kuzov { get; set; }


    public CargoCar (int id,string driver,int speed, int ballon,int dar,int posojir,int kuzov):base(id,driver,posojir,speed,ballon,dar)

   {

       Kuzov = kuzov; 

   }

   public void _ObyomCar(int bor)
   {

      if(bor>Kuzov)
      {
          
          System.Console.WriteLine($"Holish kn");   
      }

      else{
        System.Console.WriteLine($"Bor kadan bgi");
      }

   }

}
