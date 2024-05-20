
using EjercicioPolimorfismo;

List<ILibroBiblia> libros = new List<ILibroBiblia>();

while (true)
{
    Console.WriteLine("Seleccione una opción (1 - 5):");
    Console.WriteLine("1. Agregar libro del Antiguo Testamento");
    Console.WriteLine("2. Agregar libro del Nuevo Testamento");
    Console.WriteLine("3. Agregar libro apócrifo");
    Console.WriteLine("4. Mostrar todos los libros");
    Console.WriteLine("5. Salir");
    Console.Write("Opción: ");
    int opcion;
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                libros.Add(new AntiguoTestamento());
                Console.WriteLine("Libro del Antiguo Testamento agregado.\n");
                break;
            case 2:
                libros.Add(new NuevoTestamento());
                Console.WriteLine("Libro del Nuevo Testamento agregado.\n");
                break;
            case 3:
                libros.Add(new Apocrifo());
                Console.WriteLine("Libro apócrifo agregado.\n");
                break;
            case 4:
                Console.WriteLine("\nLista de todos los libros:");
                foreach (ILibroBiblia libro in libros)
                {
                    libro.Descripcion();
                    libro.CitarVersiculo();
                    Console.WriteLine();
                }
                break;
            case 5:
                Console.WriteLine("Ha salido exitosamente...");
                return;
            default:
                Console.WriteLine("Opción no válida, por favor intente de nuevo.\n");
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida, por favor intente de nuevo.\n");
    }
}