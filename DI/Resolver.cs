using Autofac;
using BLL;
using merchhunters.BLL.BLLContracts;
using merchhunters.DAL.DAL;
using merchhunters.DAL.DalContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class Resolver
    {
        public IContainer Resolve()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MockSelector>().As<ISelector>();
            builder.RegisterType<CatalogLogic>().As<ICatalogLogic>();

            return builder.Build();
        }
    }
}
