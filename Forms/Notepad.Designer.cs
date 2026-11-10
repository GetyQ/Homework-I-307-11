namespace Lesson4._1
{
    partial class Notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileStripMenu = new ToolStripMenuItem();
            openStripMenu = new ToolStripMenuItem();
            createStripMenu = new ToolStripMenuItem();
            saveStripMenu = new ToolStripMenuItem();
            saveAsToolMenu = new ToolStripMenuItem();
            linkParametrsStripMenu = new ToolStripMenuItem();
            printStripMenu = new ToolStripMenuItem();
            changeStripMenu = new ToolStripMenuItem();
            cancleStripMenu = new ToolStripMenuItem();
            cutStripMenu = new ToolStripMenuItem();
            copyStripMenu = new ToolStripMenuItem();
            pasteToolMenu = new ToolStripMenuItem();
            DeleteStripMenu = new ToolStripMenuItem();
            bingStripMenu = new ToolStripMenuItem();
            findStripMenu = new ToolStripMenuItem();
            find_nextStripMenu = new ToolStripMenuItem();
            replaceStripMenu = new ToolStripMenuItem();
            gotoStripMenu = new ToolStripMenuItem();
            selectallStripMenu = new ToolStripMenuItem();
            date_and_timeStripMenu = new ToolStripMenuItem();
            formStripMenu = new ToolStripMenuItem();
            transferStripMenu = new ToolStripMenuItem();
            cipherStripMenu = new ToolStripMenuItem();
            viewStripMenu = new ToolStripMenuItem();
            scaleStripMenu = new ToolStripMenuItem();
            uoStripMenu = new ToolStripMenuItem();
            downStripMenu = new ToolStripMenuItem();
            restoreStripMenu = new ToolStripMenuItem();
            stringStripMenu = new ToolStripMenuItem();
            referenceStripMenu = new ToolStripMenuItem();
            watch_refToolStripMenuItem = new ToolStripMenuItem();
            aboutStripMenu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(776, 397);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileStripMenu, changeStripMenu, formStripMenu, viewStripMenu, referenceStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenu
            // 
            fileStripMenu.DropDownItems.AddRange(new ToolStripItem[] { openStripMenu, createStripMenu, saveStripMenu, saveAsToolMenu, linkParametrsStripMenu, printStripMenu });
            fileStripMenu.Name = "fileStripMenu";
            fileStripMenu.Size = new Size(48, 20);
            fileStripMenu.Text = "&Файл";
            // 
            // openStripMenu
            // 
            openStripMenu.Name = "openStripMenu";
            openStripMenu.Size = new Size(195, 22);
            openStripMenu.Text = "&Открыть";
            // 
            // createStripMenu
            // 
            createStripMenu.Name = "createStripMenu";
            createStripMenu.Size = new Size(195, 22);
            createStripMenu.Text = "&Создать";
            // 
            // saveStripMenu
            // 
            saveStripMenu.Name = "saveStripMenu";
            saveStripMenu.Size = new Size(195, 22);
            saveStripMenu.Text = "&Сохранить";
            // 
            // saveAsToolMenu
            // 
            saveAsToolMenu.Name = "saveAsToolMenu";
            saveAsToolMenu.Size = new Size(195, 22);
            saveAsToolMenu.Text = "&Сохранить как";
            // 
            // linkParametrsStripMenu
            // 
            linkParametrsStripMenu.Name = "linkParametrsStripMenu";
            linkParametrsStripMenu.Size = new Size(195, 22);
            linkParametrsStripMenu.Text = "&Параметры страницы";
            // 
            // printStripMenu
            // 
            printStripMenu.Name = "printStripMenu";
            printStripMenu.Size = new Size(195, 22);
            printStripMenu.Text = "Печать";
            // 
            // changeStripMenu
            // 
            changeStripMenu.DropDownItems.AddRange(new ToolStripItem[] { cancleStripMenu, cutStripMenu, copyStripMenu, pasteToolMenu, DeleteStripMenu, bingStripMenu, findStripMenu, find_nextStripMenu, replaceStripMenu, gotoStripMenu, selectallStripMenu, date_and_timeStripMenu });
            changeStripMenu.Name = "changeStripMenu";
            changeStripMenu.Size = new Size(59, 20);
            changeStripMenu.Text = "&Правка";
            // 
            // cancleStripMenu
            // 
            cancleStripMenu.Name = "cancleStripMenu";
            cancleStripMenu.Size = new Size(205, 22);
            cancleStripMenu.Text = "&Отменить";
            // 
            // cutStripMenu
            // 
            cutStripMenu.Name = "cutStripMenu";
            cutStripMenu.Size = new Size(205, 22);
            cutStripMenu.Text = "&Вырезать";
            // 
            // copyStripMenu
            // 
            copyStripMenu.Name = "copyStripMenu";
            copyStripMenu.Size = new Size(205, 22);
            copyStripMenu.Text = "&Копировать";
            copyStripMenu.Click += коToolStripMenuItem_Click;
            // 
            // pasteToolMenu
            // 
            pasteToolMenu.Name = "pasteToolMenu";
            pasteToolMenu.Size = new Size(205, 22);
            pasteToolMenu.Text = "&Вставить";
            // 
            // DeleteStripMenu
            // 
            DeleteStripMenu.Name = "DeleteStripMenu";
            DeleteStripMenu.Size = new Size(205, 22);
            DeleteStripMenu.Text = "&Удалить";
            // 
            // bingStripMenu
            // 
            bingStripMenu.Name = "bingStripMenu";
            bingStripMenu.Size = new Size(205, 22);
            bingStripMenu.Text = "&Поиск с помощью BIng";
            // 
            // findStripMenu
            // 
            findStripMenu.Name = "findStripMenu";
            findStripMenu.Size = new Size(205, 22);
            findStripMenu.Text = "&Найти";
            // 
            // find_nextStripMenu
            // 
            find_nextStripMenu.Name = "find_nextStripMenu";
            find_nextStripMenu.Size = new Size(205, 22);
            find_nextStripMenu.Text = "&Найти Далее";
            // 
            // replaceStripMenu
            // 
            replaceStripMenu.Name = "replaceStripMenu";
            replaceStripMenu.Size = new Size(205, 22);
            replaceStripMenu.Text = "&Заменить";
            // 
            // gotoStripMenu
            // 
            gotoStripMenu.Name = "gotoStripMenu";
            gotoStripMenu.Size = new Size(205, 22);
            gotoStripMenu.Text = "&Перейти";
            // 
            // selectallStripMenu
            // 
            selectallStripMenu.Name = "selectallStripMenu";
            selectallStripMenu.Size = new Size(205, 22);
            selectallStripMenu.Text = "&Выделить всё";
            // 
            // date_and_timeStripMenu
            // 
            date_and_timeStripMenu.Name = "date_and_timeStripMenu";
            date_and_timeStripMenu.Size = new Size(205, 22);
            date_and_timeStripMenu.Text = "Время и дата";
            // 
            // formStripMenu
            // 
            formStripMenu.DropDownItems.AddRange(new ToolStripItem[] { transferStripMenu, cipherStripMenu });
            formStripMenu.Name = "formStripMenu";
            formStripMenu.Size = new Size(57, 20);
            formStripMenu.Text = "&Форма";
            // 
            // transferStripMenu
            // 
            transferStripMenu.Name = "transferStripMenu";
            transferStripMenu.Size = new Size(183, 22);
            transferStripMenu.Text = "&Перенос по словам";
            // 
            // cipherStripMenu
            // 
            cipherStripMenu.Name = "cipherStripMenu";
            cipherStripMenu.Size = new Size(183, 22);
            cipherStripMenu.Text = "Шифр";
            // 
            // viewStripMenu
            // 
            viewStripMenu.DropDownItems.AddRange(new ToolStripItem[] { scaleStripMenu, stringStripMenu });
            viewStripMenu.Name = "viewStripMenu";
            viewStripMenu.Size = new Size(39, 20);
            viewStripMenu.Text = "&Вид";
            // 
            // scaleStripMenu
            // 
            scaleStripMenu.DropDownItems.AddRange(new ToolStripItem[] { uoStripMenu, downStripMenu, restoreStripMenu });
            scaleStripMenu.Name = "scaleStripMenu";
            scaleStripMenu.Size = new Size(180, 22);
            scaleStripMenu.Text = "&Масштаб";
            // 
            // uoStripMenu
            // 
            uoStripMenu.Name = "uoStripMenu";
            uoStripMenu.Size = new Size(288, 22);
            uoStripMenu.Text = "&Увеличить";
            // 
            // downStripMenu
            // 
            downStripMenu.Name = "downStripMenu";
            downStripMenu.Size = new Size(288, 22);
            downStripMenu.Text = "&Уменьшить";
            // 
            // restoreStripMenu
            // 
            restoreStripMenu.Name = "restoreStripMenu";
            restoreStripMenu.Size = new Size(288, 22);
            restoreStripMenu.Text = "&Восстановить масштаб по умолчанию";
            // 
            // stringStripMenu
            // 
            stringStripMenu.Name = "stringStripMenu";
            stringStripMenu.Size = new Size(180, 22);
            stringStripMenu.Text = "Строка состояния";
            // 
            // referenceStripMenu
            // 
            referenceStripMenu.DropDownItems.AddRange(new ToolStripItem[] { watch_refToolStripMenuItem, aboutStripMenu });
            referenceStripMenu.Name = "referenceStripMenu";
            referenceStripMenu.Size = new Size(65, 20);
            referenceStripMenu.Text = "&Справка";
            // 
            // watch_refToolStripMenuItem
            // 
            watch_refToolStripMenuItem.Name = "watch_refToolStripMenuItem";
            watch_refToolStripMenuItem.Size = new Size(188, 22);
            watch_refToolStripMenuItem.Text = "&Посмотреть справку";
            // 
            // aboutStripMenu
            // 
            aboutStripMenu.Name = "aboutStripMenu";
            aboutStripMenu.Size = new Size(188, 22);
            aboutStripMenu.Text = "О программе";
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Notepad";
            Text = "Notepad";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileStripMenu;
        private ToolStripMenuItem openStripMenu;
        private ToolStripMenuItem createStripMenu;
        private ToolStripMenuItem saveStripMenu;
        private ToolStripMenuItem saveAsToolMenu;
        private ToolStripMenuItem linkParametrsStripMenu;
        private ToolStripMenuItem printStripMenu;
        private ToolStripMenuItem changeStripMenu;
        private ToolStripMenuItem cancleStripMenu;
        private ToolStripMenuItem cutStripMenu;
        private ToolStripMenuItem copyStripMenu;
        private ToolStripMenuItem pasteToolMenu;
        private ToolStripMenuItem DeleteStripMenu;
        private ToolStripMenuItem bingStripMenu;
        private ToolStripMenuItem findStripMenu;
        private ToolStripMenuItem find_nextStripMenu;
        private ToolStripMenuItem replaceStripMenu;
        private ToolStripMenuItem gotoStripMenu;
        private ToolStripMenuItem selectallStripMenu;
        private ToolStripMenuItem date_and_timeStripMenu;
        private ToolStripMenuItem formStripMenu;
        private ToolStripMenuItem transferStripMenu;
        private ToolStripMenuItem cipherStripMenu;
        private ToolStripMenuItem viewStripMenu;
        private ToolStripMenuItem scaleStripMenu;
        private ToolStripMenuItem uoStripMenu;
        private ToolStripMenuItem downStripMenu;
        private ToolStripMenuItem restoreStripMenu;
        private ToolStripMenuItem stringStripMenu;
        private ToolStripMenuItem referenceStripMenu;
        private ToolStripMenuItem watch_refToolStripMenuItem;
        private ToolStripMenuItem aboutStripMenu;
    }
}