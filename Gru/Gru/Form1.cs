namespace Gru
{
    public partial class Form1 : Form
    {
        Stazione stazione_1 = new Stazione();
        Gru gru=new Gru();  
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            gru.alzare();
        }
    }
}

class Gru
{

    private double altezza_max;
    public double Altezza_max
    {
        get { return altezza_max; }
    }
    private double altezza_min;
    public double Altezza_min
    {
        get { return altezza_min; }
        set { altezza_min = value; }
    }
    private string produttore;
    public string Produttore
    {
        get { return produttore; }
    }
    private string num_seriale_identif;
    public string Num_seriale_identif
    {
        get { return num_seriale_identif; }
    }
    private double peso_max;
    public double Peso_max
    {
        get { return Peso_max; }
    }
    public double altezza_braccio;
    private double incremento;
    private double decremento;

    public Gru(string produttore, string num_seriale_identif, double altezza_max, double altezza_min, double peso_max, double incremento, double decremento)
    {
        this.produttore = produttore;
        this.num_seriale_identif = num_seriale_identif;
        this.altezza_max = altezza_max;
        this.altezza_min = altezza_min;
        this.peso_max = peso_max;
        altezza_braccio = altezza_min;
        this.incremento = incremento;
        this.decremento = decremento;
    }

    public void alzare()
    {
        altezza_braccio = altezza_braccio + incremento;
        if (altezza_braccio > altezza_max)
        {
            Console.WriteLine("l'operazione non è possibile");

        }
        else
        {
            Console.WriteLine($"altezza_braccio è{altezza_braccio}");
        }
    }
    public void abbassare()
    {
        altezza_braccio = altezza_braccio - decremento;
        if (altezza_braccio < altezza_min)
        {
            Console.WriteLine("l'operazione non è possibile");
        }
        else
        {
            Console.WriteLine($"altezza_braccio è{altezza_braccio}");
        }
    }
    public void riportare()
    {
        altezza_braccio = altezza_min;
        Console.WriteLine($"Il braccio della Gru è stato riportato alla posizione di sicurezza, cioè{altezza_braccio}");
    }
}

class Stazione
{
    public Gru Gru { get; set; }

    private string num_seriale_identif;
    public string Num_seriale_identif
    {
        get { return num_seriale_identif; }
    }
    public void alzare()
    {
        Gru.alzare();
    }

    public void abbassare()
    {
        Gru.abbassare();
    }

    public void riportare()
    {
        Gru.riportare();
    }
}