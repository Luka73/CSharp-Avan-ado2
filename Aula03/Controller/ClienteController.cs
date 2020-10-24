using Aula03.Entity;
using Aula03.Input;
using Aula03.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03.Controller
{
    public class ClienteController
    {
        public void InsertCliente()
        {
            Console.WriteLine("\n****CADASTRO DE CLIENTE****");
            try
            {
                Cliente cliente = ClienteInput.LerClienteEndereco();
                ClienteRepository repository = new ClienteRepository();
                repository.Insert(cliente);
                Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void UpdateCliente()
        {
            Console.WriteLine("\n****ATUALIZAÇÃO DE CLIENTE****");

            try
            {
                int idCliente = ClienteInput.LerIdCliente();
                Cliente cliente = ClienteInput.LerClienteEndereco();
                cliente.IdCliente = idCliente;

                ClienteRepository repository = new ClienteRepository();
                repository.Update(cliente);

                Console.WriteLine("CLIENTE ATUALIZADO COM SUCESSO.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void DeleteCliente()
        {
            Console.WriteLine("\n****EXCLUSÃO DE CLIENTE****");

            try
            {
                int idCliente = ClienteInput.LerIdCliente();
                ClienteRepository repository = new ClienteRepository();
                repository.Delete(idCliente);
                Console.WriteLine("CLIENTE EXCLUÍDO COM SUCESSO.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void SelectAllClientes()
        {
            Console.WriteLine("\n****CONSULTAR TODOS OS CLIENTES****");

            try
            {
                ClienteRepository repository = new ClienteRepository();
                EnderecoRepository enderecoRepository = new EnderecoRepository();
                List<Cliente> lista = repository.SelectAll();

                foreach (var item in lista)
                {
                    Console.WriteLine("Id do Cliente..: " + item.IdCliente);
                    Console.WriteLine("Nome...........: " + item.Nome);
                    Console.WriteLine("Data Nasc......: " + item.DataNascimento.ToString("dd/MM/yyyy"));
                   
                    Endereco endereco = enderecoRepository.SelectByIdCliente(item.IdCliente);
                    if (endereco != null)
                    {
                        Console.WriteLine("Logradouro.....: " + endereco.Logradouro);
                        Console.WriteLine("Bairro.........: " + endereco.Bairro);
                        Console.WriteLine("Cidade.........: " + endereco.Cidade);
                        Console.WriteLine("Estado.........: " + endereco.Estado);
                        Console.WriteLine("Cep............: " + endereco.Cep);
                    }
                    Console.WriteLine("********************************\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void SelectByIdCliente()
        {
            Console.WriteLine("\n****CONSULTAR CLIENTE POR ID****");

            try
            {
                int idCliente = ClienteInput.LerIdCliente();
                ClienteRepository repository = new ClienteRepository();
                EnderecoRepository enderecoRepository = new EnderecoRepository();
                Cliente cliente = repository.SelectById(idCliente);

                Endereco endereco = enderecoRepository.SelectByIdCliente(cliente.IdCliente);
                

                if (cliente != null) 
                {
                    Console.WriteLine("Id do Cliente..: " + cliente.IdCliente);
                    Console.WriteLine("Nome...........: " + cliente.Nome);
                    Console.WriteLine("Data Nasc......: " + cliente.DataNascimento.ToString("dd/MM/yyyy"));
                    if (endereco != null)
                    {
                        Console.WriteLine("Logradouro.....: " + endereco.Logradouro);
                        Console.WriteLine("Bairro.........: " + endereco.Bairro);
                        Console.WriteLine("Cidade.........: " + endereco.Cidade);
                        Console.WriteLine("Estado.........: " + endereco.Estado);
                        Console.WriteLine("Cep............: " + endereco.Cep);
                    }
                    Console.WriteLine("*************************************\n");
                }
                else { Console.WriteLine("\nCLIENTE NÃO FOI ENCONTRADO"); }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }

        public void SelectByNameClientes()
        {
            Console.WriteLine("\n****CONSULTAR CLIENTES PELO NOME****");

            try
            {
                string nome = ClienteInput.LerNome();
                ClienteRepository repository = new ClienteRepository();
                EnderecoRepository enderecoRepository = new EnderecoRepository();
                List<Cliente> lista = repository.SelectAll(nome);
                
                if(lista != null) 
                {
                    foreach (var item in lista)
                    {
                        Console.WriteLine("Id do Cliente..: " + item.IdCliente);
                        Console.WriteLine("Nome...........: " + item.Nome);
                        Console.WriteLine("Data Nasc......: " + item.DataNascimento.ToString("dd/MM/yyyy"));

                        Endereco endereco = enderecoRepository.SelectByIdCliente(item.IdCliente);
                        if (endereco != null)
                        {
                            Console.WriteLine("Logradouro.....: " + endereco.Logradouro);
                            Console.WriteLine("Bairro.........: " + endereco.Bairro);
                            Console.WriteLine("Cidade.........: " + endereco.Cidade);
                            Console.WriteLine("Estado.........: " + endereco.Estado);
                            Console.WriteLine("Cep............: " + endereco.Cep);
                        }

                        Console.WriteLine("**********************************\n");
                    }
                } else { Console.WriteLine("\nNENHUM CLIENTE ENCONTRADO"); }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
    }
}
