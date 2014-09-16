using Abp.Web.Mvc.Controllers;

namespace ItContract.Web.Controllers
{
    public abstract class ItContractControllerBase : AbpController
    {
        protected ItContractControllerBase()
        {
            LocalizationSourceName = "ItContract";
        }
    }
}