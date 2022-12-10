﻿using ApiFS8Livros.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFS8Livros.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;
        public LivroController( LivroRepository livroRepository )
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Litar()
        {

            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }


        }
    }
}
