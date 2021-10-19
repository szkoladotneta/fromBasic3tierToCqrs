using Application.Common;
using Domain.Entities;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly MyDbContext _ctx;

        public ProducerRepository(MyDbContext ctx)
        {
            _ctx = ctx;
        }

        private IQueryable<Producer> Producers => _ctx.Producers;

        public Producer GetProducerById(int id) => Producers.FirstOrDefault(p => p.ProducerId == id);

        public Producer GetProducerByName(string name) => Producers.FirstOrDefault(p => p.ProducerName == name);

        public int SaveNewProducer(Producer producer)
        {
            _ctx.Producers.Add(producer);
            _ctx.SaveChanges();
            return producer.ProducerId;
        }
    }
}
