namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameImput;
            string birthdayImput;
            Console.WriteLine("¡Hola, bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameImput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayImput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayImput, out dateConverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento es inválida, usted nos envió este dato erróneo {birthdayImput}");
            var person = new Person
            {
                Name = nameImput,
                Birthday = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };
            Console.WriteLine($"Tú nombre: {person.Name}");
            Console.WriteLine($"Tú fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"¡Tú edad es: {person.Age} años!");

            Console.ReadLine();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}