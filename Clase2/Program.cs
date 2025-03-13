using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "C:\\Users\\yogen\\Desktop\\Direc\\hola.txt"; 

        try
        {
       
            EscribirEnArchivo(filePath, "Hola, este es un mensaje en el archivo.");
            string contenido = LeerDeArchivo(filePath);
            Console.WriteLine("Contenido del archivo: " + contenido);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error: " + ex.Message);
        }
    }

    static void EscribirEnArchivo(string path, string texto)
    {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = Encoding.UTF8.GetBytes(texto);
            fs.Write(buffer, 0, buffer.Length);
        }
    }

    static string LeerDeArchivo(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer);
        }
    }
}
