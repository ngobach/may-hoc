using System;
using System.Speech;
using System.Speech.Synthesis;

namespace MayHoc.Core
{
    public class SystemSpeech : ITextToSpeech
    {
        private readonly string _text;
        private SpeechSynthesizer _speaker;

        public SystemSpeech(string text)
        {
            _text = text;
        }

        public void Speak()
        {
            if (_speaker != null) return;
            _speaker = new SpeechSynthesizer();
            _speaker.SpeakAsync(_text);
            _speaker.Volume = Properties.Settings.Default.Volume;
            _speaker.Rate = Properties.Settings.Default.Rate;

        }

        public void Export(string file)
        {
            var tmp = new SpeechSynthesizer();
            tmp.SetOutputToWaveFile(file);
            tmp.Speak(_text);
            tmp.Dispose();
        }

        public void PauseResume()
        {
            if (_speaker == null) return;
            if (_speaker.State == SynthesizerState.Speaking)
                _speaker.Pause();
            else
                _speaker.Resume();
        }


        public void Stop()
        {
            if (_speaker == null) return;
            _speaker.Dispose();
            _speaker = null;
        }

        public bool IsStopped()
        {
            return _speaker.State == SynthesizerState.Ready;
        }
    }
}