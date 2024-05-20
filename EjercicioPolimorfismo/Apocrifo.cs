
namespace EjercicioPolimorfismo
{
    public class Apocrifo: ILibroBiblia
    {
        public void Descripcion()
        {
            Console.WriteLine("Este es un libro apócrifo.");
        }

        public void CitarVersiculo()
        {
            Console.WriteLine("\"El alma del justo es inmortal, pero la maldad mata a los impíos.\" - Sabiduría 1:15");
        }
    }
}
