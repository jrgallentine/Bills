#pragma checksum "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0146acbea2c66aa65bd7f4b765152df6a90ed1fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\_ViewImports.cshtml"
using BillReminder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\_ViewImports.cshtml"
using BillReminder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0146acbea2c66aa65bd7f4b765152df6a90ed1fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb415e911762b199dbadb6eabe1e9d6ab9e0f254", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
 foreach (Bill b in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 5 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
   Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
  Write(b.Due);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
  Write(b.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 8 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
  Write(b.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
  Write(b.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\jahhh\GrandCircus\Bills\BillReminder\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
