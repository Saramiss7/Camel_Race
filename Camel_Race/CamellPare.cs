using Heirloom;

namespace Camel_Race;

public abstract class CamellPare
{
    protected Rectangle _posicio;
    public Rectangle Posicio { get => _posicio; set => _posicio = value; }
    
    protected readonly Image _imatge; 
    public int ultimnum; //num. posicions que ha d'avançar de cada camell, en cas d'empat, és mira el número més gran
    public string Nom { get; }

    public CamellPare(Image imatge, string nom)
    {
        Posicio = new Rectangle(0,0,imatge.Width,imatge.Height);
        _imatge = imatge;
        Nom = nom;
    }

    public abstract int CalcularNum();
    
    public virtual void Mou()
    {
        int num = CalcularNum();
        ultimnum = num;
        _posicio.X += num;
    }

    public virtual void Pinta(GraphicsContext gfx)
    {
        gfx.DrawImage(_imatge, Posicio);
    }
}