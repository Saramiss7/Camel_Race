using Heirloom;

namespace Camel_Race;

public class Carril
{
    private Rectangle posicioCarril;
    private CamellPare Camell;
    private Meta _meta;
    private Type camellescollit = typeof(CamellPare);
    
    public Carril(Rectangle posicio)
    {
        posicioCarril = posicio;
        _meta = new Meta(posicio);
    }
    public bool HaArribat()
    {
        if (Camell.Posicio.Right >= _meta.PosicioMeta().Right)
        {
            camellescollit = Camell.GetType();
            return true;
        }
        return false;
    }
    public void Mou()
    {
        if (Camell is CamellRebota camellRebota)
        {
            if (Input.CheckKey(Key.Right, ButtonState.Pressed))
            {
                camellRebota.Mou(posicioCarril);
            }
        }
        else
        {
            Camell.Mou();
        }
    }
    
    public void AfegirCamell(CamellPare camell, int posicioX = 0)
    {
        Camell = camell;
        
        Camell.Posicio = Camell.Posicio with { X = posicioX, Y = posicioCarril.Bottom - Camell.Posicio.Height};
    }

    /*public void TreureCamell()
    {
        Camell = null;
    }*/

    public CamellPare ObtenirCamell()
    {
        return Camell;
    }
    
    public string Guanyador()
    {
        return Camell.Nom;
    }
    
    public void PintaCarril(GraphicsContext gfx)
    {
        gfx.DrawRectOutline(posicioCarril);
        gfx.Color=Color.White;
        Camell.Pinta(gfx);
    }
}