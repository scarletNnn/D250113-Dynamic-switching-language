using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using D250113.Resources;
using WPFLocalizeExtension.Engine;

namespace D250113;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ShowMessageButton_Click(object sender, RoutedEventArgs e)
    {
        #region 方法一
        //MessageBox.Show(
        //    Application.Current.TryFindResource("MessageContent").ToString(),
        //    Application.Current.TryFindResource("MessageCaption").ToString(),
        //    MessageBoxButton.OK
        //);
        #endregion

        MessageBox.Show(
            MyClassLibrary.MyLibrary.GetMessage(),
            Lang.MessageCaption,
            MessageBoxButton.OK
        );
    }

    private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
    {
        #region 方法一
        //var culture = ((Button)sender).Tag.ToString();
        //var resourceDictionary = new ResourceDictionary
        //{
        //    Source = new Uri($"I18N/Strings.{culture}.xaml", UriKind.Relative)
        //};
        ////Application.Current.Resources.MergedDictionaries[0] = resourceDictionary;
        //Application.Current.Resources.MergedDictionaries.Add(resourceDictionary); //将新的资源字典添加到应用程序的资源中
        #endregion

        var culture = ((Button)sender).Tag.ToString();
        var cultureInfo = new CultureInfo(culture);
        //Thread.CurrentThread.CurrentCulture = cultureInfo;
        //Thread.CurrentThread.CurrentUICulture = cultureInfo;

        LocalizeDictionary.Instance.Culture = cultureInfo;
    }
}

public enum enum_DiagonaLift : int
{
    None = 0,
    One = 1,
    Two = 2
}
