using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;
using DryIoc;
using DryIoc.ImTools;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;

namespace RGU.DistributedSystems.Labs.WPF.View.UserControls;

public partial class CompilerCommandMenu : UserControl
{
    public class CompilerCommandViewModel: ViewModelBase
    {
        
        #region Fields
        /// <summary>
        /// 
        /// </summary>
        private int _operand1;
        /// <summary>
        /// 
        /// </summary>
        private int _operand2;
        /// <summary>
        /// 
        /// </summary>
        private int _operand3;
        /// <summary>
        /// 
        /// </summary>
        private int _operation;
        
        #endregion
        
        #region Constructors
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <param name="operand3"></param>
        /// <param name="operation"></param>
        public CompilerCommandViewModel(
            int operand1,
            int operand2,
            int operand3,
            int operation)
        {
            this._operand1 = operand1;
            this._operand2 = operand2;
            this._operand3 = operand3;
            this._operation = operation;
        }
        
        #endregion
        
        #region Properties
        
        public int Operand1 {
            get =>
                _operand1;
            
            set
            {
                _operand1 = value;
                RaisePropertiesChanged(nameof(Operand1));
            }
            
        }
        public int Operand2 {
            get =>
                _operand2;
            
            set
            {
                _operand2 = value;
                RaisePropertiesChanged(nameof(Operand2));
            }
            
        }
        public int Operand3 {
            get =>
                _operand3;
            
            set
            {
                _operand3 = value;
                RaisePropertiesChanged(nameof(Operand3));
            }
            
        }
        public int Operation {
            get =>
                _operation;
            
            set
            {
                _operation = value;
                RaisePropertiesChanged(nameof(Operation));
            }
            
        }
        
        #endregion
        
    }
    
    #region Constructors
    
    public CompilerCommandMenu()
    {
        InitializeComponent();
        
        CompilerCommands = new ObservableCollection<CompilerCommandViewModel>();
        CompilerCommands.CollectionChanged += CompilerCommandsCollectionChangedCallback;

    }
    
    #endregion
    
    #region ObservationCollection
    
    public ObservableCollection<CompilerCommandViewModel> CompilerCommands { get; }
    private bool _isUpdatingCollection = false;
    private void CompilerCommandsCollectionChangedCallback(object? sender, NotifyCollectionChangedEventArgs e)
    {
        Dispatcher.BeginInvoke(new Action(() =>
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    string json = JsonConvert.SerializeObject(CompilerCommands);
                    
                    byte[] byteArray = Encoding.UTF8.GetBytes(json);
                    
                    var stream = new MemoryStream(byteArray);
                    
                    Data = stream;

                    Console.WriteLine("Collection written to MemoryStream.");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Element removed");
                    break;
            }
        }));
    }   
    
    #endregion

   
    
    #region Dependency properties
    
    public static readonly DependencyProperty ColumnWidthProperty = DependencyProperty.Register(
        nameof(ColumnWidth),
        typeof(double),
        typeof(CompilerCommandMenu),
        new PropertyMetadata(130.0)
    
    );
    public double ColumnWidth
    {
        get => (double)GetValue(ColumnWidthProperty);
        set => SetValue(ColumnWidthProperty, value);
    }
    
    public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
        nameof(Data),
        typeof(MemoryStream),
        typeof(CompilerCommandMenu),
        new PropertyMetadata(default(MemoryStream), DataPropertyChangedCallback)
    
    );
    public MemoryStream Data
    {
        get => (MemoryStream)GetValue(DataProperty);
        set => SetValue(DataProperty, value);
    }

    private static void DataPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      
        
        if (d is not CompilerCommandMenu compilerCommandMenu)
        {
            return;
        }
        
        var memoryStream = e.NewValue as MemoryStream;
        
        if (memoryStream == null)
        {
            Console.WriteLine("New value is not a MemoryStream.");
            return;
        }
        
        memoryStream.Seek(0, SeekOrigin.Begin);
        
        var reader = new StreamReader(memoryStream);
        
        string content = reader.ReadToEnd();
            
        var commands = content.Split([';', '\n', '\r'])
            .Where(command => !string.IsNullOrWhiteSpace(command))  
            .ToList();
            
        compilerCommandMenu.CompilerCommands.Clear(); 
        
        if (commands.Count < 1)
        {
            compilerCommandMenu.RowCount = compilerCommandMenu.CompilerCommands.Count;
            return;
        }
            
        
        var operandsCollection = new List<int[]>();
            
        bool IsValidOperand(string operand)
        {
            return Regex.IsMatch(operand, @"^\d+$");  
        }
            
            
            
        foreach (var command in commands)
        {
            var operands = command
                .Split(',', StringSplitOptions.RemoveEmptyEntries)  
                .Take(4) 
                .ToArray();
                
            int[] resultOperands = new int[4]; 
                
            for (int i = 0; i < operands.Length; i++)
            {
                if (IsValidOperand(operands[i]))  
                {
                    resultOperands[i] = int.Parse(operands[i]); 
                }
                else
                {
                    resultOperands[i] = 0; 
                    Console.WriteLine($"Неверный операнд: {operands[i]}");  
                }
            }
            
                
            for (int i = operands.Length; i < 4; i++)
            {
                resultOperands[i] = 0;
            }
                
            operandsCollection.Add(resultOperands);
                
            Console.WriteLine("Complete.");
        }
        
            
        
            
        foreach (var operands in operandsCollection)
        {
            compilerCommandMenu.CompilerCommands.Add(
                new CompilerCommandViewModel(operands[1], operands[2], operands[3],operands[0])
            );
        }
            
        compilerCommandMenu.RowCount = compilerCommandMenu.CompilerCommands.Count;
            
        Console.WriteLine("Commands successfully added to CompilerCommands.");
    }


    
    public static readonly DependencyProperty RowCountProperty = DependencyProperty.Register(
        nameof(RowCount),
        typeof(int),
        typeof(CompilerCommandMenu),
        new PropertyMetadata(0, RowCountPropertyChangedCallback, RowCountCoerceValueCallback)
    
    );
   
    public int RowCount
    {
        get => (int)GetValue(RowCountProperty);
        set => SetValue(RowCountProperty, value);
    }

    private static void RowCountPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not CompilerCommandMenu compilerCommandMenu)
        {
            return;
        }
        
        var rowNewCount = (int)e.NewValue;
        
        // Удаление лишних элементов, если новых строк меньше
        while (compilerCommandMenu.CompilerCommands.Count > rowNewCount)
            compilerCommandMenu.CompilerCommands.RemoveAt(compilerCommandMenu.CompilerCommands.Count - 1);

        // Добавление новых элементов, если новых строк больше
        while (compilerCommandMenu.CompilerCommands.Count < rowNewCount)
            compilerCommandMenu.CompilerCommands.Add(new CompilerCommandViewModel(0, 0, 0, -1));
        
    }

    private static object RowCountCoerceValueCallback(DependencyObject d, object value)
    {
        return value is int and > 0 ? value : 0;
    }
    
    #endregion
}