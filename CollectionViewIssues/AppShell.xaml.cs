namespace CollectionViewIssues;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(VirtualListViewPage), typeof(VirtualListViewPage));
        Routing.RegisterRoute(nameof(CVGridPage), typeof(CVGridPage));
        Routing.RegisterRoute(nameof(SharpnadoGridPage), typeof(SharpnadoGridPage));
    }
}

