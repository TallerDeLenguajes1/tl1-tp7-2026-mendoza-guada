Empleado[] empleados = 
{
    new Empleado("Martín", "González", new DateTime(1969,12,5), 'C', new DateTime(2020,08,21), 800000, Cargos.Ingeniero), 
    new Empleado("Erika", "Rodríguez", new DateTime(1989,01,18), 'S', new DateTime(2012,11,4), 900000, Cargos.Administrativo),
    new Empleado("Silvana", "Fernández", new DateTime(2003,09,14), 'C', new DateTime(2024,11,18), 700000, Cargos.Especialista)
};

for (int i=0; i<empleados.Length; i++)
{    
    Console.WriteLine("\n\n==== EMPLEADO #"+(i+1)+" ====\nNombre: "+empleados[i].Nombre+" "+empleados[i].Apellido+"\nFecha de nacimiento: "+empleados[i].FechaNac.ToString("dd/MM/yyyy")+"\nEdad: "+empleados[i].EdadEmpleado()+"\nEstado civil: "+empleados[i].EstadoCivil+"\nFecha de ingreso: "+empleados[i].FechaIngreso.ToString("dd/MM/yyyy")+"\nSueldo básico: $"+empleados[i].SueldoBasico+"\nCargo: "+empleados[i].Cargo+"\nAntigüedad: "+empleados[i].Antiguedad()+"\nTotal a cobrar: $"+empleados[i].Salario());
}

Procedimientos funciones = new Procedimientos();
Console.WriteLine("\n******************************\nMONTO TOTAL A PAGAR: $"+funciones.MontoTotal(empleados)+"\n******************************");
Empleado AJubilarse=funciones.ProximoAJubilarse(empleados);
Console.WriteLine("\n\nEmpleado más próximo a jubilarse\n¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\nNombre: "+AJubilarse.Nombre+" "+AJubilarse.Apellido+"\nEdad: "+AJubilarse.EdadEmpleado()+"\nAntigüedad: "+AJubilarse.Antiguedad()+"\nAños para jubilarse: "+AJubilarse.AniosParaJubilarse()+"\nSalario: $"+AJubilarse.Salario());

