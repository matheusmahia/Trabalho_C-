Matheus Henrique Ferreira Machado  37780514

Killdery José Gois Santos          31417103

Descrição Funcional de Cada Exercício

1️. Validador de Senhas Fortes
Solicita ao usuário uma senha e verifica se ela atende aos critérios de segurança:

- Mínimo de 8 caracteres

- Pelo menos uma letra maiúscula

- Pelo menos um número

- Pelo menos um caractere especial

2️. Tabuada Completa com Laço
Solicita um número ao usuário e imprime a tabuada completa de 1 a 10 utilizando um laço for.

3️. Cálculo de Fatorial com while
Recebe um número inteiro positivo do usuário e calcula seu fatorial utilizando um laço while.

4️. Conversor de Temperaturas com Menu
Cria um menu interativo para converter temperaturas entre Celsius e Fahrenheit. Utiliza switch e while para manter o menu ativo até que o usuário escolha sair.

5️. Verificador de Palíndromos
Solicita uma palavra ou frase ao usuário e verifica se é um palíndromo (lê-se igual de frente para trás e de trás para frente, ignorando espaços e acentos).

6️. Cadastro Simples de Produtos
Cria uma classe Produto com propriedades Nome, Preço e Quantidade. O usuário cadastra 3 produtos e o programa exibe a lista junto ao valor total em estoque (Preço * Quantidade).

7️. Soma de Números Pares de um Array
O usuário insere 10 números em um array. O programa calcula e exibe a soma apenas dos números pares.

8️. Cálculo de IMC com Classificação
Solicita o peso e a altura do usuário, calcula o IMC e exibe a classificação:

- Abaixo de 18.5: Abaixo do peso

- 18.5 a 24.9: Peso normal

- 25 a 29.9: Sobrepeso

- 30 ou mais: Obesidade

9️. Jogo da Adivinhação
Gera um número aleatório entre 1 e 100 e pede que o usuário tente adivinhar. Informa se o número é maior ou menor e conta o número de tentativas.

10. Lista de Tarefas (To-Do List)
Permite que o usuário adicione tarefas a uma lista e, ao final, exibe todas as tarefas inseridas. Usa List<string> e oferece opção para marcar tarefas como concluídas.


DESCRIÇÃO DE DOIS EXERCÍCIOS DETALHADOS


Validador de Senhas

Este programa verifica se uma senha atende aos critérios de segurança mínimos.
 Passos da implementação:
- Solicitação da senha ao usuário
- O programa exibe uma mensagem no console pedindo uma senha.
- Usa Console.ReadLine() para capturar a entrada do usuário.
- Validação da senha
- Chama o método ValidarSenha(senha) para verificar se a senha atende aos requisitos:
- Comprimento mínimo: A senha deve ter pelo menos 8 caracteres (senha.Length < 8).
- Presença de uma letra maiúscula: Utiliza char.IsUpper(c).
- Presença de um número: Usa char.IsDigit(c).
- Presença de um caractere especial: Verifica se o caractere não é letra nem número com !char.IsLetterOrDigit(c).
- Exibição do resultado
- Se a senha for forte, exibe "Senha forte!".
- Caso contrário, informa ao usuário os critérios que não foram atendidos.
- 
   Estruturas e Comandos Utilizados:
  
- Métodos da classe char (char.IsUpper, char.IsDigit, char.IsLetterOrDigit) para validar a senha.
- Laço foreach para percorrer cada caractere da senha e verificar suas propriedades.
- Condicional if para determinar se a senha atende a todos os critérios.
- 
   Justificativa das escolhas
  
- A verificação dos critérios dentro de um único método ValidarSenha torna o código modular e fácil de reutilizar.
- O uso de booleanos (temMaiuscula, temNumero, temEspecial) facilita a lógica de validação sem necessidade de múltiplos retornos.
- A validação é feita dentro de um foreach, garantindo que todos os caracteres da senha sejam analisados de maneira eficiente.


 Soma de Números Pares 
 
 
Este programa solicita ao usuário 10 números, armazena-os em um array e calcula a soma apenas dos números pares.
 Passos da implementação:
- Declaração das variáveis
- Cria um array numeros com tamanho 10 para armazenar os números digitados.
- Inicializa somaPares como 0, que armazenará a soma dos números pares.
- Entrada de dados
- Exibe a mensagem "Digite 10 números:".
- Utiliza um laço for para pedir 10 números ao usuário.
- Usa Console.ReadLine() para capturar a entrada e int.TryParse() para validar se é um número inteiro. Caso contrário, exibe uma mensagem "Entrada inválida! Digite um número inteiro." e solicita um novo valor.
- Identificação de números pares
- Dentro do laço for, verifica se o número digitado é par (numeros[i] % 2 == 0).
- Se for par, adiciona seu valor à variável somaPares.
- Exibição do resultado
- Após o laço for, exibe a soma dos números pares com Console.WriteLine($"\nA soma dos números pares é: {somaPares}").

 Estruturas e Comandos Utilizados
- Array int[] para armazenar os números.
- Laço for para iterar 10 vezes e coletar os números.
- int.TryParse() para validar a entrada e garantir que seja um número inteiro.
- Condicional if para identificar números pares (% 2 == 0).
- Acumulador somaPares para armazenar a soma dos números pares.

Justificativa das Escolhas
- O uso de int.TryParse() evita que o programa quebre ao receber entradas inválidas e melhora a experiência do usuário.
- A estrutura de array int[] permite armazenar os números para possíveis operações futuras.
- O laço for garante que o programa execute exatamente 10 interações de entrada.
- A verificação % 2 == 0 é uma maneira simples e eficiente de identificar números pares.










