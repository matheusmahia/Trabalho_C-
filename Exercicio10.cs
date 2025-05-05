using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        int opcao;

        do
        {
            Console.WriteLine("\nLista de Tarefas");
            Console.WriteLine("1 | Adicionar tarefa");
            Console.WriteLine("2 | Listar tarefas");
            Console.WriteLine("3 | Remover tarefa concluída");
            Console.WriteLine("4 | Sair");
            Console.Write("Escolha uma opção: ");

            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Entrada inválida! Escolha uma opção entre 1 e 4.");
                Console.Write("Escolha uma opção: ");
            }

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a nova tarefa: ");
                    string tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    Console.WriteLine("Tarefa adicionada!");
                    break;

                case 2:
                    Console.WriteLine("\n Tarefas pendentes:");
                    if (tarefas.Count == 0)
                        Console.WriteLine("Nenhuma tarefa cadastrada!");
                    else
                    {
                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tarefas[i]}");
                        }
                    }
                    break;

                case 3:
                    Console.Write("Digite o número da tarefa concluída para remover: ");
                    int indice;
                    while (!int.TryParse(Console.ReadLine(), out indice) || indice < 1 || indice > tarefas.Count)
                    {
                        Console.WriteLine("Número inválido! Digite um número válido da lista.");
                        Console.Write("Digite o número da tarefa concluída para remover: ");
                    }
                    tarefas.RemoveAt(indice - 1);
                    Console.WriteLine("Tarefa removida!");
                    break;

                case 4:
                    Console.WriteLine("Saindo da lista de tarefas.");
                    break;
            }
        } while (opcao != 4);
    }
}