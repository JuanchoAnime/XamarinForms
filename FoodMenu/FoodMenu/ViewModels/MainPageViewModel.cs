namespace FoodMenu.ViewModels
{
    using FoodMenu.Model;
    using Prism.Navigation;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Food> _foods;
        private ObservableCollection<Food> _orders;

        public ObservableCollection<Food> Foods {
            get => _foods;
            set { SetProperty(ref _foods, value); }
        }

        public ObservableCollection<Food> Orders
        {
            get => _orders;
            set { 
                SetProperty(ref _orders, value);
            }
        }

        public int OrderCount => Orders.Count;

        public float TotalPrice => Orders.Sum(x => x.Price);

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Orders = new ObservableCollection<Food>();
            Foods = GetFoods();
        }

        private ObservableCollection<Food> GetFoods() 
        {
            return new ObservableCollection<Food>
            {
                new Food{ Name = "Omelette Breakfast Dish", Image = "Omelette.png", Price = 13.99f, 
                    Description = "Omelette Breakfast Dish Fried egg. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt"},
                new Food{ Name = "California Sushi pizza", Image = "California.png", Price = 22.59f, 
                    Description = "California roll Sushi pizza. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt"},
                new Food{ Name = "Greek Salad with tomatoes", Image = "Greek.png", Price = 18.25f, 
                    Description = "Greek Salad with tomatoes. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt"},
                new Food{ Name = "Cherry with pepper salad", Image = "Cherry.png", Price = 10.99f, 
                    Description = "Tomato cherry with lettuce and bell pepper salad. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod"},
            };
        }

        public void AddFood(Food item)
        {
            if (item != null) {
                Orders.Add(item);
                RaisePropertyChanged(nameof(OrderCount));
                RaisePropertyChanged(nameof(TotalPrice));
            }
        }
    }
}
