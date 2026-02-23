using System.Windows;
using System.Windows.Controls;

namespace sims4_updater.Helpers
{
    public static class ScrollToEndBehavior
    {
        public static readonly DependencyProperty AutoScrollToEndProperty =
            DependencyProperty.RegisterAttached(
                "AutoScrollToEnd",
                typeof(bool),
                typeof(ScrollToEndBehavior),
                new PropertyMetadata(false, OnAutoScrollToEndChanged));

        public static bool GetAutoScrollToEnd(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoScrollToEndProperty);
        }

        public static void SetAutoScrollToEnd(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoScrollToEndProperty, value);
        }

        private static void OnAutoScrollToEndChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ScrollViewer scrollViewer && e.NewValue is bool autoScroll)
            {
                if (autoScroll)
                {
                    scrollViewer.ScrollChanged += ScrollViewer_ScrollChanged;
                }
                else
                {
                    scrollViewer.ScrollChanged -= ScrollViewer_ScrollChanged;
                }
            }
        }

        private static void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.ExtentHeightChange > 0)
            {
                var scrollViewer = sender as ScrollViewer;
                scrollViewer?.ScrollToEnd();
            }
        }
    }
}
