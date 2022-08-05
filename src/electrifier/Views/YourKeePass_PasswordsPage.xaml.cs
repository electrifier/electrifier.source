using CommunityToolkit.WinUI.UI.Controls;

using electrifier.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace electrifier.Views;

public sealed partial class YourKeePass_PasswordsPage : Page
{
    public YourKeePass_PasswordsViewModel ViewModel
    {
        get;
    }

    public YourKeePass_PasswordsPage()
    {
        ViewModel = App.GetService<YourKeePass_PasswordsViewModel>();
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
