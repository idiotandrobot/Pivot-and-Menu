using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App.WP81
{
    public class GroupPivotItem : PivotItem
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
    }
}
