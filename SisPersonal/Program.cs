List<Empleado> empleados=new List<Empleado>();

empleados.Add(new Empleado("Martín", "González", new DateTime(1999,12,5), 'C', new DateTime(2020,08,21), 800000, Cargos.Ingeniero));
empleados.Add(new Empleado("Erika", "Rodríguez", new DateTime(1989,01,18), 'S', new DateTime(2012,11,4), 900000, Cargos.Administrativo));
empleados.Add(new Empleado("Silvana", "Fernández", new DateTime(2003,09,14), 'C', new DateTime(2024,11,18), 700000, Cargos.Especialista));

int i=1;
foreach(Empleado item in empleados)
{
    
Console.WriteLine("\n\n==== EMPLEADO #"+i+" ====\nNombre: "+item.Nombre+" "+item.Apellido+"\nFecha de nacimiento: "+item.FechaNac.ToString("dd/MM/yyyy")+"\nEdad: "+item.EdadEmpleado()+"\nEstado civil: "+item.EstadoCivil+"\nFecha de ingreso: "+item.FechaIngreso.ToString("dd/MM/yyyy")+"\nSueldo básico: $"+item.SueldoBasico+"\nCargo: "+item.Cargo+"\nAntigüedad: "+item.Antiguedad()+"\nTotal a cobrar: $"+item.Salario());
i++;
}



