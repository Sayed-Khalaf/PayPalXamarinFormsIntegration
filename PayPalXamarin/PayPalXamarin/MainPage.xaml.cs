using PayPal.Forms;
using PayPal.Forms.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PayPalXamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //TestPayPal().Wait();
		}

        async void OnTestClick(object sender, EventArgs args)
        {
            await TestPayPal();
        }

        public async Task TestPayPal()
        {
            try
            {
                var result = await CrossPayPalManager.Current.Buy(new PayPalItem("Test Product", new Decimal(9), "USD"), new Decimal(0));

                if (result.Status == PayPalStatus.Cancelled)
                {
                    Debug.WriteLine("Cancelled");
                }
                else if (result.Status == PayPalStatus.Error)
                {
                    Debug.WriteLine(result.ErrorMessage);
                }
                else if (result.Status == PayPalStatus.Successful)
                {
                    Debug.WriteLine(result.ServerResponse.Response.Id);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
	}
}
