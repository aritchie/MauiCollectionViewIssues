namespace CollectionViewIssues;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        //MainPage = new SharpnadoGridPage();
        MainPage = new CVGridPage();
    }
}

