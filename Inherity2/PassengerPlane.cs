namespace Inherity2;

public class PassengerPlane:Airplane
{


     public int Stuardessa { get; set; }

 public PassengerPlane(int id,string driver,int posojir,int speed, int par,int stuardessa):base(id,driver,posojir,speed,par)

   {
        Stuardessa = stuardessa;
   }

    public void _PassengerPlane(int Shumora)
    {

        var bilet = Convert.ToInt32(Console.ReadLine());

      if(Shumora+bilet <=Posojir)
      {
        System.Console.WriteLine($"Safaraton behatar");
      }
      else{

        System.Console.WriteLine($"Parvozi oyandaro intizor shaved");
      }

    }

}
