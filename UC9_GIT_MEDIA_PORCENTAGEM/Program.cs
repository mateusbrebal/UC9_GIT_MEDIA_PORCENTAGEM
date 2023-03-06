string[,] alunos = new string[5, 7];
int l, c;

l = 0;
c = 0;

for (l = 0; l <= 4; l++)
{
    Console.WriteLine("NOME do Aluno:"); 
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Aulas Dadas:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("FALTAS do Aluno:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nota da PROVA 1:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nota da PROVA 2:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nota da PROVA 3:");
    alunos[l, c++] = Console.ReadLine();
    Console.WriteLine("Nota da TRABALHO:");
    alunos[l, c++] = Console.ReadLine();
}
