using CommunityToolkit.Mvvm.ComponentModel;
using MvvmHelpers;
using ObservableObject = CommunityToolkit.Mvvm.ComponentModel.ObservableObject;

namespace Game2048Maui.Models
{
    public partial class NumberTile : ObservableObject
    {
        public int Index { get; set; }

        [ObservableProperty]
        private bool isNewMatchGenerated;

        [ObservableProperty]
        private bool isNewNumberGenerated;

        [ObservableProperty]
        private bool isNumberMultiplied;

        [ObservableProperty]
        private string number;
    }
}