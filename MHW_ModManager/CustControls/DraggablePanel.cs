using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


public partial class DraggablePanel : Panel {
    public DraggablePanel() {
        InitializeComponent();
    }

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HTCAPTION = 0x2;
    [DllImport("User32.dll")]
    public static extern bool ReleaseCapture();
    [DllImport("User32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    protected override void OnMouseDown(MouseEventArgs e) {
        base.OnMouseDown(e);
        if (e.Button == MouseButtons.Left) {
            ReleaseCapture();
            SendMessage(FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }

}