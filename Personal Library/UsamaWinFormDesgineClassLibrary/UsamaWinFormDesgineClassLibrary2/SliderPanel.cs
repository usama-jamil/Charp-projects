using System.Windows.Forms;

namespace UsamaWinFormDesgineClassLibrary2
{
    public static class SliderPanel
    {

        public static void SliderPanelLeft(Control selectedButton, Panel slider)
        {
            slider.Height = selectedButton.Height;
            slider.Top = selectedButton.Top;
        }
        //private static void SliderPanelLeft(Button selectedButton, Panel slider, int sliderThickness)
        //{
        //    slider.Height = selectedButton.Height;
        //    slider.Top = selectedButton.Top;
        //    slider.Width = sliderThickness;
        //}
        private static void SliderPanelBottom(Control selectedButton, Panel slider)
        {
            slider.Width = selectedButton.Width;
            slider.Left  = selectedButton.Left;
        }
        //public static void SliderPanelBottom(Button selectedButton, Panel slider, int sliderThickness)
        //{
        //    slider.Width = selectedButton.Width;
        //    slider.Left = selectedButton.Left;
        //    slider.Height = sliderThickness;
        //}
    }
}
