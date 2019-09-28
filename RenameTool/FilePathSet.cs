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
        Dictionary<string, HashSet<string>> dicExtPath;
        #endregion

        #region 属性

        #endregion

        #region 构造函数
        public FilePathSet()
        {
            dicExtPath = new Dictionary<string, HashSet<string>>();
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
                getSetPath(Path.GetExtension(strPath)).Add(strPath);
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
                string strExt = Path.GetExtension(strPath);
                if (dicExtPath.TryGetValue(strExt, out HashSet<string> value))
                {
                    value.Remove(strPath);
                    if (value.Count == 0)
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
                dicExtPath.Remove(strExt);
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
                if (dicExtPath.TryGetValue(strExt, out HashSet<string> value))
                {
                    if (value.Count > 0)
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
        public string[] GetPath(string strExt)
        {
            if (dicExtPath.TryGetValue(strExt, out HashSet<string> value))
            {
                if (value.Count > 0)
                {
                    return value.ToArray<string>();
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
        public string[] GetPath()
        {
            HashSet<string> setPath = new HashSet<string>();
            foreach (KeyValuePair<string,HashSet<string>> item in dicExtPath)
            {
                if (item.Value.Count > 0)
                {
                    setPath.Union(item.Value);
                }
            }
            return setPath.ToArray();
        }
        #endregion

        #region 私有函数
        /// <summary>
        /// 获取指定扩展名的集合，没有则创建一个。
        /// </summary>
        /// <param name="strExt">扩展名</param>
        /// <returns></returns>
        private HashSet<string> getSetPath(string strExt)
        {
            if (dicExtPath.TryGetValue(strExt, out HashSet<string> value))
            {
                return value;
            }
            else
            {
                dicExtPath.Add(strExt, new HashSet<string>());
                return getSetPath(strExt);
            }
        }
        #endregion
    }
}
