using MauiManualTesting.Models;

namespace MauiManualTesting.ViewModels
{
	public abstract class BaseMauiManualTestingViewModel : BaseViewModel
	{
		string _filterValue;

		public BaseMauiManualTestingViewModel()
		{
			var items = CreateItems();

			if (items != null)
				Items = items.ToList();

			Filter();
		}

		public IReadOnlyList<Test> Items { get; }

		public string FilterValue
		{
			get { return _filterValue; }
			set
			{
				_filterValue = value;
				Filter();
			}
		}

		public IEnumerable<Test> FilteredItems { get; private set; } = Enumerable.Empty<Test>();

		protected abstract IEnumerable<Test> CreateItems();

		void Filter()
		{
			FilterValue ??= string.Empty;
            FilteredItems = string.IsNullOrEmpty(FilterValue) ? Items : Items.Where(item => item.Title.Contains(FilterValue, StringComparison.InvariantCultureIgnoreCase));
			OnPropertyChanged(nameof(FilteredItems));
		}
	}
}