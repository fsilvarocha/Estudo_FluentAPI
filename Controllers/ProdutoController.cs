using Estudo_FluentAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Estudo_FluentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public Produto GetAll()
        {
            var produto = new Produto
            {
                Id = 1,
                DataCadastro = DateTime.Now,
                Nome = "Monitor",
                Preco = 152
            };

            return produto;
        }
    }
}
