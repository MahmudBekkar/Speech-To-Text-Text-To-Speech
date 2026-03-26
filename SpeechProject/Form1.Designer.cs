namespace SpeechProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtSpeechToText = new System.Windows.Forms.RichTextBox();
            this.txtTextToSpeech = new System.Windows.Forms.TextBox();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.btnStopListening = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.Location = new System.Drawing.Point(150, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(387, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Speech-to-Text & Text-to-Speech";
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSpeechToText
            // 
            this.txtSpeechToText.Location = new System.Drawing.Point(50, 80);
            this.txtSpeechToText.Name = "txtSpeechToText";
            this.txtSpeechToText.ReadOnly = true;
            this.txtSpeechToText.Size = new System.Drawing.Size(700, 150);
            this.txtSpeechToText.TabIndex = 1;
            this.txtSpeechToText.Text = "";
            this.txtSpeechToText.TextChanged += new System.EventHandler(this.txtSpeechToText_TextChanged);
            // 
            // txtTextToSpeech
            // 
            this.txtTextToSpeech.Location = new System.Drawing.Point(50, 250);
            this.txtTextToSpeech.Multiline = true;
            this.txtTextToSpeech.Name = "txtTextToSpeech";
            this.txtTextToSpeech.Size = new System.Drawing.Size(700, 80);
            this.txtTextToSpeech.TabIndex = 2;
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(50, 350);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(91, 23);
            this.btnStartListening.TabIndex = 3;
            this.btnStartListening.Text = "Start Listening";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // btnStopListening
            // 
            this.btnStopListening.Location = new System.Drawing.Point(147, 350);
            this.btnStopListening.Name = "btnStopListening";
            this.btnStopListening.Size = new System.Drawing.Size(128, 23);
            this.btnStopListening.TabIndex = 4;
            this.btnStopListening.Text = "Stop Listening";
            this.btnStopListening.UseVisualStyleBackColor = true;
            this.btnStopListening.Click += new System.EventHandler(this.btnStopListening_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(329, 350);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(96, 23);
            this.btnSpeak.TabIndex = 5;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(450, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(550, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnStopListening);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.txtTextToSpeech);
            this.Controls.Add(this.txtSpeechToText);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Speech Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox txtSpeechToText;
        private System.Windows.Forms.TextBox txtTextToSpeech;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.Button btnStopListening;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

