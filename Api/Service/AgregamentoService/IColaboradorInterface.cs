using AGREGAMENTO.Models;

namespace AGREGAMENTO.Service.ColaboradorInterface
{
    public interface IColaboradorInterface
    {
        Task<ServiceResponse<List<DadosDoColaboradorModel>>> GetColaborador(); // Get
        Task<ServiceResponse<List<DadosDoColaboradorModel>>> CreateColaborador(DadosDoColaboradorModel novoColaborador); //Post
        Task<ServiceResponse<DadosDoColaboradorModel>> GetColaboradorById(int id); //Get por id
        Task<ServiceResponse<List<DadosDoColaboradorModel>>> UpdateColaborador(DadosDoColaboradorModel editadoColaborador); //PUT
        Task<ServiceResponse<List<DadosDoColaboradorModel>>> DeleteColaborador(int id);   //Delete por id
        Task<ServiceResponse<List<DadosDoColaboradorModel>>> InativaColaborador(int id); //Inativa Agregamento


    }
}
