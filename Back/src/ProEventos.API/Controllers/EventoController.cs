﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
         public EventoController()
         {
             
        }

        public IEnumerable<Evento> _evento = new Evento[]{
        
                new Evento {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento =  DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                 new Evento {
                    EventoId = 2,
                    Tema = "Angular e sua Novidades",
                    Local = "São Paulo",
                    Lote = "2° Lote",
                    QtdPessoas = 350,
                    DataEvento =  DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                },
                 new Evento {
                    EventoId = 3,
                    Tema = ".NET 5",
                    Local = "Rio de Janeiro",
                    Lote = "3° Lote",
                    QtdPessoas = 150,
                    DataEvento =  DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto2.png"
                }
        };
        

         [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return new Evento[]{
                new Evento {
                    EventoId = 1,
                    Tema = "Angular 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento =  DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                 new Evento {
                    EventoId = 2,
                    Tema = "Angular e sua Novidades",
                    Local = "São Paulo",
                    Lote = "2° Lote",
                    QtdPessoas = 350,
                    DataEvento =  DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                },
                 new Evento {
                    EventoId = 3,
                    Tema = ".NET 5",
                    Local = "Rio de Janeiro",
                    Lote = "3° Lote",
                    QtdPessoas = 150,
                    DataEvento =  DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto2.png"
                }
           };
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(evento => evento.EventoId == id);
        }

         [HttpPost]
        public String Post()
        {
           return "Exemplo de Post";
        }

         [HttpPut("{id}")]
        public String Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

         [HttpDelete("{id}")]
        public String Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }
}
