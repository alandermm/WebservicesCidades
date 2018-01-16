using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebservicesCidades.Models;

namespace WebservicesCidades.Controllers
{

    //Vamos definir a rota para a requisição do serviço
    [Route("api/[controller]")]
    public class PrimeiraController:Controller
    {
        /*[HttpGet("{id}")]
        public string Get(int id){
            return new string[]{
                "Curitiba", "Porto Alegre", "Salvador", "Belo Horizonte"
            }[id];
        }*/

        Cidades cidade = new Cidades();

        [HttpGet]
        public IEnumerable<Cidades> Get(){
            return cidade.Listar();
        }      
    }
}