using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App.WP81
{
    public class GroupAppBarButton : AppBarButton
    {
        public string CommandGroup
        {
            get { return (string)GetValue(CommandGroupProperty); }
            set { SetValue(CommandGroupProperty, value); }
        }

        public static readonly DependencyProperty CommandGroupProperty =
            DependencyProperty.Register(
                "CommandGroup",
                typeof(string),
                typeof(GroupAppBarButton),
                new PropertyMetadata(
                    false
                )
            );

        public string ActiveCommandGroup
        {
            get { return (string)GetValue(ActiveCommandGroupProperty); }
            set { SetValue(ActiveCommandGroupProperty, value); }
        }

        public static readonly DependencyProperty ActiveCommandGroupProperty =
            DependencyProperty.Register(
                "ActiveCommandGroup",
                typeof(string),
                typeof(GroupAppBarButton),
                new PropertyMetadata(
                    false,
                    new PropertyChangedCallback(OnActiveCommandGroupChanged)
                )
            );

        private static void OnActiveCommandGroupChanged(
        DependencyObject d,
        DependencyPropertyChangedEventArgs e)
        {
            var instance = d as GroupAppBarButton;
            if (instance != null)
            {
                instance.Visibility = instance.CommandGroup == instance.ActiveCommandGroup
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
        }


    }
}
