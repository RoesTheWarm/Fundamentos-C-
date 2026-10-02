Console.WriteLine("Hello, World!");

Console.WriteLine("Bryhan Pedrero ID!");
int altura  = 168;
int edad = 26;
string nombre = "Bryhan Pedrero";
string informacion = "Nacio en Cali, es estudiante de ing de software";
var hobby = "deportista";

string tarjetaDeIdentificacion = $"La informacion de {nombre} es la siguiente.\n" +
    $"Su edad es {edad} años, su altura es {altura}cms\n" +
    $"Informacion relevante {informacion} \n" +
    $"Ademas, su hobby es {hobby}";

Console.WriteLine(tarjetaDeIdentificacion);