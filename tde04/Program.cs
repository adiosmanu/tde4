//Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
// Aluno tem anos e nota usando a concatenação e a interpolação de strings.

// string nome = "Paulo";
// int idade = 17;
// double nota = 7.5;

// Console.WriteLine(nome + " tem " + idade + " anos, e sua nota é " + nota);

//Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
//escapes.


// string dados = "\nPaulo\n17 anos\nnota 7.5";

// Console.WriteLine(dados);

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double
// ( ) long
// ( ) decimal 

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// ( ) int para long
// ( ) double para long
// (x) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem 
// reversa usando a concatenação e também a interpolação de strings

// Console.WriteLine("Digite a primeira letra:");
// char letra1 = Console.ReadKey().KeyChar;
// Console.WriteLine("\nDigite a segunda letra:");
// char letra2 = Console.ReadKey().KeyChar;
// Console.WriteLine("\nDigite a terceira letra:");
// char letra3 = Console.ReadKey().KeyChar;
// Console.WriteLine(); 


// string concatenacao = "" + letra3 + letra2 + letra1;
// Console.WriteLine("Letras na ordem reversa : " + concatenacao);

        
// string interpolacao = $"{letra3}{letra2}{letra1}";
// Console.WriteLine($"Letras na ordem de interpolação: {interpolacao}");

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V)string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (V ) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (V) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical

// Escreva um programa para receber dois valores via teclado do tipo double e a 
// seguir realize as operações de soma, subtração, multiplicação, exponenciação, 
// divisão e móduloexibindo o resultado:


// Console.WriteLine("Informe o valor de x");
// double x = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Informe o valor de y");
// double y = Convert.ToDouble(Console.ReadLine());

// double soma = x + y;
// double subtracao = x - y;
// double multiplicacao = x * y;
// double exponenciacao = Math.Pow(x, y);
// double divisao = x/y;
// double modulo = x % y;

// Console.WriteLine($"Soma {soma}");
// Console.WriteLine($"Subtração {subtracao}");
// Console.WriteLine($"Multiplicação {multiplicacao}");
// Console.WriteLine($"exponenciacao {Math.Pow(x, y)}");
// Console.WriteLine($"Divisão {divisao}");
// Console.WriteLine($"Modulo {modulo}");

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

// Console.WriteLine("Digite o nome:");
// string nome = Console.ReadLine();

// Console.WriteLine("Digite a senha:");
// int senha;
// bool senhaValida = int.TryParse(Console.ReadLine(), out senha);

// string mensagem = (nome == "admin" || nome == "maria") && senhaValida && senha == 123 ? "Login feito com sucesso" : "Login inválido";

// Console.WriteLine(mensagem);

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)


