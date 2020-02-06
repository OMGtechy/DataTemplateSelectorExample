using System.Windows;
using System.Windows.Controls;

namespace DataTemplateSelectorExample.Views
{
    public class WithoutDependencyObjectDataTemplateSelector : DataTemplateSelector
    {
        // these are assigned in WithoutDependencyObjectView.xaml
        public DataTemplate MyStringDataTemplate { get; set; }
        public DataTemplate MyIntDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var itemType = item.GetType();

            if (itemType == typeof(string))
            {
                return MyStringDataTemplate;
            }

            if (itemType == typeof(int))
            {
                return MyIntDataTemplate;
            }

            // if we don't know how to handle this type, do whatever the default was
            // you could replace this with an error or something if you wanted to
            return base.SelectTemplate(item, container);
        }
    }
}
