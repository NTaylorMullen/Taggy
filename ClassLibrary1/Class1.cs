using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FooTagHelper : TagHelper, ITagHelper
    {
        Task ITagHelper.ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            return Task.CompletedTask;
        }
    }
}
