// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n - CONTROLE DE PRODUTOS E FORNECEDORES - \n");

try
{
    //definindo o caminho do banco de dados
    var connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BDProjeto04;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    
    //iniciando o cadastro de um fornecedor
    Console.WriteLine("\nCADASTRO DE FORNECEDOR\n");
}
catch (Exception e)
{
    Console.WriteLine($"\nErro: {e.Message}");
}

Console.ReadKey();
