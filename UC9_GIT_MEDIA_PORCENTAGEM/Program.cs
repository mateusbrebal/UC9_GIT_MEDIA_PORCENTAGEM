string[,] alunos = new string[5, 7];
int l, c;
double media, faltas;

l = 0;
c = 0;
media = 0;
faltas = 0;

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

    c = 0;
}

for (l = 0; l <=4; l++)
{
    media = (double.Parse(alunos[l, 3]) * 0.3) + (double.Parse(alunos[l, 4]) * 0.25) + (double.Parse(alunos[l, 5]) * 0.35) + double.Parse(alunos[l, 6]);
    faltas = (double.Parse(alunos[l, 2]) * 100) / double.Parse(alunos[l, 1]);

}