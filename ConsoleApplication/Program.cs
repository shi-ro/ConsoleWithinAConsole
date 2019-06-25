using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        private static  string Mode = "Console";
        private static string SubMode = "";
        private static List<string> ConsoleLines = new List<string>();
        static void Main(string[] args)
        {

            Console.WindowHeight = 25;
            Console.WindowWidth = 81;
            Console.BufferHeight = 25;
            Console.BufferWidth = 81;
            for (int i = 0; i < 19; i++)
            {
                ConsoleLines.Add(" ");
            }
            ConsoleLines.Add(" >");
            while (true)
            {
                DrawBorders();
                Console.SetCursorPosition(5, 22);
                string ipt = Console.ReadLine();
                string resp = TakeInput(ipt);
                if (resp.Length > 0)
                {
                    ConsoleLines.Add($" > {ipt}");
                    ConsoleLines.Add($"   {resp}");
                    ConsoleLines.Add(" >");
                    ConsoleLines.Remove(" >");
                    ConsoleLines.RemoveAt(0);
                    ConsoleLines.RemoveAt(0);
                }
            }
        }
        //12289 -> 、、
        //12290 -> 。。
        //12291 -> 〃〃
        //12295 -> 〇〇
        //12296 -> 〈〈
        //12297 -> 〉〉
        //12298 -> 《《
        //12299 -> 》》
        //12300 -> 「「
        //12301 -> 」」
        //12302 -> 『『
        //12303 -> 』』
        //12304 -> 【【
        //12305 -> 】】
        //12306 -> 〒〒
        //12307 -> 〓〓
        //12308 -> 〔〔
        //12309 -> 〕〕
        
        //9472 -> ─
        //9473 -> ━
        //9474 -> │
        //9475 -> ┃
        //9484 -> ┌
        //9487 -> ┏
        //9488 -> ┐
        //9491 -> ┓
        //9492 -> └
        //9495 -> ┗
        //9496 -> ┘
        //9499 -> ┛
        //9500 -> ├
        //9501 -> ┝
        //9504 -> ┠
        //9507 -> ┣
        //9508 -> ┤
        //9509 -> ┥
        //9512 -> ┨
        //9515 -> ┫
        //9516 -> ┬
        //9519 -> ┯
        //9520 -> ┰
        //9523 -> ┳
        //9524 -> ┴
        //9527 -> ┷
        //9528 -> ┸
        //9531 -> ┻
        //9532 -> ┼
        //9535 -> ┿
        //9538 -> ╂
        //9547 -> ╋
        public static string TakeInput(string ipt)
        {
            return ipt;
        }

        public static string InsertIntoString(string original, string insert)
        {
            if (insert.Length > original.Length)
            {
                return insert.Replace(insert.Substring(original.Length), "");
            }
            string edit = original.Remove(original.Length-insert.Length);
            return insert + edit;
        }

        public static string m(string s, int num)
        {
            string ret = "";
            for (int i = 0; i < num; i++)
            {
                ret += s;
            }
            return ret;
        }

        public static void DrawBorders()
        {
            Console.WriteLine($"┏{m("━",78)}┓");
            Console.WriteLine($"┃  {InsertIntoString(m(" ",76),Mode)}┃");
            Console.WriteLine($"┣{m("━",78)}┫");
            for (int i = 0; i < 20; i++){Console.WriteLine($"┃ {InsertIntoString(m(" ",77), ConsoleLines[i])}┃");}
            Console.WriteLine($"┗{m("━",78)}┛");
        }
    }
}
