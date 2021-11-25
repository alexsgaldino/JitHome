
using System;
using System.Threading.Tasks;
using JitHome.Application.Contracts;
using JitHome.Application.Dtos;
using JitResidencial.API.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JitHome.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        private readonly IContaService _contaService;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProdutosController(IProdutoService produtoService,
                                  IContaService contaService,
                                  IWebHostEnvironment hostEnvironment)
        {
            _produtoService = produtoService;
            _contaService = contaService;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var produtos = await _produtoService.RecuperarProdutosAsync(User.RecuperarContaPorId());
                if (produtos == null) return NoContent();

                return Ok(produtos);
            }

            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar produtos. Erro: {ex.Message}");
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                var produto = await _produtoService.RecuperarProdutoPorIdAsync(User.RecuperarContaPorId(), id);
                if (produto == null) return NoContent();

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar produtos por id. Erro: {ex.Message}");
            }
        }
        [HttpGet("{nomeProduto}/nomeProduto")]
        public async Task<ActionResult> GetByNomeProduto(string nomeProduto)
        {
            try
            {
                var produto = await _produtoService.RecuperarProdutosPorNomeProdutoAsync(User.RecuperarContaPorId(), nomeProduto);
                if (produto == null) return NoContent();

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar produtos por nome produto. Erro: {ex.Message}");
            }
        }
        [HttpGet("{codigoBarras}/codigoBarras")]
        public async Task<ActionResult> GetByCodigoBarras(string codigoBarras)
        {
            try
            {
                var produto = await _produtoService.RecuperarProdutosPorCodigoBarrasAsync(User.RecuperarContaPorId(), codigoBarras);
                if (produto == null) return NoContent();

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar recuperar produtos por código de barras. Erro: {ex.Message}");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(ProdutoDto model)
        {
            try
            {
                var produto = await _produtoService.IncluirProdutos(User.RecuperarContaPorId(), model);
                if (produto == null) return NoContent(); ;

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar adicionar produtos por código de barras. Erro: {ex.Message}");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, ProdutoDto model)
        {
            try
            {
                var produto = await _produtoService.AlterarProduto(User.RecuperarContaPorId(), id, model);
                if (produto == null) return NoContent(); ;

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar atualizar produtos por código de barras. Erro: {ex.Message}");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (await _produtoService.ExcluirProduto(User.RecuperarContaPorId(), id))
                    return Ok(new { message = "Deletado" });
                else
                    return BadRequest("Evento não deletado");
            }
            catch (Exception ex)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Erro ao tentar deletar produtos por código de barras. Erro: {ex.Message}");
            }
        }
    }
}
*/