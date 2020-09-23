using System;
using System.Drawing;
using System.Windows.Forms;

namespace SRTPluginUIRE2WinForms
{
    public static class Extensions
    {
        public static void ThreadSafeSetHealthImage(this PictureBox picBox, Image image, string imageKey)
        {
            if (picBox.InvokeRequired)
            {
                picBox.Invoke(new Action(() =>
                {
                    if (picBox.Tag == null || picBox.Tag.ToString() != imageKey)
                    {
                        picBox.Tag = imageKey;
                        picBox.Image = image;
                    }
                }));
            }
            else
            {
                if (picBox.Tag == null || picBox.Tag.ToString() != imageKey)
                {
                    picBox.Tag = imageKey;
                    picBox.Image = image;
                }
            }
        }
    }
}
