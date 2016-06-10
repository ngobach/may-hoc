namespace MayHoc.Core
{
    public interface ITextToSpeech
    {
        void Speak();
        void Export(string file);
        void PauseResume();
        void Stop();
        bool IsStopped();
    }
}
