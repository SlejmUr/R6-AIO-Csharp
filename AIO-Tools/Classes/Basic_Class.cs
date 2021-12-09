using System.IO;
namespace AIO_Tools.Classes
{
    public class Utils
    {
        //All Pictures Name Currently
        public string[] picturesNames = { "vanilla", "blackice", "dustline",
            "skullrain", "redcrow", "velvetshell", "health",
            "bloodorchid", "whitenoise", "chimera" , "grimsky",
        "Outbreak","Mad_House_Event","parabellum","windbastion",
        "burnthorizon","phantomsight","emberrise","shiftingtides",
            "rainbowismagic","Showdown","doktorscurse","roadtosi",
        "voidedge","steelwave","neondawn","Mute_protocol","Telly",
        "Mute","shadowlegacy","GrandLarceny","roadtosi2021",
        "CrimsonHeist","northstar","CrystalGuard","rainbowismagic",
        "evn_quarantine","Y6S3_EVN_MIX","highcalibre","Placeholder","Placeholder2","base"};
        public static string Version = "20211209.0";
        private static readonly string extractPath = Directory.GetCurrentDirectory();
        public static readonly string datasDB = @"URI=file:" + extractPath + "\\Data\\DataBase\\datas.db";
        public static readonly string allDB = @"URI=file:" + extractPath + "\\Data\\DataBase\\all.db";
    }
}
