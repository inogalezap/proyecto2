using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Security.Principal;
//La calse del carrito de la compra
public class Carrito
{
    public static int totalarmas;
    public static int totalcarrito;
    //Lista de productos de la compra
    public List<Ropa> ropa = new List<Ropa>();
    public List<Armas> armas = new List<Armas>();
    
    //Sirve para añadir un producto al carrito
    ///public void añadirproducto(Producto p)
    ///{
    ///    productos.Add(p);
    ///    Console.WriteLine($"p.nombre añadido al carrito");
    ///}
    //Sirve para calcular el carrito 
    public int calculartotal()
    {
        int total = 0;
        foreach (Armas a in armas)
        {
            total += a.precio;
        }
        foreach (Ropa r in ropa)
        {
            total += r.precio;
        }
        return total;
    }
    public int verproductos()
    {
        int total = 0;
        foreach (Armas a in armas)
        {
            total += a.precio;
        }
        foreach (Ropa r in ropa)
        {
            total += r.precio;
        }
        return total;
    }
    //Muestra el contenido del carrito
    ///public void mostrarcarrito()
    ///{
    ///    if (productos.Count == 0)
    ///    {
    ///        Console.WriteLine("El carrito esta vacío: ");
    ///        foreach ( Producto p in productos)
    ///        {
    ///            p.mostrar();
    ///        }
    ///        Console.WriteLine($"total: {calculartotal()}$");
    ///    }
    ///}
    //Comprueba si el carrito está vacío
    /// public bool vacio()
    /// {
    ///     return productos.Count == 0;
    /// }

}