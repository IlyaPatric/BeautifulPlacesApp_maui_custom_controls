using BeautifulPlacesApp.ViewModels;

namespace BeautifulPlacesApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new BeautifulPlacesViewModel();
	}	
}

