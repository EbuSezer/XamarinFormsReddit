using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reddit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            FillInfo();
		}
        private void FillInfo()
        {
            List<model> models = new List<model>
            {
                new model
                {
                    name="1"
                },
                 new model
                {
                    name="1"
                },
                 new model
                {
                    name="1"
                },
                 new model
                {
                    name="1"
                },
                 new model
                {
                    name="1"
                },
                 new model
                {
                    name="1"
                },
                 new model
                {
                    name="1"
                }
            };
            listPost.BindingContext = models;
        }
        class model
        {
            public string name { get; set; }
        }
        private void buttonHide_Clicked(object sender, EventArgs e)
        {
            stack.IsVisible = false;
        }

        
    }
}