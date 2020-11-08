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
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Slot_Machine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random number;
        int wheel1;
        int wheel2;
        int wheel3;

        public MainPage()
        {
            this.InitializeComponent();

            number = new Random(DateTime.Now.Millisecond);
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            wheel1 = number.Next(1, 4);

            if (wheel1 == 1)
            {
                TextBlock1.Text = "Domestic";
                playWheel2(wheel1, wheel2, number, wheel3);
            }
            else if (wheel1 == 2)
            {
                TextBlock1.Text = "Wild";
                playWheel2(wheel1, wheel2, number, wheel3);
            }
            else
            {
                TextBlock1.Text = "Fictional";
                playWheel2(wheel1, wheel2, number, wheel3);
            }
        }

        private void playWheel2(int wheel1, int wheel2, Random number, int wheel3)
        {
            wheel2 = number.Next(1, 4);

            if (wheel1 == 1)
            {
                if (wheel2 == 1)
                {
                    TextBlock2.Text = "Cat";
                    playWheel3(1, wheel2, wheel3, number);
                }
                else if (wheel2 == 2)
                {
                    TextBlock2.Text = "Dog";
                    playWheel3(1, wheel2, wheel3, number);
                }
                else
                {
                    TextBlock2.Text = "Bird";
                    playWheel3(1, wheel2, wheel3, number);
                }
            }

            else if (wheel1 == 2)
            {
                if (wheel2 == 1)
                {
                    TextBlock2.Text = "Canine";
                    playWheel3(2, wheel2, wheel3, number);
                }
                else if (wheel2 == 2)
                {
                    TextBlock2.Text = "Feline";
                    playWheel3(2, wheel2, wheel3, number);
                }
                else
                {
                    TextBlock2.Text = "Underwater";
                    playWheel3(2, wheel2, wheel3, number);
                }
            }
            else
            {
                if (wheel2 == 1)
                {
                    TextBlock2.Text = "Aquatic";
                    playWheel3(3, wheel2, wheel3, number);
                }
                else if (wheel2 == 2)
                {
                    TextBlock2.Text = "Lovecraftian";
                    playWheel3(3, wheel2, wheel3, number);
                }
                else
                {
                    TextBlock2.Text = "Mythical";
                    playWheel3(3, wheel2, wheel3, number);
                }
            }
        }

        private void playWheel3(int type, int wheel2, int wheel3, Random number)
        {
            wheel3 = number.Next(1, 4);

            if (type == 1) //Domestic animals
            {
                if (wheel2 == 1)
                {
                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Egyptian Mau";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "Maine Coon";
                    }
                    else
                    {
                        TextBlock3.Text = "Siamese";
                    }
                }

                else if (wheel2 == 2)
                {
                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Bulldog";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "German Sheppard";
                    }
                    else
                    {
                        TextBlock3.Text = "Poodle";
                    }
                }
                else
                {
                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Canary";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "Finch";
                    }
                    else
                    {
                        TextBlock3.Text = "Parakeet";
                    }
                }
            }

            else if (type == 2) //Wild animals
            {
                if (wheel2 == 1)
                {
                    if (wheel3 == 1)

                    {
                        TextBlock3.Text = "Dingo";
                    }
                    else if (wheel3 == 2)

                    {
                        TextBlock3.Text = "Hyena";
                    }
                    else

                    {
                        TextBlock3.Text = "Wolf";
                    }
                }

                else if (wheel2 == 2)
                {

                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Leopard";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "Lion";
                    }
                    else
                    {
                        TextBlock3.Text = "Tiger";
                    }
                }
                else
                {
                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Piranha";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "Shark";
                    }
                    else
                    {
                        TextBlock3.Text = "Whale";
                    }
                }
            }

            else //Fictional animals
            {
                if (wheel2 == 1)
                {
                    if (wheel3 == 1)

                    {
                        TextBlock3.Text = "Hydra";
                    }
                    else if (wheel3 == 2)

                    {
                        TextBlock3.Text = "Megalodon";
                    }
                    else

                    {
                        TextBlock3.Text = "Kraken";
                    }
                }

                else if (wheel2 == 2)
                {

                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Cthullu";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "Inpesca";
                    }
                    else
                    {
                        TextBlock3.Text = "Rhogog";
                    }
                }
                else
                {
                    if (wheel3 == 1)
                    {
                        TextBlock3.Text = "Bigfoot";
                    }
                    else if (wheel3 == 2)
                    {
                        TextBlock3.Text = "Chupacabra";
                    }
                    else
                    {
                        TextBlock3.Text = "Loch Ness Monster";
                    }
                }
            }



        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }
    }
}
