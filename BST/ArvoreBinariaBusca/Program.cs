using System;

class Principal {


	static void Main() {
		var contatos = new BinaryTree();

		Console.WriteLine( contatos.IsEmpty()?
			"Sua agenda está vazia":
			"Você possui pessoas cadastradas"
		);
		contatos.Insert(new Pessoa("Julio"  , "123.456.789-01"));
		contatos.Insert(new Pessoa("Alex"  , "456.789.012-34"));
		contatos.Insert(new Pessoa("Deivid" , "345.678.901-23"));
		contatos.Insert(new Pessoa("Gabriel", "789.012.345-67"));
		contatos.Insert(new Pessoa("Joao", "012.345.678-90"));


		// testando método Contar
		Console.WriteLine( "Contatos cadastrados: {0} ",
			contatos.Cont()
		); // 5 clientes


		// testando método Buscar
		var alex = "Alex";
		Console.WriteLine( "{0} esta cadastrada? {1}", alex, contatos.Search(alex) != null? "Sim":"Nao"
		); // não foi encontrada

		// testando método Remover
		var gabriel = "Gabriel";
		Console.WriteLine( "Clientes cadastrados: {0} ", contatos.Cont()
		); // 5 clientes
		Console.WriteLine( "{0} esta cadastrado? {1}", gabriel, contatos.Search(gabriel) != null? "Sim":"Nao"
		); // não foi encontrado (removido)

		var deivid = "Deivid";
		contatos.Delete(deivid); // encontrado e removido

		Console.WriteLine( "Clientes cadastrados: {0} ",
			contatos.Cont()
		); // 4 clientes
		Console.WriteLine( "{0} esta cadastrada? {1}",
			deivid,
			contatos.Search(deivid) != null? "Sim":"Nao"
		);



		
	} // fim da Main


} // fim da classe Principal
