using System.Collections.Generic;
using System.Linq;
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
        DAOCidades dao = new DAOCidades();

        [HttpGet(Name = "Cidades")]
        public IEnumerable<Cidades> Get(){
            return dao.Listar();
        }

        [HttpGet("{id}",Name="CidadeAtual")]
        public Cidades GetCidades(int id){
            return dao.Listar().Where(x => x.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cidades cidades){
            dao.Cadastro(cidades);

            return CreatedAtRoute("CidadeAtual", new{id=cidades.Id}, cidades );
        }

        [HttpPut]
        public IActionResult Put([FromBody] Cidades cidades){
            dao.Editar(cidades);

            return CreatedAtRoute("CidadeAtual", new{id=cidades.Id}, cidades );
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            dao.Apagar(id);
            return CreatedAtRoute("Cidades", null, null );
        }
    }
}