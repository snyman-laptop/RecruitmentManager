
using System;
using Microsoft.CognitiveServices.Speech;

namespace RecruitmentManager.Utilities
{
    public class SpeechRecognition
    {
        public async Task RecognizeSpeechAsync()
        {
            var speechConfig = SpeechConfig.FromSubscription("YourAzureKey", "YourRegion");
            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            var recognizer = new SpeechRecognizer(speechConfig, audioConfig);

            var result = await recognizer.RecognizeOnceAsync();
            if (result.Reason == ResultReason.RecognizedSpeech)
            {
                Console.WriteLine($"Recognized: {result.Text}");
            }
            else
            {
                Console.WriteLine("Speech not recognized.");
            }
        }
    }
}
