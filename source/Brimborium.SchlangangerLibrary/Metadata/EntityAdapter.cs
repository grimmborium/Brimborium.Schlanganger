using Brimborium.Contracts;
using Brimborium.Functional;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brimborium.Metadata {
    public class EntityAdapter : IEntityAdapter {
        public EntityAdapter() {
        }

        public MayBe<IMetaEntity> GetMetaEntityByIEntity<TEntity>(TEntity entity) where TEntity : IEntity {
            throw new NotImplementedException();
        }

        public MayBe<IMetaEntity> GetMetaEntityByObject(object entity) {
            throw new NotImplementedException();
        }

        public MayBe<IMetaEntity> GetMetaEntityByType(Type type) {
            throw new NotImplementedException();
        }
    }
}
