namespace Lesson4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Msg = new Button();
            Footbal = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            helpProvider1 = new HelpProvider();
            Name = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripContainer1 = new ToolStripContainer();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // Msg
            // 
            Msg.Location = new Point(183, 198);
            Msg.Name = "Msg";
            Msg.Size = new Size(75, 23);
            Msg.TabIndex = 0;
            Msg.Text = "Msg";
            Msg.UseVisualStyleBackColor = true;
            Msg.Click += button1_Click;
            // 
            // Footbal
            // 
            Footbal.AutoSize = true;
            Footbal.Location = new Point(183, 227);
            Footbal.Name = "Footbal";
            Footbal.Size = new Size(69, 19);
            Footbal.TabIndex = 1;
            Footbal.Text = "Football";
            Footbal.UseVisualStyleBackColor = true;
            Footbal.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(138, 260);
            Name.Name = "Name";
            Name.Size = new Size(39, 15);
            Name.TabIndex = 2;
            Name.Text = "Name";
            Name.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(150, 150);
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(150, 175);
            toolStripContainer1.TabIndex = 5;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Click += toolStripContainer1_TopToolStripPanel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Controls.Add(textBox1);
            Controls.Add(Name);
            Controls.Add(Footbal);
            Controls.Add(Msg);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Msg;
        private CheckBox Footbal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HelpProvider helpProvider1;
        private Label Name;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripContainer toolStripContainer1;
    }
}
