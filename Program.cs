/*Solicite que o usuário digite uma frase. Exiba a frase como se ela fosse dita pelo Cebolinha, da Turma da Mônica.
Lembre-se que o Cebolinha tem um disturbio na fala chamado dislalia, que o faz trocar o r pelo l.

Por exemplo, a frase Eu troco as letras, não falo bem, mas meus amigos não troco por ninguém será dita pelo Cebolinha como Eu tloco as letlas, não falo bem, mas meus amigos não tloco pol ninguém.
*/

Console.WriteLine("Digite uma frase:");
String frase = Console.ReadLine();
String fraseCebolinha = frase.Replace("r", "l").Replace("R","L");
Console.WriteLine($"O Cebolinha iria dizer:{fraseCebolinha}");