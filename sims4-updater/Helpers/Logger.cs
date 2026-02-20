using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace sims4_updater.Helpers
{
    public partial class Logger : ObservableObject
    {
        [ObservableProperty]
        private string _logs = string.Empty;

        public void AddLog(string log)
        {
            Logs += $"{log}{Environment.NewLine}";
        }
    }
}
