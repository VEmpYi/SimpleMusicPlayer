namespace MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listMusicView = new System.Windows.Forms.ListBox();
            this.cMS_listMV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delSingleSong = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllSongs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cMS_listMV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 9);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开文件";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listMusicView
            // 
            this.listMusicView.ContextMenuStrip = this.cMS_listMV;
            this.listMusicView.FormattingEnabled = true;
            this.listMusicView.HorizontalScrollbar = true;
            this.listMusicView.ItemHeight = 20;
            this.listMusicView.Location = new System.Drawing.Point(8, 44);
            this.listMusicView.Name = "listMusicView";
            this.listMusicView.Size = new System.Drawing.Size(294, 304);
            this.listMusicView.TabIndex = 1;
            this.listMusicView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listMusicView_MouseDoubleClick);
            // 
            // cMS_listMV
            // 
            this.cMS_listMV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS_listMV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delSingleSong,
            this.clearAllSongs});
            this.cMS_listMV.Name = "contextMenuStrip1";
            this.cMS_listMV.Size = new System.Drawing.Size(139, 52);
            this.cMS_listMV.Opening += new System.ComponentModel.CancelEventHandler(this.cMS_listMV_Opening);
            // 
            // delSingleSong
            // 
            this.delSingleSong.Name = "delSingleSong";
            this.delSingleSong.Size = new System.Drawing.Size(138, 24);
            this.delSingleSong.Text = "删除";
            this.delSingleSong.Click += new System.EventHandler(this.delSingleSong_Click);
            // 
            // clearAllSongs
            // 
            this.clearAllSongs.Name = "clearAllSongs";
            this.clearAllSongs.Size = new System.Drawing.Size(138, 24);
            this.clearAllSongs.Text = "清空列表";
            this.clearAllSongs.Click += new System.EventHandler(this.delAllSongs_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(308, 44);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(94, 29);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "上一曲";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(308, 79);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 29);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "下一曲";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(308, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭应用";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(308, 114);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清空列表";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "仅支持wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.listMusicView);
            this.Controls.Add(this.btnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cMS_listMV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpen;
        private ListBox listMusicView;
        private Button btnPrev;
        private Button btnNext;
        private Button btnClose;
        private Button btnStop;
        private ContextMenuStrip cMS_listMV;
        private Button btnClear;
        private ToolStripMenuItem delSingleSong;
        private ToolStripMenuItem clearAllSongs;
        private Label label2;
    }
}