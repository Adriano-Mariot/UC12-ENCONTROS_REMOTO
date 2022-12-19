using ENCONTRO_REMOTO_2.classes;

//Criação de objetos
PessoaFisica pf1 = new PessoaFisica("000000000");//o construtor solicita o cpf e datanascimento
Endereco endPf1 = new Endereco();

//Endereço
endPf1.Logradoura= "Rua lá de Casa";
endPf1.Numero=123;
endPf1.Comercial=false;

//Atributos da pessoa
pf1.Nome= "Adriano";
pf1.DataNaceimento = new DateTime(1985, 5, 3);
//pf1.Cpf= "08888888888";
pf1.Rendimento=10000;
pf1.Endereco = endPf1;

// Print do console

Console.WriteLine("\n-------------Dados do Cliente---------------");

Console.WriteLine($"Nome = {pf1.Nome}");
Console.WriteLine($"Cpf = {pf1.Cpf}");
Console.WriteLine($"Rendimentos = {pf1.Rendimento}");

Console.WriteLine ("\nFormas de validar Datas de nascimento-------------");
// variações de datas de nacimento <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
Console.Write("Maior de Idade ? : ");
Console.WriteLine(pf1.ValidarDataNascimento ("03/05/1985"));
Console.WriteLine(pf1.ValidarDataNascimento (pf1.DataNaceimento));
Console.WriteLine(pf1.DataNaceimento.ToShortDateString());

Console.WriteLine("\n------Endereço-------");
Console.WriteLine($"Logradouro = {pf1.Endereco.Logradoura}");
Console.WriteLine($"Numero = {pf1.Endereco.Numero}");
Console.WriteLine($"Endereço comercial? : {pf1.Endereco.Comercial}\n");


// DateTime data = new DateTime (1985 ,5,3);
// Console.WriteLine(pf1.ValidarDataNascimento (data));


//exemplo concatenação

// Console.Write( $" Nome = {pf1.Nome} tem o Cpf = {pf1.Cpf} e o rendimento de R${pf1.Rendimento} por mês.\n" );