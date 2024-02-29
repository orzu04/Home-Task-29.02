namespace Inherity2;

public class PassengerCar:Avto
{

    
    

    public PassengerCar (int id,string driver,int speed, int ballon,int dar,int posojir):base(id,driver,posojir,speed,ballon,dar)

   {

   }

   public void _PassegerCar(int odam)
   {

       if(odam>Posojir)
       {
        
        System.Console.WriteLine($"Joyi holi diga nest");

       }
       else{
        System.Console.WriteLine($"46 Sahovat Korvon");
       }

   }

}
