﻿
namespace EjercicioPolimorfismo
{
    public class NuevoTestamento: ILibroBiblia
    {
        public void Descripcion()
        {
            Console.WriteLine("Este es un libro del Nuevo Testamento.");
        }

        public void CitarVersiculo()
        {
            Console.WriteLine("\"Porque de tal manera amó Dios al mundo, que ha dado a su Hijo unigénito, para que todo aquel que en él cree, no se pierda, mas tenga vida eterna.\" - Juan 3:16");
        }
    }
}
