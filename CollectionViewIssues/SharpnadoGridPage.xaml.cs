namespace CollectionViewIssues;

public partial class SharpnadoGridPage : ContentPage
{
	public SharpnadoGridPage()
	{
        this.BindingContext = new GridViewModel();
        InitializeComponent();
	}
}
