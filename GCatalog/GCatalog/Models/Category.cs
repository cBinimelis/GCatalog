using HtmlAgilityPack;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GCatalog.Models;

public class Category{
    public string? Name { get; set; }
    public string? Url { get; set; }


    public ObservableCollection<Category> LoadCategory()
    {
        var web = new HtmlWeb();
        var categoryDocument = web.Load("http://www.dalong.net/reviews/top2.htm");
        //var gunplaDocument = web.Load("http://www.dalong.net/reviews/rg/rg_cata_e.htm");

        var categoryList = new List<Category>();
        //var gunplaList = new List<Gunpla>();

        var cats = categoryDocument.DocumentNode.SelectNodes("//a");
        //var gunplas = gunplaDocument.DocumentNode.SelectNodes("//tr/td/p/a");

        foreach (var c in cats)
        {
            if (c.InnerText.Trim() != "" && c.Attributes["href"].Value.Trim() != ""
                && c.InnerText.Trim() != null && c.Attributes["href"].Value.Trim() != null)
            {
                categoryList.Add(
                    new Category
                    {
                        Name = c.InnerText,
                        Url = c.Attributes["href"].Value
                    });
            }
        }

        return new ObservableCollection<Category>(categoryList);
        /*
        foreach (var g in gunplas)
        {
            if (g.Element("img").Attributes["src"].Value != null)
            {
                gunplaList.Add(
                    new Gunpla
                    {
                        Name = g.ParentNode.InnerText.Trim(),
                        Image = "http://www.dalong.net/reviews/rg/" + g.Element("img").Attributes["src"].Value.Trim(),
                        Url = "http://www.dalong.net/reviews/rg/" + g.Attributes["href"].Value.Trim()
                    });
            }
        }
        */
    }
}