using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MusicCardWF;

public partial class Form1 : Form
{
    private WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
    private SoundPlayer? spPlayer = null;
    private MCIPlayer mciPlayer = new();


    #region WMP
    private void playWMPButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        if (wmPlayer.URL == "")
            wmPlayer.URL = fileToOpen;
        wmPlayer.controls.play();
    }

    private void pauseWMPButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        wmPlayer.controls.pause();
    }

    private void stopWMPButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        wmPlayer.controls.stop();
    }

    #endregion


    #region PLAY SOUND

    private void playPSButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;

        if(spPlayer == null)
            spPlayer = new (fileToOpen);
        spPlayer.Play();
    }

    private void pausePSButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        if (spPlayer == null) return;
    }

    private void stopPSButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        if (spPlayer == null) return;
        spPlayer.Stop();
    }

    #endregion


    #region WAVE OOT WRITE

    private void playWOWButton_Click(object sender, EventArgs e)
    {

    }

    private void pauseWOWButton_Click(object sender, EventArgs e)
    {

    }

    private void stopWOWButton_Click(object sender, EventArgs e)
    {

    }

    #endregion



}
