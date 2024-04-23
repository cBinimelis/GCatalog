using GCatalog.Models;
using HtmlAgilityPack;
using CommunityToolkit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using DynamicData;

namespace GCatalog.ViewModels;

public partial class CategoryViewModel: ObservableObject
{
    [ObservableProperty]
    List<Category>? _categoryCollection = new();

    public CategoryViewModel(){
       LoadCategory();
    }

    void LoadCategory(){
        CategoryCollection.Add(new Category {Name = "HG", Url ="http://www.dalong.net/reviews/hg/hg_cata_e.htm"});
        CategoryCollection.Add(new Category {Name = "MG", Url ="http://www.dalong.net/reviews/mg/mg_cata1_e.htm"});
        CategoryCollection.Add(new Category {Name = "MG2", Url ="http://www.dalong.net/reviews/mg/mg_cata2_e.htm"});
        CategoryCollection.Add(new Category {Name = "RG", Url ="http://www.dalong.net/reviews/rg/rg_cata_e.htm"});
        CategoryCollection.Add(new Category {Name = "PG", Url ="http://www.dalong.net/reviews/pg/pg_cata_e.htm"});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        CategoryCollection.Add(new Category {Name = "MG", Url =""});
        
    }
    /*
    private void LoadCategory()
    {
        var web = new HtmlWeb();
        var categoryDocument = web.Load("http://www.dalong.net/reviews/top2.htm");
        var categoryList = new List<Category>();
        var cats = categoryDocument.DocumentNode.SelectNodes("//a");
        
        foreach (var c in cats)
        {
            if (c.InnerText.Trim() != "" && c.Attributes["href"].Value.Trim() != ""
                && c.InnerText.Trim() != null && c.Attributes["href"].Value.Trim() != null)
            {
                this.CategoryCollection.Add(
                    new Category
                    {
                        Name = c.InnerText,
                        Url = c.Attributes["href"].Value
                    });
            }
        }
    }
    */
}