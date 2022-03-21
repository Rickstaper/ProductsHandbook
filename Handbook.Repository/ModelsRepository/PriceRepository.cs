using Handbook.Contracts;
using Handbook.Data;
using Handbook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handbook.Repository.ModelsRepository
{
    public class PriceRepository : RepositoryBase<Price>, IPriceRepository
    {
        public PriceRepository(HandbookContext handbookContext)
            : base(handbookContext)
        { }
    }
}
