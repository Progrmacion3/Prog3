namespace Common
{
    public class Camión : Base
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Matrícula { get; set; }

        public int Año { get; set; }

        public Camión(int id) : base(id)
        {
        }

        public Camión(int id, string matrícula) : base(id)
        {
            Matrícula = matrícula;
        }

        public Camión(string marca, string modelo, string matrícula, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Matrícula = matrícula;
            Año = año;
        }

        public Camión(int id, string marca, string modelo, string matrícula, int año) : base(id)
        {
            Marca = marca;
            Modelo = modelo;
            Matrícula = matrícula;
            Año = año;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + " de matrícula " + Matrícula + " de " + Año;
        }
    }
}
