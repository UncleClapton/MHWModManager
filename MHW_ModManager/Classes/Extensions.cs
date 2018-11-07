using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class Extensions {

    public static string FixSlashes(this string str) {
        string retStr = str.Replace('/', '\\');
        if (retStr[retStr.Length - 1] == '\\') {
            retStr = retStr.Substring(0, retStr.Length - 1);
        }

        return retStr;
    }



    public static void AppendText(this RichTextBox box, string text, Color color, bool addNewLine = false) {
        box.SuspendLayout();
        box.SelectionColor = color;
        box.AppendText(addNewLine
            ? $"{text}{Environment.NewLine}"
            : text);
        box.ScrollToCaret();
        box.ResumeLayout();
    }

    public static string ToStringFormat<T>(this IEnumerable<T> array) {
        string final = "[" + array.ElementAt(0).ToString();
        for (int i = 0; ++i < array.Count();) {
            final += ", " + array.ElementAt(i).ToString();
        }
        final += "]";

        return final;
    }

}

