namespace CollectionViewIssues;

public partial class MainPage : ContentPage
{
	public int count = 0;


	public MainPage()
	{
		BindingContext = new MainPageVM();
		InitializeComponent();
	}

}


