using CommunityToolkit.WinUI.UI.Controls;

using electrifier.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace electrifier.Views;

public sealed partial class FilesFoldersPage : Page
{
    public FilesFoldersViewModel ViewModel
    {
        get;
    }

    public FilesFoldersPage()
    {
        ViewModel = App.GetService<FilesFoldersViewModel>();
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
