using System.Windows.Input;

namespace CollectionViewIssues;


public class GridViewModel : Shiny.NotifyPropertyChanged
{
	public GridViewModel()
	{
        var rand = new Random();

        for (int i = 0; i < 30; i++)
        {
            this.List.Add(new SettingsModel { Title = $"Title Test {i}", Value = $"Value Test {i}", Height = rand.Next(200, 400) });
        }

        //this.layout = new GridItemsLayout(2, ItemsLayoutOrientation.Vertical);

        Change = new Command<string>(arg =>
        {
            Columns = Int32.Parse(arg);
            //this.layout = new GridItemsLayout(Columns, ItemsLayoutOrientation.Vertical);
        });
    }


    public List<SettingsModel> List { get; } = new();
    public ICommand Change { get; }

    int columns = 2;
    public int Columns
    {
        get => columns;
        set => Set(ref columns, value);
    }


    //GridItemsLayout layout;
    //public GridItemsLayout Layout
    //{
    //    get => layout;
    //    private set
    //    {
    //        layout = value;
    //        this.RaisePropertyChanged();
    //    }
    //}
}

