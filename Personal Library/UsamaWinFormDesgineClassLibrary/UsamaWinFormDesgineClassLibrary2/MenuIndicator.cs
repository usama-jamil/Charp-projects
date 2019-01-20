using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsamaWinFormDesgineClassLibrary2
{
    public static class MenuIndicator
    {
        /// <summary>
        /// jab button click kia jay ga too 
        /// Sidepanel uski left side per aa jay gaa
        /// selected control dikhnay lgay gaa
        /// </summary>
        /// <param name="selectedButton">jo Button app nay select kerna hay</param>
        /// <param name="selectedControl">Button click kernay say jo Control samnay ay ga</param>
        /// <param name="slider">konsa Panel clicked button kay sath hoga</param>
      public  static void SelectButton(Control selectedButton, Control selectedControl,Panel slider)
        {
           SliderPanel.SliderPanelLeft(selectedButton, slider);
            selectedControl.BringToFront();
        }


        //public static void SelectButton(Button selectedButton, Control selectedControl, Panel slider, int sliderThickness)
        //{
        //    SliderPanel.SliderPanelLeft(selectedButton, slider, sliderThickness);
        //    selectedControl.BringToFront();
        //}


        public static void SelectTabPage(Control selectedButton, TabControl tabControl, TabPage selectedTabPage, Panel slider)
        {
            SliderPanel.SliderPanelLeft(selectedButton, slider);

            tabControl.SelectTab(selectedTabPage);
        }
        
        
        //public static void SelectTabPage(Button selectedButton, TabControl tabControl, TabPage selectedTabPage, Panel slider, int sliderThickness)
        //{
        //    SliderPanel.SliderPanelLeft(selectedButton, slider, sliderThickness);

        //    tabControl.SelectTab(selectedTabPage);
        //}
    }
}
