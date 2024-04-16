6using AGREGAMENTO.Data;
using AGREGAMENTO.Models;
using AGREGAMENTO.Service.ColaboradorInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AGREGAMENTO.Service.ColaboradorService
{

    public class ColaboradorService : IColaboradorInterface
    {
        // Injeção de dependencia : Criando o construtor  para de comunicar com o DataContext.cs que é ele que tem o contato com o banco de dados
        private readonly DataContext _context;  // Criando um elemento privado, apenas para leitura que vai ser do tipo DataContext
        public ColaboradorService(DataContext context)
        {
            _context = context;
        }



        public async Task<ServiceResponse<List<DadosDoColaboradorModel>>> CreateColaborador(DadosDoColaboradorModel novoColaborador)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = new ServiceResponse<List<DadosDoColaboradorModel>>();

            try
            {
                _context.Add(novoColaborador);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Colaboradores.ToList();


            }
            catch (Exception ex)
            {

                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }



        public async Task<ServiceResponse<List<DadosDoColaboradorModel>>> DeleteColaborador(int id)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = new ServiceResponse<List<DadosDoColaboradorModel>>();
            try
            {
                DadosDoColaboradorModel dadosDoColaboradorModel = _context.Colaboradores.FirstOrDefault(x => x.IdSerede == id);

                if (dadosDoColaboradorModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = $"Usuário {id} não existe para deletar";
                    serviceResponse.Sucesso = false;
                    return serviceResponse;
                }

                _context.Colaboradores.Remove(dadosDoColaboradorModel);
                await _context.SaveChangesAsync();
                serviceResponse.Dados = _context.Colaboradores.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }





        public async Task<ServiceResponse<List<DadosDoColaboradorModel>>> GetColaborador()
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = new ServiceResponse<List<DadosDoColaboradorModel>>();

            try
            {
                serviceResponse.Dados = _context.Colaboradores.ToList();

            

            } catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<DadosDoColaboradorModel>> GetColaboradorById(int id)
        {
            ServiceResponse<DadosDoColaboradorModel> serviceResponse = new ServiceResponse<DadosDoColaboradorModel>();

            try
            {
                // Quando pegamos um colaborador pelo id, temos que criar uma variável
                DadosDoColaboradorModel dadosDoColaboradorModel = _context.Colaboradores.FirstOrDefault(x => x.IdSerede == id);

                if (dadosDoColaboradorModel == null)
                {


                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = $"Usuário {id} não localizado";
                    serviceResponse.Sucesso = false;
                }
                else
                {
                    serviceResponse.Dados = _context.Colaboradores.FirstOrDefault();
                    serviceResponse.Mensagem = $"Colaborador {id} localizado";
                    serviceResponse.Sucesso = true;
                }


                serviceResponse.Dados = dadosDoColaboradorModel;

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;

            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<DadosDoColaboradorModel>>> InativaColaborador(int id)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = new ServiceResponse<List<DadosDoColaboradorModel>>();
            try
            {
                //Para inativar o colaborador, precisamos saber qual colaborador é esse
                DadosDoColaboradorModel dadosDoColaboradorModel = _context.Colaboradores.FirstOrDefault(x => x.IdSerede == id);
                if (dadosDoColaboradorModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = $"Usuário {id} não existe para inativar";
                    serviceResponse.Sucesso = false;
                }

                //Agora se achou..
                dadosDoColaboradorModel.SituacaoDoColaborador = false;
                //Atualizando no banco
                _context.Colaboradores.Update(dadosDoColaboradorModel);
                //Salvando a operação que realizamos
                await _context.SaveChangesAsync();
                //Agora vamos listar a tabela novamente dando um select no banco
                serviceResponse.Dados = _context.Colaboradores.ToList();




            } catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<DadosDoColaboradorModel>>> UpdateColaborador(DadosDoColaboradorModel editadoColaborador)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = new ServiceResponse<List<DadosDoColaboradorModel>>();

            try
            {
                DadosDoColaboradorModel dadosDoColaboradorModel = _context.Colaboradores.AsNoTracking().FirstOrDefault(x => x.IdSerede == editadoColaborador.IdSerede);

                if (dadosDoColaboradorModel == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = $"Usuário {editadoColaborador.IdSerede} não localizado";
                    serviceResponse.Sucesso = false;
                }

                //Atualizando no banco
                _context.Colaboradores.Update(editadoColaborador);
                //Salvando os dados dentro do banco
                await _context.SaveChangesAsync();
                // Listar todos os dados novamente dentro do banco
                serviceResponse.Dados = _context.Colaboradores.ToList();




            } catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Sucesso = false;
            }
            return serviceResponse;
        }

    

    }
}






