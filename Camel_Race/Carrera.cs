using Heirloom;
using Heirloom.Desktop;

namespace Camel_Race;

public class Carrera
{ 
    public Window Finestra { get; }
    private CamellPare? _camellPare;
    private Meta? _meta;
    private Carril _carril;
    private List<Carril> _carrils = new();
    private bool _haArribat;
    private List<CamellPare> _camells = new();
    private Carril? _carrilguanyador;

    private enum Estat
    {
        Inici,
        Carrera,
        Win,
        GameOver
    }
    private Estat _estatactual = Estat.Inici;
    public Carrera(Window espai)
    {
        Finestra = espai;
    }

    public void ListaCamell(List<CamellPare> Camell)
    {
        _camells = Camell;
    }
    
    public void Inicializar()
    {
        _carrils.Clear();
        
        var y = 0;
        foreach (var camell in _camells)
        {
            camell.Posicio = new Rectangle(0,0, camell.Posicio.Width, camell.Posicio.Height);
        }
        for (int i = 0; i < _camells.Count; i++)
        {
            var carril = new Carril (new Rectangle(0,y, Finestra.Width, 128));
            carril.AfegirCamell(_camells[i]);
            _carrils.Add(carril);
            y += 128;
        }
        _meta = new Meta (new Rectangle(Finestra.Width- 20 , 0, 5, Finestra.Height));
    }
    
    public void Mou()
    {
        switch (_estatactual)
        {
            case Estat.Inici:
                if (Input.CheckKey(Key.Enter, ButtonState.Down))
                {
                    _estatactual = Estat.Carrera;
                    Inicializar();
                }
                break;
            case Estat.Win:
            case Estat.GameOver:
                if (Input.CheckKey(Key.Enter, ButtonState.Down))
                {
                    _haArribat = false;
                    _carrilguanyador = null;
                    _carrils.Clear();
                    _estatactual = Estat.Carrera;
                    Inicializar();
                }
                else if (Input.CheckKey(Key.Escape, ButtonState.Down))
                {
                    _estatactual = Estat.Inici;
                }
                break;
            case Estat.Carrera:
                if (Input.CheckKey(Key.Escape, ButtonState.Down))
                {
                    _estatactual = Estat.Inici;
                }
                
                List<Carril> guanyadors = new();
                
                foreach (var carril in _carrils)
                {
                    carril.Mou();

                    /*if (carril.ObtenirCamell() is CamellTrampos t && t.peticioCanvi())
                    {
                        EsPotCanviCarril(carril);
                    }*/
                    if (carril.HaArribat())
                    {
                        guanyadors.Add(carril);
                    }
                }
                //En cas d'empat és mira quin dels camells té un nùmero de posicions per avançar més alt
                if (guanyadors.Count > 0)
                {
                    _haArribat = true;
                    CamellPare camellgran = null;
                    int mesgran = 0;

                    foreach (var guanyador in guanyadors)
                    {
                        var camell = guanyador.ObtenirCamell();
                        int avanç = camell.ultimnum;

                        if (avanç > mesgran)
                        {
                            mesgran = avanç;
                            camellgran = camell;
                        }
                    }
                    _carrilguanyador = guanyadors.First(c => c.ObtenirCamell() == camellgran);
                    _estatactual = camellgran?.Nom == "Camell Rebota" ? Estat.Win : Estat.GameOver;
                }
                break;
        }
    }

    public void Pinta(GraphicsContext gfx)
    {
        var rectanglefinestra = new Rectangle((0, 0), Finestra.Size);
        switch (_estatactual)
        {
            case Estat.Inici:
            {
                gfx.DrawImage(new Image("Imatges/Inici.jpg"), rectanglefinestra);
                break;
            } 
            case Estat.Win:
            {
                gfx.DrawImage(new Image("Imatges/Win.jpg"), rectanglefinestra);
                break;
            } 
            case Estat.GameOver:
            {
                gfx.DrawImage(new Image("Imatges/GameOver.jpg"), rectanglefinestra);
                
                if (_haArribat && _carrilguanyador != null)
                {
                    gfx.Color= Color.Black;
                    var text = "El guanyador es el " + _carrilguanyador.Guanyador();
                    gfx.DrawText(text, new Vector(650 , 450), Font.Default, 30, TextAlign.Center);
                }
                break;
            }
            case Estat.Carrera:
            {
                gfx.DrawImage(new Image("Imatges/Carrera.jpg"), rectanglefinestra);
                
                gfx.Color= Color.Black;
                foreach (var carril in _carrils)
                {
                    carril.PintaCarril(gfx);
                }
                
                gfx.Color = Color.Red;
                _meta?.PintaMeta(gfx);
                break;
            }
        }
    }
}
