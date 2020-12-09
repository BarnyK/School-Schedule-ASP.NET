#pragma checksum "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df0d9687bf1e13efd5ca0c6c2f3334015c55cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activities_Index), @"mvc.1.0.view", @"/Views/Activities/Index.cshtml")]
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
#line 1 "/home/barny/eg2/EguiProject2/Views/_ViewImports.cshtml"
using EguiProject2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/barny/eg2/EguiProject2/Views/_ViewImports.cshtml"
using EguiProject2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8df0d9687bf1e13efd5ca0c6c2f3334015c55cbf", @"/Views/Activities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c493610ad012909667ef1267266fb4419a1e2d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Activities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("room-selector-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "activities", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
  
    ViewData["Title"] = "Planner";
    var rooms = ViewData["Rooms"] as List<string>;
    var hours = ViewData["Hours"] as List<string>;
    var days = ViewData["Days"] as List<string>;
    var room = ViewData["CurrentRoom"] as string;
    var activities = ViewData["Activities"] as Activit[,];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"form-group\" id=\"selector\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df0d9687bf1e13efd5ca0c6c2f3334015c55cbf5023", async() => {
                WriteLiteral(" \n        <label for=\"room-selector\">\n            Room:\n        </label>\n        <select id=\"room-selector\"  class=\"form-control\">\n");
#nullable restore
#line 16 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
             for(var i = 0; i < rooms.Count ; i++){
                if(rooms[i] == (string)ViewData["CurrentRoom"]){

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df0d9687bf1e13efd5ca0c6c2f3334015c55cbf5722", async() => {
#nullable restore
#line 18 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                                                     Write(rooms[i]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                                   WriteLiteral(rooms[i]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 19 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                }
                else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df0d9687bf1e13efd5ca0c6c2f3334015c55cbf7841", async() => {
#nullable restore
#line 21 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                                         Write(rooms[i]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                       WriteLiteral(rooms[i]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 22 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
#nullable restore
#line 28 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
 if(room == ""){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"no-rooms-error\">\n        Please add rooms before proceading\n    </p>\n");
#nullable restore
#line 32 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"plan-table\">\n    <table class=\"table table-bordered\">\n        <thead>\n            <tr>\n                <th scope=\"col\">#</th>\n");
#nullable restore
#line 39 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                 for(var d=0; d < days.Count; d++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"col\">");
#nullable restore
#line 40 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                               Write(days[d]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 41 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n        </thead>\n        <tbody class=\"plan-table-body\">\n");
#nullable restore
#line 45 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
             for(var h = 0; h < hours.Count; h++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
#nullable restore
#line 47 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                               Write(hours[h]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n");
#nullable restore
#line 48 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                     for(var d = 0; d < 5; d++){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td \n                            data-day=\"");
#nullable restore
#line 50 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                                 Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n                            data-slot=\"");
#nullable restore
#line 51 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                                  Write(h);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n                        >\n");
#nullable restore
#line 53 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                         if(activities[d,h] is not null){
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                       Write(activities[d,h].Group);

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                                                  
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\n");
#nullable restore
#line 57 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 59 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n<script>\n    var currentRoom = \'");
#nullable restore
#line 64 "/home/barny/eg2/EguiProject2/Views/Activities/Index.cshtml"
                  Write(ViewData["CurrentRoom"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
    if(currentRoom){
        $(""#room-selector"").change(function(){
            let act = $(""#room-selector-form"").attr(""action"");
            window.location.href = act + '?room=' + $(""#room-selector"")[0].value;
        });

        $("".plan-table-body"").dblclick(function(event){
            let day = event.target.attributes[""data-day""].value;
            let hour = event.target.attributes[""data-slot""].value;
            console.log(`${day},${hour}`);
            window.location.href = `/Activities/EditActivity?day=${day}&slot=${hour}&room=${currentRoom}`
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
