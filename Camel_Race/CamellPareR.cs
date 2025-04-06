using Heirloom;

namespace Camel_Race;

public abstract class CamellPareR: CamellPare
{
    protected Vector _direccio;

    public CamellPareR(Image imatge, string nom, Vector direccio):base(imatge, nom)
    {
        _direccio = direccio;
    }

    public abstract void Rebota();
    public override void Mou()
    {
        _posicio.Offset(_direccio);
    }
}