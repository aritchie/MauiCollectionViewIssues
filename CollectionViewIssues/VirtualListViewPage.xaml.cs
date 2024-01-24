namespace CollectionViewIssues;

public partial class VirtualListViewPage : ContentPage
{
	public VirtualListViewPage()
	{
		InitializeComponent();
		this.BindingContext = new VirtualListViewModel();
	}
}
