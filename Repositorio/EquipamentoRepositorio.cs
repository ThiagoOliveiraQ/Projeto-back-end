
using calculodeequipamentos.Context;
using calculodeequipamentos.Models;
using System.Linq;

using calculodeequipamentos.Data;
using calculodeequipamentos.Repositorio;
using WebApplication2.Models;

namespace calculodeequipamentos.Repositorio
{
    public class EquipamentoRepositorio : IEquipamentoRepositorio
    {
        private readonly AppDbContext _bancoContext;
        public EquipamentoRepositorio(AppDbContext appdbcontext)
        {
            _bancoContext = appdbcontext;
        }
        public EquipamentoEletronico Adicionar(EquipamentoEletronico equipamento)
        {
            _bancoContext.Equipamentos.Add(equipamento);
            _bancoContext.SaveChanges();
            return equipamento;
        }

        public EquipamentoModel Adicionar(EquipamentoModel equipamento)
        {
            throw new NotImplementedException();
        }

        public bool ApagarReal(int id)
        {
            throw new NotImplementedException();
        }

        public EquipamentoModel Atualizar(EquipamentoModel equipamento)
        {
            throw new NotImplementedException();
        }

        public List<EquipamentoEletronico> BuscarTodos()
        {
            return _bancoContext.Equipamentos.ToList();
        }

        public EquipamentoModel ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        List<EquipamentoModel> IEquipamentoRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

    }
}
