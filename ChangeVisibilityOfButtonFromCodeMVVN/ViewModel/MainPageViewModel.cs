using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ChangeVisibilityOfButtonFromCodeMVVN.ViewModel
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
        }

        public void hub_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        {
            Hub hub = sender as Hub;
            Frame frame = (Frame)hub.Parent;
            switch (e.Section.Name)
            {
                case "image1":
                    frame.Navigate(typeof(View.Page1));
                    break;

                case "image2":
                    frame.Navigate(typeof(View.Page2));
                    break;

                case "image3":
                    frame.Navigate(typeof(View.Page3));
                    break;
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame != null)
            {
                rootFrame.Navigate(typeof(MainPage));
            }
        }
    }
}