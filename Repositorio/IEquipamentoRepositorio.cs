
using calculodeequipamentos.Models;
using WebApplication2.Models;

namespace calculodeequipamentos.Repositorio
{
    public interface IEquipamentoRepositorio
    {
        List<EquipamentoEletronico> BuscarTodos();
        EquipamentoEletronico Adicionar(EquipamentoEletronico equipamento);
        EquipamentoModel ListarPorId(int id);
        //List<EquipamentoModel> BuscarTodos();
        EquipamentoModel Adicionar(EquipamentoModel equipamento);
        EquipamentoModel Atualizar(EquipamentoModel equipamento);
        bool ApagarReal(int id);
        
    }

}