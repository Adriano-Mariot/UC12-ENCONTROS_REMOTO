using ENCONTRO_REMOTO_2.classes;
using System.Text.RegularExpressions; // para usara a class Regex

// Pessoa fisica**********************************************************************************

//Endereço
Endereco endPf1 = new Endereco();
endPf1.Logradoura= "Rua lá de Casa";
endPf1.Numero=123;
endPf1.Comercial=false;

//Atributos da pessoa
PessoaFisica pf1 = new PessoaFisica("000000000");
PessoaFisica metodosPf = new PessoaFisica();
pf1.Nome= "Adriano";
pf1.DataNaceimento = new DateTime(1985, 5, 3);
//pf1.Cpf= "08888888888";
pf1.Rendimento=1501;
pf1.Endereco = endPf1;
 
// Print do console (Por questão de aprendizado a forma de Usar o metodo WriteLine difere entre pessoa fisica e Juridica )

Console.WriteLine("\n-------------Dados do Cliente---------------");

Console.WriteLine($"Nome = {pf1.Nome}");
Console.WriteLine($"Cpf = {pf1.Cpf}");
Console.WriteLine($"Rendimentos Anual= {pf1.Rendimento}");
Console.WriteLine($"Rendimentos Liquido = {metodosPf.PagarImposto(pf1.Rendimento)}");

Console.WriteLine ("\nFormas de validar Datas de nascimento-------------");
// variações de datas de nacimento <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
Console.Write("Maior de Idade ? : ");
Console.WriteLine(pf1.ValidarDataNascimento ("03/05/1985"));
Console.WriteLine(metodosPf.ValidarDataNascimento (pf1.DataNaceimento));
Console.WriteLine(pf1.DataNaceimento.ToShortDateString());

Console.WriteLine("\n------Endereço-------");
Console.WriteLine($"Logradouro = {pf1.Endereco.Logradoura}");
Console.WriteLine($"Numero = {pf1.Endereco.Numero}");
Console.WriteLine($"Endereço comercial? : {pf1.Endereco.Comercial}\n");


// DateTime data = new DateTime (1985 ,5,3);
// Console.WriteLine(pf1.ValidarDataNascimento (data));

//--------------------------------------------------------------------------------------------------
// //exemplo concatenação

// // Console.Write( $" Nome = {pf1.Nome} tem o Cpf = {pf1.Cpf} e o rendimento de R${pf1.Rendimento} por mês.\n" );

//---------------------------------------------------------------------------------------------------
// Pessoa Juridica **********************************************************************************

//Endereço PJ
Endereco endPj1 = new Endereco();
endPj1.Logradoura= "Rua lá de Firma";
endPj1.Numero=123;
endPj1.Comercial=true;

//Atributos da pessoa Juridica
PessoaJuridica pj1 = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica(); //objeto criado para utilização dos metodos
pj1.Nome= "Adriano Mariot";
pj1.Endereco = endPj1;

// Console.WriteLine($"Qual o rendimento ?"); //Exemplo para input dos dados Opcional
// pj1.Rendimento= float.Parse(Console.ReadLine());

pj1.Rendimento=5000;
pj1.Cnpj="14.625.806/0001-80";
// pj1.Cnpj="14625806000180";
pj1.RazaoSocial="Ams Soluções Ltda";
pj1.Fantasia="Magico de OZ";

// Print do console

Console.WriteLine("\n-------------Dados da Pessoa Juridica---------------");

Console.WriteLine(@$" 
Razão Social : {pj1.RazaoSocial}
Nome Fantasia : {pj1.Fantasia}
Representante : {pj1.Nome}
CNPJ : {pj1.Cnpj}
CNPJ é Válido? : {metodosPj.ValidarCnpj(pj1.Cnpj)}
Rendimento anual : {pj1.Rendimento}
Rendimento liquido : {metodosPj.PagarImposto(pj1.Rendimento)}
Endereço : {pj1.Endereco.Logradoura},{pj1.Endereco.Numero}
End. Comercial : {pj1.Endereco.Comercial}
"); // Usando o "@" para criar novas linha

// CNPJ é Válido? : {pj1.ValidarCnpj(pj1.Cnpj)} - forma gambiarra