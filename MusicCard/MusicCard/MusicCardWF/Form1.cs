using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using WMPLib;

namespace MusicCardWF;

public partial class Form1 : Form
{
    private string? fileToOpen = null;
    private WindowsMediaPlayer wmPlayer = new WindowsMediaPlayer();
    private SoundPlayer? spPlayer = null;
    private MCIPlayer mciPlayer = new();
    


    public Form1()
    {
        InitializeComponent();
    }

    private void fileLoadButton_Click(object sender, EventArgs e)
    {
        var result = openFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            fileToOpen = openFileDialog.FileName;
            loadedFileTextBox.Text = fileToOpen;
        }
        else
        {
            fileToOpen = null;
            loadedFileTextBox.Text = "";
        }
    }




    #region PLAY SOUND

    private void playPSButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;

        if (spPlayer == null)
        {
            spPlayer = new(fileToOpen);
            spPlayer.Play();
        }
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
        spPlayer = null;
    }

    #endregion


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


    #region WAVE OOT WRITE

    private void playWOWButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void pauseWOWButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();

    }

    private void stopWOWButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();

    }

    #endregion


    #region MCI
    private void playMCIButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;

        mciPlayer.Play(fileToOpen, this);
    }

    private void pauseMCIButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        mciPlayer.Pause();
    }

    private void stopMCIButton_Click(object sender, EventArgs e)
    {
        if (fileToOpen == null) return;
        mciPlayer.Stop();
    }


    protected override void WndProc(ref Message m)
    {
        if (m.Msg == MCIPlayer.MM_MCINOTIFY)
        {
            mciPlayer.Stop();
            //MessageBox.Show(m.WParam.ToString());
            //switch (m.WParam.ToInt32())
            //{
            //    case MCIPlayer.MCI_NOTIFY_SUCCESS:
            //        // success handling
            //        break;
            //    case MCIPlayer.MCI_NOTIFY_SUPERSEDED:
            //        // superseded handling
            //        break;
            //    case MCIPlayer.MCI_NOTIFY_ABORTED:
            //        // abort handling
            //        break;
            //    case MCIPlayer.MCI_NOTIFY_FAILURE:
            //        // failure! handling
            //        break;
            //    default:
            //        // haha
            //        break;
            //}
        }
        base.WndProc(ref m);
    }


    #endregion

    #region DIRECT SOUND


    #endregion

    private void playDSButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void pauseDSButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();

    }

    private void stopDSButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();

    }
}