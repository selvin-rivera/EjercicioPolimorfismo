
namespace EjercicioPolimorfismo
{
    public class AntiguoTestamento: ILibroBiblia
    {
        public void Descripcion()
        {
            Console.WriteLine("Este es un libro del Antiguo Testamento.");
        }

        public void CitarVersiculo()
        {
            Console.WriteLine("\"En el principio creó Dios los cielos y la tierra.\" - Génesis 1:1");
        }
    }
}
