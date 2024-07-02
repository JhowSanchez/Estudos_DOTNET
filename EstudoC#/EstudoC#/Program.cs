/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();*/

using EstudoC_.Models;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Security.Cryptography;



/*
//Inversao de Dependencias
GerarGarrafa();
      Animal
Cachorro  Gato 

//Inversao
ILimpar limpar = Factory.get("Cachorro");
Limpar.Limpar();



//Tipos de dados Especiais

bool? ReceberEmail = null;

if (ReceberEmail.HasValue && ReceberEmail.Value)
    Console.WriteLine("O usuarii optou por receber e-mail");
else
    Console.WriteLine("O usuario não respondeu ou optou por nao receber e-mail");

string ConteudoArquivo = File.ReadAllText("Arquivos/vendasLista.json");

List<Vendas> lista = JsonConvert.DeserializeObject<List<Vendas>>(ConteudoArquivo);

foreach (Vendas item in lista)
{
    Console.WriteLine($"ID: {item.Id},"+
        $" Produto: {item.Produto}, "+
        $"Preço: {item.Preco}, "+
        $"DataVenda: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}"+
        $"{(item.Desconto.HasValue ? $", Desconto de: {item.Desconto} ": "")}");
}



//Tipo Anonimo

var TipoAnonimo = new {Nome = "Jou", Sobrenome = "Wandinha", Altura = 1.80 };

Console.WriteLine($"Nome: {TipoAnonimo.Nome}");
Console.WriteLine($"Sobrenome: {TipoAnonimo.Sobrenome}");
Console.WriteLine($"Altura: {TipoAnonimo.Altura}");

// Em uma Coleção

string ConteudoArquivo = File.ReadAllText("Arquivos/vendasLista.json");

List<Vendas> lista = JsonConvert.DeserializeObject<List<Vendas>>(ConteudoArquivo);

var ListaAnonimo = lista.Select(x => new { x.Produto, x.Preco});

foreach(var venda in ListaAnonimo)
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");


//Tipos Dinamicos

dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = "Texto";
Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = true;
Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");



//Classe genericas
MeuArray<int> arrayInterio = new MeuArray<int>();
arrayInterio.AdcionarElementoArray(30);
Console.WriteLine(arrayInterio[0]);

MeuArray<string> arrayString = new MeuArray<String>();
arrayString.AdcionarElementoArray("Teste");
Console.WriteLine(arrayString[0]);


//Metodo de Extensão

int numero = 20;
bool par = false;

par = numero.EhPar();
string mensagem = "O numero " + numero + " " + "É " + (par? "par":"Impar");
Console.WriteLine(mensagem);
*/






