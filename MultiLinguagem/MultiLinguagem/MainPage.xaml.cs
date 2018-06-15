using MultiLinguagem.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MultiLinguagem
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblWelcome.Text = AppResources.LabelTest;
        }
    }
}
