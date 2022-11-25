using ENCONTRO_REMOTO_2.classes;

PessoaFisica obj_Pf = new PessoaFisica();

obj_Pf.nome= "Adriano";
obj_Pf.cpf= "08888888888";
obj_Pf.rendimento=1000;

Console.WriteLine(obj_Pf.nome);
Console.WriteLine(obj_Pf.cpf);
Console.WriteLine(obj_Pf.rendimento);

//exemplo concatenação

Console.Write( $" Nome = {obj_Pf.nome} tem o Cpf = {obj_Pf.cpf} e o rendimento de R${obj_Pf.rendimento} por mês.\n" );