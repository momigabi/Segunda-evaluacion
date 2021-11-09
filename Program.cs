using System;

namespace _vscode
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena ="";
            int edad = 0;
            double altura = 0.0;
        
            
            Console.WriteLine("Bienvenido, ingrese su edad por favor:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);
            
		if (edad >=15 )
		{Console.WriteLine("Puede ingrear a la seccion de mayores ");
		}
		else 
		{ Console.WriteLine("Puede ingresar a la seccion para niños ");
		
		}  
		Console.WriteLine("Bienvenidos al Parque las maravillas,por favor ingrese su altura (en metros):");
		cadena=Console.ReadLine();
		altura= Convert.ToDouble(cadena);
		
		 if (altura > 1.6)
		 {
			 Console.WriteLine("Puede ir a las sillas voladoras, el carrusel y la montaña rusa ");
		 }
		 else 
		 {
		 Console.WriteLine("Puede ir a los carritos chocones, el carrusel y la casa embrujada");
		 }
		Console.WriteLine("Diviertase");

        }
    }
}
