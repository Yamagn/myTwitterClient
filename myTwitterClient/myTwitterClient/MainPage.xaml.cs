using Xamarin.Forms;
using CoreTweet;

namespace myTwitterClient
{
	public partial class MainPage : ContentPage
	{
        public Tokens tokens;
		public MainPage()
		{
			InitializeComponent();

            tokens = Tokens.Create("Hn1jM2UkSVFzVD556sEAN4K5D", "QZza1qpoOef2q1ZUUJdI8ipFQobkK43wlyD0POHJEq76Ur4qnR", "744673241474576384-nBOu3dPr5g1e6ZCpTpQz5BCAaXBmV8m", "2EIiOiZDAKt8MLP2iG016JVq6DpYJ4ceAo8uXMMMBZNrU");
            var statuses = tokens.Statuses.HomeTimelineAsync(count => 100);
            timeLine.ItemsSource = (System.Collections.IEnumerable)statuses;
        }
        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var statuses = await tokens.Statuses.HomeTimelineAsync(count => 100);
        //    timeLine.ItemsSource = statuses;
        //}

    }
}
