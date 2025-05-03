using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Best_Notepad
{
    public partial class SpeechForm : Form
    {
        public SpeechForm()
        {
            InitializeComponent();
        }

        private void speakbutton_Click(object sender, EventArgs e)
        {//speech syn the sizer 
            SpeechSynthesizer synt = new SpeechSynthesizer();

            synt.Rate = speedtrackBar.Value; //speed k lye
            //speed k lye
            synt.Volume = soundtrackBar.Value; //awaz k lyye

            if (personcomboBox.Text == "Male") //agr male ha to
            {
                synt.SelectVoiceByHints(VoiceGender.Male);
            }

            if (personcomboBox.Text == "Female") //agr female ha to
            {
                synt.SelectVoiceByHints(VoiceGender.Female);
            
            }

            synt.Speak(textBox1.Text); //lazmi ha ye
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            notepad1 obj = new notepad1();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
