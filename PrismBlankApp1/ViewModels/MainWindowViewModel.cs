using System.Collections.ObjectModel;
using Prism.Mvvm;
using PrismBlankApp1.Common.Models;

namespace PrismBlankApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application111";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        { 
            MenuBars=new ObservableCollection<MenuBar>();
            CreateMenBar();

        }
        private ObservableCollection<MenuBar> menuBars;

        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; }
        }
        void CreateMenBar()
        {
            MenuBars.Add(new MenuBar() { Icon = "Home", Title = "首页", Name = "IndexView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookCheckOutline", Title = "代办事项", Name = "ToDoView" });
            MenuBars.Add(new MenuBar() { Icon = "NotebookPlusOutlin", Title = "备忘录", Name = "MemoView" });
            MenuBars.Add(new MenuBar() { Icon = "Cog", Title = "设置", Name = "SettingsView" });



        }
    }
}
