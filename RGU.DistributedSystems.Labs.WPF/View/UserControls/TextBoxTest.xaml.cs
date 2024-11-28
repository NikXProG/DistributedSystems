using System.Windows;
using System.Windows.Controls;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class TextBoxTest : UserControl
{
    public TextBoxTest()
    {
        InitializeComponent();
    }
    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public double Column
    {
        get => (double)GetValue(ColumnProperty);
        set => SetValue(ColumnProperty, value);
    }
    public TextWrapping TextWrapping
    {
        get => (TextWrapping)GetValue(TextWrappingProperty);
        set => SetValue(TextWrappingProperty, value);
    }

    
    public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(TextBoxTest));
    
    public static readonly DependencyProperty ColumnProperty = DependencyProperty.Register(nameof(Column), typeof(double), typeof(TextBoxTest));

    
    public static readonly DependencyProperty TextWrappingProperty = DependencyProperty.Register(nameof(TextWrapping), typeof(TextWrapping), typeof(TextBoxTest));

}