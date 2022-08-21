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
            ProductArrayList = new List<Product>();
            ProductArrayList.Add(new Product {Name="Mocca"});
            ProductArrayList.Add(new Product { Name = "Espresso" });
            ProductArrayList.Add(new Product { Name = "Latte" });
            ProductArrayList.Add(new Product { Name = "Americano" });
            ProductArrayList.Add(new Product { Name = "Arabica" });

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


        }
    }
}