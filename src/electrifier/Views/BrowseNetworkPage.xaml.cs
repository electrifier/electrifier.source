using CommunityToolkit.WinUI.UI.Controls;

using electrifier.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace electrifier.Views;

public sealed partial class BrowseNetworkPage : Page
{
    public BrowseNetworkViewModel ViewModel
    {
        get;
    }

    public BrowseNetworkPage()
    {
        ViewModel = App.GetService<BrowseNetworkViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
