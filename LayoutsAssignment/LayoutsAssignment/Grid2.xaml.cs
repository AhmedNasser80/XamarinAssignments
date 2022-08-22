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
    public partial class Grid2 : ContentPage
    {

        private List<Product> ProductArrayList;
        public Grid2()
        {

            InitializeComponent();
            Button btn = new Button();
            btn.Clicked += Btn_Clicked;
            btn.Text = "Relative1";
            btn.Margin = new Thickness(0, 20, 0, 0);
            Button btn2 = new Button();
            btn2.Clicked += Btn2_Clicked;
            btn2.Text = "Relative2";
            btn2.Margin = new Thickness(0, 20, 0, 0);
            ProductArrayList = new List<Product>();
            ProductArrayList.Add(new Product {Name="Mocca"});
            ProductArrayList.Add(new Product { Name = "Espresso" });
            ProductArrayList.Add(new Product { Name = "Latte" });
            ProductArrayList.Add(new Product { Name = "Americano" });
            ProductArrayList.Add(new Product { Name = "Arabica" });

            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.RowDefinitions.Add(new RowDefinition());
            gridLayout.RowDefinitions.Add(new RowDefinition());

            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            gridLayout.ColumnDefinitions.Add(new ColumnDefinition());
            var productIndex = 0;
            for (int rowIndex = 0; rowIndex < 2; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 3; columnIndex++)
                {
                    if (productIndex >= ProductArrayList.Count)
                    {
                        break;
                    }
                    var product = ProductArrayList[productIndex];
                    productIndex += 1;
                    var label = new Label
                    {
                        Text = product.Name,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center
                    };
                    gridLayout.Children.Add(label, columnIndex, rowIndex);
                }
            }
            gridLayout.Children.Add(btn,0,2);
            gridLayout.Children.Add(btn2, 2, 2);




        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Relative1());
        }
        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Relative2());
        }
    }
}