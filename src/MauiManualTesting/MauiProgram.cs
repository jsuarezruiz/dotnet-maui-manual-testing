using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MauiManualTesting;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                // ChatApp
                fonts.AddFont("Metropolis-Black.otf", "Metropolis Black");
                fonts.AddFont("Metropolis-Light.otf", "Metropolis Light");
                fonts.AddFont("Metropolis-Medium.otf", "Metropolis Medium");
                fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
                fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
                fonts.AddFont("MaterialIcons-Regular.ttf", "Material Icons");

                // CouponsApp & MyTasks
                fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
                fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");

                // MoonNFT
                fonts.AddFont("Teko-Bold.ttf", "TekoBold");
                fonts.AddFont("Teko-Light.ttf", "TekoLight");
                fonts.AddFont("Teko-Medium.ttf", "TekoMedium");
                fonts.AddFont("Teko-Regular.ttf", "TekoRegular");
                fonts.AddFont("Teko-SemiBold.ttf", "TekoSemiBold");

                // FinanceApp
                fonts.AddFont("cocogoose.otf", "Cocogoose");

                // SkateboardApp
                fonts.AddFont("Mesa-Grande.ttf", "MesaGrande");
            })
            .UseMauiCompatibility(); // Required for FinanceApp

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // App
        builder.Services.AddSingleton<ViewModels.MainViewModel>();
        builder.Services.AddSingleton<Views.MainView>();

        // ChatApp
        builder.Services.AddSingleton<ChatApp.Services.MessageService>();
        builder.Services.AddSingleton<ChatApp.ViewModels.HomeViewModel>();
        builder.Services.AddSingleton<ChatApp.Views.HomeView>();
        builder.Services.AddTransient<ChatApp.ViewModels.DetailViewModel>();
        builder.Services.AddTransient<ChatApp.Views.DetailView>();

        // FinanceApp
        builder.Services.AddSingleton<FinanceApp.Services.FinanceService>();
        builder.Services.AddSingleton<FinanceApp.ViewModels.OverviewViewModel>();
        builder.Services.AddSingleton<FinanceApp.Views.OverviewView>();
        builder.Services.AddTransient<FinanceApp.ViewModels.RecentTransactionsViewModel>();
        builder.Services.AddTransient<FinanceApp.Views.RecentTransactionsView>();

        // MoonNFT
        builder.Services.AddSingleton<MoonNFTApp.Services.NFTService>();
        builder.Services.AddSingleton<MoonNFTApp.ViewModels.MainViewModel>();
        builder.Services.AddSingleton<MoonNFTApp.Views.MainView>();

        // MoviesApp
        builder.Services.AddSingleton<MoviesApp.Services.MoviesService>();
        builder.Services.AddSingleton<MoviesApp.ViewModels.MoviesViewModel>();
        builder.Services.AddSingleton<MoviesApp.Views.MoviesView>();
        builder.Services.AddTransient<MoviesApp.ViewModels.MovieDetailViewModel>();
        builder.Services.AddTransient<MoviesApp.Views.MovieDetailView>();

        // SkateboardApp
        builder.Services.AddSingleton<SkateboardApp.Services.BasketService>();
        builder.Services.AddSingleton<SkateboardApp.ViewModels.CheckoutViewModel>();
        builder.Services.AddSingleton<SkateboardApp.Views.CheckoutView>();
        builder.Services.AddTransient<SkateboardApp.ViewModels.CustomizeViewModel>();
        builder.Services.AddTransient<SkateboardApp.Views.CustomizeView>();

        // SurfingApp
        builder.Services.AddSingleton<SurfingApp.Services.UserService>();
        builder.Services.AddSingleton<SurfingApp.Services.PostService>();
        builder.Services.AddSingleton<SurfingApp.ViewModels.HomeViewModel>();
        builder.Services.AddSingleton<SurfingApp.Views.HomeView>();
        builder.Services.AddTransient<SurfingApp.ViewModels.PostViewModel>();
        builder.Services.AddTransient<SurfingApp.Views.PostView>();

        return builder.Build();
	}
}
