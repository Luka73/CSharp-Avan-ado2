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
    public class EnderecoController
    {
        public void InsertEndereco()
        {
            Console.WriteLine("****CADASTRO DE ENDEREÇO****");

            try
            {
                Endereco endereco = EnderecoInput.LerEndereco();
                EnderecoRepository repository = new EnderecoRepository();
                repository.Insert(endereco);

                Console.WriteLine("ENDEREÇO CADASTRADO COM SUCESSO.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            
        }

        public void UpdateEndereco()
        {
            Console.WriteLine("****ATUALIZAÇÃO DE ENDEREÇO****");
            
            try
            {
                Endereco endereco = EnderecoInput.LerEndereco();
                EnderecoRepository repository = new EnderecoRepository();
                repository.Update(endereco);
                Console.WriteLine("ENDEREÇO ATUALIZADO COM SUCESSO.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            
        }

        public void DeleteEndereco()
        {
            Console.WriteLine("****EXCLUSÃO DE ENDEREÇO****");
           
            try
            {
                int id = EnderecoInput.LerIdEndereco();
                EnderecoRepository repository = new EnderecoRepository();
                repository.Delete(id);
                Console.WriteLine("ENDEREÇO EXCLUÍDO COM SUCESSO.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public void SelectAllEnderecos()
        {
            Console.WriteLine("****CONSULTAR TODOS OS ENDEREÇOS****");

            try
            {
                EnderecoRepository repository = new EnderecoRepository();
                List<Endereco> lista = repository.SelectAll();

                foreach (var item in lista)
                {
                    Console.WriteLine("Id do Endereço.: " + item.IdEndereco);
                    Console.WriteLine("Logradouro.....: " + item.Logradouro);
                    Console.WriteLine("Bairro.........: " + item.Bairro);
                    Console.WriteLine("Cidade.........: " + item.Cidade);
                    Console.WriteLine("Estado.........: " + item.Estado);
                    Console.WriteLine("CEP............: " + item.Cep);
                    Console.WriteLine("Id do Cliente..: " + item.IdCliente);
                    Console.WriteLine("***********************************");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }

        public void SelectByIdEndereco()
        {
            Console.WriteLine("****CONSULTAR ENDEREÇO POR ID****");

            try
            {
                int id = EnderecoInput.LerIdEndereco();
                EnderecoRepository repository = new EnderecoRepository();
                Endereco endereco = repository.SelectById(id);

                if (endereco != null)
                {
                    Console.WriteLine("Id do Endereço.: " + endereco.IdEndereco);
                    Console.WriteLine("Logradouro.....: " + endereco.Logradouro);
                    Console.WriteLine("Bairro.........: " + endereco.Bairro);
                    Console.WriteLine("Cidade.........: " + endereco.Cidade);
                    Console.WriteLine("Estado.........: " + endereco.Estado);
                    Console.WriteLine("CEP............: " + endereco.Cep);
                    Console.WriteLine("Id do Cliente..: " + endereco.IdCliente);
                    Console.WriteLine("---");
                }
                else { Console.WriteLine("ENDEREÇO NÃO FOI ENCONTRADO"); }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}

