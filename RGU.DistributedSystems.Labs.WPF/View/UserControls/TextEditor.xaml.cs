using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class TextEditor : UserControl
{

    
    public ObservableCollection<int> Items { get; }
    
    public TextEditor()
    {
        InitializeComponent();
        Items = new ObservableCollection<int>();
           
    }
    
    public MemoryStream Data
    {
        get =>
            (MemoryStream)GetValue(DataProperty);
        
        set => 
            SetValue(DataProperty, value);
        
    }
    
    
    public static readonly DependencyProperty DataProperty =
        DependencyProperty.Register(nameof(Data), 
            typeof(MemoryStream),
            typeof(TextEditor),
            new PropertyMetadata(default(MemoryStream), DataPropertyChangedCallback));

        private static void DataPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
            Console.WriteLine("you eblan");
            // Console.WriteLine("Data Property changed");
            //
            // if (d is not TextEditor textEditor)
            // {
            //     return;
            // }
            //
            // var memoryStream = e.NewValue as MemoryStream;
            //
            // if (memoryStream == null)
            // {
            //     Console.WriteLine("New value is not a MemoryStream.");
            //     return;
            // }  
            //
            // memoryStream.Seek(0, SeekOrigin.Begin);
            //
            // var reader = new StreamReader(memoryStream);
            // string content = reader.ReadToEnd();
            // Console.WriteLine(content);  // Для отладки

           
        }
    
    public double FontSizeTextEditor
    {
        get =>
            (double)GetValue(FontSizeTextEditorProperty);
        
        set => 
            SetValue(FontSizeTextEditorProperty, value);
        
    }
    
    
    public static readonly DependencyProperty FontSizeTextEditorProperty =
        DependencyProperty.Register(nameof(FontSizeTextEditor), 
            typeof(double),
            typeof(TextEditor),
            new PropertyMetadata(25.0));
    
    
    public int SelectedIndex
    {
        get =>
            (int)GetValue(SelectedIndexProperty);
        
        set => 
            SetValue(SelectedIndexProperty, value);
        
    }
    
    
    public static readonly DependencyProperty SelectedIndexProperty =
        DependencyProperty.Register(nameof(SelectedIndex), 
            typeof(int),
            typeof(TextEditor),
            new PropertyMetadata(0));
    
    public string TextContent
    {
        get =>
            (string)GetValue(TextContentProperty);
        
        set => 
            SetValue(TextContentProperty, value);
        
    }
    
    
    public static readonly DependencyProperty TextContentProperty =
        DependencyProperty.Register(nameof(TextContent), 
            typeof(string),
            typeof(TextEditor),
            new PropertyMetadata(TextContentPropertyChangedCallback));
    
    
    private static void TextContentPropertyChangedCallback ( DependencyObject dependencyObject,
        DependencyPropertyChangedEventArgs eventArgs)
    {
        if (dependencyObject is not TextEditor textEditor)
        {
            throw new ArgumentException( nameof(dependencyObject));
        }
        
        var itemsStringTextBox = (string)eventArgs.NewValue;
        
        textEditor.Items.Clear();

        var lines = itemsStringTextBox.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        for (int i = 1; i <= lines.Length; i++)
        {
            textEditor.Items.Add(i);
        }
        
    }
    
    
}