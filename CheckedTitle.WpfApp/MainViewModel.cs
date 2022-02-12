using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CheckedTitle.WpfApp
{
    public class MainViewModel : ReactiveObject
    {
        [Reactive] public bool IsBusy { get; set; }
    }
}
