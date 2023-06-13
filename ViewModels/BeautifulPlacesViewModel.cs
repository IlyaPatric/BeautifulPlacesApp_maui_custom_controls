using System.Windows.Input;
using BeautifulPlacesApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BeautifulPlacesApp.ViewModels;

public partial class BeautifulPlacesViewModel : ObservableObject
{
    [ObservableProperty]
    private List<BeautifulPlaces> beautifulPlacesList;

    [ObservableProperty]
    private List<SomethingDifferent> somethingDifferents;

    public string MyText
    {
        get;
        set;
    } = "";
    
    public ICommand DeleteCharacters { get; }
    
    public BeautifulPlacesViewModel() 
    {
        LoadBPlaces();
        LoadSDifferent();
        DeleteCharacters = new Command(DeleteCharactersCommand);
    }

    void LoadBPlaces()
    {
        BeautifulPlacesList = new()
        {
            new BeautifulPlaces(
                "Koselig Nytte Lke Ved elv",
                "$250 / night",
                "5.0",
                "(29)",
                "green_mountains.png"),
            new BeautifulPlaces(
                "Entire Cobin",
                "$267 / night",
                "4.9",
                "(67)",
                "ocean.png"),
            new BeautifulPlaces(
                "Mountains View Apartment",
                "$250 / night",
                "5.0",
                "(47)",
                "mountains.png")
        };
    }

    void LoadSDifferent()
    {
        SomethingDifferents = new()
        {
            new SomethingDifferent(
                "baloon.jpg",
                "Air baloon"
            ),
            new SomethingDifferent(
                "car_driving.jpg",
                "Car driving"),
            new SomethingDifferent(
                "surfing.jpg",
                "Surfing"),
            new SomethingDifferent(
                "paraglider.jpg",
                "Paraglider")
        };
    }

    void DeleteCharactersCommand()
    {
        MyText = "";
    }
}