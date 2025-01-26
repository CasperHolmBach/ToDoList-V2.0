using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ToDoListV2;

public partial class MainWindow : Window
{
    private readonly IFrontendLayer frontendLayer;
    
    public MainWindow() : this(null) {}
    public MainWindow(IFrontendLayer frontendLayer)
    {
        InitializeComponent();
        this.frontendLayer = frontendLayer;
    }

    //Create task button logic
    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        //Save inputs
        var taskName = taskNameInput.Text;
        var taskDescription = taskDescriptionInput.Text;
        
        //Try sending inputs
        try
        {
            frontendLayer.ReceiveTaskProperties(taskName, taskDescription);
        }
        catch(ArgumentException)
        {
            message.Text = "Task name cannot be empty";
            return; //Early return for invalid input
        }

        //Succesful creation -> clear inputs
        taskNameInput.Clear();
        taskDescriptionInput.Clear();
        message.Text = "Task created!";
    }
}