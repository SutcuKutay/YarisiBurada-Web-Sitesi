#pragma checksum "C:\Users\ibrah\Desktop\Web-Programlama-Projesi\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7faee3ce9f14ba8af00480bf0ce028cfb9e3619"
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
#line 1 "C:\Users\ibrah\Desktop\Web-Programlama-Projesi\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\_ViewImports.cshtml"
using WebProgramlamaProjesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrah\Desktop\Web-Programlama-Projesi\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\_ViewImports.cshtml"
using WebProgramlamaProjesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ibrah\Desktop\Web-Programlama-Projesi\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7faee3ce9f14ba8af00480bf0ce028cfb9e3619", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1039d9d76aabaf4688c56f1838f0f2dbd2df9d3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ibrah\Desktop\Web-Programlama-Projesi\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<div class=""text-center"">
    <section class=""hero"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""hero__categories"">
                        <div class=""hero__categories__all bg-warning"">
                            <i class=""fa fa-bars""></i>
                            <span>Bütün türler</span>
                        </div>
                        <ul>
                            <li><a href=""#"">Elektronik</a></li>
                            <li><a href=""#"">Moda</a></li>
                            <li><a href=""#"">Ev, Yaşam, Kırtasiye, Ofis</a></li>
                            <li><a href=""#"">Oto, Bahçe, Yapı, Market</a></li>
                            <li><a href=""#"">Anne, Bebek, Oyuncak</a></li>
                            <li><a href=""#"">Spor, Outdoor</a></li>
                            <li><a href=""#"">Kozmetik, Kişisel Bakım</a></li>
                            <li><a href=""#"">Süp");
            WriteLiteral(@"ermarket, Petshop</a></li>
                            <li><a href=""#"">Kitap, Müzik, Film, Hobi</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-9"">
                    <div class=""hero__search"">
                        <div class=""hero__search__form"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7faee3ce9f14ba8af00480bf0ce028cfb9e36195623", async() => {
                WriteLiteral("\r\n                                <input type=\"text\" placeholder=\"Neye ihtiyacın var?\">\r\n                                <button type=\"submit\" class=\"site-btn bg-warning\">Ara</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""hero__item set-bg"" data-setbg=""img/hero/yag.jpg"">
                        <div class=""text-white"">
                            <h2>Sevgililer Gününe Özel<br />Büyük İndirim!</h2>
                            <p>5LT Komili Ayçiçek yağı sadece 199,99TL</p>
                            <a href=""https://www.cimri.com/market/sivi-yag-ve-zeytinyagi/en-ucuz-selin-5-lt-aycicek-yagi-fiyatlari,259"" class=""primary-btn bg-warning"">Satın Al</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Hero Section End -->
    <!-- Categories Section Begin -->
    <section class=""categories"">
        <div class=""container"">
            <div class=""row"">
                <div class=""categories__slider owl-carousel"">
                    <div class=""col-lg-3"">
                        <div class=""categories__item set-bg"" data-setbg=""img/cat");
            WriteLiteral(@"egories/cat-1.jpg"">
                            <h5><a href=""#"">Fresh Fruit</a></h5>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-2.jpg"">
                            <h5><a href=""#"">Dried Fruit</a></h5>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-3.jpg"">
                            <h5><a href=""#"">Vegetables</a></h5>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-4.jpg"">
                            <h5><a href=""#"">drink fruits</a></h5>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                    ");
            WriteLiteral(@"    <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-5.jpg"">
                            <h5><a href=""#"">drink fruits</a></h5>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Categories Section End -->
    <!-- Featured Section Begin -->
    <section class=""featured spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title"">
                        <h2>Featured Product</h2>
                    </div>
                    <div class=""featured__controls"">
                        <ul>
                            <li class=""active"" data-filter=""*"">All</li>
                            <li data-filter="".oranges"">Oranges</li>
                            <li data-filter="".fresh-meat"">Fresh Meat</li>
                            <li data-filter="".vegetables"">Vegetables</li>
                    ");
            WriteLiteral(@"        <li data-filter="".fastfood"">Fastfood</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""row featured__filter"">
                <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fresh-meat"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-1.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
   ");
            WriteLiteral(@"                     </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fastfood"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-2.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 co");
            WriteLiteral(@"l-md-4 col-sm-6 mix vegetables fresh-meat"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-3.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood oranges"">
                    <div class=""featured__item"">
                        <div");
            WriteLiteral(@" class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-4.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-5.jpg"">
                            <ul class=""f");
            WriteLiteral(@"eatured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fastfood"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-6.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
        ");
            WriteLiteral(@"                        <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-7.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a");
            WriteLiteral(@" href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood vegetables"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-8.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div");
            WriteLiteral(@">
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Featured Section End -->
    <!-- Banner Begin -->
    <div class=""banner"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6 col-sm-6"">
                    <div class=""banner__pic"">
                        <img src=""img/banner/banner-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12542, "\"", 12548, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                    <div class=\"banner__pic\">\r\n                        <img src=\"img/banner/banner-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 12767, "\"", 12773, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Banner End -->
    <!-- Latest Product Section Begin -->
    <section class=""latest-product spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-4 col-md-6"">
                    <div class=""latest-product__text"">
                        <h4>Latest Products</h4>
                        <div class=""latest-product__slider owl-carousel"">
                            <div class=""latest-prdouct__slider__item"">
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 13584, "\"", 13590, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14158, "\"", 14164, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 14732, "\"", 14738, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                            </div>
                            <div class=""latest-prdouct__slider__item"">
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15414, "\"", 15420, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15988, "\"", 15994, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 16562, "\"", 16568, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6"">
                    <div class=""latest-product__text"">
                        <h4>Top Rated Products</h4>
                        <div class=""latest-product__slider owl-carousel"">
                            <div class=""latest-prdouct__slider__item"">
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17561, "\"", 17567, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 18135, "\"", 18141, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 18709, "\"", 18715, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                            </div>
                            <div class=""latest-prdouct__slider__item"">
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 19391, "\"", 19397, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 19965, "\"", 19971, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 20539, "\"", 20545, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-6"">
                    <div class=""latest-product__text"">
                        <h4>Review Products</h4>
                        <div class=""latest-product__slider owl-carousel"">
                            <div class=""latest-prdouct__slider__item"">
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 21535, "\"", 21541, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 22109, "\"", 22115, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 22683, "\"", 22689, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                            </div>
                            <div class=""latest-prdouct__slider__item"">
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 23365, "\"", 23371, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 23939, "\"", 23945, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                                <a href=""#"" class=""latest-product__item"">
                                    <div class=""latest-product__item__pic"">
                                        <img src=""img/latest-product/lp-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 24513, "\"", 24519, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""latest-product__item__text"">
                                        <h6>Crab Pool Security</h6>
                                        <span>$30.00</span>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Latest Product Section End -->
    <!-- Blog Section Begin -->
    <section class=""from-blog spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section-title from-blog__title"">
                        <h2>From The Blog</h2>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-4 col-md-4 col-sm-6"">
                    <di");
            WriteLiteral("v class=\"blog__item\">\r\n                        <div class=\"blog__item__pic\">\r\n                            <img src=\"img/blog/blog-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 25680, "\"", 25686, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""blog__item__text"">
                            <ul>
                                <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                <li><i class=""fa fa-comment-o""></i> 5</li>
                            </ul>
                            <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                            <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-6"">
                    <div class=""blog__item"">
                        <div class=""blog__item__pic"">
                            <img src=""img/blog/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 26518, "\"", 26524, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""blog__item__text"">
                            <ul>
                                <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                <li><i class=""fa fa-comment-o""></i> 5</li>
                            </ul>
                            <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                            <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 col-md-4 col-sm-6"">
                    <div class=""blog__item"">
                        <div class=""blog__item__pic"">
                            <img src=""img/blog/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 27358, "\"", 27364, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""blog__item__text"">
                            <ul>
                                <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                <li><i class=""fa fa-comment-o""></i> 5</li>
                            </ul>
                            <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                            <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
