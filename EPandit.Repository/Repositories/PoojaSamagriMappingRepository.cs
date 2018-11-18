using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPandit.Repository.Infrastructure;
using EPandit.Repository.DataModel;

namespace EPandit.Repository.Repositories
{
    public interface IPoojaSamagriMappingRepository: IRepository<PoojaSamagriMapping>
    {

    }

    public class PoojaSamagriMappingRepository: RepositoryBase<PoojaSamagriMapping>, IPoojaSamagriMappingRepository
    {
        private readonly EPanditEntities context;

        public PoojaSamagriMappingRepository(EPanditEntities context): base(context)
        {
            this.context = context;
        }

        public override PoojaSamagriMapping FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}