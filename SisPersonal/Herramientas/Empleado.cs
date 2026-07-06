class Empleado
{
    public string? Nombre {get; set; }
    public string? Apellido {get; set; }
    public  DateTime FechaNac {get; set; }
    public  char EstadoCivil {get; set; }
    public DateTime FechaIngreso {get; set; }
    public double SueldoBasico {get; set; }
    public Cargos Cargo {get; set; }

    //CONSTRUCTOR//
    public Empleado(string nombre, string apellido, DateTime fechanac, char estadocivil, DateTime fechaingreso, double sueldobasico, Cargos cargo)
    {
        Nombre=nombre;
        Apellido=apellido;
        FechaNac=fechanac;
        EstadoCivil=estadocivil;
        FechaIngreso=fechaingreso;
        SueldoBasico=sueldobasico;
        Cargo=cargo;
    }
    public int Antiguedad() 
    {
        DateTime hoy = DateTime.Today;
        return (hoy.Year - FechaIngreso.Year);
    }
    public int EdadEmpleado()
    {
        DateTime hoy = DateTime.Today;
        return (hoy.Year - FechaNac.Year);//REVISAR POR SI EL EMPLEADO CUMPLE DESPUES DEL MES QUE ES HOY
    }
    public int AniosParaJubilarse()
    {
        return 65-EdadEmpleado();
    }
    public double Salario()
    {   
        double Adicional;
        if (Antiguedad()<=20)
        {
            Adicional=Antiguedad()*1/100*SueldoBasico;
        } else
        {
            Adicional=25/100*SueldoBasico;
        }
        if (Cargo==Cargos.Especialista || Cargo==Cargos.Ingeniero)
        {
            Adicional+=Adicional*50/100;
        }
        if (EstadoCivil=='C')
        {
            Adicional+=150000;
        }
        double Salario = SueldoBasico + Adicional;
        return Salario;
    }

}

enum Cargos
{
    Auxiliar=0,
    Administrativo=1,
    Ingeniero=2,
    Especialista=3,
    Investigador=4
}