#pragma checksum "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0ff739cb230bfeaec0a699bcdd1f4047803713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Details), @"mvc.1.0.view", @"/Views/Vendors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Details.cshtml", typeof(AspNetCore.Views_Vendors_Details))]
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
#line 1 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\_ViewImports.cshtml"
using PRSVersion1Project;

#line default
#line hidden
#line 2 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\_ViewImports.cshtml"
using PRSVersion1Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e0ff739cb230bfeaec0a699bcdd1f4047803713", @"/Views/Vendors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf7aac2d276bd4ce114af6733fac628a591ee11", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRSVersion1Project.Models.Vendor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 129, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Vendor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(216, 40, false);
#line 14 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(256, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(320, 36, false);
#line 17 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(356, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(419, 40, false);
#line 20 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(459, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(523, 36, false);
#line 23 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(559, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(622, 43, false);
#line 26 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(665, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(729, 39, false);
#line 29 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(768, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(831, 40, false);
#line 32 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(871, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(935, 36, false);
#line 35 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(971, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1034, 41, false);
#line 38 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1139, 37, false);
#line 41 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1239, 39, false);
#line 44 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1342, 35, false);
#line 47 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1440, 41, false);
#line 50 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1545, 37, false);
#line 53 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1645, 41, false);
#line 56 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1750, 37, false);
#line 59 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1834, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e0ff739cb230bfeaec0a699bcdd1f404780371311394", async() => {
                BeginContext(1880, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\MAX-Student\source\repos\PRSVersion1Solution\PRSVersion1Project\Views\Vendors\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1888, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1896, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e0ff739cb230bfeaec0a699bcdd1f404780371313738", async() => {
                BeginContext(1918, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1934, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRSVersion1Project.Models.Vendor> Html { get; private set; }
    }
}
#pragma warning restore 1591
