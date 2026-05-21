using System.Reflection;

//Exit codes:
//0: Success
//1: Invalid command
//2: Unknown command

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

if (args.Length > 0) {
    switch(args[0]){
        case "--help":
            ShowHelp();
            Environment.Exit(0);
            break;
        
        case "--version":
            Console.WriteLine($"InventarioApp v[{version}]");
            Environment.Exit(0);
            break;

        

        default:
            Console.WriteLine($"Error: Comando desconocido: '{args[0]}'");
            Console.WriteLine($"Use --help para ver los comandos disponibles.");
            Environment.Exit(2);
            break;

        
    }
}

ShowBanner();

//Interactive mode if no arguments provided
Console.WriteLine($"Insert command (o 'salir' para terminar):");
string? input = Console.ReadLine(); //STDIN para leer comandos del usuario

if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "salir") {
    Console.WriteLine($"Hasta luego");
    Environment.Exit(0);
}


// Console.WriteLine($"Estructura del proyecto:");
// Console.WriteLine($"InventarioApp/");
// Console.WriteLine($" |-- Program.cs");
// Console.WriteLine($" |-- InventarioApp.csproj");
// Console.WriteLine($" |-- gitignore");
// Console.WriteLine($" |-- Readme.md");
// Console.WriteLine($" |-- src/");
// Console.WriteLine($" |-- Models/");
// Console.WriteLine($"Configuracion .csproj:");
// Console.WriteLine($"Carpeta src/ creada:");
// Console.WriteLine($"Metadatos configurados:");

void ShowBanner(){
    Console.WriteLine($"InventarioApp v[{version}]");
    Console.WriteLine($".NET: {Environment.Version}");
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