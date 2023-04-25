using MauiManualTesting.Models;
using System.Windows.Input;

namespace MauiManualTesting.Views.Base
{
    public class BasePage : ContentPage
    {
        Test _selectedItem;

        public BasePage()
        {
            NavigateCommand = new Command(async () =>
            {
                if (SelectedItem != null)
                {
                    if (Application.Current.MainPage is FlyoutPage fp)
                        await fp.Detail.Navigation.PushAsync(PreparePage(SelectedItem));
                    else
                        await Navigation.PushAsync(PreparePage(SelectedItem));

                    SelectedItem = null;
                }
            });
        }

        public ICommand NavigateCommand { get; }

        public Test SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        Page PreparePage(Test model)
        {
            var page = (Handler?.MauiContext?.Services?.GetService(model.Type) as Page) ?? (Page)Activator.CreateInstance(model.Type);
            page.Title = model.Title;

            if (model.ViewModel != null)
            {
                page.BindingContext = model.ViewModel;
            }

            return page;
        }
    }
}