namespace лабораторная_4
{
    partial class FileManager
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДиректориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветоваяСхемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView = new System.Windows.Forms.TreeView();
            this.AmountOfElements = new System.Windows.Forms.Label();
            this.labelWay = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.goBackButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДиректориюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьДиректориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.aboutMenuStrip,
            this.closeMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содатьФайлToolStripMenuItem,
            this.создатьДиректориюToolStripMenuItem,
            this.скопироватьToolStripMenuItem,
            this.переименоватьToolStripMenuItem,
            this.openMenuStrip,
            this.удалитьToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // содатьФайлToolStripMenuItem
            // 
            this.содатьФайлToolStripMenuItem.Name = "содатьФайлToolStripMenuItem";
            this.содатьФайлToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.содатьФайлToolStripMenuItem.Text = "Создать файл ";
            this.содатьФайлToolStripMenuItem.Click += new System.EventHandler(this.создатьФайлToolStripMenuItem_Click);
            // 
            // создатьДиректориюToolStripMenuItem
            // 
            this.создатьДиректориюToolStripMenuItem.Name = "создатьДиректориюToolStripMenuItem";
            this.создатьДиректориюToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.создатьДиректориюToolStripMenuItem.Text = "Создать директорию";
            // 
            // скопироватьToolStripMenuItem
            // 
            this.скопироватьToolStripMenuItem.Name = "скопироватьToolStripMenuItem";
            this.скопироватьToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.скопироватьToolStripMenuItem.Text = "Скопировать";
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            // 
            // openMenuStrip
            // 
            this.openMenuStrip.Name = "openMenuStrip";
            this.openMenuStrip.Size = new System.Drawing.Size(287, 34);
            this.openMenuStrip.Text = "Открыть";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветоваяСхемаToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // цветоваяСхемаToolStripMenuItem
            // 
            this.цветоваяСхемаToolStripMenuItem.Name = "цветоваяСхемаToolStripMenuItem";
            this.цветоваяСхемаToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.цветоваяСхемаToolStripMenuItem.Text = "Цветовая схема";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // aboutMenuStrip
            // 
            this.aboutMenuStrip.Name = "aboutMenuStrip";
            this.aboutMenuStrip.Size = new System.Drawing.Size(141, 29);
            this.aboutMenuStrip.Text = "О программе";
            this.aboutMenuStrip.Click += new System.EventHandler(this.Ef_menu_about_Click);
            // 
            // closeMenuStrip
            // 
            this.closeMenuStrip.Name = "closeMenuStrip";
            this.closeMenuStrip.Size = new System.Drawing.Size(204, 29);
            this.closeMenuStrip.Text = "Выйти из программы";
            this.closeMenuStrip.Click += new System.EventHandler(this.выйтиИзПрограммыToolStripMenuItem_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList1;
            this.listView.Location = new System.Drawing.Point(336, 120);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(839, 446);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "file.png");
            this.imageList1.Images.SetKeyName(2, "pdf.png");
            this.imageList1.Images.SetKeyName(3, "exe.png");
            this.imageList1.Images.SetKeyName(4, "png.png");
            this.imageList1.Images.SetKeyName(5, "txt.png");
            this.imageList1.Images.SetKeyName(6, "doc.png");
            this.imageList1.Images.SetKeyName(7, "mp3.png");
            this.imageList1.Images.SetKeyName(8, "mp4.png");
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(0, 120);
            this.treeView.Name = "treeView";
            this.treeView.ShowNodeToolTips = true;
            this.treeView.Size = new System.Drawing.Size(318, 446);
            this.treeView.TabIndex = 2;
//            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Ef_treeView_AfterSelect);
            // 
            // AmountOfElements
            // 
            this.AmountOfElements.AutoSize = true;
            this.AmountOfElements.Location = new System.Drawing.Point(12, 88);
            this.AmountOfElements.Name = "AmountOfElements";
            this.AmountOfElements.Size = new System.Drawing.Size(196, 20);
            this.AmountOfElements.TabIndex = 3;
            this.AmountOfElements.Text = "Количество элементов: ";
            // 
            // labelWay
            // 
            this.labelWay.AutoSize = true;
            this.labelWay.Location = new System.Drawing.Point(332, 88);
            this.labelWay.Name = "labelWay";
            this.labelWay.Size = new System.Drawing.Size(54, 20);
            this.labelWay.TabIndex = 4;
            this.labelWay.Text = "Путь: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackButton,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1175, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // goBackButton
            // 
            this.goBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBackButton.Image = ((System.Drawing.Image)(resources.GetObject("goBackButton.Image")));
            this.goBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(34, 28);
            this.goBackButton.Text = "toolStripButton1";
            this.goBackButton.Click += new System.EventHandler(this.goBack_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьФайлToolStripMenuItem,
            this.создатьДиректориюToolStripMenuItem1,
            this.переименоватьToolStripMenuItem1,
            this.копироватьToolStripMenuItem,
            this.переместитьToolStripMenuItem,
            this.удалитьФайлToolStripMenuItem,
            this.удалитьДиректориюToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 228);
            // 
            // создатьФайлToolStripMenuItem
            // 
            this.создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            this.создатьФайлToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.создатьФайлToolStripMenuItem.Text = "Создать файл";
            // 
            // создатьДиректориюToolStripMenuItem1
            // 
            this.создатьДиректориюToolStripMenuItem1.Name = "создатьДиректориюToolStripMenuItem1";
            this.создатьДиректориюToolStripMenuItem1.Size = new System.Drawing.Size(257, 32);
            this.создатьДиректориюToolStripMenuItem1.Text = "Создать директорию";
            // 
            // переименоватьToolStripMenuItem1
            // 
            this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
            this.переименоватьToolStripMenuItem1.Size = new System.Drawing.Size(257, 32);
            this.переименоватьToolStripMenuItem1.Text = "Переименовать";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            // 
            // удалитьФайлToolStripMenuItem
            // 
            this.удалитьФайлToolStripMenuItem.Name = "удалитьФайлToolStripMenuItem";
            this.удалитьФайлToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.удалитьФайлToolStripMenuItem.Text = "Удалить файл";
            // 
            // удалитьДиректориюToolStripMenuItem
            // 
            this.удалитьДиректориюToolStripMenuItem.Name = "удалитьДиректориюToolStripMenuItem";
            this.удалитьДиректориюToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.удалитьДиректориюToolStripMenuItem.Text = "Удалить директорию";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(392, 88);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(771, 26);
            this.textBoxPath.TabIndex = 6;
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 567);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelWay);
            this.Controls.Add(this.AmountOfElements);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileManager";
            this.Text = "Файловый менеджер";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label AmountOfElements;
        private System.Windows.Forms.Label labelWay;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem содатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьДиректориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветоваяСхемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuStrip;
        private System.Windows.Forms.ToolStripButton goBackButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem closeMenuStrip;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьДиректориюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДиректориюToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPath;
    }
}

