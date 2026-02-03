using MauiCollectionViewEstudo.ViewModels;

namespace MauiCollectionViewEstudo.Views;

public partial class ProdutoView : ContentPage
{
    public ProdutoView()
    {
        InitializeComponent();
        BindingContext = new ProdutoViewModel();
    }
}