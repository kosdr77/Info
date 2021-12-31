using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Info.App;

namespace Info.Classes
{
    public static class Extensions
    {

        // Скрыть все панели и показать одну определённую
        public static void Demonstrate(this Panel panel, MainForm owner)
        {
            foreach (var panelmain in owner.Controls.OfType<Panel>().Where(x => x.Name == "PanelMain"))
                panelmain.Controls.OfType<Panel>().Where(x => x.Visible).ToList().ForEach(x => x.Hide());
            panel.Show();
        }

        // Краска для форм
        public static void Draw(this MainForm form, Color color1, Color color2, float[] positions, int angle)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (form.ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(form.ClientRectangle, Color.Empty, Color.Empty, angle);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = positions };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, form.ClientRectangle);
            }

            form.Paint -= OnPaintEventHandler;
            form.Paint += OnPaintEventHandler;

            form.Invalidate();
        }

        public static void Draw(this NotificationForm form, Color color1, Color color2, float[] positions, int angle)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (form.ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(form.ClientRectangle, Color.Empty, Color.Empty, angle);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = positions };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, form.ClientRectangle);
            }

            form.Paint -= OnPaintEventHandler;
            form.Paint += OnPaintEventHandler;

            form.Invalidate();
        }

        public static void Draw(this Panel panel, Color color1, Color color2, float[] positions, int angle)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (panel.ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(panel.ClientRectangle, Color.Empty, Color.Empty, angle);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = positions };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, panel.ClientRectangle);
            }

            panel.Paint -= OnPaintEventHandler;
            panel.Paint += OnPaintEventHandler;

            panel.Invalidate();
        }
    }
}
