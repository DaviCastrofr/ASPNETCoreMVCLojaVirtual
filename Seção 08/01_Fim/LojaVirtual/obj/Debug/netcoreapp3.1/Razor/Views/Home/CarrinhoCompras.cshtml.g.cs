#pragma checksum "C:\Users\Davi Gatão\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Home\CarrinhoCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7154ffa48ae3edb55b9450b664971287990a3c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CarrinhoCompras), @"mvc.1.0.view", @"/Views/Home/CarrinhoCompras.cshtml")]
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
#line 2 "C:\Users\Davi Gatão\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7154ffa48ae3edb55b9450b664971287990a3c2d", @"/Views/Home/CarrinhoCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef2fe099e0796df0952f9ea1a79a960ba8c3e52b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CarrinhoCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Davi Gatão\Desktop\ASPNETCoreMVCLojaVirtual\Seção 08\01_Fim\LojaVirtual\Views\Home\CarrinhoCompras.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main role=""main"">





    <section class=""container"" id=""order"" style=""margin-top: 50px"">

        <h2 class=""title-doc""># Order </h2>


        <h4 class=""subtitle-doc"">
            # Shopping cart
            <a href=""#"" data-html=""code_cart"" class=""showcode"">[code]</a>
        </h4>
        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table table-hover shopping-cart-wrap"">
                    <thead class=""text-muted"">
                        <tr>
                            <th scope=""col"">Product</th>
                            <th scope=""col"" width=""120"">Quantity</th>
                            <th scope=""col"" width=""120"">Price</th>
                            <th scope=""col"" width=""200"" class=""text-right"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <figure class=""media"">
               ");
            WriteLiteral(@"                     <div class=""img-wrap""><img src=""images/items/1.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                             ");
            WriteLiteral("       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d5395", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d6384", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d7373", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d8362", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 145</var>
                                    <small class=""text-muted"">(USD5 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a");
            BeginWriteAttribute("title", " title=\"", 2793, "\"", 2801, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2802, "\"", 2809, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"\r\n                                   data-original-title=\"Save to Wishlist\"> <i class=\"fa fa-heart\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3008, "\"", 3015, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger""> × Remove</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <figure class=""media"">
                                    <div class=""img-wrap""><img src=""images/items/2.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl>
       ");
            WriteLiteral("                             </figcaption>\r\n                                </figure>\r\n                            </td>\r\n                            <td>\r\n                                <select class=\"form-control\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d11773", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d12763", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d13753", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d14743", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 35</var>
                                    <small class=""text-muted"">(USD10 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a");
            BeginWriteAttribute("title", " title=\"", 4992, "\"", 5000, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 5001, "\"", 5008, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"\r\n                                   data-original-title=\"Save to Wishlist\"> <i class=\"fa fa-heart\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5207, "\"", 5214, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger btn-round""> × Remove</a>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <figure class=""media"">
                                    <div class=""img-wrap""><img src=""images/items/3.jpg"" class=""img-thumbnail img-sm""></div>
                                    <figcaption class=""media-body"">
                                        <h6 class=""title text-truncate"">Product name goes here </h6>
                                        <dl class=""dlist-inline small"">
                                            <dt>Size: </dt>
                                            <dd>XXL</dd>
                                        </dl>
                                        <dl class=""dlist-inline small"">
                                            <dt>Color: </dt>
                                            <dd>Orange color</dd>
                                        </dl");
            WriteLiteral(@">
                                    </figcaption>
                                </figure>
                            </td>
                            <td>
                                <select class=""form-control"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d18156", async() => {
                WriteLiteral("1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d19146", async() => {
                WriteLiteral("2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d20136", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7154ffa48ae3edb55b9450b664971287990a3c2d21126", async() => {
                WriteLiteral("4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </select>
                            </td>
                            <td>
                                <div class=""price-wrap"">
                                    <var class=""price"">USD 45</var>
                                    <small class=""text-muted"">(USD15 each)</small>
                                </div> <!-- price-wrap .// -->
                            </td>
                            <td class=""text-right"">
                                <a");
            BeginWriteAttribute("title", " title=\"", 7201, "\"", 7209, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 7210, "\"", 7217, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" data-toggle=\"tooltip\"\r\n                                   data-original-title=\"Save to Wishlist\"> <i class=\"fa fa-heart\"></i></a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7416, "\"", 7423, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-danger btn-round""> × Remove</a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div> <!-- card.// -->
        </div> <!-- code-wrap.// -->
    </section>
    <br />
    <br />
    <section class=""container"">
        <div class=""row"">
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Cálculo de frete
                    <a href=""#"" data-html=""code_desc_simple"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_simple"">
                    <div class=""box"">
                        <dl>
                            <dt>Some info: </dt>
                            <dd>
                                Dolor sit amet, consectetur adipisicing elit do eiusmod
                                tempor incididunt
                            </dd>
                        </dl>
                        <dl>
  ");
            WriteLiteral(@"                          <dt>Parameter: </dt>
                            <dd>Value name</dd>
                        </dl>
                        <dl>
                            <dt>Discount:</dt>
                            <dd>USD 658</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Cupom desconto
                    <a href=""#"" data-html=""code_desc_align"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_align"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Some info: </dt>
                            <dd> Everything in this life is always tempporary</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Parameter: </dt>
");
            WriteLiteral(@"                            <dd>Value name</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Color:</dt>
                            <dd>Orange and Black</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Material:</dt>
                            <dd>Leather</dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    # Total a pagar
                    <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_right"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Parameter: </dt>
                            <dd class=""text-right"">Value name</");
            WriteLiteral(@"dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Color:</dt>
                            <dd class=""text-right"">Orange and Black</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Material:</dt>
                            <dd class=""text-right"">Leather</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Total cost: </dt>
                            <dd class=""text-right h5 b""> USD195 </dd>
                        </dl>
                    </div> <!-- box.// -->
                </div> <!-- code-wrap.// -->
            </aside>
        </div>
    </section>



</main>");
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
