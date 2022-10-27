using POO_MPilar;

// crear una variable
string nombre = "alan";

// Crear objeto a partir de una clase
Employee empleado1 = new Employee("77766611T", "Empleado1", 30, 3000.0, false);
Employee empleado2 = new Employee("44433322F", "Empleado2", 28, 2900.0, true);
empleado1.Salary = 4000.0;

Console.WriteLine(empleado1.Name);
Console.WriteLine(empleado2.Name);

// Operaciones aritméticas
Console.WriteLine(empleado1.Salary + empleado2.Salary);

var media = (empleado1.Salary + empleado2.Salary) / 2;
Console.WriteLine(media);

Employee empleado3 = new Employee("11122233G", "Empleado3");
Employee empleado4 = new Employee("11122234G", "Empleado4");
Console.WriteLine(empleado3.Salary);

Employee empleado5 = new Employee("11122235G", "Empleado5", 3000.0);
Console.WriteLine(empleado5.Dni);

// Constructor vacio
Employee empleado6 = new Employee ();
empleado6.Name = "Empleado6";
empleado6.Age = 30;
Console.WriteLine(empleado6.Dni);
Console.WriteLine(empleado6.Name);

// Constructor dinámico (Requiere un constructor vacio
// se pueden pasar los parámetros que se quiera y en el orden que se quiera
Employee empleado7 = new Employee { Age = 30 };
Employee empleado8 = new Employee { Age = 30, Dni = "77766655G", married = false };


// Ejemplo con Vehicle

Veh coche1 = new Veh();
coche1.Manufacturer = "Seat";
coche1.Model = "Ibiza";

Veh coche2 = new Veh { Manufacturer = "Seat", Model = "Ibiza" };
Veh coche3 = new Veh { Manufacturer = "Ford" };
Veh coche4 = new Veh { Model = "Mondeo" };
Veh coche5 = new Veh { Model = "Mondeo", CubicCentimeters = 1.2 };

// Metodos de Veh
// Comprobar el estado del vehículo
Console.WriteLine(coche1.Status); //False

// Arrancar vehiculo
coche1.Start(); // invoca un metodo que realiza una accion

// Comprobar el estado del vehículo
Console.WriteLine(coche1.Status); // True

//Parar el vehículo
coche1.Stop();  // invoca un metodo que realiza una accion

// Comprobar el estado del vehículo
Console.WriteLine(coche1.Status); // 

// acelerar por primera vez 
Console.WriteLine(coche1.velocidad);  // 0
coche1.Acelerar(50);
Console.WriteLine(coche1.velocidad); // 50

// acelerar por segunda vez 
Console.WriteLine("Introdduce la cantidad a acelerar:");
int cantidad = Convert.ToInt32(Console.ReadLine());
coche1.Acelerar(cantidad);
Console.WriteLine(coche1.velocidad);

// frenar por primera vez
coche1.Frenar(20);
Console.WriteLine(coche1.velocidad);

// frenar por segunda vez
Console.WriteLine("Introduce la cantidad a frenar:");
cantidad = Convert.ToInt32(Console.ReadLine());
coche1.Frenar(cantidad);
Console.WriteLine(coche1.velocidad);

// Acelerar con sobrecarga
Veh ferrari = new Veh();
ferrari.Start();
ferrari.Acelerar(130);  //120

ferrari.Stop();
ferrari.Start();
ferrari.Acelerar(130, 200); //130

Person persona1 = new Person();
persona1.Saludar();
persona1.Saludar("Alan");

// Metodo ToString

SmartPhone movil1 = new SmartPhone {Manufacturer = "Samsung", Cores = 4, Ram = 8};
Console.WriteLine(movil1);

SmartPhone movil2 = new SmartPhone { Manufacturer = "One Plus", Cores = 8, Ram = 8 };
Console.WriteLine(movil2);

//Encapsulacion (getter setter)
// get sirve para obtener/leer un atributo
// set sirve para modificar el valor de un atributo

