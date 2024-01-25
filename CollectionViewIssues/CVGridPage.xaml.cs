using System.Reactive.Linq;
using Shiny;

namespace CollectionViewIssues;


public partial class CVGridPage : ContentPage
{
	public CVGridPage()
	{
		var vm = new GridViewModel();
        this.BindingContext = vm;

		vm
			.WhenAnyProperty(x => x.Columns)
			.Skip(1)
			.Subscribe(x =>
			{
				cv.ItemsLayout = new GridItemsLayout(x, ItemsLayoutOrientation.Vertical);
			});
        InitializeComponent();
	}
}
