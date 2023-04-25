namespace MauiManualTesting;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        // ChatApp
        Routing.RegisterRoute(nameof(ChatApp.Views.DetailView), typeof(ChatApp.Views.DetailView));
        
        // FinanceApp
        Routing.RegisterRoute(nameof(FinanceApp.Views.RecentTransactionsView), typeof(FinanceApp.Views.RecentTransactionsView));

        // MoviesApp
        Routing.RegisterRoute(nameof(MoviesApp.Views.MovieDetailView), typeof(MoviesApp.Views.MovieDetailView));

        // SkateboardApp
        Routing.RegisterRoute(nameof(SkateboardApp.Views.CustomizeView), typeof(SkateboardApp.Views.CustomizeView));
    }
}
