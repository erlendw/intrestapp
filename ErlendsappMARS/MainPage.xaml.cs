using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace ErlendsappMARS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            String text_1 = textinput_1.Text;
            String text_2 = textinput_2.Text;
            String text_3 = textinput_3.Text;

            int principle;
            int numberofyears;


            bool principle_b = int.TryParse(text_1, out principle);
            bool numberofyears_b = int.TryParse(text_2, out numberofyears);

            if(principle_b && numberofyears_b)
            {

                double sum = 

            }


        }

        private void gotFocus_clear(object sender, RoutedEventArgs e)
        {

            if (sender == textinput_1) {

                if (textinput_1.Text == "Principle")
                {
                    textinput_1.Text = "";
                }

            }

            if (sender == textinput_2)
            {

                if (textinput_2.Text == "# of years")
                {
                    textinput_2.Text = "";
                }

            }



        }

        private void LostFocus_reset(object sender, RoutedEventArgs e)
        {

            if (sender == textinput_1)
            {

                string test = textinput_1.Text;


                if (string.IsNullOrEmpty(test)) {

                    textinput_1.Text = "Principle";

                }

            }

            if (sender == textinput_2)
            {

                string test = textinput_2.Text;


                if (string.IsNullOrEmpty(test))
                {

                    textinput_2.Text = "# of years";

                }

            }


        }

        private void textinput_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GotFocus_(object sender, RoutedEventArgs e)
        {

        }

        private void textinput_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
