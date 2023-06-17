using calculodeequipamentos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class ControllerEquipamentos : Controller
    {
        
        private readonly IEquipamentoRepositorio _equipamentoRepositorio;
        public ControllerEquipamentos(IEquipamentoRepositorio equipamentoRepositorio)
        {
            _equipamentoRepositorio = equipamentoRepositorio;
        }
        public IActionResult Index()
        {
            List<EquipamentoModel> equipamentos = _equipamentoRepositorio.BuscarTodos();

            return View(equipamentos);
        }
   
        public IActionResult Editar (int id)
        {
           EquipamentoModel equipamento = _equipamentoRepositorio.ListarPorId(id);
            return View(equipamento);
        }
        public IActionResult Apagar(int id)
        {
            EquipamentoModel equipamento = _equipamentoRepositorio.ListarPorId(id);
            return View(equipamento);
        }

        public IActionResult ApagarReal(int id)
        {
            _equipamentoRepositorio.ApagarReal(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(EquipamentoModel equipamento)
        {
         _equipamentoRepositorio.Adicionar(equipamento);
         return RedirectToAction("Index");
        
        }
        [HttpPost]
        public IActionResult Alterar(EquipamentoModel equipamento)
        {
            _equipamentoRepositorio.Atualizar(equipamento);
            return RedirectToAction("Index");
        }
    }
}