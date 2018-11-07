using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class PassThroughLabel : Label {
    public PassThroughLabel() {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs pe) {
        base.OnPaint(pe);
    }

    protected override void WndProc(ref Message m) {
        const int WM_NCHITTEST = 0x0084;
        const int HTTRANSPARENT = (-1);

        if (m.Msg == WM_NCHITTEST) {
            m.Result = (IntPtr)HTTRANSPARENT;
        } else {
            base.WndProc(ref m);
        }
    }

}

