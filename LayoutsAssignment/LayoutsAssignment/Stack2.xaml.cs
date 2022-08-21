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
    public partial class Stack2 : ContentPage
    {
        public Stack2()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Margin = new Thickness(10, 20, 10, 20),
                Children =
            {
                new Image
                {
                    Source="https://aka.ms/campus.jpg",
                    HorizontalOptions= LayoutOptions.FillAndExpand,

                },
                new StackLayout
                {
                    Orientation=StackOrientation.Horizontal,
                    Children =
                    {
                        new Label
                        {
                            Text="Share",
                            TextColor=Color.Navy
                        },
                         new Label
                        {
                            Text="commit",
                            TextColor=Color.Navy
                        },
                          new Label
                        {
                            Text="like",
                            TextColor=Color.Navy
                        }


                    }

                },

                new Label
                {
                    Text = "700 likes",
                    FontSize=18,
                    FontAttributes= FontAttributes.Bold
                },
                new Label
                {
                    Text = "this is shot Yesterday"

                },
            }
            };
            Content = stackLayout;
        }
    }
}