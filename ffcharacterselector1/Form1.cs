using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ffcharacterselector1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Character
        {
            public string name;
            public string description;
        }

        Character[] myCharacter = new Character[5];
        SpeechSynthesizer synth = new SpeechSynthesizer();

        private void Form1_Load(object sender, EventArgs e)
        {

            // Place data in structure array
            myCharacter[0].name = "Cloud";
            myCharacter[0].description = "An ex-SOLDIER: first class, Cloud came to Midgar to start a new chapter of his life as a mercenary. " +
                "At the invitation of his childhood friend, Tifa, he accepted a job with Avalanche. He may bring his buster " +
                "sword to bear against Shinra troopers, but he does not care for plight of the planet. For him, this is a job and nothing more.";

            myCharacter[1].name = "Aerith";
            myCharacter[1].description = "Aerith is a flower seller who lives in the Sector 5 slums, " +
                "who first meets Cloud on the streets of Midgar after the bombing of Mako Reactor 1. " +
                "Shinra has kept a close eye on her ever since she was a child, as she has the ability to hear the voice of the planet. " +
                "She is often found tending a modest bed of flowers at an old church in Sector 5.";

            myCharacter[2].name = "Barret";
            myCharacter[2].description = "The leader of an independent Avalanche cell in Midgar, " +
                "Barret was disavowed by the old guard for his extreme methods that attracted too much attention. " +
                "He subsequently came to Midgar, where he resolved to continue to pursue his vendetta against Shinra with " +
                "a small but trusted group of followers. When not fighting against the corporation, he and his comrades serve " +
                "in the neighborhood watch and keep the people safe─including his daughter Marlene, who he dotes on as a loving father.";

            myCharacter[3].name = "Tifa";
            myCharacter[3].description = "A loyal member of Avalanche─an underground organization opposed to Shinra─Tifa also runs Seventh Heaven, " +
                "a popular bar in the Sector 7 slums. Although she bears a terrible grudge towards Shinra, she is not convinced " +
                "that bombing mako reactors is the solution. As she struggled to reconcile her cause with her conscience, Tifa was reunited " +
                "with her childhood friend, Cloud, for the first time in years...";

            myCharacter[4].name = "Red XIII";
            myCharacter[4].description = "Red XIII is a beast with a flaming tail, crimson fur, deadly claws, and the ability to speak. " +
                "At present, he is being held in capitivity as a test subject for Professor Hojo.";

            // Setting default value
            textBox1.Text = myCharacter[0].description;
            label1.Text = myCharacter[0].name;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0:
                    pictureBox1.Image = ffcharacterselector1.Resource1.character1;
                    textBox1.Text = myCharacter[0].description;
                    label1.Text = myCharacter[0].name;
                    break;

                case 1:
                    pictureBox1.Image = ffcharacterselector1.Resource1.character2;
                    textBox1.Text = myCharacter[1].description;
                    label1.Text = myCharacter[1].name;
                    break;

                case 2:
                    pictureBox1.Image = ffcharacterselector1.Resource1.character3;
                    textBox1.Text = myCharacter[2].description;
                    label1.Text = myCharacter[2].name;
                    break;

                case 3:
                    pictureBox1.Image = ffcharacterselector1.Resource1.character4;
                    textBox1.Text = myCharacter[3].description;
                    label1.Text = myCharacter[3].name;
                    break;

                case 4:
                    pictureBox1.Image = ffcharacterselector1.Resource1.character5;
                    textBox1.Text = myCharacter[4].description;
                    label1.Text = myCharacter[4].name;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selection = 0;
            synth.SetOutputToDefaultAudioDevice();
            selection = trackBar1.Value;
            synth.Speak(myCharacter[selection].description);
        }
    }
}
