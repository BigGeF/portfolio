#pragma checksum "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9dfc246629e5fc3c62eab49dc9ce47a821eaf44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Index), @"mvc.1.0.view", @"/Views/Hello/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hello/Index.cshtml", typeof(AspNetCore.Views_Hello_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9dfc246629e5fc3c62eab49dc9ce47a821eaf44", @"/Views/Hello/Index.cshtml")]
    public class Views_Hello_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9dfc246629e5fc3c62eab49dc9ce47a821eaf442908", async() => {
                BeginContext(41, 135, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(185, 540, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9dfc246629e5fc3c62eab49dc9ce47a821eaf444235", async() => {
                BeginContext(191, 35, true);
                WriteLiteral("\r\n    <h1>Hello From Views!!</h1>\r\n");
                EndContext();
#line 10 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
      
        var StringList = new List<string>{
            "one",
            "two",
            "three",
            "four"
        };
        foreach(var word in StringList)
        {
            
            

#line default
#line hidden
#line 20 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
             if(word[0]=='t'){

#line default
#line hidden
                BeginContext(470, 60, true);
                WriteLiteral("                <p style=\"color:red\";>\r\n                    ");
                EndContext();
                BeginContext(531, 4, false);
#line 22 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
               Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(535, 24, true);
                WriteLiteral("\r\n                </p>\r\n");
                EndContext();
#line 24 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
            }
            else{

#line default
#line hidden
                BeginContext(593, 55, true);
                WriteLiteral("                <p>\r\n                    <a href=\"/Hi\">");
                EndContext();
                BeginContext(649, 4, false);
#line 27 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
                             Write(word);

#line default
#line hidden
                EndContext();
                BeginContext(653, 32, true);
                WriteLiteral("</a>\r\n                    </p>\r\n");
                EndContext();
#line 29 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
            }

#line default
#line hidden
#line 29 "C:\Program Files\codingdojo\C#\newMe\AspMVC\TestProject\Views\Hello\Index.cshtml"
             
        }
    

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(725, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
