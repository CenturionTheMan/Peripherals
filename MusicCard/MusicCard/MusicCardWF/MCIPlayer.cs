using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicCardWF;



// res: https://learn.microsoft.com/en-us/previous-versions/dd757161(v=vs.85)

internal class MCIPlayer
{
    public const int MM_MCINOTIFY = 0x03b9;
    public const int MCI_NOTIFY_SUCCESS = 0x01;
    public const int MCI_NOTIFY_SUPERSEDED = 0x02;
    public const int MCI_NOTIFY_ABORTED = 0x04;
    public const int MCI_NOTIFY_FAILURE = 0x08;

    private string fileName;
    private bool isOpen = false;
    private Form notifyForm;
    private string alias = "musound";

    //mciSendString 
    [DllImport("winmm.dll")]
    private static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);


    private void CloseMedia()
    {
        if (isOpen)
        {
            string command = $"close {alias}";
            mciSendString(command, null, 0, IntPtr.Zero);
            isOpen = false;
        }
    }


    private void OpenMedia()
    {
        CloseMedia();
        var command = $"open waveaudio!{fileName} alias {alias}";
        mciSendString(command, null, 0, IntPtr.Zero);
        isOpen = true;
    }


    private void PlayMedia()
    {
        string command = $"play {alias} notify";
        mciSendString(command, null, 0, notifyForm.Handle);
    }

    private void ResumeMedia()
    {
        string command = $"resume {alias}";
        mciSendString(command, null, 0, notifyForm.Handle);
    }

    public void Pause()
    {
        if (isOpen == false) return;
        string command = $"pause {alias}";
        mciSendString(command, null, 0, notifyForm.Handle);
    }

    public void Play(string fileName, Form notifyForm)
    {
        if(isOpen)
        {
            ResumeMedia();
        }
        else
        {
            this.fileName = fileName;
            this.notifyForm = notifyForm;
            OpenMedia();
            PlayMedia();
        }
    }

    public void Stop()
    {
        CloseMedia();
    }
}
