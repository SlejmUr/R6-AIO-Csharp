using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIO_Tools.Classes;

namespace AIO_Tools.Forms
{
    public partial class StartingGame : Form
    {
        public StartingGame()
        {
            InitializeComponent();
        }
        private static readonly string datasdb = Utils.datasDB;
        private List<string> SeasonNames = new List<string>();
        private List<string> InstalledSeaons = new List<string>();
        private INI ini = new INI();
        private void StartGame_Load(object sender, EventArgs e)
        {
            FILLName();
            Logging.DebugLog("Seasonnames Count: " + SeasonNames.Count);
        }
        private void FILLName()
        {
            InstalledBox.Items.Clear();
            string pickgetnet;
            using var sqlconnection = new SQLiteConnection(datasdb);
            sqlconnection.Open();
            using var cmd = new SQLiteCommand(sqlconnection);
            cmd.CommandText = "SELECT pickgetnet FROM pick GROUP BY pick.pickgetnet ORDER BY pick.pickfoldername ASC";
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            {
                while (rdr.Read())
                {
                    pickgetnet = rdr["pickgetnet"].ToString();
                    InstalledBox.Items.Add(pickgetnet);
                    SeasonNames.Add(pickgetnet);
                    IsInstalled(pickgetnet);
                }
            }
        }
        private void IsInstalled(string SeasonName)
        {
            string installed =  ini.GetInstalledSeason_I(SeasonName);
            if (string.IsNullOrEmpty(installed))
            {
                InstalledBox.Items.Remove(SeasonName);
            }
            if (installed == "Installed")
            {
                int indx = InstalledBox.Items.IndexOf(SeasonName);
                InstalledBox.Items.Insert(indx, SeasonName + " Installed!");
                InstalledBox.Items.RemoveAt(indx+1);
                InstalledSeaons.Add(SeasonName);
            }
        }

        private void InstalledBox_IndexChanged(object sender, EventArgs e)
        {
            int indx = InstalledBox.SelectedIndex;
            string season = InstalledSeaons[indx].ToString();
            PathLabel.Text = ini.GetInstalledSeason_Path(season);
        }
    }
}