/*
//Site para VERIFICAR seu JSON e minimizar o tamanho dele para envio ou validar quando receber 
//https://codebeautify.org/jsonviewer
List<Vendas> ListaVendas = new List<Vendas>(); 
DateTime dataAtual = DateTime.Now;
Vendas n1 = new Vendas(1, "Material", 25.00M);
Vendas n2 = new Vendas(2, "Material 2", 35.00M);
Vendas n3 = new Vendas(2, "Material 2", 35.00M,dataAtual);
Vendas n4 = new Vendas(2, "Material 2", 35.00M,dataAtual);


string serializado = JsonConvert.SerializeObject(n1);
string serializadoFormat = JsonConvert.SerializeObject(n1, Formatting.Indented);

ListaVendas.Add(n1);
ListaVendas.Add(n2);    
ListaVendas.Add(n3);
ListaVendas.Add(n4);

string serializadoLista = JsonConvert.SerializeObject(ListaVendas);
string serializadoListaFormat = JsonConvert.SerializeObject(ListaVendas, Formatting.Indented);

//Escrevendo em JSON
File.WriteAllText("Arquivos/vendas.json", serializadoFormat);
File.WriteAllText("Arquivos/vendasLista.json", serializadoListaFormat);

Console.WriteLine(serializadoFormat);
Console.WriteLine("\n#######################\n");
Console.WriteLine(serializadoListaFormat);


//Deserializar , Importar um JSON

string ConteudoArquivo = File.ReadAllText("Arquivos/vendasLista.json");

 List<Vendas> lista = JsonConvert.DeserializeObject<List<Vendas>>(ConteudoArquivo);

foreach (Vendas item in lista)
{
    Console.WriteLine($"ID: {item.Id}, Produto: {item.Produto}, Preço: {item.Preco}, DataVenda: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


Console.WriteLine("\n##############\n");
//Atributos 

string ConteudoArquivoProp = File.ReadAllText("Arquivos/vendas.json");

List<Vendas> listaP = JsonConvert.DeserializeObject<List<Vendas>>(ConteudoArquivoProp);

foreach (Vendas item in listaP)
{
    Console.WriteLine($"ID: {item.Id}, Produto: {item.Produto}, Preço: {item.Preco}, DataVenda: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


//####    Estrutura de Dados    #### 

/*Console.WriteLine("Hello World");
Pessoa pes = new Pessoa( idade: 10, Sobrenome: "Sanchez", nome: "Jou");
//Pessoa pesB = new Pessoa.PessoaBiulder().SetNome("Jou").SetIdade(20).Biulder();
//pesB.Apresentar();
//pesB.Nome = "Jou";
Console.WriteLine(pes);

string[] Linhas = File.ReadAllLines("Arquivos/ArquivoTeste.txt");

try
{
    foreach (string line in Linhas)
        Console.WriteLine(line);
}
catch (FileNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro na leitura. Arquivo não encontrado. "+e.Message);
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine($"Ocorreu um erro na leitura. Caminho da pasta não encontrado. "+e.Message);
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro na leitura. {e.Message}");
}
finally //Executado sempre mesmo se der erro  ou não ## Exemplo, fez consulta no banco e mesmo que der errado ou certo ele finaliza a conexão do banco com o finally
{
    Console.WriteLine($"Chegou ate aqui");
}



new ExemploExcecao().Metodo1();



//Fila e Pilhas 

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (var item in fila)  
    Console.WriteLine(item);

Console.WriteLine(fila.Dequeue());
Console.WriteLine("##################");

foreach (var item in fila)
    Console.WriteLine(item);

Console.WriteLine("\nPilhas\n");

Stack<int> Pilha = new Stack<int>();

Pilha.Push(1);
Pilha.Push(2);
Pilha.Push(3);
Pilha.Push(4);

foreach (var item in Pilha)
    Console.WriteLine(item);

Console.WriteLine($"Remover Elemento da Pilha: " + Pilha.Pop());

Pilha.Push(20);
foreach (var item in Pilha)
    Console.WriteLine(item);




//Dictionary



//          Chave  Valor     // Chave deve ser unico
Dictionary<string, string> Estados = new Dictionary<string, string>();

Estados.Add("SP","São Paulo");
Estados.Add("BA","Bahia");
Estados.Add("MG","Minas Gerais");
Estados.Add("MT","Mato Grosso");

foreach (var item in Estados)
    Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");

//Erro pois a chave deve ser unica!
//Estados.Add("MG", "Minas Gerais");
Estados.Remove("BA");
Console.WriteLine("---------------------");
foreach (var item in Estados)
    Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");

Console.WriteLine("---------------------");
Estados["SP"] = "São Paulo - Valor Alterado";

foreach (var item in Estados)
    Console.WriteLine($"Chave : {item.Key}, Valor: {item.Value}");

Console.WriteLine("Verificando Elemento");

string chave = "SP";

if (Estados.ContainsKey(chave))
    Console.WriteLine("Chave existente");
else
    Console.WriteLine($"Chave não existente. Seguro adicionar a chave {chave} ");
//Consultando um valor
Console.WriteLine(Estados["SP"]);





//Tuplas

(int ID, string Nome, string Sobrenome,decimal Altura) tupla = (1,"Jonathan","Sanchez",10.5M);
Console.WriteLine(tupla);
Console.WriteLine($"ID: "+tupla.ID);
Console.WriteLine($"Nome: "+tupla.Nome);
Console.WriteLine($"Sobrenome: "+tupla.Sobrenome);
Console.WriteLine($"Altura: "+tupla.Altura);

Console.WriteLine("##########################");
//Nesse novos modelos não tem como dar um nome aos tipos da tuplas
ValueTuple<int, string, string, decimal> tupla2 = (2, "Jou", "Wandinha", 10.3M);
var tupla3 = Tuple.Create(3,"Flavinha","Mello",1.5M);

Console.WriteLine(tupla2);
Console.WriteLine($"ID: " + tupla2.Item1);
Console.WriteLine($"Nome: " + tupla2.Item2);
Console.WriteLine($"Sobrenome: " + tupla2.Item3);
Console.WriteLine($"Altura: " + tupla2.Item4);


//Tupla em Metodos


LeituraArquivo ler = new LeituraArquivo();
(bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) Tupla = ler.LerArquivo("Arquivos/ArquivoTeste.txt");
//ler.LerArquivo("ArquivoTeste.txt");
Console.WriteLine("\nTupla em Metodos\n");

if (Tupla.Sucesso)
{
    Console.WriteLine(Tupla.Sucesso);
    Console.WriteLine(Tupla.QuantidadeDeLinhas);
    foreach (var item in Tupla.Linhas)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o Arquivo!!!");
}

Console.WriteLine("##########################");
var (Sucesso, LinhasArquivo, QuantidadeDeLinhas) = ler.LerArquivo("Arquivo/ArquivoTeste.txt");


Console.WriteLine("Tupla em Metodos\n");
if(Sucesso)
{
    Console.WriteLine(Sucesso);
    Console.WriteLine(QuantidadeDeLinhas);
    foreach (var item in LinhasArquivo)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o Arquivo!!!");
}


//Descarte em Tuplas

var (Sucesso1, LinhasArquivo1, _) = ler.LerArquivo("Arquivo/ArquivoTeste.txt");
(bool Sucesso, string[] Linhas, int _) Tupla1 = ler.LerArquivo("Arquivos/ArquivoTeste.txt");




//Desconstrutor
//Esta na classe pessoa
Pessoa p1 = new Pessoa("Leonardo","Buta",10);

(string nome, string sobrenome, int idade) = p1;
Console.WriteLine($"{nome} {sobrenome} {idade}");




//IF Ternario

int num = 20;
bool ehPar = false;

ehPar = num % 2 == 0;
Console.WriteLine($"O numero {num} é " + (ehPar ? "par" : "impart"));



if (num % 2 == 0)
    Console.WriteLine($"O numero {num} e par");
else 
    Console.WriteLine($"O numero {num} e impar");
*/


