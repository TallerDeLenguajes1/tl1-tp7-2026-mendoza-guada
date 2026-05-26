namespace EspacioCalculadora
{
    public class Calculadora
    {
        public double dato;

        /*public double Dato
        {
            get=>dato;
        }
        */
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

        public double Resultado()
        {
            return dato;
        }

    }

}