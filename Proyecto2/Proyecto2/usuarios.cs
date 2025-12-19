public class Usuarios
{
    //atributos del usuario
    public string nombre {get; set;}
    public int edad {get; set;}

    static bool SesionIniciada = false;
    //Sirve para iniciar sesión
    public bool iniciosesion(string correo, string usuario, string contraseña)
    {
        if (usuario == "cliente" && contraseña == "cliente1" && correo == "cliente@gmail.com")
        {
            nombre = usuario;
            SesionIniciada = true;
            return true;
        }
            return false;
    }
}