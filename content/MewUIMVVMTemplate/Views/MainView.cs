using Aprillz.MewUI;
using Aprillz.MewUI.Controls;
using MewUIMVVMTemplate.ViewModels;

namespace MewUIMVVMTemplate.Views;

public class MainView : UserControl
{
    public MainView(MainVM vm) =>
        Content = new StackPanel()
            .Vertical()
            .Padding(8)
            .Spacing(8)
            .Center()
            .Children(
                new Label().Text("Counter MewUI MVVM").FontSize(32).Center(),
                new Label().BindText(vm.Count).Center().FontSize(64),
                new StackPanel()
                    .Horizontal()
                    .Padding(8)
                    .Spacing(8)
                    .Center()
                    .Children(
                        new Button()
                            .FontSize(24)
                            .Padding(8)
                            .Size(64)
                            .OnClick(() => vm.Decrement())
                            .Content(new Label().Text("-").Center().FontSize(24)),
                        new Button()
                            .FontSize(24)
                            .Padding(8)
                            .Size(64)
                            .OnClick(() => vm.Increment())
                            .Content(new Label().Text("+").Center().FontSize(24))
                    )
            );
}
