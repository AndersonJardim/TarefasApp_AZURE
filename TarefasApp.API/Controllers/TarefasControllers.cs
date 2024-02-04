using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TarefasApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        /// <summary>
        /// Servi�o para cadastro de tarefas.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

        /// <summary>
        /// Servi�o para atualiza��o de tarefas.
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }

        /// <summary>
        /// Servi�o para deletar de tarefas.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

        /// <summary>
        /// Servi�o para consultar de tarefas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}



