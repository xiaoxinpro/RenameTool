using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenameTool
{
    /// <summary>
    /// 文件路径集合类
    /// </summary>
    public class FilePathSet
    {
        #region 私有字段
        /// <summary>
        /// 基础数据结构dict(扩展名,dict(原文件名,新文件名))
        /// </summary>
        Dictionary<string, Dictionary<string, string>> dicExtPath;
        #endregion

        #region 属性

        #endregion

        #region 构造函数
        public FilePathSet()
        {
            dicExtPath = new Dictionary<string, Dictionary<string, string>>();
        }
        #endregion

        #region 公共函数
        /// <summary>
        /// 添加文件到集合中
        /// </summary>
        /// <param name="strPaths">文件完整路径</param>
        public void Add(params string[] strPaths)
        {
            foreach (string strPath in strPaths)
            {
                Dictionary<string, string> dictPath = getSetPath(getPathExt(strPath));
                if (!dictPath.TryGetValue(strPath, out string value))
                {
                    dictPath.Add(strPath, "");
                }
            }
        }

        /// <summary>
        /// 删除指定文件路径
        /// </summary>
        /// <param name="strPaths">文件完整路径</param>
        public void RemovePath(params string[] strPaths)
        {
            foreach (string strPath in strPaths)
            {
                string strExt = getPathExt(strPath);
                if (dicExtPath.TryGetValue(strExt, out Dictionary<string, string> dictPath))
                {
                    dictPath.Remove(strPath);
                    if (dictPath.Count == 0)
                    {
                        dicExtPath.Remove(strExt);
                    }
                }
            }
        }

        /// <summary>
        /// 删除指定扩展名的全部文件路径
        /// </summary>
        /// <param name="strExts">扩展名</param>
        public void RemoveExt(params string[] strExts)
        {
            foreach (string strExt in strExts)
            {
                dicExtPath.Remove(strExt.ToLower().Trim());
            }
        }

        /// <summary>
        /// 清空全部文件路径
        /// </summary>
        public void Clear()
        {
            dicExtPath.Clear();
        }

        /// <summary>
        /// 获取集合中的所有扩展名
        /// </summary>
        /// <returns>返回扩展名数组</returns>
        public string[] GetExtension()
        {
            List<string> listExt = new List<string>();
            foreach (string strExt in dicExtPath.Keys.ToArray())
            {
                if (dicExtPath.TryGetValue(strExt, out Dictionary<string, string> dictPath))
                {
                    if (dictPath.Count > 0)
                    {
                        listExt.Add(strExt);
                    }
                    else
                    {
                        dicExtPath.Remove(strExt);
                    }
                }
            }
            return listExt.ToArray();
        }

        /// <summary>
        /// 获取指定扩展名的全部文件路径
        /// </summary>
        /// <param name="strExt"></param>
        /// <returns>路径数组</returns>
        public string[] GetPath(string strExt, bool isOldPath = true)
        {
            if (dicExtPath.TryGetValue(strExt, out Dictionary<string, string> dictPath))
            {
                if (dictPath.Count > 0)
                {
                    return isOldPath ? dictPath.Keys.ToArray() : dictPath.Values.ToArray();
                }
                else
                {
                    dicExtPath.Remove(strExt);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取全部文件路径
        /// </summary>
        /// <returns>路径数组</returns>
        public string[] GetPath(bool isOldPath = true)
        {
            List<string> listPath = new List<string>();
            foreach (KeyValuePair<string,Dictionary<string, string>> item in dicExtPath)
            {
                if (item.Value.Count > 0)
                {
                    listPath.AddRange(isOldPath ? item.Value.Keys.ToArray() : item.Value.Values.ToArray());
                }
            }
            return listPath.ToArray();
        }

        /// <summary>
        /// 获取扩展名数量
        /// </summary>
        /// <returns></returns>
        public int CountExt()
        {
            return dicExtPath.Count;
        }

        /// <summary>
        /// 获取指定扩展名的文件数量
        /// </summary>
        /// <param name="strExt">扩展名</param>
        /// <returns></returns>
        public int CountPath(string strExt)
        {
            if (dicExtPath.TryGetValue(strExt.ToLower().Trim(), out Dictionary<string, string> dictPath))
            {
                if (dictPath.Count == 0)
                {
                    RemoveExt(strExt);
                }
                return dictPath.Count;
            }
            return 0;
        }

        /// <summary>
        /// 获取全部文件数量
        /// </summary>
        /// <returns></returns>
        public int CountPath()
        {
            int ret = 0;
            foreach (string strExt in dicExtPath.Keys.ToArray())
            {
                ret += CountPath(strExt);
            }
            return ret;
        }
        #endregion

        #region 私有函数
        /// <summary>
        /// 获取指定扩展名的集合，没有则创建一个。
        /// </summary>
        /// <param name="strExt">扩展名</param>
        /// <returns></returns>
        private Dictionary<string, string> getSetPath(string strExt)
        {
            if (dicExtPath.TryGetValue(strExt, out Dictionary<string, string> dictPath))
            {
                return dictPath;
            }
            else
            {
                dicExtPath.Add(strExt, new Dictionary<string, string>());
                return getSetPath(strExt);
            }
        }

        /// <summary>
        /// 获取文件路径中的扩展名
        /// </summary>
        /// <param name="strPath">文件路径</param>
        /// <returns></returns>
        private string getPathExt(string strPath)
        {
            return Path.GetExtension(strPath).Trim().ToLower();
        }
        #endregion
    }
}
