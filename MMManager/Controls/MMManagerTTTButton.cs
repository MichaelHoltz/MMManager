﻿using System;
using System.Windows.Forms;
using System.Media;
namespace MMManager
{
    class MMManagerTTTButton :Button
    {
        private System.ComponentModel.IContainer components;

        public Boolean customEnable { get; set; } = true;
        public Boolean allowClick { get; set; } = true;
        protected override void OnClick(EventArgs e)
        {
            if (customEnable && allowClick)
            {
                base.OnClick(e);
            }
            else
            {
                string currentDir = System.IO.Directory.GetCurrentDirectory();
                SoundPlayer simpleSound = new SoundPlayer(currentDir + @"\Sounds\Blop.wav");
                simpleSound.Play();

            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}