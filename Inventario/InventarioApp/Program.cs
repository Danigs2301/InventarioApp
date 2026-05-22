

//Variables
int itemsEnInventario = 0;
decimal valorTotalInventario = 0.00m;
bool sistemaActivo = true;

ShowBanner();
bool continuar = true;

while (continuar){
    showMenu();
    string comando = LeerEntrada("Inventario ");
    Console.WriteLine($"Comando ingresado: {comando}");
    continuar = false;
}

//========= METODOS =========
bool ProcesarComando(string comando){
    switch(comando){
        case "listar":
            ListarProductos();
            return true;
        
        case "agregar":
            AgregarProducto();
            return true;
        
        case "buscar":
            BuscarProducto();
            return true;

        case "salir":
            Console.WriteLine($"Hasta luego");
            sistemaActivo = false;
            return false;
        
        default:
            Console.WriteLine($"Comando no valido: '{comando}'");
            return true;
    }
}

void ListarProductos(){
    Console.WriteLine($"Items en inventario: {itemsEnInventario}");
    Console.WriteLine($"Valor de inventario: {valorTotalInventario}");
}

void AgregarProducto(){
    Console.WriteLine($"Agregar producto: Modulo 3");
}

void BuscarProducto(){
    Console.WriteLine($"Buscar producto: Modulo 4");
}

string LeerEntrada(string prompt){
    string salida = "El prompt ingresado es: " + prompt;
    return salida;
}   

string showMenu(){
    return
    "MENU PRINCIPAL\n" +
    "1. lista - Ver productos\n" +
    "2. agregar - Agregar producto\n" +
    "3. buscar - Buscar producto\n" +
    "4. salir - Terminar\n";
}

// void showMenu(){
//     Console.WriteLine($"Coloque la opción a realizar:");
//     string? input = Console.ReadLine();
//     string comandoLimpio = string.IsNullOrEmpty(input) ? "salir" : input.Trim().ToLower() ?? "salir";

//     switch(comandoLimpio){
//         case "salir":
//             Console.WriteLine($"Hasta luego");
//             sistemaActivo = false;
//             break;
        
//         case "listar":
//             Console.WriteLine($"Items en inventario: {itemsEnInventario}");
//             break;

//         default:
//             Console.WriteLine($"Comando desconocido: '{comandoLimpio}'");
//             Console.WriteLine($"Comandos disponibles: agregar, remover, mostrar, salir");
//             break;
//     }
// }



void ShowBanner(){
    Console.WriteLine($"App de gestión de inventario versión");
}

void ShowHelp(){
    Console.WriteLine("Uso: InventarioApp [comando] [opciones]");
    Console.WriteLine("Comandos:");
    Console.WriteLine("  --help - h Muestra esta ayuda.");
    Console.WriteLine("  --version, -v Muestra la versión de la aplicación.");
    Console.WriteLine("");
    Console.WriteLine("EJEMPLOS:");
    Console.WriteLine("dotnet run -- --help");
    Console.WriteLine("dotnet run -- --version");
}