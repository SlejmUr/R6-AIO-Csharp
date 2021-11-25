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
        "evn_quarantine","Y6S3_EVN_MIX","Placeholder","Placeholder2","base"};
        public static string Version = "DEV-2021112X.X";
        private readonly string extractPath = Directory.GetCurrentDirectory();
        public readonly string datasDB = @"URI=file:" + extractPath + "\\Data\\DataBase\\datas.db";
        public readonly string allDB = @"URI=file:" + extractPath + "\\Data\\DataBase\\all.db";
    }
}
