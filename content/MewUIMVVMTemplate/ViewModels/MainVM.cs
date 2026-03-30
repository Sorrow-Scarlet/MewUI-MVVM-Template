using Aprillz.MewUI;
using MewUIMVVMTemplate.Models;

namespace MewUIMVVMTemplate.ViewModels;

public class MainVM
{
    public Counter Counter { get; set; } = new();
    public ObservableValue<int> Count { get; set; } = new(0);

    public void Increment()
    {
        Count.Value = ++Counter.Count;
    }

    public void Decrement()
    {
        Count.Value = --Counter.Count;
    }
}
