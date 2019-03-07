using System;
using Aram.BSS;
using Aram.DA;
using Aram.IBSS;
using Aram.IDataAccess;
using PostgreSQL;
using StructureMap;

namespace Aram.IOC
{
    public class AramRegistry : Registry
    {
        public AramRegistry()
        {
            For<IAramContext>().Use<EntityContext>();
            For<IInventoryDA>().Use<InventoryDA>();
            For<IInventoryBSS>().Use<InventoryBSS>();
            For<IKindDA>().Use<KindDA>();
            For<IKindBSS>().Use<KindBSS>();
            For<IProblemDA>().Use<ProblemDA>();
            For<IProblemBSS>().Use<ProblemBSS>();
            For<IProblemInventoryDA>().Use<ProblemInventoryDA>();
            For<IProblemInventoryBSS>().Use<ProblemInventoryBSS>();
            For<IStatusDA>().Use<StatusDA>();
            For<IStatusBSS>().Use<StatusBSS>();
            For<IUserDA>().Use<UserDA>();
            For<IUserBSS>().Use<UserBSS>();
        }

    }
}
