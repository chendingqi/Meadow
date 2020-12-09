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
        public MeadowContext meadowContext;

        public MainWindow(MeadowContext _meadowContext,IUsersService _usersService)
        {
            this.meadowContext = _meadowContext;
            this.usersService = _usersService;
            UsersEntity usersEntity = new UsersEntity();
            usersEntity.NickName = "陈";
            usersEntity.Account = "chen";
            usersEntity.Password = "123456";
            usersService.Create(usersEntity);
            InitializeComponent();
        }
    }
}
