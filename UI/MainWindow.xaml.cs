using Data.Context;
using Domain.Entity;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IUsersService usersService;

        public MainWindow(IUsersService _usersService)
        {
            this.usersService = _usersService;
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            UsersEntity usersEntity = new UsersEntity
            {
                NickName = "陈",
                Account = "chen",
                Password = "123456"
            };
            await usersService.Create(usersEntity);
        }

        private async void Get_Click(object sender, RoutedEventArgs e)
        {
            var result = await usersService.GetName(Guid.Parse("C6C45844-FE21-455C-5964-08D89C16191D"));
            this.Result.Content = result;
        }
    }
}
