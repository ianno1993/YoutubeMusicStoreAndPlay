﻿namespace YoutubeMusicStoreAndPlay
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateVideoInto = new System.Windows.Forms.Button();
            this.btnAddNewVideo = new System.Windows.Forms.Button();
            this.btnCopySelectedVideoName = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnCopySelectedVideoURL = new System.Windows.Forms.Button();
            this.txtVideoName = new System.Windows.Forms.TextBox();
            this.btnCopyVideoListNames = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPlayAndRemove = new System.Windows.Forms.Button();
            this.btnPlayRandomVideo = new System.Windows.Forms.Button();
            this.btnPlaySelectedOnRepeat = new System.Windows.Forms.Button();
            this.btnPlaySelectedVideo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveVideo = new System.Windows.Forms.Button();
            this.btnMoveSelectedItemUp = new System.Windows.Forms.Button();
            this.btnMoveSelectedItemDown = new System.Windows.Forms.Button();
            this.lbVideoList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.axShockwaveFlash1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(812, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Youtube player";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(6, 4);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(800, 450);
            this.axShockwaveFlash1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.lbVideoList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateVideoInto);
            this.groupBox1.Controls.Add(this.btnAddNewVideo);
            this.groupBox1.Controls.Add(this.btnCopySelectedVideoName);
            this.groupBox1.Controls.Add(this.btnAddVideo);
            this.groupBox1.Controls.Add(this.btnCopySelectedVideoURL);
            this.groupBox1.Controls.Add(this.txtVideoName);
            this.groupBox1.Controls.Add(this.btnCopyVideoListNames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVideoURL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(402, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a video.";
            // 
            // btnUpdateVideoInto
            // 
            this.btnUpdateVideoInto.Location = new System.Drawing.Point(6, 109);
            this.btnUpdateVideoInto.Name = "btnUpdateVideoInto";
            this.btnUpdateVideoInto.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateVideoInto.TabIndex = 10;
            this.btnUpdateVideoInto.Text = "Update info";
            this.btnUpdateVideoInto.UseVisualStyleBackColor = true;
            this.btnUpdateVideoInto.Click += new System.EventHandler(this.btnUpdateVideoInto_Click);
            // 
            // btnAddNewVideo
            // 
            this.btnAddNewVideo.Location = new System.Drawing.Point(145, 109);
            this.btnAddNewVideo.Name = "btnAddNewVideo";
            this.btnAddNewVideo.Size = new System.Drawing.Size(96, 23);
            this.btnAddNewVideo.TabIndex = 9;
            this.btnAddNewVideo.Text = "Add new video";
            this.btnAddNewVideo.UseVisualStyleBackColor = true;
            this.btnAddNewVideo.Click += new System.EventHandler(this.btnAddNewVideo_Click);
            // 
            // btnCopySelectedVideoName
            // 
            this.btnCopySelectedVideoName.Location = new System.Drawing.Point(6, 81);
            this.btnCopySelectedVideoName.Name = "btnCopySelectedVideoName";
            this.btnCopySelectedVideoName.Size = new System.Drawing.Size(96, 23);
            this.btnCopySelectedVideoName.TabIndex = 8;
            this.btnCopySelectedVideoName.Text = "Copy Name";
            this.btnCopySelectedVideoName.UseVisualStyleBackColor = true;
            this.btnCopySelectedVideoName.Click += new System.EventHandler(this.btnCopySelectedVideoName_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(284, 110);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(96, 23);
            this.btnAddVideo.TabIndex = 4;
            this.btnAddVideo.Text = "Add video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Visible = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnCopySelectedVideoURL
            // 
            this.btnCopySelectedVideoURL.Location = new System.Drawing.Point(145, 81);
            this.btnCopySelectedVideoURL.Name = "btnCopySelectedVideoURL";
            this.btnCopySelectedVideoURL.Size = new System.Drawing.Size(96, 23);
            this.btnCopySelectedVideoURL.TabIndex = 7;
            this.btnCopySelectedVideoURL.Text = "Copy URL";
            this.btnCopySelectedVideoURL.UseVisualStyleBackColor = true;
            this.btnCopySelectedVideoURL.Click += new System.EventHandler(this.btnCopySelectedVideoURL_Click);
            // 
            // txtVideoName
            // 
            this.txtVideoName.Location = new System.Drawing.Point(90, 19);
            this.txtVideoName.Name = "txtVideoName";
            this.txtVideoName.Size = new System.Drawing.Size(290, 20);
            this.txtVideoName.TabIndex = 3;
            // 
            // btnCopyVideoListNames
            // 
            this.btnCopyVideoListNames.Location = new System.Drawing.Point(283, 81);
            this.btnCopyVideoListNames.Name = "btnCopyVideoListNames";
            this.btnCopyVideoListNames.Size = new System.Drawing.Size(96, 23);
            this.btnCopyVideoListNames.TabIndex = 6;
            this.btnCopyVideoListNames.Text = "Copy video list";
            this.btnCopyVideoListNames.UseVisualStyleBackColor = true;
            this.btnCopyVideoListNames.Click += new System.EventHandler(this.btnCopyVideoListNames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Video name:";
            // 
            // txtVideoURL
            // 
            this.txtVideoURL.Location = new System.Drawing.Point(90, 55);
            this.txtVideoURL.Name = "txtVideoURL";
            this.txtVideoURL.Size = new System.Drawing.Size(290, 20);
            this.txtVideoURL.TabIndex = 1;
            this.txtVideoURL.Text = "Example: http://www.youtube.com/watch?v=abcdefghijk";
            this.txtVideoURL.Enter += new System.EventHandler(this.txtVideoURL_Enter_1);
            this.txtVideoURL.Leave += new System.EventHandler(this.txtVideoURL_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video URL:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPlayAndRemove);
            this.groupBox4.Controls.Add(this.btnPlayRandomVideo);
            this.groupBox4.Controls.Add(this.btnPlaySelectedOnRepeat);
            this.groupBox4.Controls.Add(this.btnPlaySelectedVideo);
            this.groupBox4.Location = new System.Drawing.Point(402, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 81);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Video play controls";
            // 
            // btnPlayAndRemove
            // 
            this.btnPlayAndRemove.Location = new System.Drawing.Point(7, 49);
            this.btnPlayAndRemove.Name = "btnPlayAndRemove";
            this.btnPlayAndRemove.Size = new System.Drawing.Size(96, 23);
            this.btnPlayAndRemove.TabIndex = 3;
            this.btnPlayAndRemove.Text = "Play and remove";
            this.btnPlayAndRemove.UseVisualStyleBackColor = true;
            // 
            // btnPlayRandomVideo
            // 
            this.btnPlayRandomVideo.Location = new System.Drawing.Point(284, 20);
            this.btnPlayRandomVideo.Name = "btnPlayRandomVideo";
            this.btnPlayRandomVideo.Size = new System.Drawing.Size(96, 23);
            this.btnPlayRandomVideo.TabIndex = 2;
            this.btnPlayRandomVideo.Text = "Play Random";
            this.btnPlayRandomVideo.UseVisualStyleBackColor = true;
            // 
            // btnPlaySelectedOnRepeat
            // 
            this.btnPlaySelectedOnRepeat.Location = new System.Drawing.Point(146, 19);
            this.btnPlaySelectedOnRepeat.Name = "btnPlaySelectedOnRepeat";
            this.btnPlaySelectedOnRepeat.Size = new System.Drawing.Size(96, 23);
            this.btnPlaySelectedOnRepeat.TabIndex = 1;
            this.btnPlaySelectedOnRepeat.Text = "Repeat";
            this.btnPlaySelectedOnRepeat.UseVisualStyleBackColor = true;
            this.btnPlaySelectedOnRepeat.Click += new System.EventHandler(this.btnPlaySelectedOnRepeat_Click);
            // 
            // btnPlaySelectedVideo
            // 
            this.btnPlaySelectedVideo.Location = new System.Drawing.Point(7, 20);
            this.btnPlaySelectedVideo.Name = "btnPlaySelectedVideo";
            this.btnPlaySelectedVideo.Size = new System.Drawing.Size(96, 23);
            this.btnPlaySelectedVideo.TabIndex = 0;
            this.btnPlaySelectedVideo.Text = "Play";
            this.btnPlaySelectedVideo.UseVisualStyleBackColor = true;
            this.btnPlaySelectedVideo.Click += new System.EventHandler(this.btnPlaySelectedVideo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveVideo);
            this.groupBox3.Controls.Add(this.btnMoveSelectedItemUp);
            this.groupBox3.Controls.Add(this.btnMoveSelectedItemDown);
            this.groupBox3.Location = new System.Drawing.Point(402, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stored video\'s Controls";
            // 
            // btnRemoveVideo
            // 
            this.btnRemoveVideo.Location = new System.Drawing.Point(146, 19);
            this.btnRemoveVideo.Name = "btnRemoveVideo";
            this.btnRemoveVideo.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveVideo.TabIndex = 6;
            this.btnRemoveVideo.Text = "Remove video";
            this.btnRemoveVideo.UseVisualStyleBackColor = true;
            this.btnRemoveVideo.Click += new System.EventHandler(this.btnRemoveVideo_Click);
            // 
            // btnMoveSelectedItemUp
            // 
            this.btnMoveSelectedItemUp.Location = new System.Drawing.Point(7, 19);
            this.btnMoveSelectedItemUp.Name = "btnMoveSelectedItemUp";
            this.btnMoveSelectedItemUp.Size = new System.Drawing.Size(96, 23);
            this.btnMoveSelectedItemUp.TabIndex = 5;
            this.btnMoveSelectedItemUp.Text = "Move item up";
            this.btnMoveSelectedItemUp.UseVisualStyleBackColor = true;
            // 
            // btnMoveSelectedItemDown
            // 
            this.btnMoveSelectedItemDown.Location = new System.Drawing.Point(5, 48);
            this.btnMoveSelectedItemDown.Name = "btnMoveSelectedItemDown";
            this.btnMoveSelectedItemDown.Size = new System.Drawing.Size(96, 23);
            this.btnMoveSelectedItemDown.TabIndex = 4;
            this.btnMoveSelectedItemDown.Text = "Move item down";
            this.btnMoveSelectedItemDown.UseVisualStyleBackColor = true;
            // 
            // lbVideoList
            // 
            this.lbVideoList.FormattingEnabled = true;
            this.lbVideoList.Location = new System.Drawing.Point(10, 7);
            this.lbVideoList.Name = "lbVideoList";
            this.lbVideoList.Size = new System.Drawing.Size(386, 433);
            this.lbVideoList.TabIndex = 0;
            this.lbVideoList.SelectedIndexChanged += new System.EventHandler(this.lbVideoList_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(815, 479);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Youtube video store and player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.TextBox txtVideoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVideoURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPlaySelectedVideo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbVideoList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnMoveSelectedItemUp;
        private System.Windows.Forms.Button btnMoveSelectedItemDown;
        private System.Windows.Forms.Button btnPlayRandomVideo;
        private System.Windows.Forms.Button btnPlaySelectedOnRepeat;
        private System.Windows.Forms.Button btnPlayAndRemove;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
        private System.Windows.Forms.Button btnCopySelectedVideoName;
        private System.Windows.Forms.Button btnCopySelectedVideoURL;
        private System.Windows.Forms.Button btnCopyVideoListNames;
        private System.Windows.Forms.Button btnAddNewVideo;
        private System.Windows.Forms.Button btnUpdateVideoInto;
        private System.Windows.Forms.Button btnRemoveVideo;

    }
}
