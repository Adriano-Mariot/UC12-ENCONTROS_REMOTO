using ENCONTRO_REMOTO_2.classes;
using System.Text.RegularExpressions; // para usara a class Regex

//metodos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica(); //objeto criado para utilização dos metodos

//listas 
List <PessoaFisica> ListaPf=new List<PessoaFisica>(); // lista vazia inicializada
List <PessoaJuridica> ListaPj=new List<PessoaJuridica>(); // lista vazia inicializada                                   

Console.Clear();
//cabeçalho do sistema
Console.WriteLine(@$"
=======================================
|                                     |
| Bem Vindo ao sistema de Cadastro de |
|    Pessoas Físicas e Jurídicas      |
|                                     |
=======================================
");
//Loading class Utils
Utils.loading("Carregando ",5,500);

//Menu do tipo de pessoa
string? op1;
do
{
    Console.WriteLine(@$"
    =======================================
    |           Menu Principal            |
    |    Escolha uma das opções Abaixo    |
    | ----------------------------------- |
    |         1 - Pessoa Física           |
    |         2 - Pessoa Jurídica         |
    |                                     |
    |         0 - Sair                    |
    =======================================
    ");

    op1 = Console.ReadLine();

    switch (op1)
    {
        case "0":
                Console.Clear();            
            break;
        case "1": //pessoa fisica

                string? opcaoPf;
                do
                {
                Console.Clear();
 Console.WriteLine(@$"
    =======================================
    |          Menu Pessoa Fisica         |
    |    Escolha uma das opções Abaixo    |
    | ----------------------------------- |
    |  1 - Cadastrar Pessoa Física        |
    |  2 - Mostrar dados Pessoa Física    |
    |                                     |
    |  0 - Voltar para o Menu anterior    |
    =======================================
                            ");                                       
                            opcaoPf = Console.ReadLine();                             

                            switch (opcaoPf)
                            {
                                case "0":
                                    Utils.ParadaNoConsole("Retornando para o menu Principal");
                                    break;
                                case "1":
                                    Console.Clear(); 
                                    Utils.ParadaNoConsole("Iniciando o Cadastro de Pessoa Fisica!");

                                    //Endereço
                                    Endereco endPf1 = new Endereco();

                                    Console.Write("Qual endereço ? : ");
                                    endPf1.Logradoura = Console.ReadLine();
                                    Console.Write("Qual numero ? : ");
                                    endPf1.Numero = int.Parse(Console.ReadLine());
                                    Console.Write("Indereço comercial? [s/n] : ");
                                    string comercial = Console.ReadLine();
                                    if (comercial=="s")
                                    {
                                        endPf1.Comercial = true;
                                    }
                                    else if(comercial =="n")
                                    {
                                        endPf1.Comercial = false;
                                    }
                                    
                                    //Atributos da pessoa
                                    PessoaFisica pf1 = new PessoaFisica("000000000");
                                    
                                    Console.Write("Qual nome completo? : ");
                                    pf1.Nome = Console.ReadLine();
                                    pf1.DataNaceimento = new DateTime(1985, 5, 3);
                                    Console.Write("Qual CPF? : ");
                                    pf1.Cpf= Console.ReadLine();
                                    Console.Write("Qual Seu rendimento bruto? : ");
                                    pf1.Rendimento = float.Parse(Console.ReadLine());
                                    Console.WriteLine("");
                                    pf1.Endereco = endPf1;

                                    //Adciona objetos dentro da lista pessoa fisica
                                    ListaPf.Add(pf1);                            

                                    Utils.ParadaNoConsole("Pessoa fisica Cadastrada com Sucesso!");
                                    break;

                                case "2":
                                    Console.Clear();
                                    Utils.loading("Carregando Dados de Pessoas Fisicas ",3,300);
                                    Console.WriteLine("--------------Lista de Pessoas Físicas-----------");

                                    foreach (var pessoa in ListaPf)
                                    {
                                        Console.WriteLine($"\nNome = {pessoa.Nome}");
                                        Console.WriteLine($"Cpf = {pessoa.Cpf}");
                                        Console.WriteLine($"Rendimentos Anual= {pessoa.Rendimento}");
                                        Console.WriteLine($"Rendimentos Liquido = {metodosPf.PagarImposto(pessoa.Rendimento)}");
                                        Console.WriteLine($"Idade = {pessoa.DataNaceimento.ToShortDateString()}");
                                        Console.WriteLine(metodosPf.ValidarDataNascimento (pessoa.DataNaceimento) ? "Maior de Idade : Sim! " : "Maior de Idade : Não! ");
                                        Console.WriteLine($"Logradouro = {pessoa.Endereco.Logradoura},{pessoa.Endereco.Numero}");                                      
                                        Console.WriteLine((pessoa.Endereco.Comercial) ? "Endereço comercial? : Sim! " : "Endereço comercial? : Não! ");
                                    }
                                             
                                    Utils.ParadaNoConsole(" ");
                                    break;
                                default:
                                    Console.Clear();
                                    Utils.ParadaNoConsole("Opção Invalida!");
                                    break;
                            }
                            
                }while(opcaoPf != "0");         

                
            break;
        case "2": //pessoa Juridica
         string? opcaoPj;
                do
                {
                Console.Clear();
 Console.WriteLine(@$"
    =======================================
    |         Menu Pessoa Jurídica        |
    |    Escolha uma das opções Abaixo    |
    | ----------------------------------- |
    |  1 - Cadastrar Pessoa Jurídica      |
    |  2 - Mostrar dados Pessoa Jurídica  |
    |                                     |
    |  0 - Voltar para o Menu anterior    |
    =======================================
                            ");                                       
                            opcaoPj = Console.ReadLine();                             

                            switch (opcaoPj)
                            {
                                case "0":
                                    Utils.ParadaNoConsole("Retornando para o menu Principal");
                                    break;
                                case "1":
                                    Console.Clear(); 
                                    Utils.ParadaNoConsole("Iniciando o Cadastro de Pessoa Jurídica!");

                                    //Endereço
                                    Endereco endPj1 = new Endereco();
                                
                                    Console.Write("Qual endereço ? : ");
                                    endPj1.Logradoura = Console.ReadLine();
                                    Console.Write("Qual numero ? : ");
                                    endPj1.Numero = int.Parse(Console.ReadLine());
                                    Console.Write("Indereço comercial? [s/n] : ");
                                    string comercial = Console.ReadLine();
                                    if (comercial=="s")
                                    {
                                        endPj1.Comercial = true;
                                    }
                                    else if(comercial =="n")
                                    {
                                        endPj1.Comercial = false;
                                    }
                                    
                                    //Atributos da pessoa
                                    PessoaJuridica pj1 = new PessoaJuridica();
                                    
                                    Console.Write("Qual nome completo do Representante? : ");
                                    pj1.Nome = Console.ReadLine();
                                    Console.Write("Qual a razão social? : ");
                                    pj1.RazaoSocial=Console.ReadLine();
                                    Console.Write("Qual o nome fantasia? : ");
                                    pj1.Fantasia=Console.ReadLine();
                                    Console.Write("Qual CNPJ? : ");
                                    pj1.Cnpj= Console.ReadLine(); //"14.625.806/0001-80"
                                    Console.Write("Qual Seu rendimento bruto? : ");
                                    pj1.Rendimento = float.Parse(Console.ReadLine());
                                    Console.WriteLine("");
                                    pj1.Endereco = endPj1;


                                    //Adciona objetos dentro da lista pessoa fisica
                                    ListaPj.Add(pj1);                            

                                    Utils.ParadaNoConsole("Pessoa Jurídica Cadastrada com Sucesso!");
                                    break;

                                case "2":
                                    Console.Clear();
                                    Utils.loading("Carregando Dados de Pessoas Jurídicas ",3,300);
                                    Console.WriteLine("--------------Lista de Pessoas Jurídicas-----------");

                                    foreach (var pessoaJu in ListaPj)
                                    {
                                        Console.WriteLine($"\nRazão Social : {pessoaJu.RazaoSocial}");
                                        Console.WriteLine($"Nome Fantasia : {pessoaJu.Fantasia}");
                                        Console.WriteLine($"Representante : {pessoaJu.Nome}");
                                        Console.WriteLine($"CNPJ : {pessoaJu.Cnpj}");
                                        Console.WriteLine(metodosPj.ValidarCnpj(pessoaJu.Cnpj) ? "CNPJ é Válido!" : "CNPJ Não é Válido!");
                                        Console.WriteLine($"Rendimento anual : {pessoaJu.Rendimento}");
                                        Console.WriteLine($"Rendimento liquido : {metodosPj.PagarImposto(pessoaJu.Rendimento)}");
                                        Console.WriteLine($"Logradouro = {pessoaJu.Endereco.Logradoura},{pessoaJu.Endereco.Numero}");                                      
                                        Console.WriteLine((pessoaJu.Endereco.Comercial) ? "Endereço comercial? : Sim! " : "Endereço comercial? : Não! ");
                                    }
                                             
                                    Utils.ParadaNoConsole(" ");
                                    break;
                                default:
                                    Console.Clear();
                                    Utils.ParadaNoConsole("Opção Invalida!");
                                    break;
                            }
                            
                }while(opcaoPj != "0");          
            break;
        default:
                Utils.ParadaNoConsole("Opção Invalida ");
            break;
    }

} while (op1 != "0");


Utils.loading("Saindo do sistema! ",3,300);
Console.WriteLine($"FIM");


// // Metodo antigo
// // Pessoa fisica**********************************************************************************

// //Endereço
// Endereco endPf1 = new Endereco();
// endPf1.Logradoura= "Rua lá de Casa";
// endPf1.Numero=123;
// endPf1.Comercial=false;

// //Atributos da pessoa
// PessoaFisica pf1 = new PessoaFisica("000000000");
// PessoaFisica metodosPf = new PessoaFisica();
// pf1.Nome= "Adriano";
// pf1.DataNaceimento = new DateTime(1985, 5, 3);
// //pf1.Cpf= "08888888888";
// pf1.Rendimento=1501;
// pf1.Endereco = endPf1;
 
// // Print do console (Por questão de aprendizado a forma de Usar o metodo WriteLine difere entre pessoa fisica e Juridica )

// Console.WriteLine("\n-------------Dados do Cliente---------------");

// Console.WriteLine($"Nome = {pf1.Nome}");
// Console.WriteLine($"Cpf = {pf1.Cpf}");
// Console.WriteLine($"Rendimentos Anual= {pf1.Rendimento}");
// Console.WriteLine($"Rendimentos Liquido = {metodosPf.PagarImposto(pf1.Rendimento)}");

// Console.WriteLine ("\nFormas de validar Datas de nascimento-------------");
// // variações de datas de nacimento <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
// Console.Write("Maior de Idade ? : ");
// Console.WriteLine(pf1.ValidarDataNascimento ("03/05/1985"));
// Console.WriteLine(metodosPf.ValidarDataNascimento (pf1.DataNaceimento));
// Console.WriteLine(pf1.DataNaceimento.ToShortDateString());

// Console.WriteLine("\n------Endereço-------");
// Console.WriteLine($"Logradouro = {pf1.Endereco.Logradoura}");
// Console.WriteLine($"Numero = {pf1.Endereco.Numero}");
// Console.WriteLine($"Endereço comercial? : {pf1.Endereco.Comercial}\n");


// // DateTime data = new DateTime (1985 ,5,3);
// // Console.WriteLine(pf1.ValidarDataNascimento (data));

// //--------------------------------------------------------------------------------------------------
// // //exemplo concatenação

// // // Console.Write( $" Nome = {pf1.Nome} tem o Cpf = {pf1.Cpf} e o rendimento de R${pf1.Rendimento} por mês.\n" );

// //---------------------------------------------------------------------------------------------------
// // Pessoa Juridica **********************************************************************************

// //Endereço PJ
// Endereco endPj1 = new Endereco();
// endPj1.Logradoura= "Rua lá de Firma";
// endPj1.Numero=123;
// endPj1.Comercial=true;

// //Atributos da pessoa Juridica
// PessoaJuridica pj1 = new PessoaJuridica();
// PessoaJuridica metodosPj = new PessoaJuridica(); //objeto criado para utilização dos metodos
// pj1.Nome= "Adriano Mariot";
// pj1.Endereco = endPj1;

// // Console.WriteLine($"Qual o rendimento ?"); //Exemplo para input dos dados Opcional
// // pj1.Rendimento= float.Parse(Console.ReadLine());

// pj1.Rendimento=5000;
// pj1.Cnpj="14.625.806/0001-80";
// // pj1.Cnpj="14625806000180";
// pj1.RazaoSocial="Ams Soluções Ltda";
// pj1.Fantasia="Magico de OZ";

// // Print do console

// Console.WriteLine("\n-------------Dados da Pessoa Juridica---------------");

// Console.WriteLine(@$" 
// Razão Social : {pj1.RazaoSocial}
// Nome Fantasia : {pj1.Fantasia}
// Representante : {pj1.Nome}
// CNPJ : {pj1.Cnpj}
// CNPJ é Válido? : {metodosPj.ValidarCnpj(pj1.Cnpj)}
// Rendimento anual : {pj1.Rendimento}
// Rendimento liquido : {metodosPj.PagarImposto(pj1.Rendimento)}
// Endereço : {pj1.Endereco.Logradoura},{pj1.Endereco.Numero}
// End. Comercial : {pj1.Endereco.Comercial}
// "); // Usando o "@" para criar novas linha

// // CNPJ é Válido? : {pj1.ValidarCnpj(pj1.Cnpj)} - forma gambiarra