Guest invitado = new Guest();
invitado.Age = -20; //edad negativa
Console.WriteLine(invitado.Age);
Console.WriteLine(invitado.Dni);
// invitado.Dni = "77788899";
// invitado.Salary = 10.0;
Console.WriteLine(invitado.Salary);
invitado.promote(200.0);
Console.WriteLine(invitado.Salary);
// invitado.saalry = 200.0;

// Promote sobrecargado y private
invitado.Promote();
Console.WriteLine(invitado.Salary);
// invitado.CalcSalaryPromotion();


// Asosciacion entre clases

Address address1 = new Address
{
    Street = "Calle falsa 123",
    City = "Madrid",
    PostalCode = "44099",
    
};


Customer customer1 = new Customer {
    Dni= "77711122E",
    Email = "cust1@company.com",
    Address = address1
};

// calle del cliente
Console.WriteLine(customer1.Address.Street);

// Herencia:

Car car = new Car();
car.Manufacturer = "Ford"; // heredada
car.NumRuedas = 4; // heredada
car.NumPuertas = 3;         //especifica de car
car.RuedaRepuesto = false;  //especifica de car
//car.NumPassengers = 3;      //especifica de car
car.Start(); //heredado

MotorCycle moto = new MotorCycle();
moto.Manufacturer = "Kawasaki"; // heredada
moto.NumRuedas = 2;   // heredada
moto.Copilot = true; // especifica de moto
moto.Naked = false;  // especifica de moto

Truck truck = new Truck();
moto.Manufacturer = "Volvo"; //heredada
truck.NumRuedas = 12;  // heredada
truck.Trailer = true; // especificada de truck
truck.TrailerCapacity = 5; // especificada de truck

// Clase abstracta: no se puede instanciar
// se aplica normalmente a la clase base de una herencia
//con el objetivo que no sea  instanciada y obliga a que 
//se instancie una de las hijas

/*RoadVehicle veh1 = new Car();
truck.Manufacturer = "Honda";
truck.NumRuedas = 4; */

ElectricCar electric1 = new ElectricCar();
electric1.Manufacturer = "Alfa"; //heradada de RoadVehicle
electric1.NumRuedas = 4; //heradada de RoadVehicle
electric1.NumPuertas = 5; //heradada de Car
electric1.RuedaRepuesto = true; //heradada de Car
electric1.NumPassengers = 5;    //heradada de Car
electric1.BatteryCapacity = 50000; //especifica

CombustionCar combustion1 = new CombustionCar();
combustion1.Manufacturer = "Alfa"; //heradada de RoadVehicle
combustion1.NumRuedas = 4; //heradada de RoadVehicle
combustion1.NumPuertas = 5; //heradada de Car
combustion1.RuedaRepuesto = true; //heradada de Car
combustion1.NumPassengers = 5;    //heradada de Car
combustion1.TankCapacity = 120; //especifica
combustion1.Emission = 30.5; //especifica

// Override en herencia
// 
Car alfaRomeo = new Car();
alfaRomeo.NumPersons = 3;
alfaRomeo.Start();
Console.WriteLine(alfaRomeo.Status + "" + alfaRomeo.NumPersons);

alfaRomeo.Stop();
Console.WriteLine(alfaRomeo.Status + "" + alfaRomeo.NumPersons);

// Polimorfismo
Customer client = new Customer {
    Dni = "55544417T",
    Vehicle = truck
};
client.Vehicle.Start();

DoSomething(truck);
DoSomething(moto);
void DoSomething(RoadVehicle vehicle)//Polimorfismo
{ 
    vehicle.Start();
    //acelerar....
    vehicle.Stop();
}

var vehicles = new List<RoadVehicle>
{
    new MotorCycle{ Copilot=true },
    new ElectricCar{ BatteryCapacity = 30000}
};

Customer client2 = new Customer
{
    Dni = "34344435",
    PersonalVehicles = vehicles //Polimorfismo
};

// print vehicles
client2.PersonalVehicles.ForEach(v => Console.Write(v.Manufacturer));
Console.WriteLine("Num vehiculos de client2: " + client2.PersonalVehicles.Count());

