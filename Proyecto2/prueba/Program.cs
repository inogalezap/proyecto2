using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Program
{
    //VARIABLES PARA INICIAR SESION
    static bool sesion = false;
    static string User = "";

    //Una lista de lista para el carrito
    static List<string> carrito = new List<string>();
    static int totalcarrito = 0;
    static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }
    // Esto es el menu principal que verá el usuario
    static void Menuprincipal()
    {
        Console.Clear();
        Console.WriteLine("|========MENU=========|");
        Console.WriteLine("|1. Inicio de sesion  |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|2. Comprar ropa      |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|3. Comprar armas     |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|4. Tienda medieval   |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|5. informacion legal |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|6. Historia de armas |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|8. Realizar compra   |");
        Console.WriteLine("|=====================|");
        Console.WriteLine("|9. Ver Carrito       |");
        Console.WriteLine("|=====================|");

    }

    //Un menu para sus opciones que despues llevarán al usuario a donde eliga
    static void Menu()
    {
        int opcion = 1;
        while (opcion != 0)
        {
            Console.Clear();
            Menuprincipal();
            Console.Write("Escoge una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion != 1 && !sesion)
            {
                Console.Clear();
                Console.WriteLine("Tienes que iniciar sesion para poder acceder a esta opción");
                Console.WriteLine("Pulse ENTER para volver al menu principal...");
                Console.ReadKey();
                continue;
            } 

            switch (opcion)
            {
                case 1:
                    iniciosesion();
                    break;
                case 2:
                    Comprarropa();
                    break;
                case 3:
                    Compraarmas();
                    break;
                case 4:
                    medieval();
                    break;
                case 5:
                    informacion();
                    break;
                case 6:
                    Historia();
                    break;
                case 8:
                    Realizarcompra();
                    break;
                case 9:
                    vercarrito();
                    break;

            }
        }

    }
    //La primera tienda de ropa
    static void Comprarropa()
    {
        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|        Elige tu ropa:        |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    1. Camiseta basica        |");
            Console.WriteLine("|Precio: 39$                   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    2. pantalon tactico       |");
            Console.WriteLine("|Precio: 299$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    3. Chaqueta multicam 150$ |");
            Console.WriteLine("|Precio: 150$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    4. Polar USAF MIL-TEC     |");
            Console.WriteLine("|Precio: 49$                   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    5. Benelli M3 (Escopeta)  |");
            Console.WriteLine("|Precio: 700$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    9. Ver total de compra    |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    0. salir al menu principal|");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("Eliga una opcion: ");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //switch para que eliga y ademas se va sumando todo lo que eliga
            switch (respuesta)
            {

                case 1:
                    total += 40;
                    totalcarrito += 40;
                    Console.WriteLine("Has añadido una camiseta basica (40$)");
                    break;
                case 2:
                    total += 299;
                    totalcarrito += 299;
                    Console.WriteLine("Has añadido una camiseta basica (299$)");
                    break;
                case 3:
                    total += 150;
                    totalcarrito += 150;
                    Console.WriteLine("Has añadido una camiseta basica (150$)");
                    break;
                case 4:
                    total += 49;
                    totalcarrito += 49;
                    Console.WriteLine("Has añadido un Polar USAF MIL-TEC (49$) ");
                    break;
                case 5:
                    total += 700;
                    totalcarrito += 700;
                    Console.WriteLine("Has añadido un Polar USAF MIL-TEC (49$) ");
                    break;
                case 9:
                    Console.WriteLine($"total de tu compra: {total}$");
                    Console.WriteLine("Gracias por comprar!");
                    break;
                case 0:
                    Console.WriteLine("Gracias por su compra.");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opcion no valida, introduzca otra vez:");
                    break;
            }
            //Aqui debe elegir un numero y si pone 9 le dira el total de dinero que tiene acumulado
            Console.Clear();
            if (respuesta != 0 && respuesta != 9)
            {
                Console.WriteLine("¿Quiere seguir comprando?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Total actual: {total}$");
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadKey();
            }

        }
    }
    //Aqui esta la segunda tienda de armas, el codigo es mas de lo mismo que el de la tienda anterior
    static void Compraarmas()
    {

        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|     Elige tu compra          |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 1.  Rifle de precisión       |");
            Console.WriteLine("| Precio: 568$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 2. Escopeta de calibre 12    |");
            Console.WriteLine("| Precio: 749$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 3. Glock 17 de 19mm          |");
            Console.WriteLine("| Precio: 299$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 4. Carabina colt m16 .22LR   |");
            Console.WriteLine("| Precio: 799$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    5. Benelli M3 (Escopeta)  |");
            Console.WriteLine("|Precio: 700$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|  9. Ver total de compra      |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 0. salir al menu principal   |");
            Console.WriteLine("|------------------------------|");
            Console.Write("Opcion:");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (respuesta)
            {
                case 1:
                    Carrito.totalarmas += 568;
                    Carrito.totalcarrito += 568;
                    carrito.Add("Rifle de precisión");
                    Console.WriteLine("Rifle de precisió seleccionado");
                    break;
                case 2:
                    total += 749;
                    totalcarrito += 749;
                    carrito.Add("Escopeta de calibre 12");
                    Console.WriteLine("Escopeta de calibre 12 seleccionado");
                    break;
                case 3:
                    total += 299;
                    totalcarrito += 299;
                    carrito.Add("Glock 17 de 19mm ");
                    Console.WriteLine("Glock 17 de 19mm seleccionado");
                    break;
                case 4:
                    total += 799;
                    totalcarrito += 799;
                    carrito.Add("Carabina colt m16 .22LR");
                    Console.WriteLine("Carabina colt m16 .22LR seleccionado");
                    break;
                case 5:
                    total += 700;
                    totalcarrito += 700;
                    carrito.Add("Benelli M3 (Escopeta)");
                    Console.WriteLine("Benelli M3 (Escopeta)");
                    break;
                case 9:
                    Console.WriteLine($"Total de la compra: {Carrito.totalarmas}$");
                    break;
                case 0:
                    Console.WriteLine("Gracias por su compra.");
                    break;
                default:
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
            }
            if (respuesta != 0 && respuesta != 9)
            {
                Console.WriteLine("¿Quiere seguir comprando?");
                Console.WriteLine("Pulse la tecla enter...");
            }
            else
            {
                Console.WriteLine($"El resultado total es: {Carrito.totalcarrito}$");
                Console.WriteLine("Presione ENTER para termianr...");
                Console.ReadKey();

            }

        }
    }
    //Aqui podra ver el carrito de la compra que verá todo lo acumulado de la compra
    static void vercarrito()
    {
        Console.Clear();
        Console.WriteLine("|====================|");
        Console.WriteLine("|Carrito de la compra|");
        Console.WriteLine("|====================|");

        Console.Clear();
        if (carrito.Count == 0)
        {
            Console.WriteLine("El carrito esta vacio.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine(carrito);
            Console.WriteLine("|=======================|");
            Console.WriteLine($"| TOTAL DE COMPRA: {totalcarrito}$|");
        }
        Console.WriteLine("|======================|");
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
    }
    //aqui realizara la compra
    static void Realizarcompra()
    {
        Console.Clear();
        Console.WriteLine("|========================|");
        Console.WriteLine("|    FINALIZA COMPRA     |");
        Console.WriteLine("|========================|");
        if (carrito.Count == 0)
        {
            Console.WriteLine("No hay ningun producto en el carrito");
        }
        else
        {
            Console.WriteLine("Productos comprados son: ");
            foreach (string producto in carrito)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine(" |=======================================|");
            Console.WriteLine($"|Total de la compra es: {totalcarrito}$ |");
            Console.WriteLine(" |   Gracias por su compra!              |");
            Console.WriteLine(" |=======================================|");
        }
        Console.WriteLine("|============================|");
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
            
        
    }
    //Este es un inicio de sesion solo tengo puesto un usuario que es (cliente) y su contraseña es (cliente1)
    static void iniciosesion()
    {
        Console.Clear();
        Console.WriteLine("|==================|");
        Console.WriteLine("| INICIO DE SESION |");
        Console.WriteLine("|==================|");
        Console.Clear();
        Console.WriteLine("Introduzca su correo electronico:");
        string correo = Console.ReadLine() ??"";
        Console.WriteLine("Por favor introduzca el nombre de Usuario:");
        string user = Console.ReadLine() ??"";
        Console.WriteLine("Por favor introduzca la contraseña de Usuario:");
        string contraseña = Console.ReadLine() ??"";
        if (user == "cliente" && contraseña == "cliente1" && correo =="cliente@gmail.com")
        {
            sesion = true;
            User = user;
            Console.WriteLine("Se ha iniciado sesion correctamente");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta, Vuelva a introducir una contraseña valida");
        }
        Console.WriteLine("Presiona ENTER para volver al menu principal...");
        Console.ReadKey();
    }
    //Información legal de la pagina. 
    static void informacion()
    {
        Console.Clear();
        Console.WriteLine("=================");
        Console.WriteLine("INFORMACION LEGAL");
        Console.WriteLine("=================");
        Console.WriteLine("Somos una emprese dedicada la venta y compra de armamentos, Todo aquel que deseé poseér un arma será totalmente responsable de sus actos");
        Console.WriteLine("por motivos legales tenemos que asegurarnos de que la persona que porte un arma esta totalmente capacitadas tanto psicologicamente como de");
        Console.WriteLine("no tener ninguna sanción por parte de la policía.");
        Console.WriteLine("==================================================================================================================================================================================");
        Console.WriteLine("El proceso de obtener un arma será evaluado por profesionales que determinarán si la persona es apta para portar dicha arma. Se harán diferentes pruebas,");
        Console.WriteLine("las pruebas se harán mediante puntos (MAXIMO 10), se deberá pasar todas las pruebas de lo contrario no se obtendra el arma. Habrá tanto examenes tipo test como prueba de reconoci-");
        Console.WriteLine("miento medico también hay que solicitar un permiso especial (D) o diferente si es de caza mayor ya sea a la guardia civil o policia nacional");
        Console.WriteLine("al poner los datos personales ya se le dará de alta, esto puede tardar varias semanas");
        Console.WriteLine("por nuestra parte no suele ser mas de 2 semanas de preparación para poder solicitar el permiso.");
        Console.WriteLine("==================================================================================================================================================================================");
        Console.WriteLine("En el caso hipotético de que alguien haga algo indevido no nos hacemos cargo de nada. Recordamos que tenemos todos los datos por si ocurriera algo.");
        Console.WriteLine("Gracias por leer esto.");
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para volver...");
        Console.ReadKey();
        Console.Clear();
       
    }
    //Otra tienda pero de tematica medieval
    static void medieval()
    {
        int total = 0;
        int respuesta = 1;
        while (respuesta != 0)
        {
            Console.Clear();
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|     Elige tu arma medieval   |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 1.  casco de acero templado  |");
            Console.WriteLine("| Precio: 80$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 2.  Cota de malla            |");
            Console.WriteLine("| Precio: 200$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 3.  Arco de roble            |");
            Console.WriteLine("| Precio: 150$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 4. Maza de guerra            |");
            Console.WriteLine("| Precio: 180$                 |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|    5. Espada larga de acero  |");
            Console.WriteLine("|Precio: 120$                  |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("|  9. Ver total de compra      |");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine("| 0. salir al menu principal   |");
            Console.WriteLine("|------------------------------|");
            Console.Write("Opcion:");
            respuesta = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (respuesta)
            {
                case 1:
                    total += 80;
                    totalcarrito += 80;
                    Console.WriteLine("Rifle de precisió seleccionado");
                    break;
                case 2:
                    total += 200;
                    totalcarrito += 200;
                    Console.WriteLine("Escopeta de calibre 12 seleccionado");
                    break;
                case 3:
                    total += 150;
                    totalcarrito += 150;
                    Console.WriteLine("Glock 17 de 19mm seleccionado");
                    break;
                case 4:
                    total += 180;
                    totalcarrito += 180;
                    Console.WriteLine("Carabina colt m16 .22LR seleccionado");
                    break;
                case 5:
                    total += 120;
                    totalcarrito += 120;
                    Console.WriteLine("Benelli M3 (Escopeta)");
                    break;
                case 9:
                    Console.WriteLine($"Total de la compra: {total}$");
                    break;
                case 0:
                    Console.WriteLine("Gracias por su compra.");
                    break;
                default:
                    Console.WriteLine("");
                    Console.ReadKey();
                    break;
            }
            if (respuesta != 0 && respuesta != 9)
            {
                Console.WriteLine("¿Quiere seguir comprando?");
                Console.WriteLine("Pulse la tecla ENTER...");
            }
            else
            {
                Console.WriteLine($"El resultado total es: {total}$");
                Console.WriteLine("Presione ENTER para termianr...");
                Console.ReadKey();

            }
        }
    }
    static void Historia()
    {
        int pagina = 0;
        int opcion = 1;

        while (opcion != 0)
        {
            Console.Clear();

            if (pagina == 1)
            {
                Console.WriteLine("====================PAGINA (1/5)=============================");
                Console.WriteLine("Las armas han acompañado a la humanidad desde la prehistoria");
                Console.WriteLine("los primeros instrumentos eran simples de piedras afiladas");
                Console.WriteLine("con el tiempo evolucionaron hacia lanzas, arcos y espadas.");
            } else if (pagina == 2)
            {
                Console.WriteLine("====================PAGINA (2/5)============================================");
                Console.WriteLine("Durante la edad media se perfeccionaron las armas blancas");
                Console.WriteLine("la metalurgia permitio fabricar armaduras, escudos y espadas mas resistentes");
                Console.WriteLine("fue una epoca donde nacieron las armas de asedio, como catapultas.");
            } else if (pagina == 3)
            {
                Console.WriteLine("====================PAGINA (3/5)====================================================");
                Console.WriteLine("A medida que pasaba el tiempo las armas fuereon mejorando hasta llegar a");
                Console.WriteLine("la pólvora, china revolucionó la guerra tal y como se conocia, al principio solo se ");
                Console.WriteLine("usaba para hacer fuegos artificiales, pero un alquimista chino se dio cuenta de que ");
            } else if (pagina == 4)
            {
                Console.WriteLine("====================PAGINA (4/5)===================================================");
                Console.WriteLine("la pólvora era algo más que simples fuegos artificales. Se dio cuenta que al juntar");
                Console.WriteLine("salitre, azufre y carbón, hacia una reaccion quimica tan potente que herá mortal");
                Console.WriteLine("ha medida que pasaba el tiempo se fueron perfeccionando y en Europa no llego hasta");
                Console.WriteLine("finales del siglo XIII a través de la peninsula Iberica.");
            } else if (pagina == 5)
            {
                Console.WriteLine("====================PAGINA (5/5)===========================================================");
                Console.WriteLine("A medida que pasaba el tiempo se fue mejorando hasta llegar a día de hoy que las armas son");
                Console.WriteLine("tan potentes como para poder destruir el plante entero con tan solo tres bombas atomicas.");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Pasar de página"          );
            Console.WriteLine("----------------------------");
            Console.WriteLine("2. Anterior página"          );
            Console.WriteLine("----------------------------");
            Console.WriteLine("0. Volver al menu principal");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Eliga una opción: "          );
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1 && pagina < 5)
            {
                pagina ++;
            } else if (opcion == 2 && pagina > 1)
                pagina --;
        }
    }
}