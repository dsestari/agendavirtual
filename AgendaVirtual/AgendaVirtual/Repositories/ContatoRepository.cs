using AgendaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaVirtual.Repositories
{
    public class ContatoRepository
    {
        public List<Contato> ObterContatos()
        {
            using(Context db = new Context())
            {
                return db.Contatos.ToList();
            }
        }

        public Contato ObterContato(int id)
        {
            using(Context db = new Context())
            {
                return db.Contatos.SingleOrDefault(c => c.idContato == id);
            }
        }

        public Contato IncluirContato(Contato contato)
        {
            using(Context db = new Context())
            {
                db.Entry(contato).State = System.Data.Entity.EntityState.Added;

                db.SaveChanges();

                return contato;
            }
        }

        public Contato AtualizarContato(Contato contato)
        {
            using(Context db = new Context())
            {
                db.Entry(contato).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();

                return contato;
            }
        }

        public void ExcluirContato(Contato contato)
        {
            using (Context db = new Context())
            {
                db.Entry(contato).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
            }
        } 
    }
}