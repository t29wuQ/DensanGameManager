using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DensanGameManager
{
    public static class DataEdit
    {
        static readonly string PATH = "./gamelist.ini";

        public static void AddGame(Game game)
        {
            File.AppendAllText(PATH, "[" + game.Title + "]" + Environment.NewLine);
            File.AppendAllText(PATH, "GamePath=" + game.Path + Environment.NewLine);
            File.AppendAllText(PATH, "GameImagePath=" + game.ImagePath + Environment.NewLine);
            File.AppendAllText(PATH, "Info=" + game.Info + Environment.NewLine + Environment.NewLine);
        }

        public static List<Game> LoadGameList()
        {
            IniFile ini = new IniFile(Environment.CurrentDirectory + "\\gamelist.ini");
            string[] sections = ini.GetSections();
            List<Game> gameList = new List<Game>();
            foreach (string section in sections)
            {
                string path = "", imagePath = "", info = "";
                foreach(string key in ini.GetKeys(section))
                {
                    switch(key)
                    {
                        case "GamePath":
                            path = ini[section, key];
                            break;
                        case "GameImagePath":
                            imagePath = ini[section, key];
                            break;
                        case "Info":
                            info = ini[section, key];
                            break;
                    }
                }
                gameList.Add(new Game() { Title = section, Path = path, ImagePath = imagePath, Info = info });
            }
            return gameList;
        }
    }
}