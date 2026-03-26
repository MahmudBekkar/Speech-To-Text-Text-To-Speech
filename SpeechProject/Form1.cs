using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SpeechProject
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognizer;
        SpeechSynthesizer speaker;
        bool isListening = false;

        public Form1()
        {
            InitializeComponent();
            InitializeSpeech();
        }

        private void InitializeSpeech()
        {
            try
            {
                // Text to Speech
                speaker = new SpeechSynthesizer();
                speaker.SetOutputToDefaultAudioDevice();
                speaker.Rate = 0;
                speaker.Volume = 100;

                // Speech to Text
                recognizer = new SpeechRecognitionEngine();
                recognizer.SetInputToDefaultAudioDevice();
                recognizer.LoadGrammar(new DictationGrammar());

                recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
                recognizer.RecognizeCompleted += Recognizer_RecognizeCompleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing speech engine: " + ex.Message);
            }
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Result.Text))
            {
                txtSpeechToText.AppendText(e.Result.Text + Environment.NewLine);
            }
        }

        private void Recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            isListening = false;
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            try
            {
                if (isListening)
                {
                    MessageBox.Show("Recognition is already running.");
                    return;
                }

                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                isListening = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Start Listening Error: " + ex.Message);
            }
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isListening)
                {
                    MessageBox.Show("Recognition is already stopped.");
                    return;
                }

                recognizer.RecognizeAsyncStop();
                isListening = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stop Listening Error: " + ex.Message);
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                string text = txtTextToSpeech.Text.Trim();

                if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Please enter text first.");
                    return;
                }

                speaker.SpeakAsync(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Speak Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpeechToText.Clear();
            txtTextToSpeech.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtSpeechToText_TextChanged(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                if (recognizer != null)
                {
                    if (isListening)
                    {
                        recognizer.RecognizeAsyncCancel();
                    }

                    recognizer.Dispose();
                }

                if (speaker != null)
                {
                    speaker.Dispose();
                }
            }
            catch
            {
            }

            base.OnFormClosing(e);
        }
    }
}