using System;
using System.IO;
using RestSharp;
using NAudio.Wave;

namespace MayHoc.Core
{
    public class VNSpeech : ITextToSpeech, IDisposable
    {
        private readonly byte[] _data;

        private readonly IWavePlayer waveOutDevice = new WaveOut();

        private AudioFileReader audioFileReader;

        public VNSpeech(string text)
        {
            var client = new RestClient("http://cloudtalk.vn/");

            var req = new RestRequest("/tts", Method.POST);
            req.AddParameter("text", text);
            req.AddParameter("style", "poem");
            req.AddParameter("uid", "reserved");

            var id = client.Execute(req).Content;
            req = new RestRequest("ttsoutput?id=" + id);
            _data = client.Execute(req).RawBytes;
            File.WriteAllBytes("tmp.mp3", _data);
        }

        public void Speak(){
            audioFileReader = new AudioFileReader("tmp.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void Export(string file)
        {
            File.WriteAllBytes(file, _data);
        }

        public void PauseResume()
        {
            if (waveOutDevice.PlaybackState == PlaybackState.Paused)
                waveOutDevice.Play();
            else
                waveOutDevice.Pause();
        }

        public void Stop()
        {
            waveOutDevice.Stop();
            Dispose();
        }

        public bool IsStopped()
        {
            return waveOutDevice.PlaybackState == PlaybackState.Stopped;
        }

        public void Dispose()
        {
            audioFileReader.Dispose();
            waveOutDevice.Dispose();
        }
    }
}
