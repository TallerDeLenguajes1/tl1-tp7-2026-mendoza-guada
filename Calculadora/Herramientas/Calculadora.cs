namespace EspacioCalculadora
{
    public class Calculadora
    {
        public double dato {get; set;}

        public void Sumar(double termino)
        {
            dato+=termino;
        }
        public void Restar(double termino)
        {
            dato-=termino;
        }
        public void Multiplicar(double termino)
        {
            dato*=termino;
        }
        public void Dividir(double termino)
        {
            if (termino == 0)
            {
                Console.WriteLine("ERROR. No se puede dividir por 0");
                return;
            }
            dato/=termino;
        }
        public void Limpiar()
        {
            dato=0;
        }
        public double Resultado()
        {
            return dato;
        }

    }

}