using Abp.Web.Mvc.Views;

namespace ItContract.Web.Views
{
    public abstract class ItContractWebViewPageBase : ItContractWebViewPageBase<dynamic>
    {

    }

    public abstract class ItContractWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ItContractWebViewPageBase()
        {
            LocalizationSourceName = "ItContract";
        }
    }
}