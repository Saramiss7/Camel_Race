using Heirloom;
using Heirloom.Desktop;

namespace Camel_Race;

class Program
{
    private const int Amplada = 1300;
    private const int Altura = 768;
    private static Window _finestra = null!;
    private static Carrera _carrera = null!;
    public static Dictionary<string, Image> Imatges = new();
    public static List<CamellPare> Camells = new();

    static void Main()
    {
        Application.Run(() =>
        {
            _finestra = new Window("Carrera de camells", (Amplada, Altura)) { IsResizable = false };
            _finestra.MoveToCenter();
            _carrera = new Carrera(_finestra);
            
            //Imatges.Add("Normal", new Image("Imatges/Camell6.png"));
            Imatges.Add("Rotat", new Image("Imatges/Camell1.png"));
            Imatges.Add("Rebota", new Image("Imatges/Camell6.png"));
            Imatges.Add("Esprintador", new Image("Imatges/Camell2.png"));
            Imatges.Add("Fondista", new Image("Imatges/Camell5.png"));
            Imatges.Add("AntiSenars", new Image("Imatges/Camell4.png"));
            Imatges.Add("Flipat", new Image("Imatges/Camell3.png"));

            //Canviar mida de camells

            Camells.Add(new CamellRotat(Imatges["Rotat"], 0f));
            Camells.Add(new CamellRebota(Imatges["Rebota"], (1,1)));
            //Camells.Add(new CamellNormal(Imatges["Normal"]));
            Camells.Add(new CamellEsprintador(Imatges["Esprintador"]));
            Camells.Add(new CamellFondista(Imatges["Fondista"]));
            Camells.Add(new CamellAntiSenars(Imatges["AntiSenars"]));
            Camells.Add(new CamellFlipat(Imatges["Flipat"]));
            
            _carrera.ListaCamell(Camells);
            _carrera.Inicializar();
            var loop = GameLoop.Create(_finestra.Graphics, OnUpdate, 120);
            loop.Start();
        });
    }

    private static void OnUpdate(GraphicsContext gfx, float dt)
    {
        _carrera.Mou();
        _carrera.Pinta(gfx);
    }
}