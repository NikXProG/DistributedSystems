using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using RGU.DistributedSystems.Labs.WPF.MVVM.Converter;


namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;
using RGU.DistributedSystems.Labs.WPF.Models;
public partial class DynamicTable : UserControl
{
    
    public DynamicTable()
    {
        InitializeComponent();

    }
    
    
    #region Dependency properties
  
    public static readonly DependencyProperty ColumnWidthProperty = DependencyProperty.Register(
        nameof(ColumnWidth),
        typeof(double),
        typeof(DynamicTable),
        new PropertyMetadata(130.0)
    
    );
    
    public double ColumnWidth
    {
        get => (double)GetValue(ColumnWidthProperty);
        set => SetValue(ColumnWidthProperty, value);
    }
    
    public static readonly DependencyProperty AddRowCommandProperty = DependencyProperty.Register(
        nameof(AddRowCommand),
        typeof(ICommand),
        typeof(DynamicTable)
    
    );
    
    public ICommand AddRowCommand
    {
        get => (ICommand)GetValue(AddRowCommandProperty);
        set => SetValue(AddRowCommandProperty, value);
    }
    
    
    public static readonly DependencyProperty AddColumnCommandProperty = DependencyProperty.Register(
        nameof(AddColumnCommand),
        typeof(ICommand),
        typeof(DynamicTable)
    
    );
    
    public ICommand AddColumnCommand
    {
        get => (ICommand)GetValue(AddColumnCommandProperty);
        set => SetValue(AddColumnCommandProperty, value);
    }

    public static readonly DependencyProperty ColumnCountProperty = DependencyProperty.Register(
        nameof(ColumnCount),
        typeof(int),
        typeof(DynamicTable)
    
    );
    
    public Thickness DataGridMargin
    {
        get => (Thickness)GetValue(DataGridMarginProperty);
        set => SetValue(DataGridMarginProperty, value);
    }

    
    public static readonly DependencyProperty DataGridMarginProperty = DependencyProperty.Register(
        nameof(DataGridMargin), 
        typeof(Thickness),
        typeof(DynamicTable),
        new PropertyMetadata(new Thickness(20.0))
    );

    public int ColumnCount
    {
        get => (int)GetValue(ColumnCountProperty);
        set => SetValue(ColumnCountProperty, value);
    }

    
    public static readonly DependencyProperty RowCountProperty = DependencyProperty.Register(
        nameof(RowCount), 
        typeof(int),
        typeof(DynamicTable)
    );
  
    public int RowCount
    {
        get => (int)GetValue(ColumnCountProperty);
        set => SetValue(ColumnCountProperty, value);
    }
 
    public static readonly DependencyProperty MatrixSourceProperty =
        DependencyProperty.Register(nameof(MatrixSource), 
            typeof(DataMatrixModel.DataMatrix), 
            typeof(DynamicTable), 
            new PropertyMetadata(OnMatrixSourceChangedCallback));
    
    public DataMatrixModel.DataMatrix MatrixSource
    {
        get => (DataMatrixModel.DataMatrix)GetValue(MatrixSourceProperty);
        set => SetValue(MatrixSourceProperty, value);
    }
    
    
    
    private static void OnMatrixSourceChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        DynamicTable control = d as DynamicTable;
    
        if (control.MainDataGrid == null)
        {
            return;
        }
    
        DataMatrixModel.DataMatrix dataMatrix = e.NewValue as DataMatrixModel.DataMatrix;
    
        // Установка источника данных для DataGrid
        control.MainDataGrid.ItemsSource = dataMatrix.Rows;
    
        // Очистка существующих колонок DataGrid
        control.MainDataGrid.Columns.Clear();
    
        int count = 0;
    
        // Создание колонок DataGrid на основе структуры DataMatrix
        foreach (var col in dataMatrix.Columns)
        {
            // Создание колонки с пользовательским шаблоном
            var dataGridTemplateColumn = new DataGridTemplateColumn
            {
                Header = col,
                SortMemberPath = $"[{count}]"
            };
    
            // Создание шаблона для ячеек
            var dataTemplate = new DataTemplate();
    
            // Создание фабрики для элементов в шаблоне
            var gridFactory = new FrameworkElementFactory(typeof(Grid));
            var textBoxFactory = new FrameworkElementFactory(typeof(TextBox));
    
            // Привязка текста в TextBox к элементу данных по индексу
            var newBinding = new Binding($"[{count}]" ){ Mode = BindingMode.TwoWay };
            textBoxFactory.SetBinding(TextBox.TextProperty, newBinding);
            
            // Настройка визуальных свойств TextBox
            textBoxFactory.SetValue(TextBoxBase.AcceptsReturnProperty, true);
            textBoxFactory.SetValue(ForegroundProperty, new SolidColorBrush(Colors.Black));
            textBoxFactory.SetValue(TextBox.TextWrappingProperty, TextWrapping.Wrap);
            textBoxFactory.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
            textBoxFactory.SetValue(VerticalAlignmentProperty, VerticalAlignment.Stretch);
            textBoxFactory.SetValue(BorderThicknessProperty, new Thickness(0));
            
            gridFactory.AppendChild(textBoxFactory);
    
            // Установка шаблона для ячеек в колонке
            dataTemplate.VisualTree = gridFactory;
            dataGridTemplateColumn.CellTemplate = dataTemplate;
    
            // Добавление колонки в DataGrid
            control.MainDataGrid.Columns.Add(dataGridTemplateColumn);
    
            count++;
        }
    }

 
    
    #endregion


}
