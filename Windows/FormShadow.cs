using System.Windows.Forms;

namespace Info.Windows
{
    // Наследуемся от Form
    public class FormShadow : Form
    {
        #region Тень формы + перетаскивание окна + предотвращение разворачивания
#if !DEBUG
        [DllImport("dwmapi.dll")] public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins pMarInset);
        [DllImport("dwmapi.dll")] public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [DllImport("dwmapi.dll")] public static extern int DwmIsCompositionEnabled(ref int pfEnabled); readonly bool _mAeroEnabled;
        public struct Margins { public int LeftWidth; public int RightWidth; public int TopHeight; public int BottomHeight; }

        public FormShadow() => _mAeroEnabled = CheckAeroEnabled();

        bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return enabled == 1;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x00A3)
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 0x0085:
                    if (_mAeroEnabled)
                    {
                        var v = 2; DwmSetWindowAttribute(Handle, 2, ref v, 4);
                        Margins margins = new()
                        {
                            BottomHeight = 0,
                            LeftWidth = 1,
                            RightWidth = 0,
                            TopHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
                case 0x0083:
                    m.Result = (IntPtr)0; break;
                case 0x84 when (int)m.Result == 0x1: m.Result = (IntPtr)0x2; break;
                default: break;
            }
        }

#endif
        #endregion
    }
}