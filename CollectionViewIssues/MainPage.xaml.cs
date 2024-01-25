namespace CollectionViewIssues;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		BindingContext = new DynamicSizeViewModel();
		InitializeComponent();
	}

}


