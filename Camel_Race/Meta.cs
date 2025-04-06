using Heirloom;

namespace Camel_Race;

public class Meta
{
    private Rectangle posicioMeta;
    
    public Meta(Rectangle posicio)
    {
        posicioMeta = posicio;
    }

    public Rectangle PosicioMeta()
    {
        return posicioMeta;
    }
    public void PintaMeta(GraphicsContext gfx)
    {
        gfx.DrawLine(new Vector (posicioMeta.X - 35, posicioMeta.Y), new Vector(posicioMeta.X -35, posicioMeta.Height), 2);
    }
}