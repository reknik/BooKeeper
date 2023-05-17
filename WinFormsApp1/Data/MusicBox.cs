using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace BooKeeper.Data;
public class MusicBox
{
    SoundPlayer simpleSound;
    List<Stream> songList = new List<Stream>()
    {
        Properties.Resources.JustRelax,
        Properties.Resources.ReflectedLight, Properties.Resources.Meow
    };
    Stream currentSong;

    public MusicBox()
    {
        simpleSound = new SoundPlayer(songList[0]);
        currentSong = songList[0];
    }

    public void play()
    {
        simpleSound.PlayLooping();
    }

    public void stop()
    {
        simpleSound.Stop();
    }

    public void nextSong()
    {
        simpleSound.Stop();
        if (songList.IndexOf(currentSong) + 1 < songList.Count) {
           
            currentSong = songList[songList.IndexOf(currentSong) + 1];
        }
        else
        {
            currentSong = songList[0];
        }
        currentSong.Position = 0;
        simpleSound.Stream = currentSong;
        simpleSound.PlayLooping();
    }
}
 
