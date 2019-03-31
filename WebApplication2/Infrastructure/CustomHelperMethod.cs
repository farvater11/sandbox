using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Infrastructure
{
    //Класс и метод обязательно static и public 
    public static class CustomHelperMethod
    {                                       
        public static MvcHtmlString UnorderedList(this HtmlHelper helper, IEnumerable<WebApplication2.Models.Product> list )
        { //                         ^Любое имя     ^тип данных к которому будем добавть метод
            TagBuilder ulTag = new TagBuilder("ul"); // Класс стоящий указаный тег вокруг string 
            TagBuilder liTag = new TagBuilder("li"); 
            foreach(var item in list)
            {
                liTag.SetInnerText(item.GetName()); // Обернуть текст в html тег
                ulTag.InnerHtml += liTag.ToString(); // Обернуть html код в еще один тег 
            }
            return new MvcHtmlString(ulTag.ToString());
        } 
    }
}