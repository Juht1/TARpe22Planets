using Planeedid.Services;

namespace Planeedid.Views;

public partial class PlanetsPage : ContentPage
{
    public PlanetsPage()
    {
        InitializeComponent();

        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        lstAllPlanets = PlanetsService.GetAllPlanet();
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    private void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }

    async void Planets_SelectionChanged(object sender, SelectedItemChangedEventArgs e)
    { 

    }
}