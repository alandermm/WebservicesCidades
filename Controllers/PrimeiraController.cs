using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public string Get(){
            return null;
        }      
    }
}