using MauiManualTesting.Models;

namespace MauiManualTesting.ViewModels
{
    public class MainViewModel : BaseMauiManualTestingViewModel
    {
        protected override IEnumerable<Test> CreateItems() => new[]
        {
            new Test(typeof(ChatApp.Views.HomeView), "ChatApp", "Chat App UI Challenge"),
            new Test(typeof(CouponsApp.Views.CouponsView), "CouponsApp", "Coupons App UI Challenge"),
            new Test(typeof(FinanceApp.Views.OverviewView), "FinanceApp", "Finance App UI Challenge"),
            new Test(typeof(MyTasks.Views.MyTasksView), "MyTasks", "Tasks App UI Challenge"),
            new Test(typeof(MoonNFTApp.Views.MainView), "Moon NFT App", "NFT App UI Challenge"),
            new Test(typeof(MoviesApp.Views.MoviesView), "MoviesApp", "Movies App UI Challenge"),
            new Test(typeof(SkateboardApp.Views.CheckoutView), "SkateboardApp", "Skateboard App UI Challenge"),
            new Test(typeof(SurfingApp.Views.HomeView), "SurfingApp", "Surfing App UI Challenge."),
        };
    }
}