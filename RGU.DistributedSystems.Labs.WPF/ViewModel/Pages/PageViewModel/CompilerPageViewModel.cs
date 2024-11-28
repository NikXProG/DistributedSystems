using System.Collections.ObjectModel;
using System.IO;
using System.Text.Unicode;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RGU.DistributedSystems.Labs.WPF.Converter;
using RGU.DistributedSystems.Labs.WPF.MVVM.Command;
using RGU.DistributedSystems.Labs.WPF.MVVM.ViewModel;
using RGU.DistributedSystems.Labs.WPF.Utils;
using RGU.DistributedSystems.Labs.WPF.View.UserControls;

namespace RGU.DistributedSystems.Labs.WPF.ViewModel.Pages.PageViewModel;
using RGU.DistributedSystems.Labs.WPF.Models;

internal sealed class CompilerPageViewModel : PageViewModelBase
{
    
    #region Fields


    private MemoryStream _memoryStream = new MemoryStream();
    
    private string _textContentTextBox = "";
    private int _selectedIndexValue = 0;
    private double _fontSizeTextEditor = 25.0;
    private int _rowCount = 2;
    private bool  _isVisibleTextEditor  = true;
    private bool  _isVisibleDesignBlockCraft  = true;
    
    private readonly Lazy<ICommand> _addRowCommand;
    private readonly Lazy<ICommand> _deleteRowCommand;
    private readonly Lazy<ICommand> _compileCommand;
    private readonly Lazy<ICommand> _textChangedCommand;
    private readonly Lazy<ICommand> _selectedChangedCommand;
    private readonly Lazy<ICommand> _fontSizeChangedCommand;
    private readonly Lazy<ICommand> _buttonTextEditorViewCommand;
    private readonly Lazy<ICommand> _buttonDesignBlockCraftViewCommand;
    private readonly Lazy<ICommand> _buttonMixedFunctionalViewCommand;
    
    #endregion

    #region Constructors

