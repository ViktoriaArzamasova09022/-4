using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Data;


namespace лабораторная_4
{
    class ClassForFileManager
    {
        
        // Получение списка дисков и создание узлов для TreeView
        public static void SetLocalDrive(TreeView tv)
        {
            DriveInfo[] lDrives = DriveInfo.GetDrives();
            foreach (DriveInfo item in lDrives)
            {
                TreeNode tn = new TreeNode(item.Name);
                tv.Nodes.Add(tn);
                GetSubDir(tn, tn.FullPath);               
            }
        }

        /// Получение каталогов и добавление их в ListView
        public static void GetDirectories(string path, ListView lv)
        {
            try
            {
                lv.Clear();
                string[] dirs = Directory.GetDirectories(path);                             
                // AddListViewItems(files, lv, 1);
                DirectoryInfo fileList;
                fileList = new DirectoryInfo(path);
                FileInfo[] files = fileList.GetFiles();              
                for (int i = 0; i < files.Length; i++)
                {                        
                    switch (files[i].Extension.ToUpper())
                    {
                        case ".MP3":
                            {
                                lv.Items.Add(files[i].Name, 7);                             
                                break;
                            }
                        case ".EXE":
                        case ".COM":
                            {
                                lv.Items.Add(files[i].Name, 3);
                                break;
                            }
                        case ".TXT":
                            {
                                lv.Items.Add(files[i].Name, 5);
                                break;
                            }
                        case ".XML":
                        case ".lnk":
                            {
                                lv.Items.Add(files[i].Name, 1);
                                break;
                            }
                        case ".MP4":
                        case ".AVI":
                        case ".MKV":
                            {
                                lv.Items.Add(files[i].Name, 8);
                                break;
                            }
                        case ".PDF":
                            {
                                lv.Items.Add(files[i].Name, 2);
                                break;
                            }
                        case ".DOC":
                        case ".DOCX":
                            {
                                lv.Items.Add(files[i].Name, 6);
                                break;
                            }
                        case ".PNG":
                        case ".JPG":
                        case ".JPEG":
                            {
                                lv.Items.Add(files[i].Name, 4);
                                break;
                            }
                        default:
                            {
                                lv.Items.Add(files[i].Name, 0);
                                break;
                            }
                    }
                }  
            }
            catch (Exception)
            {
                lv.Clear();
            }
        }
        // Получение под папок по указанному пути       
       public static void GetSubDir(TreeNode tn, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string item in dirs)
                {
                    string[] tmp = item.Split('\\');
                    TreeNode ntr = new TreeNode(tmp[tmp.Length - 1]);
                    tn.Nodes.Add(ntr);
                    tn.ExpandAll();
                }
            }
            catch (Exception)
            {
            }
        }
        // Поиск узла по пути и в случае нахождения - выбрать его     
        public static void SearchNode(TreeView tv, string path)
        {
            TreeNode res = null;
            foreach (TreeNode tn in tv.Nodes)
            {
                Searching(tn.Nodes, path, ref res);
                if (res != null)
                {
                    tv.Focus();
                    tv.SelectedNode = res;
                    tn.ExpandAll();
                    return;
                }
            }
        }
        /// Функция для поиска в дочерних узлах дерева    
        private static void Searching(TreeNodeCollection tnc, string path, ref TreeNode res)
        {
            foreach (TreeNode tn in tnc)
            {
                if (tn.FullPath == path)
                {
                    res = tn;
                    tn.ExpandAll();
                }
                Searching(tn.Nodes, path, ref res);
            }
        }
    }
}
