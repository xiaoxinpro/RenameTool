﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RenameTool
{
    public class FilePathRule
    {
        #region 公共属性
        public string Name { get; set; }

        public static int FileLength { get; private set; } = 0;
        public virtual int RunCount { get; protected set; } = 0;
        #endregion

        #region 公共方法
        public virtual string Run(string strFileName)
        {
            return strFileName;
        }
        #endregion

        #region 静态字段
        private static List<FilePathRule> listFilePathRule = new List<FilePathRule>();
        private static bool isExtension = false;
        private static string strExtension = "";
        #endregion

        #region 静态函数
        public static void ForceExtension(bool isEnable, string strExt = "")
        {
            isExtension = isEnable;
            if (strExt.Length > 0)
            {
                strExtension = strExt.IndexOf(".") == 0 ? strExt : "." + strExt;
            }
            else
            {
                strExtension = strExt;
            }
        }

        public static void Rename(Dictionary<string, string> dictPath)
        {
            FileLength = dictPath.Count;
            string[] arrKey = dictPath.Keys.ToArray();
            foreach (string key in arrKey)
            {
                StringBuilder sbFileName = new StringBuilder();
                string fileName = Path.GetFileNameWithoutExtension(key);
                foreach (FilePathRule rule in listFilePathRule)
                {
                    if (rule is FilePathRuleText)
                    {
                        sbFileName.Append(((FilePathRuleText)rule).Run(fileName));
                    }
                    else if (rule is FilePathRuleRegex)
                    {
                        sbFileName.Append(((FilePathRuleRegex)rule).Run(fileName));
                    }
                    else if (rule is FilePathRuleNumber)
                    {
                        sbFileName.Append(((FilePathRuleNumber)rule).Run(fileName));
                    }
                    else
                    {
                        sbFileName.Append(rule.Run(fileName));
                    }
                }
                string strExt;
                if (isExtension)
                {
                    strExt = strExtension;
                }
                else
                {
                    strExt = Path.GetExtension(key);
                }
                dictPath[key] = Path.GetDirectoryName(key) + @"\" + sbFileName.ToString() + strExt;
            }
        }

        public static void Add(FilePathRule rule)
        {
            if (rule != null)
            {
                listFilePathRule.Add(rule);
            }
        }

        public static int RuleCount()
        {
            return listFilePathRule.Count;
        }

        public static void Clear()
        {
            listFilePathRule.Clear();
        }

        public static void Remove(int index)
        {
            if (index < listFilePathRule.Count)
            {
                listFilePathRule.RemoveAt(index);
            }
        }

        public static void Remove(string ruleName)
        {
            for (int i = 0; i < listFilePathRule.Count; i++)
            {
                if(listFilePathRule[i].Name == ruleName)
                {
                    Remove(i);
                    break;
                }
            }
        }

        public static FilePathRule GetRule(int index)
        {
            if (index < listFilePathRule.Count)
            {
                return listFilePathRule[index];
            }
            else
            {
                return null;
            }
        }

        public static FilePathRule GetRule(string ruleName)
        {
            for (int i = 0; i < listFilePathRule.Count; i++)
            {
                if (listFilePathRule[i].Name == ruleName)
                {
                    return GetRule(i);
                }
            }
            return null;
        }

        public static void EditRule(int index, FilePathRule rule)
        {
            if (index < listFilePathRule.Count)
            {
                listFilePathRule[index] = rule;
            }
        }

        public static void EditRule(string ruleName, FilePathRule rule)
        {
            for (int i = 0; i < listFilePathRule.Count; i++)
            {
                if (listFilePathRule[i].Name == ruleName)
                {
                    EditRule(i, rule);
                }
            }
        }

        #endregion


    }

    public class FilePathRuleText : FilePathRule
    {
        public string Text { get; set; }
        public override int RunCount { get; protected set; } = 0;

        public FilePathRuleText(string name, string text = "")
        {
            Name = name;
            Text = text;
            RunCount = 0;
        }

        public override string Run(string strFileName)
        {
            RunCount++;
            return base.Run(Text);
        }
    }

    public class FilePathRuleRegex : FilePathRule
    {
        public string Pattern { get; set; }
        public override int RunCount { get; protected set; } = 0;

        public FilePathRuleRegex(string name, string regex = "")
        {
            Name = name;
            Pattern = regex;
            RunCount = 0;
        }

        public override string Run(string strFileName)
        {
            RunCount++;
            return base.Run(Regex.Match(strFileName, Pattern).Value);
        }
    }

    public class FilePathRuleNumber : FilePathRule
    {
        public decimal Start { get; set; }
        public decimal Step { get; set; }
        public bool IsSamp { get; set; }
        public override int RunCount { get; protected set; } = 0;

        public FilePathRuleNumber(string name, decimal start = 1, decimal step = 1, bool isSamp = false)
        {
            Name = name;
            Start = start;
            Step = step;
            IsSamp = isSamp;
            RunCount = 0;
        }

        public override string Run(string strFileName)
        {
            int len = FileLength.ToString().Length;
            decimal cnt = Start + Step * RunCount++;
            return base.Run(IsSamp ? cnt.ToString().PadLeft(len, '0') : cnt.ToString());
        }
    }
}
