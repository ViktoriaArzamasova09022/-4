using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace лабораторная_4
{
    public partial class FileManager : Form
    {
        private string filePath = "D:/";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public FileManager()
        {
            InitializeComponent();

            treeView.BeforeSelect += treeView1_BeforeSelect;
            treeView.BeforeExpand += treeView1_BeforeExpand;
            // заполняем дерево дисками
            FillDriveNodes();
        }

        protected override void OnLoad(EventArgs e)
        {
            textBoxPath.Text = filePath;
            loadFilesAndDirectories();
            //ClassForFileManager.SetLocalDrive(treeView);
            treeView.BeforeSelect += Ef_treeView_BeforeSelect;
            treeView.AfterSelect += Ef_treeView_AfterSelect;
            //closeMenuStrip.Click += выйтиИзПрограммыToolStripMenuItem_Click;
            //aboutMenuStrip.Click += Ef_menu_about_Click;
        }
        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath;
            FileAttributes fileAttr;

            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    listView.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        switch (files[i].Extension.ToUpper())
                        {
                            case ".MP3":
                                {
                                    listView.Items.Add(files[i].Name, 7);
                                    break;
                                }
                            case ".EXE":
                            case ".COM":
                                {
                                    listView.Items.Add(files[i].Name, 3);
                                    break;
                                }
                            case ".TXT":
                                {
                                    listView.Items.Add(files[i].Name, 5);
                                    break;
                                }
                            case ".XML":
                            case ".lnk":
                                {
                                    listView.Items.Add(files[i].Name, 1);
                                    break;
                                }
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                {
                                    listView.Items.Add(files[i].Name, 8);
                                    break;
                                }
                            case ".PDF":
                                {
                                    listView.Items.Add(files[i].Name, 2);
                                    break;
                                }
                            case ".DOC":
                            case ".DOCX":
                                {
                                    listView.Items.Add(files[i].Name, 6);
                                    break;
                                }
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                {
                                    listView.Items.Add(files[i].Name, 4);
                                    break;
                                }
                            default:
                                {
                                    listView.Items.Add(files[i].Name, 0);
                                    break;
                                }
                        }

                        for (int j = 0; j < dirs.Length; j++)
                        {
                            listView.Items.Add(dirs[j].Name, 0);
                        }
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        public void loadButtonAction()
        {         
            filePath = textBoxPath.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        private void Ef_menu_about_Click(object sender, EventArgs e)
        {
            string str = "Работу выполнила: Арзамасова Виктория 09-022";
            MessageBox.Show(str, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// Обработчик события выбора элемента в Tree View

        public void Ef_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string newPath = e.Node.FullPath;
            labelWay.Text = "Путь: ";
            textBoxPath.Text = newPath;
            if (e.Node.GetNodeCount(true) == 0)
            {
                ClassForFileManager.GetSubDir(e.Node, e.Node.FullPath);
            }

            ClassForFileManager.GetDirectories(e.Node.FullPath, listView);

            AmountOfElements.Text = $"Колличество эллементов: {listView.Items.Count}";

        }
        public void Ef_treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            //FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception)
            { }
        }

        private void выйтиИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены, что хотите выйти из программы?";
            string mesBox = "Выход";
            var result = MessageBox.Show(message, mesBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
            }       
        }
        private void listView_MouseDoubleClick(object sender, EventArgs e)
        {
            string _path = treeView.SelectedNode.FullPath + "\\" + listView.FocusedItem.Text;
            textBoxPath.Text = _path;
            //Проверка существования файла
            if (File.Exists(_path))
            {
                //Комманда для открытия файла приложением по умолчанию
                Process.Start(_path);
            }
            else
            {
                ClassForFileManager.SearchNode(treeView, _path);
                ClassForFileManager.GetDirectories(_path, listView);
            }
        }
        private void goBack_Click(object sender, EventArgs e)
        {
            goBack();
            loadFilesAndDirectories();
           // ClassForFileManager.GetDirectories(e.Node.FullPath, listView);
        }
        public void goBack()
        {
            try
            {
                // RemoveBackSlash();
                string path = textBoxPath.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                labelWay.Text = "Путь: ";
                listView.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBoxPath.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach(DirectoryInfo directory in dirs)
                {
                    listView.Items.Add(directory.Name);
                }
                FileInfo[] files = dir.GetFiles();
                foreach(FileInfo fileInfo in files)
                {
                    listView.Items.Add(fileInfo.Name);
                }
                textBoxPath.Text = path;
               // RemoveBackSlash();
            }
            catch
            {

            }
        }
        public void RemoveBackSlash()
        {
            string path = treeView.SelectedNode.FullPath + "\\" + listView.FocusedItem.Text;
            if (path.LastIndexOf("\\") == path.Length - 1)
            {
                labelWay.Text = "Путь: " + path.Substring(0, path.Length - 1);
            }

        }
        void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
        // событие перед выделением узла
        void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillTreeNode(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        // получаем все диски на компьютере
        private void FillDriveNodes()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillTreeNode(driveNode, drive.Name);
                    treeView.Nodes.Add(driveNode);
                }
            }
            catch (Exception) { }
        }
        // получаем дочерние узлы для определенного узла
        private void FillTreeNode(TreeNode driveNode, string path)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception) { }
        }
        private void создатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
