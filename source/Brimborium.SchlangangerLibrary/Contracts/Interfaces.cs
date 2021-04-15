using Brimborium.Functional;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brimborium.Contracts {
    public interface IEntity {
    }

    public interface IDynamicEntity : IEntity {
    }

    public interface IStaticEntity : IEntity {
    }

    public interface IMetaContainer : IEntity {
    }

    public interface IMetaEntity : IEntity {
    }

    public interface IMetaAction : IEntity {
    }

    public interface IMetaProperty : IEntity {
    }

    public interface IMetaBehaviour : IEntity {
    }

    public interface IMetaValue : IEntity {
    }

    public interface IEntityAdapter {
        MayBe<IMetaEntity> GetMetaEntityByType(Type type);
        MayBe<IMetaEntity> GetMetaEntityByObject(object entity);
        MayBe<IMetaEntity> GetMetaEntityByIEntity<TEntity>(TEntity entity) where TEntity: IEntity;
    }
}
