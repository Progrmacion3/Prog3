namespace Common
{
    public class Camión
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Matrícula { get; set; }

        public int Año { get; set; }

        public Camión()
        {
        }

        public Camión(int id)
        {
            Id = id;
        }

        public Camión(string marca, string modelo, string matrícula, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Matrícula = matrícula;
            Año = año;
        }

        public Camión(int id, string marca, string modelo, string matrícula, int año)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Matrícula = matrícula;
            Año = año;
        }


        public override string ToString()
        {
            return Id + " " + Marca + " " + Modelo + " " + " " + Matrícula + " " + Año;
        }
    }
}
