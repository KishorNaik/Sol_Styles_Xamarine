using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Sol_Demo
{
    public class MainPageViewModel 
    {

        #region Constructor
        public MainPageViewModel()
        {
            OnSubmitClick();
        }
        #endregion 

        #region Public Method
        public Command SubmitDynamicResource { get; set; }
        #endregion

        #region Private Method
        private void OnSubmitClick()
        {
            SubmitDynamicResource = new Command<ContentPage>((contentPage) => 
            {
                contentPage.Resources["btnStyleOrangle"] = contentPage.Resources["btnStyleRed"];

            });
        }
        #endregion 
    }
}
