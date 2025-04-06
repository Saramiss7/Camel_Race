using Heirloom;

namespace Camel_Race;

public class CamellNormal:CamellPare
{
    public CamellNormal(Image imatgeCamellNormal ):base (imatgeCamellNormal, "Camell Normal") {
    }
    
    //Camells: Depen del número que sorti avancen
    public override int CalcularNum() {

        Random rnd = new Random();
        if (Input.CheckKey(Key.Right, ButtonState.Pressed))
        {
            return rnd.Next(1, 50);
        }
        return 0;
    }
}