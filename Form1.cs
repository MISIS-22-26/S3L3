using System.Numerics;

namespace L3
{
    // Actual Window
    public partial class Form1 : Form
    {
        // Constructor
        public Form1()
        {
            InitializeComponent();
            current_action = Cipher;
        }
        // Action Implementation
        Action current_action;
        public delegate string Action(int phase);
        public void Do(int phase) => Paste(current_action(phase));

        // Action Mode Switch on BTN Click
        private void button1_Click(object sender, EventArgs e) => current_action = current_action == Cipher ? Decipher : Cipher;

        // Cesar's Cipher
        private string Cipher(int phase = 5) {
            var message = textBox1.Text.ToCharArray();
            for (var index = 0; index < message.Length; index++)
            {
                var ch = message[index];
                if (' '.Equals(ch)) continue;
                if (!char.IsLetter(ch))
                {
                    textBox2.Paste("Message must contain only letters");
                    textBox1.Clear();
                    return null;
                }
                var beginning_code = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((ch - beginning_code + phase) % 26 + beginning_code);
                message[index] = ch;
            }
            return new(message);
        }
        private string Decipher(int phase = 5) {
            var message = textBox1.Text.ToCharArray();
            for (var index = 0; index < message.Length; index++)
            {
                var ch = message[index];
                if (' '.Equals(ch)) continue;
                if (!char.IsLetter(ch))
                {
                    textBox2.Paste("Message must contain only letters");
                    textBox1.Clear();
                    return null;
                }
                var beginning_code = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((ch - beginning_code + 26 - phase) % 26 + beginning_code);
                message[index] = ch;
            }
            return new(message);
        }


        // Misc
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Paste(string message) {
            textBox2.Clear();
            textBox2.Paste(message);
        }
    }
}
