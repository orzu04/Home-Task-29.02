namespace Inherity2;

public class Transport
{

    public int Id { get; set; }
    public string Drivar { get; set; }
    public int Posojir { get; set; }
    public int Speed { get; set; }

   public Transport(int id , string driver,int posojir,int speed)
   {
        Id = id;
        Drivar = driver;
        Posojir= posojir;
        Speed = speed;

   }

}
