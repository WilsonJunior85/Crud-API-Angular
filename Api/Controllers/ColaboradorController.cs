using AGREGAMENTO.Models;
using AGREGAMENTO.Service.ColaboradorInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace COLABORADOR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        //Injeção de dependência para conseguir trabalhar com o "IColaboradorInterface.cs"
        private readonly IColaboradorInterface _colaboradorInterface;
        public ColaboradorController(IColaboradorInterface colaboradorInterface)
        {
            _colaboradorInterface = colaboradorInterface;

        }
     // ==============================================================================================================================================//



        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<DadosDoColaboradorModel>>>> GetColaborador()
        {
            return Ok(await _colaboradorInterface.GetColaborador());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<DadosDoColaboradorModel>>> GetColaboradorById(int id)
        {
            ServiceResponse<DadosDoColaboradorModel> serviceResponse = await _colaboradorInterface.GetColaboradorById(id);
            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<DadosDoColaboradorModel>>>> CreateColaborador([FromBody]DadosDoColaboradorModel novoColaborador)
        {
            return Ok(await _colaboradorInterface.CreateColaborador(novoColaborador));

        }


        [HttpPut("inativaColaborador")]
        public async Task<ActionResult<ServiceResponse<List<DadosDoColaboradorModel>>>> InativaColaborador(int id)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = await _colaboradorInterface.InativaColaborador(id);
            return Ok(serviceResponse);

        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<DadosDoColaboradorModel>>>> UpdateColaborador(DadosDoColaboradorModel editadoColaborador)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = await _colaboradorInterface.UpdateColaborador(editadoColaborador);
            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<DadosDoColaboradorModel>>>> DeleteColaborador(int id)
        {
            ServiceResponse<List<DadosDoColaboradorModel>> serviceResponse = await _colaboradorInterface.DeleteColaborador(id);
            return Ok(serviceResponse);
        }
    }

    
}
