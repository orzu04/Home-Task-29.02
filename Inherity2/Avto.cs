namespace Inherity2;

public class Avto:Transport
{

    public int Ballon { get; set; }
    public int Dar { get; set; }

    public Avto(int id,string driver,int posojir,int speed, int ballon,int dar):base(id,driver,posojir,speed)

   {

     Ballon = ballon;
     Dar = dar;

   }

}
