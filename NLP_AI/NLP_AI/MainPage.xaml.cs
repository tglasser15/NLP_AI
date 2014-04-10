using Bing.Speech;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NLP_AI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        SpeechRecognizer SR;
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            // Apply credentials from the Windows Azure Data Marketplace.
            var credentials = new SpeechAuthorizationParameters();
            credentials.ClientId = "NLP_AI";
            credentials.ClientSecret = "iy/eYVkn5xlcJmA7GhSggBcuxpH8KWuQlA07NrjBsZo=";

            // Initialize the speech recognizer.
            SR = new SpeechRecognizer("en-US", credentials);

            // Add speech recognition event handlers.
            SR.AudioCaptureStateChanged += SR_AudioCaptureStateChanged;
            SR.AudioLevelChanged += SR_AudioLevelChanged;
            SR.RecognizerResultReceived += SR_RecognizerResultReceived;
        }

        private async void SpeakButton_Click(object sender, RoutedEventArgs e)
        {
            // Always call RecognizeSpeechToTextAsync from inside
            // a try block because it calls a web service.
            try
            {
                // Start speech recognition.
                var result = await SR.RecognizeSpeechToTextAsync();

                // Write the result to the TextBlock.
                ResultText.Text = result.Text;
            }
            catch (Exception ex)
            {
                // If there's an exception, show the Type and Message
                // in TextBlock ResultText.
                ResultText.Text = "Sorry, I can't understand what you said.";
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cancel the current speech session.
            SR.RequestCancelOperation();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop listening and move to Thinking state.
            SR.StopListeningAndProcessAudio();
        }

        void SR_AudioCaptureStateChanged(SpeechRecognizer sender, SpeechRecognitionAudioCaptureStateChangedEventArgs args)
        {
            // Show the panel that corresponds to the current state.
            switch (args.State)
            {
                case SpeechRecognizerAudioCaptureState.Complete:
                    if (uiState == "ListenPanel" || uiState == "ThinkPanel")
                    {
                        SetPanel(CompletePanel);
                    }
                    break;
                case SpeechRecognizerAudioCaptureState.Initializing:
                    SetPanel(InitPanel);
                    break;
                case SpeechRecognizerAudioCaptureState.Listening:
                    SetPanel(ListenPanel);
                    break;
                case SpeechRecognizerAudioCaptureState.Thinking:
                    SetPanel(ThinkPanel);
                    break;
                default:
                    break;
            }
        }

        string uiState = "";
        private void SetPanel(StackPanel panel)
        {
            // Hide all the panels.
            InitPanel.Visibility = Visibility.Collapsed;
            ListenPanel.Visibility = Visibility.Collapsed;
            ThinkPanel.Visibility = Visibility.Collapsed;
            CompletePanel.Visibility = Visibility.Collapsed;
            StartPanel.Visibility = Visibility.Collapsed;

            // Show the selected panel and flag the UI state.
            panel.Visibility = Visibility.Visible;
            uiState = panel.Name;
        }

        void SR_AudioLevelChanged(SpeechRecognizer sender, SpeechRecognitionAudioLevelChangedEventArgs args)
        {
            var v = args.AudioLevel;
            if (v > 0) VolumeMeter.Opacity = v / 50;
            else VolumeMeter.Opacity = Math.Abs((v - 50) / 100);
        }

        void SR_RecognizerResultReceived(SpeechRecognizer sender, SpeechRecognitionResultReceivedEventArgs args)
        {
            if (args.Text != null)
            {
                ResultText.Text = args.Text;
            }
            else
            {
                ResultText.Text = "Can't Hear You!";
            }
        }
    }
}
