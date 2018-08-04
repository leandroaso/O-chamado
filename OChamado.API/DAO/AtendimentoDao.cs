using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OChamado.API.DAO
{
    public class AtendimentoDao : BaseDao<Atendimento>
    {

        private readonly ChamadoContext _context;

        public AtendimentoDao(ChamadoContext chamadoContext)
        {
            _context = chamadoContext;
        }

        public void Delete(int id)
        {
            Atendimento atendimento = Get(id);
            _context.Atendimento.Remove(atendimento);
            _context.SaveChanges();
        }

        public Atendimento Get(params object[] id)
        {
            Atendimento atendimento = _context.Atendimento.Find(id);
            return atendimento;
        }

        public IEnumerable<Atendimento> List()
        {
            return _context.Atendimento.ToList();
        }

        public void Save(Atendimento atendimento)
        {
            _context.Atendimento.Add(atendimento);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<Atendimento> atendimentos)
        {
            _context.Atendimento.AddRange(atendimentos);
            _context.SaveChanges();
        }

        public void Updade(Atendimento atendimento)
        {
            _context.Atendimento.Update(atendimento);
            _context.SaveChanges();
        }
    }
}
