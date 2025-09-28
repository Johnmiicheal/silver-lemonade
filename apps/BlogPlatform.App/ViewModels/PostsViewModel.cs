using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BlogPlatform.App.ViewModels;

public partial class PostsViewModel : BaseViewModel
{
    public ObservableCollection<PostViewModel> Posts { get; } = new();

    public PostsViewModel()
    {
        Title = "Posts";
        // TODO: Load posts from API
    }
}

public partial class PostViewModel : ObservableObject
{
    [ObservableProperty]
    int id;

    [ObservableProperty]
    string title = string.Empty;

    [ObservableProperty]
    string summary = string.Empty;

    [ObservableProperty]
    string content = string.Empty;

    [ObservableProperty]
    DateTime createdAt;

    [ObservableProperty]
    string authorName = string.Empty;
}
