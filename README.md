# hide-checkbox-treeview-xamarin
How to conditionally hide the checkbox in Xamarin.Forms TreeView (SfTreeView)

## Sample

### XAML
Bind the SfCheckBox.IsVisible property with TreeViewNode.Level and define converter to handle the Visibility.
```xaml
<treeView:SfTreeView x:Name="treeView"
                    ItemTemplateContextType="Node"
                    CheckBoxMode="Recursive" 
                    AutoExpandMode="RootNodesExpanded"
                    CheckedItems="{Binding CheckedItems}"
                    ItemsSource="{Binding Folders}">
    <treeView:SfTreeView.HierarchyPropertyDescriptors>
        <treeViewEngine:HierarchyPropertyDescriptor TargetType="{x:Type local:Folder}" ChildPropertyName="SubFolder"/>
        <treeViewEngine:HierarchyPropertyDescriptor TargetType="{x:Type local:SubFolder}" ChildPropertyName="Files"/>
        <treeViewEngine:HierarchyPropertyDescriptor TargetType="{x:Type local:File}" ChildPropertyName="SubFiles"/>
    </treeView:SfTreeView.HierarchyPropertyDescriptors>
 
    <treeView:SfTreeView.ItemTemplate>
        <DataTemplate>
            <Grid Padding="5">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="40"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                <checkBox:SfCheckBox x:Name="CheckBox" IsChecked="{Binding IsChecked, Mode=TwoWay}" CornerRadius="2" IsVisible="{Binding Level, Converter={StaticResource checkBoxVisibilityConverter}}"/>
                <Label Text="{Binding Content.FileName}" VerticalOptions="CenterAndExpand" HorizontalOptions="StartAndExpand" Grid.Column="1"/>
            </Grid>
        </DataTemplate>
    </treeView:SfTreeView.ItemTemplate>
</treeView:SfTreeView>
```

### Converter
```csharp
public class CheckBoxVisibilityConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (int)value == 0 ? false : true;
    }
}
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements)

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
