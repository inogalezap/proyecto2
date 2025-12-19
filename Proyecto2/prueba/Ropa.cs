public class Ropa
{
    public string nombre {get; set;} 
    public int precio {get; set;}
    public int talla {get; set;}

    public Ropa (string Nombre, int precio, int talla)
    {
        nombre = Nombre;
        precio = precio;
        talla = talla;
    }
}