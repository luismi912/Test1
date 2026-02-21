Hospitales Hospital1 = new Hospitales()
{
    Id = 1,
    Nombre = "La piloto",
    Pais = "Colombia",
    Departamento = "Arauca",
    Calle = "Carrera 38c #55-22",
    Fecha_Fundacion = DateTime.Now,
    Activo = true,
    Consultorios = new List<Consultorios>(),
    Doctores = new List<Doctores>(),
    Pacientes = new List<Pacientes>(),
    Telefonos = new List<Telefonos>()
};

Hospital1.Consultorios.Add(new Consultorios() {Id = 1, Especialidad = "Odontologia", Activo = true, Numero_Piso = 2, Hospital = Hospital1.Id, _Hospital = Hospital1});
Hospital1.Consultorios.Add(new Consultorios() {Id = 2, Especialidad = "Electro", Activo = true, Numero_Piso = 1, Hospital = Hospital1.Id, _Hospital = Hospital1});

Hospital1.Doctores.Add(new Doctores() {Id = 1, Nombre = "Camlia", Cedula = "31394192429", Fecha_Nacimiento = DateTime.Now, Salario = 1500000, Especialidad = "Cirguias", Hospital = Hospital1.Id, _Hospital = Hospital1});

Hospital1.Pacientes.Add(new Doctores() {Id = 1, Nombre = "Sofia", Cedula = "49345834672", Fecha_Nacimiento = DateTime.Now, Salario = 1200000, Problema = "Higado", Fecha_Cita = DateTime.Now, Hospital = Hospital1.Id, _Hospital = Hospital1});

Hospitales Hospital2 = new Hospitales()
{
    Id = 2,
    Nombre = "La cruz",
    Pais = "Colombia",
    Departamento = "Antioquia",
    Calle = "Carrera 3a #51-27",
    Fecha_Fundacion = DateTime.Now,
    Activo = true,
};

Hospital2.Consultorios.Add( new Consultorios() {Id = 3, Especialidad = "Cardiograma", Activo = true, Numero_Piso = 2, Hospital = Hospital2.Id, _Hospital = Hospital2});
Hospital2.Consultorios.Add( new Consultorios() {Id = 4, Especialidad = "Craneologia", Activo = true, Numero_Piso = 3, Hospital = Hospital2.Id, _Hospital = Hospital2});

public class Hospitales
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public String? Departamento {get;set;}
    public String? Pais {get;set;}
    public String? Calle {get;set;}
    public DateTime Fecha_Fundacion {get;set;}
    public bool Activo {get;set;}
    public List<Consultorios> Consultorios {get;set;}
    public List<Doctores> Doctores {get;set;}
    public List<Pacientes> Pacientes {get;set;}
    public  List<Telefonos> Telefonos {get;set;}
}

public class Telefonos
{
    public int Id {get;set;}
    public String? Numero {get;set;}
    public String? Tipo {get;set;}

    public int Hospital {get;set;}
    public Hospitales? _Hospital {get;set;}
}

public class Consultorios
{
    public int Id {get;set;}
    public String? Especialidad {get;set;}
    public bool Activo {get;set;}
    public int Numero_Piso {get;set;}

    public int Hospital {get;set;}
    public Hospitales _Hospital {get;set;}
}

public class Personas
{
    public int Id {get;set;}
    public String? Nombre {get;set;}
    public String? Cedula {get;set;}
    public DateTime Fecha_Nacimiento {get;set;}
    public decimal Salario {get;set;}
}

public class Doctores : Personas
{
    public String? Especialidad {get;set;}

    public int Hospital {get;set;}
    public Hospitales? _Hospital {get;set;}
}

public class Pacientes : Personas
{
    public String? Problema {get;set;}
    public DateTime Fecha_Cita {get;set;}

    public int Hospital {get;set;}
    public Hospitales? _Hosítal {get;set;}
}