    public CompilerPageViewModel(NavigationManager navigationManager) : base(navigationManager)
    {
        _selectedChangedCommand = new Lazy<ICommand>(() => 
            new RelayCommand(TextBoxSelectionChanged));
        
        _fontSizeChangedCommand = new Lazy<ICommand>(() => 
            new RelayCommand((param) => FontSizeChanged((MouseWheelEventArgs)param!)));

        _addRowCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ => AddRow()));
        
        _deleteRowCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ => DeleteRow()));
        
        _buttonTextEditorViewCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ =>  ButtonTextEditorVisibilityChanged()));
        
        _buttonDesignBlockCraftViewCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ =>  ButtonDesignBlockCraftVisibilityChanged()));
                
        _buttonMixedFunctionalViewCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ =>  ButtonMixedFunctionalVisibilityChanged()));
        
        _compileCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ =>  Compile()));

        _textChangedCommand = new Lazy<ICommand>(() =>
            new RelayCommand(_ => TextBoxTextChanged()));

    }

    #endregion
    
    #region Commands
    
    public ICommand ButtonMixedFunctionalViewCommand => _buttonMixedFunctionalViewCommand.Value;
    
    public ICommand CompileCommand => _compileCommand.Value;
    
    public ICommand ButtonDesignBlockCraftViewCommand => _buttonDesignBlockCraftViewCommand.Value;
    
    public ICommand ButtonTextEditorViewCommand => _buttonTextEditorViewCommand.Value;
    
    public ICommand DeleteRowCommand => _deleteRowCommand.Value;
    
    public ICommand AddRowCommand => _addRowCommand.Value;

    public ICommand SelectedChangedCommand => _selectedChangedCommand.Value;
    
    public ICommand TextChangedCommand => _textChangedCommand.Value;
    
    public ICommand FontSizeChangedCommand => _fontSizeChangedCommand.Value;
    
    #endregion
    
    #region Properties

    public int SelectedIndexValue
    {
        get => _selectedIndexValue;
        set
        {
            _selectedIndexValue = value;
            RaisePropertyChanged(nameof(SelectedIndexValue));
        }
    }
    
    
    public bool IsVisibleTextEditor
    {
        get => _isVisibleTextEditor;
        set
        {
            _isVisibleTextEditor = value;
            RaisePropertyChanged(nameof(IsVisibleTextEditor));
        }
    }
    
    
    public bool IsVisibleDesignBlockCraft
    {
        get => _isVisibleDesignBlockCraft;
        set
        {
            _isVisibleDesignBlockCraft = value;
            RaisePropertyChanged(nameof(IsVisibleDesignBlockCraft));
        }
    }
    
    
    public int RowCount
    {
        get => _rowCount;
        set
        {
            _rowCount =  value <= 0 ? 0 : value;
            RaisePropertyChanged(nameof(RowCount)); 
        }
    }
    
    public double FontSizeTextEditor
    {
        get => _fontSizeTextEditor;
        set
        {
            _fontSizeTextEditor = value;
            RaisePropertyChanged(nameof(FontSizeTextEditor));
        }
    }
    
    public MemoryStream MemoryStream
    {
        get => _memoryStream;
        set
        {
            _memoryStream = value;
            RaisePropertyChanged(nameof(MemoryStream));
        }
    }
    
    public string TextContentTextBox
    {
        get => _textContentTextBox;
        set
        {
            _textContentTextBox = value;
            RaisePropertyChanged(nameof(TextContentTextBox));
        }
        
    }
    

    #endregion
    
    #region Methods

        #region Handlers

        private void TextBoxSelectionChanged(object? parameter)
        {
            if (parameter is not TextBox textBox)
            {
                return;
            }
            
            var lines = TextContentTextBox.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                   
            int count = 0;
            int currentIndex = 0;
                    
            foreach (var line in lines)
            {
                        
                if (textBox.SelectionStart >= currentIndex &&  textBox.SelectionStart <= currentIndex + line.Length)
                {
                          
                    SelectedIndexValue = count; 
                    break;
                }
                currentIndex += line.Length + 2;
                count++; 
                        
            }
                    
        }
            
        private void FontSizeChanged(MouseWheelEventArgs? e)
        {
            if(Keyboard.Modifiers != ModifierKeys.Control)
            {
                return;
            }
                    
            e!.Handled = true;

            FontSizeTextEditor += (e.Delta > 0 ? 1 : -1) * 5.0;
                    
        }
        
        
        #endregion
    
        private void AddRow()
        {
            RowCount++;
        }
        
        private void DeleteRow()
        {
            RowCount--;
        }
        
        private void Compile()
        {
            if (MemoryStream.CanSeek && MemoryStream.Position == MemoryStream.Length)
            {
                Console.WriteLine("Stream has been closed or disposed.");
                return;
            }

            
            // if (MemoryStream is { CanSeek: true })
            // {
            //     Console.WriteLine(MemoryStream.Length);
            //     MemoryStream.Seek(0, SeekOrigin.Begin);  
            //     using (var reader = new StreamReader(MemoryStream))
            //     {
            //         string content = reader.ReadToEnd();
            //         Console.WriteLine("MemoryStream Content:");
            //         Console.WriteLine(content);  // Для отладки
            //     }
            //     TextBoxTextChanged();
            // }
            // else
            // {
            //     Console.WriteLine("MemoryStream is closed or disposed.");
            // }
            
        }

                
        private void TextBoxTextChanged()
        {  
            
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(TextContentTextBox);
            var stream = new MemoryStream(byteArray);
            var writer = new StreamWriter(stream);
            writer.Write(TextContentTextBox);
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin); 
            MemoryStream = stream; 
            
        }
        
        private void ButtonTextEditorVisibilityChanged()
        {
            IsVisibleDesignBlockCraft = false;
            IsVisibleTextEditor = true;
        }
        
        private void ButtonDesignBlockCraftVisibilityChanged()
        {
            IsVisibleDesignBlockCraft = true;
            IsVisibleTextEditor = false;
        }
        private void ButtonMixedFunctionalVisibilityChanged()
        {
            IsVisibleDesignBlockCraft = true;
            IsVisibleTextEditor = true;
        }

    #endregion
    
    
}