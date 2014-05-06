using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace TraktBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pbScreen.Image = null;
            this.pbAvatar.Image = null;
            this.labelUsername.Text = string.Empty;
            this.labelAge.Text = string.Empty;
            this.labelGender.Text = string.Empty;
        }

        private void btnGetJSON_Click(object sender, EventArgs e)
        {
            string watchListJson = Controller.DownloadContent(Program.UrlWatchList);

            List<Movie>  watchlist = Controller.DeserializeMovies(watchListJson);

            List<Movie>  randomList = watchlist.GetDistinctRandom(5);

            //string watchingJson = Controller.DownloadContent(Program.UrlProfile);


            //TraktUser traktUser = Controller.DeserializeTraktUser(watchingJson);
            //PopulateUserView(traktUser);
            //SetAvatarImage(traktUser.Avatar);
            //this.label23.Text = string.Format("{0}, {1}", watching.Episode.Title, watching.Episode.Season);
        }

        private void PopulateUserView(TraktUser traktUser)
        {
            this.labelUsername.Text = traktUser.Username;
            this.labelUsername.Visible = true;
            //this.labelProtectedData.Text = traktUser.Protected;
            //this.labelFullNameData.Text = traktUser.FullName;
            this.labelGender.Text = traktUser.Gender;
            this.labelGender.Visible = true;
            this.labelAge.Text = traktUser.Age.ToString(CultureInfo.InvariantCulture);
            this.labelAge.Visible = true;


            this.pbScreen.Image = GetImageStreamFromUrl(traktUser.Watching[0].Episode.Images.Screen);
            //this.labelLocationData.Text = traktUser.Location;
            //this.labelAboutData.Text = (string.IsNullOrEmpty(traktUser.About) ? "No Information Available" : traktUser.About);
            //this.labelJoinedData.Text = traktUser.Joined.ToString();
            //this.labelAvatarData.Text = traktUser.Avatar;
            //this.labelUrlData.Text = traktUser.Url;
            //this.labelVipData.Text = traktUser.Vip.ToString();
        }

        private static Image GetImageStreamFromUrl(string screenUrl)
        {
            return Controller.GetImageStreamFromUrl(screenUrl);
        }

        private void SetAvatarImage(string avatarUrl)
        {
            this.pbAvatar.Image = Controller.GetImageStreamFromUrl(avatarUrl);
        }

        private void CleanUp()
        {
            this.pbScreen.Image = null;
            this.pbAvatar.Image = null;
            this.labelUsername.Text = string.Empty;
            this.labelAge.Text = string.Empty;
            this.labelGender.Text = string.Empty;
        }
        

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            CleanUp();
        }
    }
}
