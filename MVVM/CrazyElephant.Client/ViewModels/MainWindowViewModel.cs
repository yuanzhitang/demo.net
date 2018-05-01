using CrazyElephant.Client.Models;
using CrazyElephant.Client.Services;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrazyElephant.Client.ViewModels
{
    class MainWindowViewModel : NotificationObject
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; this.RaisePropertyChanged("Count"); }
        }

        private Restaurant restaurant;

        public Restaurant Restaurant
        {
            get { return restaurant; }
            set { restaurant = value; this.RaisePropertyChanged("Restaurant"); }
        }

        private List<DishItemViewModel> dishMenu;

        public List<DishItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set { dishMenu = value; this.RaisePropertyChanged("DishMenu"); }
        }

        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
            this.SelectMenuItemCommand = new DelegateCommand(new Action(this.SelectMenuItemCommandExecute));
        }

        private void SelectMenuItemCommandExecute()
        {
            this.Count = this.DishMenu.Count(i => i.IsSelected == true);
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = this.DishMenu.Where(i => i.IsSelected == true).Select(i => i.Dish.Name).ToList();
            IOrderService orderService = new MockOrderService();
            orderService.PlaceOrder(selectedDishes);
            MessageBox.Show("订餐成功！");
        }

        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "Crazy大象";
            this.Restaurant.Address = "某街某巷";
            this.Restaurant.Telephone = "123541231412312";
        }

        private void LoadDishMenu()
        {
            XmlDataService ds = new XmlDataService();
            var dishes = ds.GetAllDishes();
            this.DishMenu = new List<DishItemViewModel>();
            foreach (var dish in dishes)
            {
                DishItemViewModel item = new DishItemViewModel
                {
                    Dish = dish
                };
                this.DishMenu.Add(item);
            }
        }

    }
}
