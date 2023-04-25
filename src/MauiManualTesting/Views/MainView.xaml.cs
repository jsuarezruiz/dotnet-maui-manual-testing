using MauiManualTesting.ViewModels;
using MauiManualTesting.Views.Base;

namespace MauiManualTesting.Views;

public partial class MainView : BasePage
{
	public MainView(MainViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}