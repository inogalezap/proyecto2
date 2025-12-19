using System.Dynamic;
//La clase producto que se puede comprar 
public class Armas
{
    //Los aatributos que tiene un producto
    public string nombre {get; set;} 
    public int precio {get; set;}
    //El constructor 
    public Armas (string Nombre, int Precio)
    {
        nombre = Nombre;
        precio = Precio;
    }
    //mostrar la información del producto
public void mostrar()
    {
        Console.WriteLine($"{nombre} - {precio}$");
    }
}