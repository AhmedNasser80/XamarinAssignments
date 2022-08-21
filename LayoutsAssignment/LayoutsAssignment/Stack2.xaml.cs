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
            Button btn = new Button();
            btn.Clicked += Btn_Clicked;
            btn.Text = "Grid1";
            btn.Margin = new Thickness(0, 20, 0, 0);
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
                btn
            }
            };
            Content = stackLayout;
        }
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Grid1());
        }
    }
}