using System.Numerics;

namespace L3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var phase = 5;
            var message = textBox1.Text.ToCharArray();
            for (var index = 0; index < message.Length; index++)
            {
                var ch = message[index];
                if (' '.Equals(ch)) continue;
                if (!char.IsLetter(ch))
                {
                    textBox2.Paste("Message must contain only letters");
                    textBox1.Clear();
                    return;
                }
                var beginning_code = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((ch - beginning_code + phase) % 26 + beginning_code);
                message[index] = ch;
            }
            textBox2.Paste(new(message));
            textBox1.Clear();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var phase = 5;
            var message = textBox1.Text.ToCharArray();
            for (var index = 0; index < message.Length; index++)
            {
                var ch = message[index];
                if (' '.Equals(ch)) continue;
                if (!char.IsLetter(ch))
                {
                    textBox2.Paste("Message must contain only letters");
                    textBox1.Clear();
                    return;
                }
                var beginning_code = char.IsUpper(ch) ? 'A' : 'a';
                ch = (char)((ch - beginning_code + 26 - phase) % 26 + beginning_code);
                message[index] = ch;
            }
            textBox2.Paste(new(message));
            textBox1.Clear();
        }
    }
}
