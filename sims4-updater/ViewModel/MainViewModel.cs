using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using sims4_updater.Helpers;
using sims4_updater.Models;
using sims4_updater.Services;
using System.Windows;

namespace sims4_updater.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private Sims4Model _sims4Model;

        private static Logger _logger = new Logger();
        public static Logger Logger => _logger;

        [ObservableProperty]
        private bool _isDlcListVisible = false;

        [ObservableProperty]
        private string _currentVersion = string.Empty;

        [ObservableProperty]
        private bool _isUpdateAvailable = false;

        [ObservableProperty]
        private string _latestVersion = string.Empty;

        private readonly UpdateChecker _updateChecker;
        private string? _updateDownloadUrl;


        public MainViewModel()
        {
            _sims4Model = new Sims4Model(_logger);
            _updateChecker = new UpdateChecker();
            CurrentVersion = _updateChecker.GetCurrentVersion();

            _ = CheckForUpdatesAsync();
        }

        private async Task CheckForUpdatesAsync()
        {
            try
            {
                var (hasUpdate, latestVersion, downloadUrl) = await _updateChecker.CheckForUpdatesAsync();

                if (hasUpdate && latestVersion != null)
                {
                    IsUpdateAvailable = true;
                    LatestVersion = latestVersion;
                    _updateDownloadUrl = downloadUrl;
                    Logger.AddLog($"New Version available: {latestVersion}");
                }
                else
                {
                    Logger.AddLog($"You are using the latest version: {CurrentVersion}");
                }
            }
            catch (Exception ex)
            {
                Logger.AddLog($"Unable to check for updates: {ex.Message}");
            }
        }

        [RelayCommand]
        private void DownloadUpdate()
        {
            if (!string.IsNullOrEmpty(_updateDownloadUrl))
            {
                _updateChecker.OpenReleaseUrl(_updateDownloadUrl);
            }
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
            if(string.IsNullOrEmpty(Sims4Model.GamePath))
            {
                Logger.AddLog("ERROR: Please select the Sims 4 game folder first.");
                return;
            }
            Sims4Model.ScanDirectoryForDLCS(Sims4Model.GamePath);
            IsDlcListVisible = true;            
        }

        [RelayCommand]
        private async Task InstallDLCAsync()
        {
            await Sims4Model.AllDlcs.DownloadAndInstallSelectedDlcsAsync(Logger, Sims4Model.GamePath);
        }

        [RelayCommand]
        private async Task InstallDLCUnlockerAsync()
        {
            await Sims4DLCUnlocker.InstallUnlocker(Logger);
        }

        [RelayCommand]
        private void SelectAll()
        {
            foreach (var dlc in Sims4Model.AllDlcs.Sims4DLCs)
            {
                dlc.ToInstall = true;
            }
        }

    }
}
