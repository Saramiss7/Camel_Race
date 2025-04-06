using Heirloom;

namespace Camel_Race;

public class CamellEsprintador:CamellPare
{
    public CamellEsprintador(Image imatgeCamellEsprintador):base (imatgeCamellEsprintador, "Camell Esprintador")
    {
    }

    //Esprintador: Si el número és superior a 7/10, avança el doble
    public override int CalcularNum()
    {
        Random rnd = new Random();
        var n = rnd.Next(1, 5);
        if (n >= 4.5)
        {
            return n*2;
        }
        return n;
    }
}