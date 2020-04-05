using AllEventsMvvM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AllEventsMvvM.ViewModel
{
   public class EventsAllViewModel:INotifyPropertyChanged
    {
        public EventsAllViewModel()
        {
            _NewPage = "Welcome";
            _ForgotPasswordCommand = new Command(naviForgotPasswordCommand);
            _loginclick = new Command(naviloginclick);
            _icon = new Command(Openimage);
            //_uid = new Command(naviuid);
            //_uidpass = new Command(naviuidpass);
            
        }


        private ICommand _icon;
        public ICommand icon
        {
            set { _icon = value; }
            get { return _icon; }
        }

        void Openimage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new WorkPage1());
        }


        private string _uid;
        public string uid
        {
            set { _uid = value;  }
            get { return _uid; }
        }
        private void naviuid() { }
        private string _uidpass;
        public string uidpass
       
        {
            set { _uidpass = value; }
            get { return _uidpass; }
        }
        private void naviuidpass() { }
        private ICommand _loginclick;
        public ICommand loginclick
        {
            set { _loginclick = value; }
            get { return _loginclick; }
        }
        private void naviloginclick() {

            //Preference.Set("Type something", uid.Text);
            //Preference.Set("Type ", uid.Text); 
        }

        private ICommand _ForgotPasswordCommand;
        public ICommand ForgotPasswordCommand
        {
            set { _ForgotPasswordCommand = value; }
            get { return _ForgotPasswordCommand; }
        }

        private void naviForgotPasswordCommand() {

            Application.Current.MainPage.Navigation.PushAsync(new WorkPage1());
                }
        private string _NewPage;

        public event PropertyChangedEventHandler PropertyChanged;

        public string NewPage
        {
            set { _NewPage = value; }
            get { return _NewPage; }
        }
                

         private bool _IsChecked;
        public bool IsChecked
        {
            set { _IsChecked = value; }
            get { return _IsChecked; }
        }

        }
    }

