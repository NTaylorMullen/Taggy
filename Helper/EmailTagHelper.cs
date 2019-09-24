using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Helper
{
    [HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
    public class EmailTagHelper : TagHelper, ITagHelper
    {
        Task ITagHelper.ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            return Task.CompletedTask;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
        }
    }
}
