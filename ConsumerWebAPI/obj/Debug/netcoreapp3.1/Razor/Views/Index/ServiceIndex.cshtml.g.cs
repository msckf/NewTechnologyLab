#pragma checksum "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fee868b96b6b9c1e2c9db09da4498b7ecc07ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_ServiceIndex), @"mvc.1.0.view", @"/Views/Index/ServiceIndex.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\_ViewImports.cshtml"
using ConsumerWebAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\_ViewImports.cshtml"
using ConsumerWebAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fee868b96b6b9c1e2c9db09da4498b7ecc07ae0", @"/Views/Index/ServiceIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72b7dd75de158090c649ccb018e52b7e9ce125e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Index_ServiceIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ConsulService>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <style>
        table.tftable,
        table.table-count {
            font-size: 12px;
            color: #333333;
            width: 100%;
            border-width: 1px;
            border-collapse: collapse;
        }

            table.table-count th,
            table.table-count td {
                font-weight: 400;
                font-style: normal;
                font-size: 12px;
                border-width: 1px;
                border-style: solid;
                border-color: #e4e4e4;
                text-align: center;
            }

            table.tftable th,
            table.tftable td {
                font-weight: 400;
                font-style: normal;
                font-size: 12px;
                border-width: 1px;
                padding: 8px;
                border-style: solid;
                border-color: #e4e4e4;
                text-align: left;
                text-align: center;
            }

        .tftable {
            margin");
            WriteLiteral(@"-left: 1%;
            margin-bottom: 10px;
            margin-top: 10px;
        }

        table.tftable tr:hover {
            background: #C3ECFF;
        }

        .tftable > thead > tr:hover {
            background: white;
        }
    </style>

        <table class=""tftable"" style=""width: 98%;"">
            <tr>
                <td>服务ID</td>
                <td>服务IP</td>
                <td>服务端口</td>
                <td>服务名称</td>
                <td>调用服务</td>
            </tr>
");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
                   Write(item.Port);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
                   Write(Html.ActionLink("获取数据","GetWebAPI",new { Url = item.Url }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Admin\Desktop\WebApi.Demo\ConsumerWebAPI\Views\Index\ServiceIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ConsulService>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
