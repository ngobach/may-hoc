using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using RestSharp;

namespace MayHoc.Core
{
    public class Factory
    {
        public ITextToSpeech MakeLocal(string text)
        {
            return new SystemSpeech(text);
        }

        public ITextToSpeech MakeVNSpeech(string text)
        {
            return new VNSpeech(text);
        }
    }
}
