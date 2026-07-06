Empleado empleado1= new Empleado("Martín", "González", new DateTime(1999,12,5), 'C', new DateTime(2015,08,21), 800000, Cargos.Ingeniero);

Console.WriteLine("====EMPLEADO #1====\nNombre: "+empleado1.Nombre+" "+empleado1.Apellido+"\nFecha de nacimiento: "+empleado1.FechaNac.ToString("dd/MM/yyyy")+"\nEdad: "+empleado1.EdadEmpleado()+"\nFecha de ingreso: "+empleado1.FechaIngreso.ToString("dd/MM/yyyy")+"\nSueldo básico: $"+empleado1.SueldoBasico+"\nCargo: "+empleado1.Cargo+"\nAntigüedad: "+empleado1.Antiguedad()+"\nTotal a cobrar: $"+empleado1.Salario());


