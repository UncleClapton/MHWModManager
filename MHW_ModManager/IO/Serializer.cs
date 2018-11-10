using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

public class Serializer {

    public static BinaryFormatter binaryFormatter = new BinaryFormatter();

    public static string GetMMDataFolder() => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\ModManagerData\\";

    public static string GetDataFilePath() => $"{GetMMDataFolder()}{modsDataFileName}";

    public static string GetModsCacheFolder() => GetMMDataFolder() + "ModsCache\\";

    public static string GetGameModFolder() => $"{MainForm.instance.modsData.gameDir.FixSlashes()}\\{MainForm.instance.modsData.modDir}";

    public static string GetExeDir() => Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

    public const string modsDataFileName = "mods.db";

    public static byte[] Serialize(object obj) {
        MemoryStream memoryStream = new MemoryStream();
        binaryFormatter.Serialize(memoryStream, obj);
        return memoryStream.ToArray();
    }

    public static object Deserialize(byte[] data) {
        MemoryStream memoryStream = new MemoryStream(data);

        return binaryFormatter.Deserialize(memoryStream);
    }




    public static void SaveObj(object obj, string path) {
        Directory.CreateDirectory(GetModsCacheFolder());

        File.WriteAllBytes(path, Serialize(obj));
    }

    public static object LoadObj(string path) {

        if (!File.Exists(path)) {
            Debug.WriteLine("save doesnt exist");
            return null;
        }

        byte[] data = File.ReadAllBytes(path);
        if (data.Length == 0)
            return null;

        object loadedObj = Deserialize(data);
        Debug.WriteLine("load success");

        return loadedObj;
    }

}
