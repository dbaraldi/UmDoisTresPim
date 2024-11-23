Console.Clear();

int qtdExecutada = 0;
int maxExecucoes = 40;

while (qtdExecutada < maxExecucoes)
{
    qtdExecutada = qtdExecutada + 1;
    Console.Write(qtdExecutada %4 == 0 ? "pim\n" : $"{qtdExecutada,1} ");
}
