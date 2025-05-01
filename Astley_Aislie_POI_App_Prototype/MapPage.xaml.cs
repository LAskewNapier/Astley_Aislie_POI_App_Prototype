using Microsoft.Maui.Controls;

namespace ImageZoomApp
{
    public partial class MapPage : ContentPage
    {
        private const double MinScale = 2; // Minimum zoom level
        private const double MaxScale = 3; // Maximum zoom level
        private const double MoveStep = 40; // Step size for movement

        public MapPage()
        {
            InitializeComponent();
        }

        private void OnZoomInClicked(object sender, EventArgs e)
        {
            if (ZoomableImage.Scale < MaxScale)
            {
                ZoomableImage.Scale += 0.1;
            }
        }

        private void OnZoomOutClicked(object sender, EventArgs e)
        {
            if (ZoomableImage.Scale > MinScale)
            {
                ZoomableImage.Scale -= 0.1;
            }
        }

        private void OnMoveLeftClicked(object sender, EventArgs e)
        {
            MoveImage(+MoveStep, 0);
        }

        private void OnMoveRightClicked(object sender, EventArgs e)
        {
            MoveImage(-MoveStep, 0);
        }

        private void OnMoveUpClicked(object sender, EventArgs e)
        {
            MoveImage(0, +MoveStep);
        }

        private void OnMoveDownClicked(object sender, EventArgs e)
        {
            MoveImage(0, -MoveStep);
        }

        private void MoveImage(double deltaX, double deltaY)
        {
            var translationX = ZoomableImage.TranslationX + deltaX;
            var translationY = ZoomableImage.TranslationY + deltaY;

            // Calculate boundaries
            var maxTranslationX = (ZoomableImage.Width * ZoomableImage.Scale - ImageScrollView.Width);
            var maxTranslationY = (ZoomableImage.Height * ZoomableImage.Scale - ImageScrollView.Height);

            // Apply limits
            ZoomableImage.TranslationX = Math.Max(-maxTranslationX, Math.Min(maxTranslationX, translationX));
            ZoomableImage.TranslationY = Math.Max(-maxTranslationY, Math.Min(maxTranslationY, translationY));
        }
    }
}
