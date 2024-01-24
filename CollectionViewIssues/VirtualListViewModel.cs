using System;
using Microsoft.Maui.Adapters;

namespace CollectionViewIssues;


public class VirtualListViewModel
{
    public VirtualListViewModel()
    {
        var rand = new Random();
        var list = new List<SettingsModel>();

        for (int i = 0; i < 30; i++)
        {
            list.Add(new SettingsModel { Title = $"Title Test {i}", Value = $"Value Test {i}", Height = rand.Next(200, 400) });
        }
        this.Adapter = new VirtualListViewAdapter<SettingsModel>(list);
    }


    public VirtualListViewAdapter<SettingsModel> Adapter { get; }
}

