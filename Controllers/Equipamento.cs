
using calculodeequipamentos.Models;
using calculodeequipamentos.Repositorio;
using Microsoft.AspNetCore.Mvc;


namespace calculodeequipamentos.Controllers
{
    public class Equipamento : Controller
    {
        private readonly IEquipamentoRepositorio _equipamentoRepositorio;
        public Equipamento(IEquipamentoRepositorio equipamentoRepositorio)
        {
            _equipamentoRepositorio = equipamentoRepositorio;
        }
        public IActionResult Index()
        {
            List<EquipamentoEletronico> equipamento = _equipamentoRepositorio.BuscarTodos();
            return View(equipamento);
        }
        public IActionResult RegistrarResultado()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarResultado(EquipamentoEletronico equipamento)
        {
            _equipamentoRepositorio.Adicionar(equipamento);
            return RedirectToAction("Index");
        }
    }
}


