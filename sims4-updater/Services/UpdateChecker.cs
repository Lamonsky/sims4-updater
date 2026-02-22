using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;

namespace sims4_updater.Services
{
    public class UpdateChecker
    {
        private const string GitHubApiUrl = "https://api.github.com/repos/Lamonsky/sims4-updater/releases/latest";
        private const string GitHubReleasesUrl = "https://github.com/Lamonsky/sims4-updater/releases/latest";
        private readonly HttpClient _httpClient;

        public UpdateChecker()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Sims4-Updater");
        }

        public string GetCurrentVersion()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var version = assembly.GetName().Version;
            return version != null ? $"{version.Major}.{version.Minor}.{version.Build}" : "1.0.0";
        }

        public async Task<(bool HasUpdate, string? LatestVersion, string? DownloadUrl)> CheckForUpdatesAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(GitHubApiUrl);
                var json = JObject.Parse(response);

                var tagName = json["tag_name"]?.ToString();
                if (string.IsNullOrEmpty(tagName))
                    return (false, null, null);

                var latestVersion = tagName.TrimStart('v');
                var currentVersion = GetCurrentVersion();

                var latest = Version.Parse(latestVersion);
                var current = Version.Parse(currentVersion);

                bool hasUpdate = latest > current;

                var downloadUrl = json["html_url"]?.ToString() ?? GitHubReleasesUrl;

                return (hasUpdate, latestVersion, downloadUrl);
            }
            catch (Exception)
            {
                return (false, null, null);
            }
        }

        public void OpenReleaseUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch
            {
            }
        }
    }
}
