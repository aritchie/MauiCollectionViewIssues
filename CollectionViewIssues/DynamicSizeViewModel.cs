using Microsoft.Maui.Adapters;

namespace CollectionViewIssues;

public class DynamicSizeViewModel
{
    

    public DynamicSizeViewModel()
	{
        Random rand = new Random();
        for (int i = 0; i < 30; i++)
        {
            SettingsList.Add(new SettingsModel { Title = $"Title Test {i}", Value = $"Value Test {i}", Height = rand.Next(200,400) });
        }
    }


    public List<SettingsModel> SettingsList { get; } = new();

    VirtualListViewAdapter<SettingsModel>? adapter;
    public VirtualListViewAdapter<SettingsModel> Adapter => adapter ??= new VirtualListViewAdapter<SettingsModel>(this.SettingsList);
}

