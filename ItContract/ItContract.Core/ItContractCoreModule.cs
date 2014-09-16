using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;

namespace ItContract
{
    public class ItContractCoreModule : AbpModule
    {
        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
