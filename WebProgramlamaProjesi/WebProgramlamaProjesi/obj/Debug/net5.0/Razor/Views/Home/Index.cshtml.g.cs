#pragma checksum "C:\Users\ibrah\Desktop\Web-Programlama-Projesi\WebProgramlamaProjesi\WebProgramlamaProjesi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "419a6f640465beb10ef82139502ea387a14241a7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"419a6f640465beb10ef82139502ea387a14241a7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c31f05e611f09b9c1358f5250d638b05f7a2de1", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral(@"
<div class=""text-center"">
    <section class=""hero"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""hero__categories"">
                        <div class=""hero__categories__all"">
                            <i class=""fa fa-bars""></i>
                            <span>All departments</span>
                        </div>
                        <ul>
                            <li><a href=""#"">Fresh Meat</a></li>
                            <li><a href=""#"">Vegetables</a></li>
                            <li><a href=""#"">Fruit & Nut Gifts</a></li>
                            <li><a href=""#"">Fresh Berries</a></li>
                            <li><a href=""#"">Ocean Foods</a></li>
                            <li><a href=""#"">Butter & Eggs</a></li>
                            <li><a href=""#"">Fastfood</a></li>
                            <li><a href=""#"">Fresh Onion</a></li>
                            <li><a href=""");
            WriteLiteral(@"#"">Papayaya & Crisps</a></li>
                            <li><a href=""#"">Oatmeal</a></li>
                            <li><a href=""#"">Fresh Bananas</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-9"">
                    <div class=""hero__search"">
                        <div class=""hero__search__form"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "419a6f640465beb10ef82139502ea387a14241a75438", async() => {
                WriteLiteral(@"
                                <div class=""hero__search__categories"">
                                    All Categories
                                    <span class=""arrow_carrot-down""></span>
                                </div>
                                <input type=""text"" placeholder=""What do yo u need?"">
                                <button type=""submit"" class=""site-btn"">SEARCH</button>
                            ");
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
                        <div class=""hero__search__phone"">
                            <div class=""hero__search__phone__icon"">
                                <i class=""fa fa-phone""></i>
                            </div>
                            <div class=""hero__search__phone__text"">
                                <h5>+65 11.188.888</h5>
                                <span>support 24/7 time</span>
                            </div>
                        </div>
                    </div>
                    <div class=""hero__item set-bg"" data-setbg=""img/hero/banner.jpg"">
                        <div class=""hero__text"">
                            <span>FRUIT FRESH</span>
                            <h2>Vegetable <br />100% Organic</h2>
                            <p>Free Pickup and Delivery Available</p>
                            <a href=""#"" class=""primary-btn"">SHOP NOW</a>
                        </div>
                    </div>
                <");
            WriteLiteral(@"/div>
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
                        <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-1.jpg"">
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
                            <h5><a href=""#"">Veg");
            WriteLiteral(@"etables</a></h5>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-4.jpg"">
                            <h5><a href=""#"">drink fruits</a></h5>
                        </div>
                    </div>
                    <div class=""col-lg-3"">
                        <div class=""categories__item set-bg"" data-setbg=""img/categories/cat-5.jpg"">
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
          ");
            WriteLiteral(@"          </div>
                    <div class=""featured__controls"">
                        <ul>
                            <li class=""active"" data-filter=""*"">All</li>
                            <li data-filter="".oranges"">Oranges</li>
                            <li data-filter="".fresh-meat"">Fresh Meat</li>
                            <li data-filter="".vegetables"">Vegetables</li>
                            <li data-filter="".fastfood"">Fastfood</li>
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
                ");
            WriteLiteral(@"                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fastfood"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-2.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#"">");
            WriteLiteral(@"<i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix vegetables fresh-meat"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-3.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
     ");
            WriteLiteral(@"                   <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood oranges"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-4.jpg"">
                            <ul class=""featured__item__pic__hover"">
                                <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                            </ul>
                        </div>
                        <div class=""featured__item__text"">
                            <h6><a href=""#"">Crab Pool Security</a></");
            WriteLiteral(@"h6>
                            <h5>$30.00</h5>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fresh-meat vegetables"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-5.jpg"">
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
        ");
            WriteLiteral(@"        </div>
                <div class=""col-lg-3 col-md-4 col-sm-6 mix oranges fastfood"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-6.jpg"">
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
                    <di");
            WriteLiteral(@"v class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feature-7.jpg"">
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
                <div class=""col-lg-3 col-md-4 col-sm-6 mix fastfood vegetables"">
                    <div class=""featured__item"">
                        <div class=""featured__item__pic set-bg"" data-setbg=""img/featured/feat");
            WriteLiteral(@"ure-8.jpg"">
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
                        <img src=""im");
            WriteLiteral("g/banner/banner-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 13242, "\"", 13248, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6 col-sm-6\">\r\n                    <div class=\"banner__pic\">\r\n                        <img src=\"img/banner/banner-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 13467, "\"", 13473, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 14284, "\"", 14290, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 14858, "\"", 14864, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 15432, "\"", 15438, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 16114, "\"", 16120, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 16688, "\"", 16694, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 17262, "\"", 17268, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 18261, "\"", 18267, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 18835, "\"", 18841, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 19409, "\"", 19415, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 20091, "\"", 20097, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 20665, "\"", 20671, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 21239, "\"", 21245, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 22235, "\"", 22241, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 22809, "\"", 22815, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 23383, "\"", 23389, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 24065, "\"", 24071, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 24639, "\"", 24645, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 25213, "\"", 25219, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 26380, "\"", 26386, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 27218, "\"", 27224, 0);
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
            BeginWriteAttribute("alt", " alt=\"", 28058, "\"", 28064, 0);
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