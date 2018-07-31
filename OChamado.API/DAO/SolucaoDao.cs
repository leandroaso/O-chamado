using OChamado.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OChamado.API.DAO
{
    public class SolucaoDao : BaseDao<Solucao>
    {
        private readonly ChamadoContext _context;

        public SolucaoDao(ChamadoContext chamadoContext)
        {
            _context = chamadoContext;
        }


        public void Delete(int id)
        {
            Solucao solucao = Get(id);
            _context.Solucao.Remove(solucao);
            _context.SaveChanges();
        }

        public Solucao Get(params object[] id)
        {
            return _context.Solucao.Find(id);
        }

        public IEnumerable<Solucao> List()
        {
            return _context.Solucao.ToList(); 
        }

        public void Save(Solucao solucao)
        {
            _context.Solucao.Add(solucao);
            _context.SaveChanges();
        }

        public void SaveAll(IEnumerable<Solucao> solucoes)
        {
            _context.Solucao.AddRange(solucoes);
            _context.SaveChanges();
        }

        public void Updade(Solucao solucao)
        {
            _context.Solucao.Update(solucao);
            _context.SaveChanges();
        }
    }
}
