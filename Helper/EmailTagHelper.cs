using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Helper
{
    [HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
    public class EmailTagHelper : TagHelper, ITagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
        }
    }
}
