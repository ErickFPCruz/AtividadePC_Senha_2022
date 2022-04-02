Console.Clear();

Console.Write("Por favor, escreva tua senha aqui: ");

bool senhaDoUsuario = Console.ReadLine() == "umaSenhaIncrivelmenteSegura";

if (senhaDoUsuario)
{
    Console.WriteLine("Acesso permitido!");
}

else
{
    Console.WriteLine("Acesso negado!");

}