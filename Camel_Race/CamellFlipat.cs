using Heirloom;

namespace Camel_Race;

public class CamellFlipat:CamellPare
{
    public int direccio = 1;
    public CamellFlipat(Image imatgeCamellFlipat ):base (imatgeCamellFlipat, "Camell Flipat") {
    }
    // Flipats: Un cop adavant i un cop enderrera
    public override int CalcularNum() {
        Random rnd = new Random();
        direccio *= -1;
        return rnd.Next(1, 10) * direccio;
    }
}