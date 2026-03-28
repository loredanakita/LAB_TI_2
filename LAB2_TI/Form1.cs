using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

namespace LAB2_TI
{
    public partial class Form1 : Form
    {
        string fileExtension;
        KeyGenerator cipher;
        byte[] rawBytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void fileImportButton_Click(object sender, EventArgs e)
        {
             using (OpenFileDialog openFileDialog = new OpenFileDialog())
             {
                 openFileDialog.Filter = "Все файлы (*.*)|*.*";
                 openFileDialog.FilterIndex = 1;
                 openFileDialog.RestoreDirectory = true;

                 if (openFileDialog.ShowDialog() == DialogResult.OK)
                 {
                     string selectedPath = openFileDialog.FileName;
                     rawBytes = System.IO.File.ReadAllBytes(selectedPath);
                     fileExtension = BinaryParser.GetExtension(openFileDialog.FileName);

                     plainText.Text = BinaryParser.GetStringByBytes(rawBytes, showAll: false);
                 }
             }
        }

        private void fileExportButton_Click(object sender, EventArgs e)
        {
            if (cipher == null || cipher.encryptedData.Length == 0)
            {
                MessageBox.Show($"Для начала зашифруйте данные",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = fileExtension;
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllBytes(outputPath, cipher.encryptedData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static BitArray GetBitArrayMSB(byte[] rawBytes)
        {
            BitArray bits = new BitArray(rawBytes.Length * 8);
            for (int i = 0; i < rawBytes.Length; i++)
            {
                byte b = rawBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    // Старший бит (7-j) идет в начало
                    bits[i * 8 + j] = (b & (1 << (7 - j))) != 0;
                }
            }
            return bits;
        }


        private void encodeButton_Click(object sender, EventArgs e)
        {
            if (plainText.Text.Length == 0)
            {
                MessageBox.Show($"Поле с входными данными не может быть пустым",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BitArray inputBits = GetBitArrayMSB(rawBytes);
            string filteredKey = BinaryParser.GetCorrectString(registerText.Text);
            
            if (filteredKey.Length != 39)
            {
                MessageBox.Show($"Текущая длина ключа: {filteredKey.Length}, необходимая длина ключа: 39",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KeyGenerator.GetRegLength() == filteredKey.Length)
            {
                cipher = new KeyGenerator(inputBits, BinaryParser.GetCorrectString(registerText.Text));
                byte[] encryptedBytes = cipher.GetCipherText();
                keyText.Text = cipher.GetKey(showAll: false);
                cipherText.Text = BinaryParser.GetStringByBytes(cipher.GetCipherText(), showAll: false);
            }
        }

        private void registerText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры и клавишу Backspace
            if (!char.IsControl(e.KeyChar) && !(e.KeyChar == '1') && !(e.KeyChar == '0'))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            keyText.Text = "";
            plainText.Text = "";
            cipherText.Text = "";
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            plainText.Text = BinaryParser.GetStringByBytes(rawBytes, showAll: true);
            if (plainText.Text.Length == 0)
            {
                MessageBox.Show($"Поле с входными данными не может быть пустым",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BitArray inputBits = GetBitArrayMSB(rawBytes);
            string filteredKey = BinaryParser.GetCorrectString(registerText.Text);

            if (filteredKey.Length != 39)
            {
                MessageBox.Show($"Текущая длина ключа: {filteredKey.Length}, необходимая длина ключа: 39",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KeyGenerator.GetRegLength() == filteredKey.Length)
            {
                cipher = new KeyGenerator(inputBits, BinaryParser.GetCorrectString(registerText.Text));
                byte[] encryptedBytes = cipher.GetCipherText();
                keyText.Text = cipher.GetKey(showAll: true);
                cipherText.Text = BinaryParser.GetStringByBytes(cipher.GetCipherText(), showAll: true);
            }
        }
    }
}
