using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutsAssignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid1 : ContentPage
    {
        public Grid1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Clicked += Btn_Clicked;
            btn.Text = "Grid1";
            btn.Margin = new Thickness(0, 20, 0, 0);
            Grid grid = new Grid
            {
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition(),
                    new RowDefinition(),
                    new RowDefinition(),
                    new RowDefinition(),
                    new RowDefinition()

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition()
                },
            };
            grid.Children.Add(new Label
            {
                Text = "1234",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 30,
                Margin = new Thickness(0,10,0,0),
            },1,0);
            grid.Children.Add(new Label
            {
                Text="1",
                TextColor = Color.Black,
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                VerticalOptions=LayoutOptions.CenterAndExpand,
                FontSize=24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)
                
            },0,1);
            grid.Children.Add(new Label
            {
                Text = "2",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 1, 1);
            grid.Children.Add(new Label
            {
                Text = "3",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 2, 1);
            grid.Children.Add(new Label
            {
                Text = "4",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 0, 2);
            grid.Children.Add(new Label
            {
                Text = "5",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 1, 2);
            grid.Children.Add(new Label
            {
                Text = "6",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 2, 2);
            grid.Children.Add(new Label
            {
                Text = "7",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 0, 3);
            grid.Children.Add(new Label
            {
                Text = "8",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 1, 3);
            grid.Children.Add(new Label
            {
                Text = "9",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 24,
                BackgroundColor = Color.White,
                Padding = new Thickness(30)

            }, 2, 3);
            grid.Children.Add(new Label
            {
                Text = "Dial",
                Margin = new Thickness(0, 20),
                Padding=new Thickness(20, 10),
                FontSize = 30,
                HorizontalOptions= LayoutOptions.CenterAndExpand,
                BackgroundColor= Color.LightGreen,

            }, 1, 4) ;
            grid.Children.Add(btn);
            Content = grid;
        }
        
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid2());
        }
    }
}