using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Initialization
{
    internal interface ITUI
    {
        void FullUI();
        void NotificationUI();
        void MessageUI();
        void ActionUI();
        void InventoryUI();
        void CharacterStatsUI();
        void MapUI();
        void QuestsUI();


        class UI()
        {
            public void FullUI()
            {
                WriteLine(@"   ________________________________________________________________________________________________________________   ");
                WriteLine(@" /__==========================================/\==================================================================__\ ");
                WriteLine(@"/|Text input:                                 ||Notifications:                                                      |\");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"|__===========================================\/==========================================_/======================__/|");
                WriteLine(@"||(M)ovement        (O)bservation      (R)un  /                                           |\_  Character Quests:  _/_|");
                WriteLine(@"||                                           /                                            |_\|\__|__=============__\_|");
                WriteLine(@"||                             __=========__|_____________________________________________|__\_|/|List:             ||");
                WriteLine(@"||                             |Text output:|                                                 \ \|                  ||");
                WriteLine(@"||(C)onversation:              |__========__\                                                  \ |                  ||");
                WriteLine(@"||_____________________________|_____________\__________________________________________________\|                  ||");
                WriteLine(@"|__============================================================================================__|                  ||");
                WriteLine(@"|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\|                  ||");
                WriteLine(@"||Inventory:                                  ||Map(7*8):                                        |                  ||");
                WriteLine(@"||                                            ||                                                 |                  ||");
                WriteLine(@"||                                            ||                                                 |                  ||");
                WriteLine(@"||                                            ||                                                 |                  ||");
                WriteLine(@"||                                            ||                                                 |                  ||");
                WriteLine(@"||                                            ||                                                 |                  ||");
                WriteLine(@"||                                            ||                                                 |                  ||");
                WriteLine(@"||                                            ||                                                 |                  /|");
                WriteLine(@"||                                            |\                                                 |                 / |");
                WriteLine(@"||                                            |__\===================/===========================^================/__|");
                WriteLine(@"||                                            ||Character Statistics/                                               ||");
                WriteLine(@"||                                            |__================__/                                                ||");
                WriteLine(@"||                                            ||/                                                                   ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"||                                            ||                                                                    ||");
                WriteLine(@"|\                                            ||                                                                    /|");
                WriteLine(@"| \                                           /\                                                                   / |");
                WriteLine(@"|__\=========================================/==\=================================================================/__|");
            }

            public void NotificationUI()
            {
                WriteLine(@"/\==================================================================__\ ");
                WriteLine(@"||Notifications:                                                      |\");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"\/==========================================_/======================__/|");
                WriteLine(@"");
            }

            public void MessageUI()
            {
                WriteLine(@" /__==========================================/\");
                WriteLine(@"/|Text input:                                 ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"|__===========================================\/");
                WriteLine(@"");
            }

            public void ActionUI()
            {
                WriteLine(@"|__===========================================/\==========================================_/=====|");
                WriteLine(@"||(M);ovement        (O);bservation  (R);etreat  /                                           |\_ |");
                WriteLine(@"||                                           /                                            |_\|\__|");
                WriteLine(@"||                             __=========__|_____________________________________________|__\_|/|");
                WriteLine(@"||                             |Text output:|                                                 \ \|");
                WriteLine(@"||(C);onversation:              |__========__\                                                  \|");
                WriteLine(@"||_____________________________|_____________\__________________________________________________\|");
                WriteLine(@"");
            }

            public void InventoryUI()
            {
                WriteLine(@"|__=============================================");
                WriteLine(@"|/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/");
                WriteLine(@"||Inventory:                                  ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            |\");
                WriteLine(@"||                                            |_");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            |_");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"||                                            ||");
                WriteLine(@"|\                                            ||");
                WriteLine(@"| \                                           /\");
                WriteLine(@"|__\=========================================/==");
                WriteLine(@"   \____________________________________________");
                WriteLine(@"");
            }

            public void CharacterStatsUI()
            {
                WriteLine(@"|__\===================/===========================^================/__|");
                WriteLine(@"||Character Statistics/                                               ||");
                WriteLine(@"|__================__/                                                ||");
                WriteLine(@"||/                                                                   ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    ||");
                WriteLine(@"||                                                                    /|");
                WriteLine(@"/\                                                                   / |");
                WriteLine(@"==\=================================================================/__|");
                WriteLine(@"____________________________________________________________________/   ");
                WriteLine(@"");
            }

            public void MapUI()
            {
                WriteLine(@"=================================================__|");
                WriteLine(@"\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\|");
                WriteLine(@"||Map(7*8);:                                       |");
                WriteLine(@"||                                                 |");
                WriteLine(@"||                                                 |");
                WriteLine(@"||                                                 |");
                WriteLine(@"||                                                 |");
                WriteLine(@"||                                                 |");
                WriteLine(@"||                                                 |");
                WriteLine(@"||                                                 |");
                WriteLine(@"|\                                                 |");
                WriteLine(@"|__\===================/===========================^");
                WriteLine(@"");
            }

            public void QuestsUI()
            {
                WriteLine(@"===================__/|");
                WriteLine(@"Character Quests:  _/_|");
                WriteLine(@"__|__=============__\_|");
                WriteLine(@"|/|List:             ||");
                WriteLine(@" \|                  ||");
                WriteLine(@"\ |                  ||");
                WriteLine(@"_\|                  ||");
                WriteLine(@"__|                  ||");
                WriteLine(@"/\|                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  ||");
                WriteLine(@"  |                  /|");
                WriteLine(@"  |                 / |");
                WriteLine(@"==^================/__|");
            }
        }
    }
}

