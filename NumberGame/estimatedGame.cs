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

namespace NumberGame
{
    public partial class estimatedGame : Form
    {
        public estimatedGame()
        {
            InitializeComponent();
        }

        //<summary>
        //Form açıldığındaki olaylar       
        //</summary>
        private void estimatedGame_Load(object sender, EventArgs e)
        {
            //Kullanıcı ve skorlarının yazıldığı metin dosyasını satır satır okuma 
            string[] scoreList = File.ReadAllLines("KullaniciSkorlari.txt");
            // Okunan her satırı kullanıcı adı ve skoru olarak bölüp listviewe ekleme
            for (int index = 0; index < scoreList.Length; index++)
            {
                string[] userScoreInfo = scoreList[index].Split('|');
                ListViewItem scoreLVI = new ListViewItem(userScoreInfo);
                scoreListView.Items.Add(scoreLVI);
            }
        }

        //Random sayı üretmek için random sınıfından nesne üretme
        Random rnd = new Random();
        //Üretilen sayıyı değişken de tutma
        string numberToFind = "";

        //<summary>
        //Oyuna başlama butonuna tıklama olayı
        //</summary>
        private void startBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNameTxtBx.Text) == false)
            {
                //Seçilen basamak sayısına göre üretilen sayının aralığını belirleyip sayıyı üretme
                double countByMin = Math.Pow(10, (Convert.ToDouble(digitNumberNumericUpDown.Value) - 1));
                double countByMax = Math.Pow(10, Convert.ToDouble(Convert.ToDouble(digitNumberNumericUpDown.Value)));
                numberToFind = Convert.ToString(rnd.Next(Convert.ToInt32(countByMin), Convert.ToInt32(countByMax)));

                //Rakamların farklı olması isteniyorsa 
                if (recurringCheckBox.Checked == true)
                {
                    numberToFind = "";
                    int digit = 0;
                    //seçilen bamsamak sayısı kadar
                    while (digit < digitNumberNumericUpDown.Value)
                    {
                        //bir rakam üretip
                        int numeral = rnd.Next(10);
                        bool sameNumeral = false;

                        for (int i = 0; i < numberToFind.Length; i++)
                        {
                            //üretilen sayının içinde bu rakam zaten bulunuyorsa tekrar eklemeyip
                            if (numeral == Convert.ToInt32(numberToFind[i].ToString()))
                            {
                                sameNumeral = true;
                            }
                        }
                        //bulunmuyorsa yanına ekleyip sayıyı üretme
                        if (sameNumeral == false)
                        {
                            numberToFind += numeral.ToString();
                            digit++;
                        }
                    }
                }
                else
                {

                }
                //Basamak sayısına göre tahminin yazıldığı textbox ın karakter sayısını ayarlama
                estimatedNumberTxtBx.MaxLength = Convert.ToInt32(digitNumberNumericUpDown.Value);
                //Hak sayısını yazma
                retriesLbl.Text = retriesNumericUpDown.Value.ToString();
                //Formu düzenleme
                startBtn.Visible = false;
                estimatedPnl.Visible = true;
                remainingTimer.Enabled = true;
                userStatusPnl.Visible = true;
            }
            else
                MessageBox.Show("Lütfen kullanıcı adınızı giriniz!");

        }

       //<summary>
       //Kullanıcı tekrar oynamak istediğinde formun düzenini oluşturma olayı
       //</summary>
        public void AgainGame( string score)
        {
            //Tahmin edilen sayının üretilen sayıdaki  durumunu basamak basamak gösteren labelların dizisi
            Label[] digitToFindArr = { digit1Lbl, digit2Lbl, digit3Lbl, digit4Lbl, digit5Lbl, digit6Lbl, digit7Lbl, digit8Lbl, digit9Lbl, digit10Lbl };
            //Bu labelları temizleme
            for (int i = 0; i < digitToFindArr.Length; i++)
            {
                digitToFindArr[i].Text = "?";
                digitToFindArr[i].Visible = false;
            }
            //Geri kalan nesnelerin düzenlenmesi
            estimatedPnl.Visible = false;
            estimatedNumberTxtBx.Text = "";
            startBtn.Visible = true;
            //Sürenin başa dönmesi
            timeLbl.Text = "20";
            //Skorun tutulması
            scoreLbl.Text = score;
            //Bilinen rakamların yazıldığı listviewi temizleme
            numberToKnow.Items.Clear();
        }

        //<summary>
        //Tahmin etme butonuna tıklama olayı
        //</summary>
        private void estimatedBtn_Click(object sender, EventArgs e)
        {
            //Tahmin edilen sayının üretilen sayıdaki  durumunu basamak basamak gösteren labelların dizisi
            Label[] digitToFindArr = { digit1Lbl, digit2Lbl, digit3Lbl, digit4Lbl, digit5Lbl, digit6Lbl, digit7Lbl, digit8Lbl, digit9Lbl, digit10Lbl };

            if (String.IsNullOrEmpty(estimatedNumberTxtBx.Text) == false && estimatedNumberTxtBx.Text.Length == digitNumberNumericUpDown.Value)
            {
                //Her tahminde hakdan düşme
                    retriesLbl.Text = (Convert.ToInt32(retriesLbl.Text) - 1).ToString();
                //Her tahminde süreyi durdurma
                    remainingTimer.Stop();

                    for (int i = 0; i < digitNumberNumericUpDown.Value; i++)
                    {
                    //Seçilen basamak sayısı kadar labeli gösterme her tahminde rengini eski haline çevirme
                        digitToFindArr[i].ForeColor = Color.Black;
                        digitToFindArr[i].Visible = true;
                    //Tahmin edilen sayının içinde üretilen sayıda olan ve yeride aynı olan rakam varsa direkt basamak labelına yazdırma
                        if (numberToFind[i] == estimatedNumberTxtBx.Text[i])
                            digitToFindArr[i].Text = numberToFind[i].ToString();
                       
                        else if (numberToFind.Contains(estimatedNumberTxtBx.Text[i]))
                        { 
                        //Bilinen rakamları listviewe yazdırma
                         numberToKnow.Items.Add(estimatedNumberTxtBx.Text[i].ToString());
                       //Yeri farklıysa basamak labelının rengini değiştirme
                        if (digitToFindArr[i].Text == "?")
                                digitToFindArr[i].ForeColor = Color.Green;
                            else
                            {

                            }
                        }
                    }
              //Her tahminde süreyi tekrar başlatma
                    remainingTimer.Start();
                    timeLbl.Text = "20";


                //Sayı bilindiyse
                if (Convert.ToString(numberToFind) == estimatedNumberTxtBx.Text)
                {
                    remainingTimer.Enabled = false;
                    //Bilinen sayının basamak sayısına göre skor belirleme
                    scoreLbl.Text = (Convert.ToInt32(scoreLbl.Text) + estimatedNumberTxtBx.MaxLength * 10).ToString();
                    if (MessageBox.Show("Tebrikler Kazandınız :) Yeniden Oynamak İster Misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                //Tekrar oynamak istenirse tekrar oynama methodunu çağırma
                        AgainGame(scoreLbl.Text);
                    }
                    else
                    {
                //Yoksa kullanıcı adını ve skorunu txt ye yazdırıp listviewe ekleme       
                        FileStream fs = new FileStream("KullaniciSkorlari.txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(userNameTxtBx.Text + "|" + scoreLbl.Text);
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        string[] scoreList = File.ReadAllLines("KullaniciSkorlari.txt");
                        string[] userScoreInfo = scoreList[scoreList.Length-1].Split('|');
                        ListViewItem scoreLVI = new ListViewItem(userScoreInfo);
                        scoreListView.Items.Add(scoreLVI);
                        MessageBox.Show("Skorunuz kaydedilmiştir!");
                //Formu yeni oyun için hazırlama
                        userNameTxtBx.Text = "";
                        userStatusPnl.Visible = false;
                        AgainGame("0");
                    }

                }
                else
                {
                    //Hak sayısı bittiyse oyunu sonlandırma
                    if (Convert.ToInt32(retriesLbl.Text) == 0)
                    {
                        if (MessageBox.Show("Hakınız Bitti Kaybettiniz!Tekrar Denemek İster Misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            AgainGame(scoreLbl.Text);
                        }
                        else
                        {
                           
                            userNameTxtBx.Text = "";
                            userStatusPnl.Visible = false;
                            AgainGame("0");
                        }
                    }
                    else
                    {

                    }
                }
            }
            else
                MessageBox.Show("Lütfen " + estimatedNumberTxtBx.MaxLength.ToString() + " basamaklı bir tahmin giriniz.");
            
        }

        //<summary>
        //Tahmin etme süresi olayı
        //</summary>
        private void remainingTimer_Tick(object sender, EventArgs e)
        {
            //Her tahmin için verilen süreyi geri sayım halinde yazdırma
            timeLbl.Text = (Convert.ToInt32(timeLbl.Text) - 1).ToString();
            //Süre biterse oyunu durdurup kullanıcıya tekarar oynamak isteyip istemediğini sorma
            if (Convert.ToInt32(timeLbl.Text) == 0)
            {
                remainingTimer.Stop();
                if (MessageBox.Show("Süre Doldu Kaybettiniz!Tekrar Denemek İster Misiniz?", "Oyun Bitti", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AgainGame(scoreLbl.Text);
                }
                else
                {
                   //Oynamak istemiyorsa yeni oyuncu için formu düzenleme
                    userNameTxtBx.Text = "";
                    userStatusPnl.Visible = false;
                    AgainGame("0");
                }
            }
        }

        //<summary>
        //Skorları listeleme butonuna basma olayı
        //</summary>
        int controlClick = 0;
        private void scoreListBtn_Click(object sender, EventArgs e)
        {
           //İlk tıklamada gösterme
            if (controlClick == 0)
            {
                scoreListView.Visible = true;
                scoreListBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                controlClick++;
            }
            //İkincide gizleme
            else if(controlClick==1)
            {
                scoreListView.Visible = false;
                scoreListBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                controlClick=0;
            }
        }

        //<summary>
        //Tahmin edilen sayının yazıldığı textboxın karakter kontrol methodu
        //</summary>
        private void estimatedNumberTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sayı dışında bir karakter yazdırmama
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
