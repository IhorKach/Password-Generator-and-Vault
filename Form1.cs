using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace EduardApplication_v0
{
    public partial class Form1 : Form
    {
        List<string> accountsDataList = new List<string>();
        private readonly string folderName = @"C:\Holder";
        private string PathFile;
        private string dataFile;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SaveLoadAndCopyGroupBox.Enabled = false;
            GeneratePasswordBt.Focus();
        }
        #region EncryptionFile
        public static void AddEncryption(string FileName)
        {
            File.Encrypt(FileName);
        }
        public static void RemoveEncryption(string FileName)
        {
            File.Decrypt(FileName);
        }
        #endregion
        #region EncryptionData

        private string EncryptData(string stringToEncrypt)
        {
            char[] tempCharArray = new char[stringToEncrypt.Length];
            char[] encryptedCharArray = new char[tempCharArray.Length];
            tempCharArray = stringToEncrypt.ToCharArray();

            for (int i = 0; i < encryptedCharArray.Length; i++)
            {
                encryptedCharArray[i] = (char)(tempCharArray[i] + 'b');
            }
            string returnString = "";
            for (int i = 0; i < encryptedCharArray.Length; i++)
            {
                returnString += encryptedCharArray[i].ToString();
            }
            return returnString;
        }
        private string DecryptData(string stringToDecrypt)
        {
            char[] tempCharArray = stringToDecrypt.ToCharArray();
            char[] decryptedCharArray = new char[tempCharArray.Length];

            for (int i = 0; i < decryptedCharArray.Length; i++)
            {
                decryptedCharArray[i] = (char)(tempCharArray[i] - 'b');
            }
            string returnString = "";
            for (int i = 0; i < decryptedCharArray.Length; i++)
            {
                returnString += decryptedCharArray[i].ToString();
            }
            return returnString;
        }
        #endregion
        #region RandomizerPasswords
        public static string CreateRandomPassword(int PasswordLength)
        {
            string _allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ!@&?$*()[]_";
            Random randNum = new Random();
            char[] chars = new char[PasswordLength];
            int allowedCharCount = _allowedChars.Length;
            for (int i = 0; i < PasswordLength; i++)
            {
                chars[i] = _allowedChars[(int)((_allowedChars.Length) * randNum.NextDouble())];
            }
            return new string(chars);
        }
        protected void GeneratePasswordBt_Click(object sender, EventArgs e)
        {
            GeneratedPasswordTb.Text = CreateRandomPassword(Convert.ToInt32(
                NumberOfGeneratedSymbolsNumUpDown.Value));
        }

        private void CopyGeneratedPasswordBt_Click(object sender, EventArgs e)
        {
            if (GeneratedPasswordTb.Text != "")
            {
                Clipboard.SetText(GeneratedPasswordTb.Text);
                IsCopiedGeneratorLb.Text = "Copied!";
                Random randomizer = new Random();
                int randColor = randomizer.Next(0, 2000000000);
                IsCopiedGeneratorLb.ForeColor = Color.FromArgb(randColor);
            }
            else MessageBox.Show("Nothing to copy!", "Info", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }
        #endregion
        #region WhiteSpaces
        private void AuthorizationLoginTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void AuthorizationPasswordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
        private void AccountPasswordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void AccountLoginTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        #endregion
        #region Authorization
        private async void AuthorizationRegisterBt_Click(object sender, EventArgs e)
        {
            try
            {
                if ((AuthorizationLoginTb.Text != "")
                    && (AuthorizationPasswordTb.Text != ""))
                {

                    Directory.CreateDirectory(folderName);
                    PathFile = folderName + "\\" + AuthorizationLoginTb.Text + ".txt";

                    if (!File.Exists(PathFile))
                        using (StreamWriter writer = new StreamWriter(PathFile, false))
                        {
                            string lineToEncrypt = $"{AuthorizationLoginTb.Text}:Mainlogin" +
                            $"MainPassword:{AuthorizationPasswordTb.Text}";
                            await writer.WriteLineAsync(EncryptData(lineToEncrypt));

                        }
                    else
                    {
                        MessageBox.Show("Account is already exist!", "Info", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                        throw new Exception("Ты по-моему кнопки перепутал");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Data Please!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    throw new Exception("Ты или дурак или груша");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private async void AuthorizationLogInBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (AuthorizationLoginTb.Text != "" && AuthorizationPasswordTb.Text != "")
                {
                    string tempPass, tempLog;

                    PathFile = folderName + "\\" + AuthorizationLoginTb.Text + ".txt";

                    if (File.Exists(PathFile))
                    {
                        using (StreamReader reader = new StreamReader(PathFile))
                        {
                            string encryptedData = await reader.ReadLineAsync();
                            string decryptedData = DecryptData(encryptedData);
                            tempLog = decryptedData.Substring(0, AuthorizationLoginTb.TextLength);
                            tempPass = decryptedData.Substring(decryptedData.Length - AuthorizationPasswordTb.TextLength, AuthorizationPasswordTb.TextLength);
                        }
                        if (tempLog == AuthorizationLoginTb.Text && tempPass == AuthorizationPasswordTb.Text)
                        {
                            AuthorizationNotificationLabel.Text = "You Successfully Logged In";
                            AuthorizationNotificationLabel.ForeColor = Color.Green;
                            SaveLoadAndCopyGroupBox.Enabled = true;
                            AuthorizationGroupBox.Enabled = false;
                            using (StreamReader reader = new StreamReader(PathFile))
                            {
                                string line;
                                while ((line = await reader.ReadLineAsync()) != null)
                                {
                                    accountsDataList.Add(DecryptData(line));
                                    dataFile = accountsDataList[0];
                                }
                                for (int i = 1; i < accountsDataList.Count; i++)
                                {
                                    string outputLine = accountsDataList[i];
                                    AccountsListbx.Items.Add(accountsDataList[i - 1]);
                                    outputLine = outputLine.Substring(0, outputLine.IndexOf(' '));
                                    AccountsListbx.Items[i - 1] = outputLine;
                                }
                            }
                        }
                        else
                        {
                            AuthorizationNotificationLabel.Text = "Wrong Password or Login";
                            AuthorizationNotificationLabel.ForeColor = Color.Red;
                            SaveLoadAndCopyGroupBox.Enabled = false;
                            throw new Exception("Password or Login?");
                        }

                        using (FileStream fs = File.Open(PathFile, FileMode.Open, FileAccess.ReadWrite))
                        {
                            AddEncryption(PathFile);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account doesn't exist!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                        throw new Exception("Account?");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Data Please!", "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    throw new Exception("Data?");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            try
            {
                accountsDataList.Remove(accountsDataList.First());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
        #region SaveLoadAndCopy
        private void CopySavedPasswordBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccountPasswordTb.Text != "")
                {
                    Clipboard.SetText(AccountPasswordTb.Text);
                    IsCopiedAccountPasswordLb.Text = "Copied!";
                    Random randomizer = new Random();
                    int randColor = randomizer.Next(0, 2000000000);
                    IsCopiedAccountPasswordLb.ForeColor = Color.FromArgb(randColor);
                }
                else
                {
                    MessageBox.Show("Nothing to copy!", "Info", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    throw new Exception("И шо ты копировать собрался?");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private async void AccountSaverBt_Click(object sender, EventArgs e)
        {
            PathFile = folderName + "\\" + AuthorizationLoginTb.Text + ".txt";
            using (StreamWriter writer = new StreamWriter(PathFile, true))
            {
                string line = $"{NameServiceTb.Text} " + $"{AccountLoginTb.Text} " + $"{AccountPasswordTb.Text}";
                await writer.WriteLineAsync(EncryptData(line));

                accountsDataList.Add(line);


                string outputLine = accountsDataList[accountsDataList.Count - 1];
                AccountsListbx.Items.Add(accountsDataList[accountsDataList.Count - 1]);


                outputLine = outputLine.Substring(0, outputLine.IndexOf(' '));
                AccountsListbx.Items[AccountsListbx.Items.Count - 1] = outputLine;


            }
        }

        private void AccountsListbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string findAccount = AccountsListbx.Text;


            foreach (var account in accountsDataList)
            {
                string match = account.Substring(0, account.IndexOf(' '));
                try
                {
                    if (match.Equals(findAccount))
                    {

                        string[] tempLogPassArr = new string[3];
                        tempLogPassArr = account.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        NameServiceTb.Text = tempLogPassArr[0];
                        AccountLoginTb.Text = tempLogPassArr[1];
                        AccountPasswordTb.Text = tempLogPassArr[2];

                    }
                    else throw new Exception("What happened???");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

            }

        }

        private void ShowAccountModeChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowAccountModeChkbx.Checked == true)
            {
                Form1.ActiveForm.Size = new Size(600, 500);
            }
            else if (ShowAccountModeChkbx.Checked == false)
                Form1.ActiveForm.Size = new Size(600, 170);

        }


        private void DeleteAccountBt_Click(object sender, EventArgs e)
        {
            string stringToDelete = AccountsListbx.Text;
            try
            {
                //Delete account from listbox
                
                AccountsListbx.Items.Remove(AccountsListbx.Text);
                NameServiceTb.Text = "";
                AccountLoginTb.Text = "";
                AccountPasswordTb.Text = "";
                
                //Delete account from List
               
                foreach (var accountToDelete in accountsDataList)
                {
                    string match = accountToDelete.Substring(0, accountToDelete.IndexOf(' '));
                    if (match.Equals(stringToDelete))
                    {
                        accountsDataList.Remove(accountToDelete);
                        break;
                    }
                    else
                        throw new Exception("Something goes wrong...");
                }
                
                //Updating Data
                
                List<string> updatedDataAfterDelete = new List<string>();
                updatedDataAfterDelete.Add(EncryptData(dataFile));
                foreach (var accountToWrite in accountsDataList)
                {
                    string line = accountToWrite.ToString();
                    updatedDataAfterDelete.Add(EncryptData(line));

                }
                File.WriteAllLines(PathFile, updatedDataAfterDelete);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        #endregion
    }

}
