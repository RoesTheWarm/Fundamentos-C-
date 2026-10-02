//Console.WriteLine("Hello, World!");



int totalJugador = 25;
int totalDealer = 15;
string message;
 //Blackjack, juntar 21 pidiendo cartas o en caso de tener menos de 21 igual tener mayor puntuacion que el dealer

if (totalJugador > totalDealer && totalJugador < 22)
{
    message = "Venciste al dealer, felicidades!";
}
else if (totalJugador >= 21)
{
    message = "Perdiste vs el dealer, pasaste de 21";
}
else if (totalJugador <= totalDealer)
{
    message = "Perdiste vs el dealer, lo siento";
}
else
{
    message = "Condicion no valida";
}

Console.WriteLine($"{message}");