using CommunityToolkit.Mvvm.ComponentModel;
using CG.Web.MegaApiClient;
using sims4_updater.ViewModel;
using sims4_updater.Helpers;

namespace sims4_updater.Models
{
    public partial class Sims4DLC : ObservableObject
    {
        [ObservableProperty]
        private string _code = string.Empty;

        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _url = string.Empty;

        [ObservableProperty]
        private bool _installed = false;
        [ObservableProperty]
        private bool _toInstall = false;
        private string _downloadFolder = string.Empty;

        public async Task Download(Logger logger, INode targetNode)
        {
            _downloadFolder = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Sims4DLCs");

            if (!System.IO.Directory.Exists(_downloadFolder))
            {
                System.IO.Directory.CreateDirectory(_downloadFolder);
            }

            string downloadFilePath = System.IO.Path.Combine(_downloadFolder, $"{Code}.zip");

            MegaApiClient megaApiClient = new MegaApiClient();

            megaApiClient.LoginAnonymous();

            string outputFilePath = System.IO.Path.Combine(_downloadFolder, $"{Code}.zip");

            if (System.IO.File.Exists(outputFilePath))
            {
                System.IO.File.Delete(outputFilePath);
            }

            if (targetNode == null)
            {
                logger.AddLog("DLC not found in the Mega folder.");
                return;
            }

            IProgress<double> progress = new Progress<double>(p =>
            {
                StaticsVariables.Instance.Progress = p;
            });
            await megaApiClient.DownloadFileAsync(targetNode, outputFilePath, progress);

            //megaApiClient.DownloadFile(fileLink, outputFilePath);

            megaApiClient.Logout();


        }
        public void DownloadBackup()
        {
            _downloadFolder = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Sims4DLCs");

            if (!System.IO.Directory.Exists(_downloadFolder))
            {
                System.IO.Directory.CreateDirectory(_downloadFolder);
            }

            string downloadFilePath = System.IO.Path.Combine(_downloadFolder, $"{Code}.zip");

            MegaApiClient megaApiClient = new MegaApiClient();

            megaApiClient.LoginAnonymous();

            Uri fileLink = new Uri(Url);

            string outputFilePath = System.IO.Path.Combine(_downloadFolder, $"{Code}.zip");

            if (System.IO.File.Exists(outputFilePath))
            {
                System.IO.File.Delete(outputFilePath);
            }

            megaApiClient.DownloadFile(fileLink, outputFilePath);

            megaApiClient.Logout();


        }
        public void Extract(Logger logger)
        {
            string downloadFilePath = System.IO.Path.Combine(_downloadFolder, $"{Code}.zip");

            if (string.IsNullOrEmpty(downloadFilePath) || !System.IO.File.Exists(downloadFilePath))
            {
                logger.AddLog("Download file not found.");
                return;
            }

            string extractFolder = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Sims4DLCs", Code);

            if (!System.IO.Directory.Exists(extractFolder))
            {
                System.IO.Directory.CreateDirectory(extractFolder);
            }

            System.IO.Compression.ZipFile.ExtractToDirectory(downloadFilePath, extractFolder);
        } 
        public void Install(string gamepath, Logger logger) 
        {
            string extrackedFolder = System.IO.Path.Combine(_downloadFolder, Code);
            try
            {
                if (!System.IO.Directory.Exists(extrackedFolder))
                {
                    throw new InvalidOperationException("Extracted folder not found.");
                }
                // Copy extracted files to the game path
                foreach (string file in System.IO.Directory.GetFiles(extrackedFolder, "*", System.IO.SearchOption.AllDirectories))
                {
                    string relativePath = System.IO.Path.GetRelativePath(extrackedFolder, file);
                    string destinationPath = System.IO.Path.Combine(gamepath, Code, relativePath);
                    // Ensure the destination directory exists
                    string? destinationDir = System.IO.Path.GetDirectoryName(destinationPath);
                    if (!string.IsNullOrEmpty(destinationDir) && !System.IO.Directory.Exists(destinationDir))
                    {
                        System.IO.Directory.CreateDirectory(destinationDir);
                    }
                    System.IO.File.Copy(file, destinationPath, true);
                }
            }
            catch
            {
                logger.AddLog("Failed to install DLC. Please clean the DLC folder and try again");
                logger.AddLog("Folder to clean: " + System.IO.Path.Combine(gamepath, Code));
            }
        }

        public void Remove(Logger logger)
        {
            string extrackedFolder = System.IO.Path.Combine(_downloadFolder, Code);
            string downloadedFilePath = System.IO.Path.Combine(_downloadFolder, $"{Code}.zip");
            try
            {
                System.IO.Directory.Delete(extrackedFolder, true);
                System.IO.File.Delete(downloadedFilePath);
            }
            catch
            {
                logger.AddLog("Failed to remove DLC. Please clean the Sims4DLCs folder in the temp directory after installing all dlcs");
            }
        }

    }
}
