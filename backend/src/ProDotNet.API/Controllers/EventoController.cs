﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProDotNet.API.Models;
using ProDotNet.API.Data;

namespace ProDotNet.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        // public IEnumerable<Evento> _evento = new Evento[]{
        //       new Evento() {
        //           EventoId = 1,
        //           Tema = "oi",
        //           Local = "Belo Horizonte",
        //           Lote = "1° Lote",
        //           QtdPessoas = 250,
        //           DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //           ImagemURL = "foto.png"
        //       },
        //       new Evento() {
        //           EventoId = 2,
        //           Tema = "ola",
        //           Local = "São Paulo",
        //           Lote = "2° Lote",
        //           QtdPessoas = 251,
        //           DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
        //           ImagemURL = "foto1.png"

        //       }
        //     };

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId == id);
        }


        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }
    }
}
