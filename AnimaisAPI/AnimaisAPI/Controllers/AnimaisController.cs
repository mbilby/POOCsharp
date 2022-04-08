﻿using AnimaisAPI.Models;
using AnimaisAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimaisAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        public AnimaisController()
        {
        }

        [HttpGet("Animais", Name = "Animais")]
        public RetornoAnimais Todos ()
        {
            RetornoAnimais retornoAnimais = new RetornoAnimais();
            return retornoAnimais.Busca();
        }    

        [HttpGet("Gatos", Name ="Gatos")]
        public List<Gato> Gatos ()
        {
            BuscaGato xpto = new BuscaGato();
            return xpto.Busca().ToList();
        }
        [HttpGet("Cachorros", Name = "Cachorro")]
        public List<Cachorro> Cachorros()
        {
            BuscaCachorro xpto = new BuscaCachorro();
            return xpto.Busca().ToList();
        }

        [HttpPost("CreatecCachorro", Name = "CreateCachorro")]

        public List<Cachorro> Post(Cachorro cachorro)
        {
            List<Cachorro> listaCachorros = new List<Cachorro>();
            cachorro.Idade = cachorro.Idade + 10;
            listaCachorros.Add(cachorro);
            return listaCachorros;            
        }
    }
}
