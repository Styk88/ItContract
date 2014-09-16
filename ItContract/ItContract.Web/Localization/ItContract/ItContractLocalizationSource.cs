using System.Web;
using Abp.Localization.Sources.Xml;

namespace ItContract.Web.Localization.ItContract
{
    public class ItContractLocalizationSource : XmlLocalizationSource
    {
        public ItContractLocalizationSource()
            : base("ItContract", HttpContext.Current.Server.MapPath("/Localization/ItContract"))
        {
        }
    }
}