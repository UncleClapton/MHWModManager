using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public partial class InputBoxForm : Form {
    public InputBoxForm() {
        InitializeComponent();
        CenterToScreen();
    }


    static bool _isOpen = false;
    public static bool isOpen {
        get {
            return (_isOpen);
        }
        set {
            _isOpen = value;
        }
    }

    //DragWindowStuff
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HTCAPTION = 0x2;
    [DllImport("User32.dll")]
    public static extern bool ReleaseCapture();
    [DllImport("User32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    private void panel1_MouseDown(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }

    private void trackBarGeneric_Scroll(object sender, EventArgs e) {
        labelGeneric.Text = "Only include images " + trackBarGeneric.Value + "% or greater in similarity";
    }

    private void textBoxInput_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            buttonOK.PerformClick();
        }
    }

    private void InputBoxForm_Shown(object sender, EventArgs e) {
        if (textBoxInput.Visible)
            textBoxInput.Focus();
        else {
            buttonOK.Focus();
        }

        isOpen = true;
    }

    private void InputBoxForm_FormClosing_1(object sender, FormClosingEventArgs e) {
        isOpen = false;
    }

    public void YesNoSetup(string title, string message, string yesText = "Yes", string NoText = "No") {
        TitleLabel.Text = title;

        labelGeneric.Height += 25;
        labelGeneric.Visible = true;
        labelGeneric.Text = message;

        buttonCancel.Text = NoText;
        buttonOK.Text = yesText;

        textBoxInput.Visible = false;
    }

    public static InputBoxForm OKBOX(string title, string message, string okText = "OK") {
        InputBoxForm wBox = new InputBoxForm();

        wBox.TitleLabel.Text = title;
        wBox.TitleLabel.ForeColor = Color.Crimson;
        wBox.labelGeneric.Height += 25;
        wBox.Width += 50;
        wBox.richTextBox1.Width += 50;
        wBox.labelGeneric.Visible = true;

        wBox.labelGeneric.Text = message;
        wBox.buttonCancel.Text = okText;

        wBox.textBoxInput.Visible = false;
        wBox.buttonOK.Visible = false;

        wBox.labelGeneric.Visible = false;

        wBox.buttonNoAll.Visible = false;
        wBox.buttonYesAll.Visible = false;

        return wBox;
    }

    public static bool WarningBox(string title, string message, string yesText = "Yes", string NoText = "No") {
        InputBoxForm wBox = new InputBoxForm();
        wBox.YesNoSetup(title, message, yesText, NoText);

        DialogResult result = wBox.ShowDialog();

        if (result != DialogResult.OK)
            return true;

        return false;
    }


    //end class
}

