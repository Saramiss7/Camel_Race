using Heirloom;

namespace Camel_Race;

public class CamellRebota : CamellPareR
{
    private const float Velocitat = 25f;
    Random rnd = new Random();
    public CamellRebota(Image imatge, Vector direccio) : base(imatge, "Camell Rebota", direccio)
    {
        _direccio = direccio;
    }

    public override void Mou()
    {
        _posicio.Offset(_direccio * Velocitat);
    }
    public void Mou(Rectangle carril)
    {
        var novaPosicio = _posicio;
        
        novaPosicio.Offset(_direccio * Velocitat);
        
        if (novaPosicio.Top <= carril.Top)
        {
            novaPosicio = new Rectangle(novaPosicio.X, carril.Top, novaPosicio.Width, novaPosicio.Height);
            _direccio.Y *= -1;
        }

        if (novaPosicio.Bottom >= carril.Bottom)
        {
            novaPosicio = new Rectangle(novaPosicio.X, carril.Bottom - novaPosicio.Height, novaPosicio.Width, novaPosicio.Height);
            _direccio.Y *= -1;
        }
        
        if (novaPosicio.Right >= carril.Right)
        {
            novaPosicio = new Rectangle(carril.Right - novaPosicio.Width, novaPosicio.Y, novaPosicio.Width, novaPosicio.Height);
            _direccio.X *= -1;
        }
        
        if (Input.CheckKey(Key.Right, ButtonState.Pressed))
        {
            novaPosicio.X += CalcularNum();

            if (novaPosicio.Right > carril.Right) 
            {
                novaPosicio = new Rectangle(carril.Right - novaPosicio.Width, novaPosicio.Y, novaPosicio.Width, novaPosicio.Height);
            }
        }
        _posicio = novaPosicio;
    }
    public override int CalcularNum()
    {
        Random random = new Random();
        return random.Next(-50, 50);
    }

    public override void Rebota()
    {
        _direccio.X *= -1;

        var desplaçament = (_posicio.Y + _posicio.Height - _posicio.Y)/(_posicio.Height - _posicio.Height);
        var angle = 0.25f * Calc.Pi * (2 * desplaçament - 1);
        _direccio.Y = Calc.Sin(angle);

        _direccio.X *= -1;
    }
}