namespace Inherity2;

public class Airplane : Transport
{
    public int Par { get; set; }
  

    public Airplane(int id,string driver,int posojir,int speed, int par):base(id,driver,posojir,speed)

   {
        Par = par;
   }


}
