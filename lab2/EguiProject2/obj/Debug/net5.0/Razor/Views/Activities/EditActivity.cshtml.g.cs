#pragma checksum "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "780025571318b4762a557d4034ec44d2575ff3be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activities_EditActivity), @"mvc.1.0.view", @"/Views/Activities/EditActivity.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780025571318b4762a557d4034ec44d2575ff3be", @"/Views/Activities/EditActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c493610ad012909667ef1267266fb4419a1e2d4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Activities_EditActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityStorage>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
  
    ViewData["Title"] = "Edit Activity";
    var act = ViewData["Activity"] as Activit;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
 using (Html.BeginForm(
    "RemoveActivity",
    "Activities",
    FormMethod.Post,
    new {@class="form-group edit-activity"}
)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" id=\"go-back-button\" class=\"btn btn-dark\" onclick=\"goBack()\">Go back</button>\n");
#nullable restore
#line 15 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
     if(act is null){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"submit\" class=\"btn btn-danger\" disabled>Remove</button>\n");
#nullable restore
#line 17 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"hidden\" name=\"room\"");
            BeginWriteAttribute("value", " value=\"", 510, "\"", 527, 1);
#nullable restore
#line 19 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 518, act.Room, 518, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <input type=\"hidden\" name=\"day\"");
            BeginWriteAttribute("value", " value=\"", 569, "\"", 585, 1);
#nullable restore
#line 20 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 577, act.Day, 577, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <input type=\"hidden\" name=\"slot\"");
            BeginWriteAttribute("value", " value=\"", 628, "\"", 645, 1);
#nullable restore
#line 21 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 636, act.Slot, 636, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <button type=\"submit\" class=\"btn btn-danger\">Remove</button>\n");
#nullable restore
#line 23 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" id=\"add-act-button\" class=\"btn btn-success\" onclick=\"addActivity()\">Add</button>\n");
#nullable restore
#line 25 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 28 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
 using (Html.BeginForm(
    "EditActivity",
    "Activities",
    FormMethod.Post,
    new {@class="form-group edit-activity", @id="edit-activity-form"}
)){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"room\"");
            BeginWriteAttribute("value", " value=\"", 1027, "\"", 1052, 1);
#nullable restore
#line 34 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 1035, ViewData["Room"], 1035, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <input type=\"hidden\" name=\"slot\"");
            BeginWriteAttribute("value", " value=\"", 1091, "\"", 1116, 1);
#nullable restore
#line 35 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 1099, ViewData["Slot"], 1099, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <input type=\"hidden\" name=\"day\"");
            BeginWriteAttribute("value", " value=\"", 1154, "\"", 1180, 1);
#nullable restore
#line 36 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 1162, ViewData["DayId"], 1162, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <label for=\"room\">Room: </label>\n    <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1263, "\"", 1288, 1);
#nullable restore
#line 38 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 1271, ViewData["Room"], 1271, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n    <label>Hours: </label>\n    <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1370, "\"", 1395, 1);
#nullable restore
#line 40 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 1378, ViewData["Hour"], 1378, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n    <label>Day: </label>\n    <input class=\"form-control\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1475, "\"", 1499, 1);
#nullable restore
#line 42 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
WriteAttributeValue("", 1483, ViewData["Day"], 1483, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\n    <label for=\"room\">Group: </label>\n    <select name=\"group\" class=\"form-control\" required>\n");
#nullable restore
#line 45 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
         foreach(var x in Model.Groups){

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780025571318b4762a557d4034ec44d2575ff3be8926", async() => {
#nullable restore
#line 46 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
                          Write(x);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
               WriteLiteral(x);

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
#line 47 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\n");
            WriteLiteral("    <label for=\"Teacher\">Teacher: </label>\n    <select name=\"teacher\" class=\"form-control\" required>\n");
#nullable restore
#line 52 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
         foreach(var x in Model.Teachers){

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780025571318b4762a557d4034ec44d2575ff3be11177", async() => {
#nullable restore
#line 53 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
                          Write(x);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
               WriteLiteral(x);

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
#line 54 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\n    <label for=\"Topic\">Topic: </label>\n    <select name=\"topic\" class=\"form-control\" required>\n");
#nullable restore
#line 58 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
         foreach(var x in Model.Topics){

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780025571318b4762a557d4034ec44d2575ff3be13391", async() => {
#nullable restore
#line 59 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
                          Write(x);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
               WriteLiteral(x);

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
#line 60 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\n");
#nullable restore
#line 62 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script>\n    $(\"#go-back-button\").click(function(){\n        window.location.href = \"/Activities/Index?room=");
#nullable restore
#line 67 "/home/barny/eg2/EguiProject2/Views/Activities/EditActivity.cshtml"
                                                  Write(ViewData["room"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n    });\n\n    $(\"#add-act-button\").click(function(){\n        $(\"#edit-activity-form\").submit();\n    })\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityStorage> Html { get; private set; }
    }
}
#pragma warning restore 1591
