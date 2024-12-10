namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }

        private async void DrawingView_DrawingLineCompleted(object sender,
            CommunityToolkit.Maui.Core.DrawingLineCompletedEventArgs e)
        {

            var stream = await myDrawing.GetImageStream(150,150);
            myImage.Source = ImageSource.FromStream(() => stream);
            


        }
    }

}
