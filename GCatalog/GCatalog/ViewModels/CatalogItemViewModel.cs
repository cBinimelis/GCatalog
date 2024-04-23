using GCatalog.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCatalog.ViewModels
{
    public partial class CatalogItemViewModel : ObservableObject
    {

        [ObservableProperty]
        List<CatalogItem>? _catalogItems = new();

        private async void LoadCatalog(string catUrl = "http://www.dalong.net/reviews/mg/mg_cata1_e.htm")
        {
            var web = new HtmlWeb();
            var gunplaDocument = web.Load(catUrl);

            var categoryList = new List<Category>();
            //var gunplaList = new List<Gunpla>();

            var gunplas = gunplaDocument.DocumentNode.SelectNodes("//tr/td/p/a");

            foreach (var g in gunplas)
            {
                if (g.InnerText.Trim() != "" && g.Attributes["href"].Value.Trim() != ""
                    && g.InnerText.Trim() != null && g.Attributes["href"].Value.Trim() != null)
                {
                    CatalogItems.Add(
                        new CatalogItem
                        {
                            Name = g.InnerText,
                            Image = g.Attributes["src"].Value,
                            Url = g.Attributes["href"].Value
                        });
                }
            }
        }
    }
}
