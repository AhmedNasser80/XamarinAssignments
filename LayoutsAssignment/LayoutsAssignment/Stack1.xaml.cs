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
    public partial class Stack1 : ContentPage
    {
        public Stack1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Clicked += Btn_Clicked;
            btn.Text = "Stack2";
            btn.Margin = new Thickness(0, 20, 0, 0);
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =

                {
                    new Label
                    {
                        Text = "Welcome to Xamarin",
                        HorizontalOptions = LayoutOptions.Center,
                        FontSize = 24
                    },
                    new Label
                    {
                        Text = "Cross-platform apps made easy",
                        HorizontalOptions = LayoutOptions.Center,
                        FontSize = 20


                    },
                    new Label
                    {
                        Text = "Login",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        BackgroundColor = Color.Navy,
                        Margin = new Thickness(0, 10),


                    },
                    new Label
                    {
                        Text = "Register",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        BackgroundColor = Color.Navy,
                        Margin = new Thickness(0, 10),
                    },
                    btn

                }

            };

            Content = stackLayout;

        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Stack2());
        }
    }
 }