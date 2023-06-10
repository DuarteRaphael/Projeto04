// See https://aka.ms/new-console-template for more information
using Projeto04.Entities;
using Projeto04.Repositories;

Console.WriteLine("\n - CONTROLE DE PRODUTOS E FORNECEDORES - \n");

try
{
    //definindo o caminho do banco de dados
    var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDProjeto04;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    
    //iniciando o cadastro de um fornecedor
    Console.WriteLine("\nCADASTRO DE FORNECEDOR\n");

    //criando um objeto para a classe Fornecedor
    var fornecedor = new Fornecedor();
    
    //gerando um Id para o fornecedor
    fornecedor.IdFornecedor = Guid.NewGuid();

    Console.Write("Nome do fornecedor......: ");
    fornecedor.Nome = Console.ReadLine();

    Console.Write("CNPJ do fornecedor......: ");
    fornecedor.Cnpj = Console.ReadLine();

    //gravando no banco
    var fornecedorRepository = new FornecedorRepository(connectionstring);
    fornecedorRepository.Inserir(fornecedor);

    //mensagem de sucesso
    Console.WriteLine("\nFornecedor cadastrado com sucesso!");
}
catch (Exception e)
{
    Console.WriteLine($"\nErro: {e.Message}");
}

//pause
Console.ReadKey();
