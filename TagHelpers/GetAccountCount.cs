using HMD.BankApp.Web.Data.Context;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HMD.BankApp.Web.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount : TagHelper
    {
        public int ApplicationUserId { get; set; }

        private readonly BankContext _bankContext;

        public GetAccountCount(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _bankContext.AccountDbSet.Count(x => x.ApplicationUserId == ApplicationUserId);

            var html = $"<span class='badge bg-danger'> {accountCount} </span>";

            output.Content.SetHtmlContent(html);


            base.Process(context, output);
        }
    }
}
