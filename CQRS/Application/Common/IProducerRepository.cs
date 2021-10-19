using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IProducerRepository
    {
        Producer GetProducerById(int id);
        Producer GetProducerByName(string name);
        int SaveNewProducer(Producer producer);

    }
}
