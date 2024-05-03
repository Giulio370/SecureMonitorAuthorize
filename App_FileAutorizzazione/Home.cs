using App_FileAutorizzazione.Classi;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_FileAutorizzazione
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        
        string fileName = "";

        private string SelectFile()
        {
            var dlg = new OpenFileDialog()
            {
                //InitialDirectory = @"C:\Users",
                InitialDirectory = @".\",
                Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt",
                RestoreDirectory = true
            };

            //User didn't select a file so return a default value  
            if (dlg.ShowDialog() != DialogResult.OK)
                return "";

            //Return the file the user selected  
            fileName = dlg.FileName;
            return dlg.FileName;
        }
        private Monitor LeggiJson(string path)
        {
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                Monitor m = (Monitor)serializer.Deserialize(file, typeof(Monitor));
                return m;
            }
        }

        private void btn_Importa_Click(object sender, EventArgs e)
        {
            try
            {
                Monitor m = LeggiJson(SelectFile());
                label_IdMon.Text = m.ID_Monitor.ToString();
                label_nomeMon.Text = m.Name;
                label_IdGpu.Text = m.ID_GPU.ToString();
                panel_MonitorIcon.Visible = true;
            }
            catch
            {
                Console.WriteLine("Errore");
            }
        }
        /// //////////////////////
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }
        /// //////////////////////
        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
            /// 
        private void btn_Crea_Click(object sender, EventArgs e)
        {       
            if (string.IsNullOrEmpty(label_IdMon.Text) || label_IdMon.Text=="None") { MessageBox.Show("Select a File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } else
            {
                var key = "YOUR KEY (32)";
                var encryptedString = EncryptString(key, label_IdMon.Text+";"+label_nomeMon.Text + ";"+label_IdGpu.Text);
                //Console.WriteLine($"encrypted string = {encryptedString}");
                
                //var decryptedString = DecryptString(key, encryptedString);
                //Console.WriteLine($"decrypted string = {decryptedString}");

                //string filePath = "FileAutorizzazioneMonitor.txt";
                int startIndex = fileName.IndexOf("PlayerCertificate_");
                int endIndex = fileName.IndexOf(".json");
                File.WriteAllText(fileName.Substring(startIndex, endIndex-startIndex)+".txt", encryptedString);
                Console.WriteLine(fileName);
                //File.WriteAllText(fileName, encryptedString);
                MessageBox.Show("Permission created successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_MonitorIcon.Visible = false;
        }
    }
}
