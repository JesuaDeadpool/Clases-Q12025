using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Q12025
{
    public class Ave
    {

        public string? Nombre { get; set; }
        public string? Especie { get; set; }
        public string? Color {  get; set; }
        public double Tamanio { get; set; }
        public string? Habitat { get; set; }

        public FamiliaAve Familia { get; set; }

        public Ave()
        {
            Familia = new FamiliaAve(); 
        }

        //Metodo
        public void Imprimir()

        {
            Console.WriteLine($"Nombre: {Nombre}");  //Interpolación $"Dato : {Variable}"
            Console.WriteLine($"Especie : {Especie}");
            Console.WriteLine($"Color : {Color}");
            Console.WriteLine($"Tamaño : {Tamanio}");
            Console.WriteLine($"Habitat : {Habitat}");
            Console.WriteLine($"Familia: {Familia.Nombre}");
            Console.WriteLine($"Número de especie : {Familia.NumeroEspecie}");
            Console.WriteLine($"Caracteristicas : {Familia.Caracteristicas}");
            Console.WriteLine("");
            Console.WriteLine("");
        }


    }
}
