using Heirloom;

namespace Camel_Race;

public class CamellRotat: CamellPare
{
    private float _rotacio;
    public CamellRotat(Image imatgeCamellRotat, float rotacio):base (imatgeCamellRotat, "Camell Rotat") {
        _rotacio = rotacio;
    }

    public override int CalcularNum()
    {
        Random rnd = new Random();
        _rotacio += 90;
        return rnd.Next(0, 6);
    }
    
    public override void Pinta(GraphicsContext gfx)
    {
        gfx.DrawImage(_imatge, Posicio.Position, _rotacio);
    }
}