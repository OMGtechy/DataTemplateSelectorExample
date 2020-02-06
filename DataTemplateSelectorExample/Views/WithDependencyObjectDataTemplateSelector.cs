using System.Windows;
using System.Windows.Controls;

namespace DataTemplateSelectorExample.Views
{
    public class WithDependencyObjectDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var itemType = item.GetType();

            if (itemType == typeof(string))
            {
                // this string "MyStringDataTemplate" comes from WithDependencyObjectView.xaml,
                // if you choose to do things this way I would recommend putting it into a constant somewhere (DRY)
                return (container as FrameworkElement).FindResource("MyStringDataTemplate") as DataTemplate;
            }

            if (itemType == typeof(int))
            {
                // this string "MyStringDataTemplate" comes from WithDependencyObjectView.xaml,
                // if you choose to do things this way I would recommend putting it into a constant somewhere (DRY)
                return (container as FrameworkElement).FindResource("MyIntDataTemplate") as DataTemplate;
            }

            // if we don't know how to handle this type, do whatever the default was
            // you could replace this with an error or something if you wanted to
            return base.SelectTemplate(item, container);
        }
    }
}
