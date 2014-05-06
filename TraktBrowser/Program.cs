using System;
using System.Net;
using System.Windows.Forms;
namespace TraktBrowser
{
	internal static class Program
	{
		public const string UrlProfile = "http://api.trakt.tv/user/profile.json/7b8cbd557ce6af7c0987fafdf4582044/Amoenus";
		public const string UrlWatching = "http://api.trakt.tv/user/watching.json/7b8cbd557ce6af7c0987fafdf4582044/Amoenus";
        public const string UrlWatchList = "http://api.trakt.tv/user/watchlist/movies.json/7b8cbd557ce6af7c0987fafdf4582044/Amoenus";

		public static readonly IWebProxy Proxy = new WebProxy("http://10.139.2.18:3128/");
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
