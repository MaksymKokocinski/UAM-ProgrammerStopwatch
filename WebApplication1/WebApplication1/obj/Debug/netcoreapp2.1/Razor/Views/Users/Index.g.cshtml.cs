#pragma checksum "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87e8598dc2354a0fb000d3144052218023fffe59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Index.cshtml", typeof(AspNetCore.Views_Users_Index))]
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
#line 1 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using Projekt;

#line default
#line hidden
#line 1 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
using Projekt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e8598dc2354a0fb000d3144052218023fffe59", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ccb9a0a85e2b383b463914ff60e93aa736b684", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Tasks>, List<holdTime>, List<Userzy>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "User";
    var result = 0;
    foreach (var item in Model.Item1)
    {
        if (item.stan == true)
        {
            foreach (var item3 in Model.Item3)
            {
                if (item3.login == (string)ViewData["login"])
                {
                    if (item.id_usera == item3.id)
                    {
                        result += (int)item.diffrence;
                    }
                }
            }
        }
    }
    ViewData["res"] = result;

#line default
#line hidden
            BeginContext(613, 72, true);
            WriteLiteral("<h2>\r\n    Zadania\r\n</h2>\r\n<table class=\"table_own_style\">\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
         foreach (var item in Model.Item1)
        {
            

#line default
#line hidden
#line 31 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
             if (item.stan == false)
            {
                

#line default
#line hidden
#line 33 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                 if (item.id_holdTime == 0)
                {

#line default
#line hidden
            BeginContext(857, 109, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"table_style_name\">\r\n                            ");
            EndContext();
            BeginContext(967, 39, false);
#line 37 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 116, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"table_style_time\">\r\n                            ");
            EndContext();
            BeginContext(1123, 45, false);
#line 40 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 147, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"table_style_button\">\r\n                            <button class=\"butt-defaulta\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1315, "\"", 1387, 3);
            WriteAttributeValue("", 1325, "location.href=\'", 1325, 15, true);
#line 43 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
WriteAttributeValue("", 1340, Url.Action("Start", "Users",new {id=item.id}), 1340, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 1386, "\'", 1386, 1, true);
            EndWriteAttribute();
            BeginContext(1388, 139, true);
            WriteLiteral(">\r\n                                Start\r\n                            </button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#line 48 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                 
            }

#line default
#line hidden
#line 49 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1572, 172, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<h2>\r\n    Przypisane\r\n</h2>\r\n<table class=\"table_own_style\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"table_style_name\">\r\n                ");
            EndContext();
            BeginContext(1745, 63, false);
#line 60 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().name));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"table_style_time\">\r\n                ");
            EndContext();
            BeginContext(1889, 69, false);
#line 63 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"table_style_time\">\r\n                ");
            EndContext();
            BeginContext(2039, 69, false);
#line 66 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item2.FirstOrDefault().time_start));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"table_style_time\">\r\n                ");
            EndContext();
            BeginContext(2189, 68, false);
#line 69 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().diffrence));

#line default
#line hidden
            EndContext();
            BeginContext(2257, 83, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"body_user_edit\">\r\n");
            EndContext();
#line 74 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
         foreach (var item in Model.Item1)
        {
            

#line default
#line hidden
#line 76 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
             if (item.stan == false)
            {
                

#line default
#line hidden
#line 78 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                 foreach (var item3 in Model.Item3)
                {
                    

#line default
#line hidden
#line 80 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                     if (item3.login == (string)ViewData["login"])
                    {
                        

#line default
#line hidden
#line 82 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                         if (item.id_usera == item3.id)
                        {
                            

#line default
#line hidden
#line 84 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                             if (item.id_holdTime != 0)
                            {
                                

#line default
#line hidden
#line 86 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                 if (Model.Item2.Where(x => x.id == item.id_holdTime).FirstOrDefault().time_diffrence == 0)
                                {

#line default
#line hidden
            BeginContext(2943, 173, true);
            WriteLiteral("                                    <tr name=\"table-tr\">\r\n                                        <td class=\"table_style_name\">\r\n                                            ");
            EndContext();
            BeginContext(3117, 39, false);
#line 90 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(3156, 164, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_time\">\r\n                                            ");
            EndContext();
            BeginContext(3321, 45, false);
#line 93 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(3366, 194, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td style=\"background-color:cyan\" class=\"table_style_time\">\r\n                                            ");
            EndContext();
            BeginContext(3561, 44, false);
#line 96 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.time_user));

#line default
#line hidden
            EndContext();
            BeginContext(3605, 164, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_time\">\r\n                                            ");
            EndContext();
            BeginContext(3770, 44, false);
#line 99 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.diffrence));

#line default
#line hidden
            EndContext();
            BeginContext(3814, 195, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_button\">\r\n                                            <button class=\"butt-defaulta\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4009, "\"", 4090, 3);
            WriteAttributeValue("", 4019, "location.href=\'", 4019, 15, true);
#line 102 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
WriteAttributeValue("", 4034, Url.Action("Zatrzymaj", "Users", new { id = item.id }), 4034, 55, false);

#line default
#line hidden
            WriteAttributeValue("", 4089, "\'", 4089, 1, true);
            EndWriteAttribute();
            BeginContext(4091, 310, true);
            WriteLiteral(@">
                                                Zatrzymaj
                                            </button>
                                        </td>
                                        <td class=""table_style_button"">
                                            <button class=""butt-defaulta""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4401, "\"", 4436, 3);
            WriteAttributeValue("", 4411, "confirmDelete(\'", 4411, 15, true);
#line 107 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
WriteAttributeValue("", 4426, item.id, 4426, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 4434, "\')", 4434, 2, true);
            EndWriteAttribute();
            BeginContext(4437, 205, true);
            WriteLiteral(">\r\n                                                Zakończ\r\n                                            </button>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 112 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4750, 173, true);
            WriteLiteral("                                    <tr name=\"table-tr\">\r\n                                        <td class=\"table_style_name\">\r\n                                            ");
            EndContext();
            BeginContext(4924, 39, false);
#line 117 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(4963, 164, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_time\">\r\n                                            ");
            EndContext();
            BeginContext(5128, 45, false);
#line 120 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(5173, 164, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_time\">\r\n                                            ");
            EndContext();
            BeginContext(5338, 44, false);
#line 123 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.time_user));

#line default
#line hidden
            EndContext();
            BeginContext(5382, 164, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_time\">\r\n                                            ");
            EndContext();
            BeginContext(5547, 44, false);
#line 126 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.diffrence));

#line default
#line hidden
            EndContext();
            BeginContext(5591, 195, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"table_style_button\">\r\n                                            <button class=\"butt-defaulta\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5786, "\"", 5863, 3);
            WriteAttributeValue("", 5796, "location.href=\'", 5796, 15, true);
#line 129 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
WriteAttributeValue("", 5811, Url.Action("Wznow", "Users", new { id = item.id }), 5811, 51, false);

#line default
#line hidden
            WriteAttributeValue("", 5862, "\'", 5862, 1, true);
            EndWriteAttribute();
            BeginContext(5864, 306, true);
            WriteLiteral(@">
                                                Wznów
                                            </button>
                                        </td>
                                        <td class=""table_style_button"">
                                            <button class=""butt-defaulta""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6170, "\"", 6205, 3);
            WriteAttributeValue("", 6180, "confirmDelete(\'", 6180, 15, true);
#line 134 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
WriteAttributeValue("", 6195, item.id, 6195, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 6203, "\')", 6203, 2, true);
            EndWriteAttribute();
            BeginContext(6206, 205, true);
            WriteLiteral(">\r\n                                                Zakończ\r\n                                            </button>\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 139 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                }

#line default
#line hidden
#line 139 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                 
                            }

#line default
#line hidden
#line 140 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                             
                        }

#line default
#line hidden
#line 141 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                         
                    }

#line default
#line hidden
#line 142 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                     
                }

#line default
#line hidden
#line 143 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                 
            }

#line default
#line hidden
#line 144 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(6572, 172, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<h2>\r\n    Zakończone\r\n</h2>\r\n<table class=\"table_own_style\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"table_style_name\">\r\n                ");
            EndContext();
            BeginContext(6745, 63, false);
#line 155 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().name));

#line default
#line hidden
            EndContext();
            BeginContext(6808, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"table_style_time\">\r\n                ");
            EndContext();
            BeginContext(6889, 69, false);
#line 158 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(6958, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"table_style_time\">\r\n                ");
            EndContext();
            BeginContext(7039, 68, false);
#line 161 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().time_user));

#line default
#line hidden
            EndContext();
            BeginContext(7107, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"table_style_time\">\r\n                ");
            EndContext();
            BeginContext(7188, 68, false);
#line 164 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Item1.FirstOrDefault().diffrence));

#line default
#line hidden
            EndContext();
            BeginContext(7256, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 169 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
         foreach (var item in Model.Item1)
        {
            

#line default
#line hidden
#line 171 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
             if (item.stan == true)
            {
                

#line default
#line hidden
#line 173 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                 foreach (var item3 in Model.Item3)
                {
                    

#line default
#line hidden
#line 175 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                     if (item3.login == (string)ViewData["login"])
                    {
                        

#line default
#line hidden
#line 177 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                         if (item.id_usera == item3.id)
                        {
                            

#line default
#line hidden
#line 179 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                             if (item.diffrence < 0)
                            {

#line default
#line hidden
            BeginContext(7758, 179, true);
            WriteLiteral("                                <tr style=\"background-color:#ff2626;\">\r\n                                    <td class=\"table_style_name\">\r\n                                        ");
            EndContext();
            BeginContext(7938, 39, false);
#line 183 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(7977, 152, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_time\">\r\n                                        ");
            EndContext();
            BeginContext(8130, 45, false);
#line 186 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(8175, 152, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_time\">\r\n                                        ");
            EndContext();
            BeginContext(8328, 44, false);
#line 189 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.time_user));

#line default
#line hidden
            EndContext();
            BeginContext(8372, 152, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_time\">\r\n                                        ");
            EndContext();
            BeginContext(8525, 44, false);
#line 192 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.diffrence));

#line default
#line hidden
            EndContext();
            BeginContext(8569, 261, true);
            WriteLiteral(@"
                                    </td>
                                    <td style=""border: 1px solid black"">
                                        Zadanie zakończone
                                    </td>
                                </tr>
");
            EndContext();
#line 198 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(8926, 179, true);
            WriteLiteral("                                <tr style=\"background-color:#00bf00;\">\r\n                                    <td class=\"table_style_name\">\r\n                                        ");
            EndContext();
            BeginContext(9106, 39, false);
#line 203 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(9145, 152, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_time\">\r\n                                        ");
            EndContext();
            BeginContext(9298, 45, false);
#line 206 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.time_admin));

#line default
#line hidden
            EndContext();
            BeginContext(9343, 152, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_time\">\r\n                                        ");
            EndContext();
            BeginContext(9496, 44, false);
#line 209 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.time_user));

#line default
#line hidden
            EndContext();
            BeginContext(9540, 152, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_time\">\r\n                                        ");
            EndContext();
            BeginContext(9693, 44, false);
#line 212 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.diffrence));

#line default
#line hidden
            EndContext();
            BeginContext(9737, 254, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"table_style_name\">\r\n                                        Zadanie zakończone\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 218 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                            }

#line default
#line hidden
#line 218 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                             
                        }

#line default
#line hidden
#line 219 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                         
                    }

#line default
#line hidden
#line 220 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                     
                }

#line default
#line hidden
#line 221 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                 
            }

#line default
#line hidden
#line 222 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(10117, 147, true);
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td><b>Suma różnic</b></td>\r\n            <td><b>");
            EndContext();
            BeginContext(10265, 15, false);
#line 230 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
              Write(ViewData["res"]);

#line default
#line hidden
            EndContext();
            BeginContext(10280, 52, true);
            WriteLiteral("</b></td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10351, 37, true);
                WriteLiteral("\r\n    <script>\r\n        var sesja = \'");
                EndContext();
                BeginContext(10389, 23, false);
#line 238 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                Write(ViewData["nameKomorki"]);

#line default
#line hidden
                EndContext();
                BeginContext(10412, 28, true);
                WriteLiteral("\';\r\n        var continueT = ");
                EndContext();
                BeginContext(10441, 24, false);
#line 239 "C:\Users\SwanG\Desktop\Pr\Pr\P\WebApplication1\WebApplication1\Views\Users\Index.cshtml"
                   Write(ViewData["continueTime"]);

#line default
#line hidden
                EndContext();
                BeginContext(10465, 18, true);
                WriteLiteral(";\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Tasks>, List<holdTime>, List<Userzy>>> Html { get; private set; }
    }
}
#pragma warning restore 1591