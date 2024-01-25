namespace CollectionViewIssues;

public partial class CVGridPage : ContentPage
{
	public CVGridPage()
	{
        this.BindingContext = new GridViewModel();
        InitializeComponent();
	}
}
