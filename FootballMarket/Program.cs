using System;

namespace FootballMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Roberto", "Marrapodi");
            Medico medico = new Medico("Lucas", "Pisano");
            Agente agente = new Agente("Carlos", "Bombin");

            Console.WriteLine(jugador.nombreCompleto);
            Console.WriteLine(medico.nombreCompleto);
            Console.WriteLine(agente.nombreCompleto);

            jugador.identificacion = 121212;
            medico.identificacion = 159753;
            agente.identificacion = 444444;

            Console.WriteLine(jugador.GetIdentificacion());
            Console.WriteLine(medico.GetIdentificacion());
            Console.WriteLine(agente.GetIdentificacion());
        }
    }
}

abstract class Person
{
    protected string _nombre;
    protected string _apellido;
    protected int _identificacion;
    protected Person(string n, string a)
    {
        _nombre = n;
        _apellido = a;
    }

    public string nombreCompleto 
    {
        get => $"{_nombre} {_apellido}";
    }

    public int identificacion
    {
        get => _identificacion;
        set => _identificacion = value;
    }

    public virtual string GetIdentificacion()
    {
        return _identificacion.ToString();
    }

}

class Medico : Person
{
    public Medico(string n, string a) : base(n, a)
    {
    }
    public override string GetIdentificacion()
    {
        return "Licencia Médica: " + base.GetIdentificacion();
    }

}

class Jugador : Person
{
    public Jugador(string n, string a) : base(n, a)
    {
    }

    public override string GetIdentificacion()
    {
        return "Identificación de jugador: " + base.GetIdentificacion();
    }
}

class Agente : Person
{
    public Agente(string n, string a) : base(n, a)
    {
    }

    public override string GetIdentificacion()
    {
        return "Código de agente: " + base.GetIdentificacion();
    }
}