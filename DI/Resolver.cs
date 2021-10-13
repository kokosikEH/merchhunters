using Autofac;
using BLL;
using DAL;
using merchhunters.BLL.BLLContracts;
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
        public void Resolve()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MockSelector>().As<ISelector>();
            builder.RegisterType<CatalogLogic>().As<ICatalogLogic>();
        }
    }
}
