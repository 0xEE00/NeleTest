using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NeleTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        int a = 0;
        int b = 0;
        int rezultat = 0;

        private async void btnPozdrav_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog poruka = new MessageDialog("Ćao " + txtIme.Text + " " + txtPrezime.Text);
            await poruka.ShowAsync();
        }

        private void btnSaberi_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(txtBrojA.Text);
            b = Convert.ToInt32(txtBrojB.Text);

            rezultat = a + b;
            txtRezultat.Text = Convert.ToString(rezultat);
        }

        private void btnOduzmi_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(txtBrojA.Text);
            b = Convert.ToInt32(txtBrojB.Text);
            rezultat = a - b;
            txtRezultat.Text = Convert.ToString(rezultat);

        }
        private void TestMetoda()
        {

        }
    }
}
