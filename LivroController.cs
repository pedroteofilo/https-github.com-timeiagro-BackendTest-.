using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicação_WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aplicação_WEB.Controler
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private static List<Livro> livros = new List<Livro>();


        public static Livro BiscaPorNome(List<Livro> lista, String nome)
        {
            return (from livro in lista
                    where livro.name.Equals(nome)
                    select *);
                   
        }
        public void BuscarLivroPeloNoome(string nome)
        {
            var item = from livro in livros
                       where livro.name == nome
                       select livro;  
        }
        
       IEnumerable<Livro> listarDescendente =
       from livro in livros
            orderby livro.price descending
            select livro;

        // Metodo para mostrar a lista na ordem decentente





        IEnumerable<Livro> listarAscendente =
       from livro in livros
       orderby livro.price ascending
       select livro;




    }
    
}