// Address - Country - Language

//1. crear varios objetos language
Language idioma1 = new Language { Name = "Castellano", ISO="ES", Year=1990, latin=true};
Language idioma2 = new Language { Name = "Gallego", ISO="ES", Year=1970, latin =true };
Language idioma3 = new Language { Name = "Vasco", ISO = "ES", Year = 1950, latin = true };

//2. crear objeto Country con varios languages
// opcion 1

var languages = new List<Language> { idioma1, idioma2, idioma3 };
/*var languages = new List<Language>(); //estructura con datos que contiene Language
languages.Add(idioma1);
languages.Add(idioma2);
languages.Add(idioma3);*/

Country country1 = new Country {NameISO = "ES", Population = 35000, PIB=1.2, 
    Capital="Madrid", IsMemberEU=true,
    Languages = languages};


//opcion 2
Country country2 = new Country
{
    NameISO = "ES",
    Population = 3000,
    PIB = 1.2,
    Capital = "Madrid",
    IsMemberEU = true,
};

// country2.Languages.AddRange(languages);
country2.Languages.Add(idioma1);
country2.Languages.Add(idioma2);
country2.Languages.Add(idioma3);


// 3. crear objeto Address con un Country
Address addressMadrid = new Address
{
    Street = "calle", PostalCode = "333333",
    City = "Madrid",
    Country = country1
};


// 4. Crear un objeto Customer con un Address

Customer cliente1 = new Customer
{
    Dni = "343434", Email = "cust1@sdsd.com",
    Address = addressMadrid
};

// 5. A partir del objeto customer imprimir que lenguaje
// habla con un bucle for 
if (cliente1.Address.Country.Languages == null)
    Console.WriteLine("Lista de idiomas sin inicializarla");

if (cliente1.PersonalVehicles == null)
    Console.WriteLine("Lista de personal vehicles sin inicializarla");

Console.WriteLine("El cliente habla los siguintes idiomas:");
foreach (Language idioma in cliente1.Address.Country.Languages) {
    Console.WriteLine(idioma.Name);
}

// Interfaces
/*ISaludo saludo1 = new Saludoformal(); //Polimorfismo en interfaz
Customer rodolfo = new Customer { saludo = saludo1 };
rodolfo.saludo.saludar();

ISaludo saludo2 = new SaludoInformal();
rodolfo.saludo = saludo2;
rodolfo.saludo.saludar();
rodolfo.saludo.saludar("Alan");

Customer mike = new Customer { saludo = saludo2 }; */

//Saludoformal saludoFormal = new SaludoFormal(); //NO polimorfismo
//SaludoInformal s2 = new SaludoInformal(); //NO polimorfismo
//SaludoFormal s3 = new SaludoInformal(); //NO polimorfismo

//1. Crear clase Computer
//2. Crear una Interface IComputerRepository
//3. Crear una implementación de la interface
//4. Utilizar los métodos desde Program.cs

IComputerRepository computerRepo = new ComputerListRepository();
var computers = computerRepo.FindAll();
Console.WriteLine(computers.Count);

Computer computer1 = computerRepo.FindById(1);
Console.WriteLine(computer1.Ram);

var computer2 = computerRepo.FindAllByRam(8, 64);
var computer3 = computerRepo.FindAllByRam(16,128);

Console.WriteLine("fin");

// Comprobar que Save añade un nuevo ordenador: 
// Caso 1: Añadir un ordenador que Sí se guarde porque no existe
// Crear un nuevo computer
Computer computer4 = new Computer { Id = 4, Model = "DELL", Ram = 6 };
// llamar al método Save
bool saved = computerRepo.Save(computer4);
// comprobar si se guardó
if (saved)
{
    Console.WriteLine("Se guardó correctamente el computer4");
}
else
{
    Console.WriteLine("No se pudo guardar el computer4");
}
// Caso 2: Añadir un ordenador que NO se guarde porque ya existe




