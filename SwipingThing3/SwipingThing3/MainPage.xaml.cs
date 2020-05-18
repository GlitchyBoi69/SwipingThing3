using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipingThing3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IList<string> strList = new List<string>();
        IList<string> ImgList = new List<string>();
        int index;
        public MainPage()
        {
            InitializeComponent();
            strList.Add("Meme 1");
            strList.Add("Meme 2");
            strList.Add("Meme 3");
            strList.Add("Meme 4");
            ImgList.Add("meme1.png");
            ImgList.Add("meme2.png");
            ImgList.Add("meme3.png");
            ImgList.Add("meme4.png");
            index = 0;
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            // theLabel.Text = e.Direction.ToString();
            if (e.Direction == SwipeDirection.Left)
            {
                index++;
                if (index >= 4) index = 0;
                theLabel.Text = strList[index];
                theImage.Source = ImgList[index]; 
            }
            if (e.Direction == SwipeDirection.Right)
            {
                index--;
                if (index <= 0) index = 3;
                theLabel.Text = strList[index];
                theImage.Source = ImgList[index];
            }
        }

    }
}