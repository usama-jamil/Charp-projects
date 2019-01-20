using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UsamaWindowsFormsControlLibrary
{
    class UCircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            var graphicsPath = new GraphicsPath();
                graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            this.Region = new System.Drawing.Region(graphicsPath);

            base.OnPaint(pevent);
        }

    }
}
