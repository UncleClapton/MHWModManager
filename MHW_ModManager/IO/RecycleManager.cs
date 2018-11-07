using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using Shell32; //Reference Microsoft Shell Controls And Automation on the COM tab.
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.FileIO;


class RecycleManager {

    private static Shell Shl;
    private const long ssfBITBUCKET = 10;
    private const int recycleNAME = 0;
    private const int recyclePATH = 1;

    public static bool Restore(string Item) {
        Shl = new Shell();
        Folder Recycler = Shl.NameSpace(10);
        string lowerItem = Item.ToLower();
        for (int i = 0; i < Recycler.Items().Count; i++) {
            FolderItem FI = Recycler.Items().Item(i);
            string FileName = Recycler.GetDetailsOf(FI, 0);
            if (Path.GetExtension(FileName) == "") FileName += Path.GetExtension(FI.Path);
            //Necessary for systems with hidden file extensions.
            string FilePath = Recycler.GetDetailsOf(FI, 1);
            string combinedPath = Path.Combine(FilePath, FileName).ToLower();
            if (lowerItem == combinedPath) {
                DoVerb(FI, "ESTORE");
                return true;
            }
        }
        return false;
    }
    private static bool DoVerb(FolderItem Item, string Verb) {
        foreach (FolderItemVerb FIVerb in Item.Verbs()) {
            if (FIVerb.Name.ToUpper().Contains(Verb.ToUpper())) {
                FIVerb.DoIt();
                return true;
            }
        }
        return false;
    }


    public static void DeleteNoWarn(string path) {
        FileSystem.DeleteFile(path,
                                UIOption.OnlyErrorDialogs,
                                RecycleOption.SendToRecycleBin,
                                UICancelOption.ThrowException);
    }

    public static bool DeleteWarn(string path) {
        try {
            FileSystem.DeleteFile(path,
                                    UIOption.AllDialogs,
                                    RecycleOption.SendToRecycleBin,
                                    UICancelOption.ThrowException);
            return true;
        } catch {
            return false;
        }
    }

    public static void DeleteDirNoWarn(string path) {
        FileSystem.DeleteDirectory(path,
                                UIOption.OnlyErrorDialogs,
                                RecycleOption.SendToRecycleBin,
                                UICancelOption.ThrowException);
    }

    public static bool DeleteDirWarn(string path) {
        try {
            FileSystem.DeleteDirectory(path,
                                    UIOption.AllDialogs,
                                    RecycleOption.SendToRecycleBin,
                                    UICancelOption.ThrowException);
            return true;
        } catch {
            return false;
        }
    }

}
