#pragma checksum "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232cec43ebec4a7839e2f7d5edcbdddbe31ed294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\_ViewImports.cshtml"
using DogGo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\_ViewImports.cshtml"
using DogGo2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232cec43ebec4a7839e2f7d5edcbdddbe31ed294", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d51492f0f7e66c209e9aac5e4310217d01e9ea5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo2.Models.ViewModels.WalkersViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Walker Profile</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Walker.Neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
       Write(Html.DisplayFor(model => model.Walker.Neighborhood.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            <img class=\"bg-info\"");
            BeginWriteAttribute("src", " src=\"", 691, "\"", 719, 1);
#nullable restore
#line 26 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 697, Model.Walker.ImageUrl, 697, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\" />\r\n        </dt>\r\n       \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 32 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232cec43ebec4a7839e2f7d5edcbdddbe31ed2945865", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""row"">
    <section class=""col-8 container mt-5"">
      <h1 class=""text-left"">Walks</h1>

      <table class=""table"">
          <thead>
              <tr>
                  <th scope=""col"">Date</th>
                  <th scope=""col"">Client</th>
                  <th scope=""col"">Duration</th>
              </tr>
          </thead>
          <tbody>
      
");
#nullable restore
#line 50 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
           foreach (Walks walk in Model.Walks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 53 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
                   Write(walk.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
                   Write(walk.Dog.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
                   Write(TimeSpan.FromSeconds(walk.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</td>\r\n                </tr>          \r\n");
#nullable restore
#line 57 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n      </table>\r\n    </section>\r\n\r\n    <section>\r\n        <h1>Totalk Walk Time : ");
#nullable restore
#line 64 "D:\workspace\backend\csharp\book2\DogGo2\DogGo2\Views\Walkers\Details.cshtml"
                          Write(TimeSpan.FromSeconds(Model.Walks.Sum(walk => walk.Duration)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </section>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo2.Models.ViewModels.WalkersViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
