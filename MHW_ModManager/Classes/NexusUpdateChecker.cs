using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


public class NexusUpdateChecker {

    public static async void CheckForNewVersion() {

        string url = @"https://www.nexusmods.com/monsterhunterworld/mods/372?tab=files";

        //api access not released yet
        //string url = @"https://api.nexusmods.com/v1/games/monsterhunterworld/mods/372";
        string content = string.Empty;

        try {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream)) {
                content = reader.ReadToEnd();
            }

            //doin this nonsense bc cant use the api yet
            int idx = content.IndexOf("<meta property=\"twitter:data1\" content=\"");
            if (idx == -1)
                return;

            string versionString = content.Substring(idx).SubstringIndexOf("content").SubstringIndexOf("\"", 1);
            versionString = versionString.Substring(0, versionString.IndexOf('"'));

            float versionNum = float.Parse(versionString);


            if(versionNum <= MainForm.instance.modsData.version) {
                MainForm.instance.linkNewUpdate.Text = "You Have the Latest Version";
                MainForm.instance.linkNewUpdate.LinkColor = System.Drawing.Color.LawnGreen;
            }
            MainForm.instance.linkNewUpdate.Visible = true;

            Console.WriteLine(versionNum);
        } catch (Exception ex){
            Console.WriteLine("UpdateCheckFailed\n" + ex.Message);
            MainForm.instance.linkNewUpdate.Text = "Check For Updates";
            MainForm.instance.linkNewUpdate.LinkColor = System.Drawing.Color.PaleTurquoise;
            MainForm.instance.linkNewUpdate.Visible = true;
        }
    }

}

