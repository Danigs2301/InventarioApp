using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine($"Platform: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine($"Application Version: {version}");
Console.WriteLine($"Estructura del proyecto:");
Console.WriteLine($"Configuracion .csproj:");
Console.WriteLine($"Carpeta src/ creada:");
Console.WriteLine($"Metadatos configurados:");
Console.WriteLine($"Estructura del proyecto:");
Console.WriteLine($"Estructura del proyecto:");
Console.WriteLine($"Estructura del proyecto:");