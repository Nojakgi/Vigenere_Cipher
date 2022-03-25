using System.Text;

namespace Vigenere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtToEncrypt.Text);
            string key = txtKeyToEncrypt.Text;

            VigenereEncrypt(ref s, key);

            txtAfterEncrypt.Text = Convert.ToString(s);
        }

        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder(txtToDecrypt.Text);
            string key = txtKeyToDecrypt.Text;

            VigenereDecryption(ref s, key);

            txtAfterDecrypt.Text = Convert.ToString(s);
        }

        public void VigenereEncrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++)
                s[i] = char.ToUpper(s[i]);

            key = key.ToUpper();
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    s[i] = (char)(s[i] + key[j] - 'A');
                    if (s[i] > 'Z') s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }

        public void VigenereDecryption(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++)
                s[i] = char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                        (char)(s[i] - key[j] + 'A') :
                        (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;

            }
        }
    }
}