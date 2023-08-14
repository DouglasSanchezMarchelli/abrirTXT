using System;
using System.IO;

namespace LeerArchivoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leyendo Contenido de Archivo de Texto");
            Console.WriteLine("====================================");

            Console.Write("Ingrese la ruta completa del archivo de texto (ejemplo: C:\\ruta\\archivo.txt): ");
            string rutaArchivo = Console.ReadLine();

            if (File.Exists(rutaArchivo))
            {
                try
                {
                    string contenido = File.ReadAllText(rutaArchivo);
                    Console.WriteLine("Contenido del Archivo:");
                    Console.WriteLine("=======================");
                    Console.WriteLine(contenido);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al leer el archivo: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }
    }
}