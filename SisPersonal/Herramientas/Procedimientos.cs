public class Procedimientos
{
    public double MontoTotal(Empleado[] empleados)
    {
        double TotalAPagar=0;
        for (int i=0; i<empleados.Length; i++)
        {
            TotalAPagar+=empleados[i].Salario();
        }
        return TotalAPagar;
    }
    public Empleado ProximoAJubilarse(Empleado[] empleados)
    {
        int aJubilarse=65;
        int indice=0;
        for (int i=0; i<empleados.Length; i++)
        {
            if (empleados[i].AniosParaJubilarse()<aJubilarse)
            {
                aJubilarse=empleados[i].AniosParaJubilarse();
                indice=i;
            }
        }
        return empleados[indice];

    }
}