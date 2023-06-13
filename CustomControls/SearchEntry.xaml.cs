using System.Windows.Input;

namespace BeautifulPlacesApp.CustomControls;

public partial class SearchEntry : ContentView
{
    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(SearchEntry), string.Empty);

    public string Placeholder
    {
        get => GetValue(PlaceholderProperty).ToString();
        set => SetValue(PlaceholderProperty, value);
    }
    
    public static readonly BindableProperty TextProperty = 
        BindableProperty.Create(nameof(Text), typeof(string), typeof(SearchEntry), string.Empty);

    public string Text
    {
        get => GetValue(TextProperty).ToString();
        set => SetValue(TextProperty, value);
    }

    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(SearchEntry));

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }
        
    public SearchEntry()
    {
        InitializeComponent();
    }
}