using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameTool
{
    public class FilePathRename
    {
        public static void Run(Dictionary<string,string>dictPath, out string err)
        {
            err = "";
            string[] arrPath = dictPath.Keys.ToArray();
            foreach (string item in arrPath)
            {
                if (item == dictPath[item])
                {
                    return;
                }
                else if (File.Exists(item) && !File.Exists(dictPath[item]))
                {
                    try
                    {
                        File.Move(item, dictPath[item]);
                        dictPath.Remove(item);
                    }
                    catch (Exception e)
                    {
                        err += item + " -> " + dictPath[item] + " : " + e.Message + "\r\n";
                    }
                }
                else if (!File.Exists(item))
                {
                    err += item + " -> " + dictPath[item] + " : " + "目标文件不存在。" + "\r\n";
                }
                else
                {
                    err += item + " -> " + dictPath[item] + " : " + "已存在即将命名的文件。" + "\r\n";
                }
            }
        }

        public static void Run(string oldPath, string newPath, out string err)
        {
            err = "";
            if (oldPath == newPath)
            {
                return;
            }
            else if (File.Exists(oldPath) && !File.Exists(newPath))
            {
                try
                {
                    File.Move(oldPath, newPath);
                }
                catch (Exception e)
                {
                    err = e.Message;
                }
            }
            else if (!File.Exists(oldPath))
            {
                err = "目标文件不存在。";
            }
            else
            {
                err = "已存在即将命名的文件。";
            }
        }
    }
}
