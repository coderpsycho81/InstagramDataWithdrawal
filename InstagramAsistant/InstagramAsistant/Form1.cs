using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Net;
using System.IO;
using System.Drawing;

namespace InstagramAsistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ChromeDriver instagram;
        private bool isActive = false;
        private Thread instagramThread;

        #region Chrome Creat
        private void chromeCreat()
        {
            // Options
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--headless");

            // Servics
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);
            service.HideCommandPromptWindow = true;

            // Manager
            instagram = new ChromeDriver(service, options);
            instagram.Navigate().GoToUrl(urlText.Text);
            Thread.Sleep(500);

            isActive = true;
        }

        private void StartinstagramThread()
        {
            instagramThread = new Thread(chromeCreat);
            instagramThread.Start();
        }

        private void CheckIsActive()
        {
            while (true)
            {
                if (isActive)
                {
                    MessageBox.Show("Giriş Tamamlandı!");

                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Cursor = Cursors.Default;
                    });

                    InstagramUserSettings();

                    break;
                }
                Thread.Sleep(1000);
            }
        }

        private void urlInstagram_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urlText.Text))
            {
                MessageBox.Show("URL alanı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            StartinstagramThread();

            Thread checkIsActiveThread = new Thread(CheckIsActive);
            checkIsActiveThread.Start();
        }
        #endregion

        private void InstagramUserSettings()
        {
            if (isActive)
            {
                try
                {
                    Thread.Sleep(1000);

                    #region Resim Çekme
                    // Resim Çekme
                    userPicture.Load(instagram.FindElement(By.XPath("//img[@class='xpdipgo x972fbf xcfux6l x1qhh985 xm0m39n xk390pu x5yr21d xdj266r x11i5rnm xat24cr x1mh8g0r xl1xv1r xexx8yu x4uap5 x18d9i69 xkhd6sd x11njtxf xh8yej3']")).GetAttribute("src"));
                    userPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    #endregion

                    #region Username Çekme
                    // Username Çekme
                    IWebElement textElement = instagram.FindElement(By.XPath("//h2[@class='x1lliihq x1plvlek xryxfnj x1n2onr6 x193iq5w xeuugli x1fj9vlw x13faqbe x1vvkbs x1s928wv xhkezso x1gmr53x x1cpjm7i x1fgarty x1943h6x x1i0vuye x1ms8i2q xo1l8bm x5n08af x10wh9bi x1wdrske x8viiok x18hxmgj']"));
                    SetLabelText(usernameLabel, textElement.Text);
                    #endregion

                    #region Gönderi, Takip, Takipçi Çekme
                    // Gönderi Takipci vb Çekme
                    IWebElement ulElement = instagram.FindElement(By.XPath("//ul[@class='x78zum5 x1q0g3np xieb3on']"));
                    IList<IWebElement> liElements = ulElement.FindElements(By.TagName("li"));

                    for (int i = 0; i < liElements.Count && i < 3; i++)
                    {
                        Label label = null;
                        switch (i)
                        {
                            case 0:
                                label = sendLabel;
                                break;
                            case 1:
                                label = followerLabel;
                                break;
                            case 2:
                                label = followLabel;
                                break;
                        }

                        string sendLabelText = liElements[0].Text;
                        string followerLabelText = liElements[1].Text;
                        string followLabelText = liElements[2].Text;
                        SetLabelText(sendLabel, sendLabelText);
                        SetLabelText(followerLabel, followerLabelText);
                        SetLabelText(followLabel, followLabelText);
                    }
                    #endregion

                    #region Name Çekme
                    IWebElement nameText = instagram.FindElement(By.XPath("//span[@class='x1lliihq x1plvlek xryxfnj x1n2onr6 x193iq5w xeuugli x1fj9vlw x13faqbe x1vvkbs x1s928wv xhkezso x1gmr53x x1cpjm7i x1fgarty x1943h6x x1i0vuye xvs91rp x1s688f x5n08af x10wh9bi x1wdrske x8viiok x18hxmgj']"));
                    SetLabelText(nameLabel, nameText.Text);
                    #endregion

                    #region Açıklama Çekme
                    IWebElement exText = instagram.FindElement(By.XPath("//h1[@class='_ap3a _aaco _aacu _aacx _aad6 _aade']"));
                    SetLabelText(explanationLabel, exText.Text);
                    #endregion


                    this.Invoke((MethodInvoker)delegate
                    {
                        profilePhotoDownload.Enabled = true;

                        Thread.Sleep(1000);
                        GetAndDisplayImages();
                    });

                }
                catch (NoSuchElementException)
                {
                    MessageBox.Show("Hesap ile ilgili veri çekilirken bi hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region SetLabelText
        private void SetLabelText(Label label, string text)
        {
            this.Invoke((MethodInvoker)delegate {
                label.Text = text;
            });
        }
        #endregion

        #region profilePhotoDownload
        private void profilePhotoDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string profilePhotoUrl = instagram.FindElement(By.XPath("//img[@class='xpdipgo x972fbf xcfux6l x1qhh985 xm0m39n xk390pu x5yr21d xdj266r x11i5rnm xat24cr x1mh8g0r xl1xv1r xexx8yu x4uap5 x18d9i69 xkhd6sd x11njtxf xh8yej3']")).GetAttribute("src");

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "profile_photo.jpg"; 
                saveFileDialog.Filter = "JPEG Dosyaları|*.jpg|Tüm Dosyalar|*.*"; 

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(profilePhotoUrl, filePath);

                        MessageBox.Show("Profil fotoğrafı başarıyla indirildi ve " + filePath + " konumuna kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (NoSuchElementException)
            {
                MessageBox.Show("Profil fotoğrafı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil fotoğrafı indirilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GetAndDisplayImages
        private void GetAndDisplayImages()
        {
            IReadOnlyList<IWebElement> imgElements = instagram.FindElements(By.CssSelector("._aagv img"));

            Panel imageContainer = ımageContainer;
            imageContainer.AutoScroll = true;

            int totalWidth = 0;
            int yPosition = 0;
            foreach (IWebElement imgElement in imgElements)
            {
                string src = imgElement.GetAttribute("src");

                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(src);
                Image originalImage = Image.FromStream(new MemoryStream(imageData));

                int newWidth = Math.Min(imageContainer.ClientSize.Width / 5, originalImage.Width);
                int newHeight = (int)(((float)newWidth / originalImage.Width) * originalImage.Height);

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = new Bitmap(originalImage, newWidth, newHeight);
                pictureBox.Margin = new Padding(5);
                pictureBox.Location = new Point(totalWidth, yPosition);

                imageContainer.Controls.Add(pictureBox);

                totalWidth += newWidth + 10; 

                if (totalWidth + newWidth > imageContainer.ClientSize.Width)
                {
                    totalWidth = 0;
                    yPosition += newHeight + 10;
                }
            }

            Controls.Add(imageContainer);
        }
        #endregion
    }
}
