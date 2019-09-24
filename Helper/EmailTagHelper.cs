using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Helper
{
    [HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
    public class EmailTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
        }
    }
}
