using AllEventsMvvM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllEventsMvvM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsAllView : ContentPage
    {
        public EventsAllView()
        {
            InitializeComponent();
            BindingContext = new EventsAllViewModel();
        }
    }
}