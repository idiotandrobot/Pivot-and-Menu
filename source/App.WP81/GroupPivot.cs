using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App.WP81
{
    public class GroupPivot : Pivot
    {
        public GroupPivot()
        {
            SelectionChanged += GroupPivot_SelectionChanged;
        }

        void GroupPivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var instance = e.AddedItems.FirstOrDefault() as GroupPivotItem;
            if (instance != null)
            {
                CommandGroup = instance.CommandGroup;
            }
        }

        public string CommandGroup
        {
            get { return (string)GetValue(CommandGroupProperty); }
            set { SetValue(CommandGroupProperty, value); }
        }

        public static readonly DependencyProperty CommandGroupProperty =
            DependencyProperty.Register(
                "CommandGroup",
                typeof(string),
                typeof(GroupPivot),
                new PropertyMetadata(
                    false
                )
            );        
    }
}
