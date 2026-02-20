using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using sims4_updater.Helpers;
using sims4_updater.Models;

namespace sims4_updater.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private Sims4Model _sims4Model;

        [ObservableProperty]
        private static Logger _logger = new Logger();

        [ObservableProperty]
        private bool _isDlcListVisible = false;


        public MainViewModel()
        {
            _sims4Model = new Sims4Model(_logger);
        }

        [RelayCommand]
        private void Browse()
        {
            var dialog = new OpenFolderDialog
            {
                Title = "Select Sims 4 folder"
            };

            if (dialog.ShowDialog() == true)
            {
                Sims4Model.GamePath = dialog.FolderName;
            }
        }

        [RelayCommand]
        private void Scan()
        {
            Sims4Model.ScanDirectoryForDLCS(Sims4Model.GamePath);
            IsDlcListVisible = true;            
        }

        [RelayCommand]
        private async Task InstallAsync()
        {
            await Sims4Model.AllDlcs.DownloadAndInstallSelectedDlcsAsync(Logger, Sims4Model.GamePath);
        }

    }
}
