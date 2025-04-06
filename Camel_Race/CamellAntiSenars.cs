using Heirloom;

namespace Camel_Race;

public class CamellAntiSenars:CamellPare
{
    public CamellAntiSenars(Image imatgeCamellAntisenar ):base (imatgeCamellAntisenar, "Camell Antisenar") {
    }
    //Antisenars: Si el número és parell avança, si és senar només 1 posicio.
    public override int CalcularNum() {
        Random rnd = new Random();
        var n = rnd.Next(1, 10);
        if (n%2==0)
        {
            return n;
        }

        return 1;
    }

    public override void Pinta(GraphicsContext gfx)
    {
        gfx.DrawImage(_imatge, Posicio);
    }
}