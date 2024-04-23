using Avalonia.Controls;
using GCatalog.Models;
using GCatalog.ViewModels;

namespace GCatalog.Views;

public partial class CategoryView : UserControl
{
    public CategoryView()
    {
        InitializeComponent();
        CategoryViewModel viewModel = new CategoryViewModel();
        DataContext = viewModel;
    }
}