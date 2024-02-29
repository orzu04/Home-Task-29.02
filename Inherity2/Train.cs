namespace Inherity2;

public class Train:Transport
{

    public int Vagon { get; set; }



     public Train(int id,string driver,int posojir,int speed, int vagon):base(id,driver,posojir,speed)

   {
        Vagon = vagon;
   }
    

}
