using Heirloom;

namespace Camel_Race;

public class CamellFondista:CamellPare
{
    public CamellFondista(Image imatgeCamellFondista):base (imatgeCamellFondista, "Camell Fondista") {
    }
    //Fondista: Si el número < 5 n'avança 1, si és major 2.
    public override int CalcularNum()
    {
        Random rnd = new Random();
        return rnd.Next(1, 2);
    }
}