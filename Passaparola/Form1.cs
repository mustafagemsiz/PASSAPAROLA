using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:if (textBox1.Text.ToUpper() == "ANKARA")
                        {
                            circularButton1.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton1.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 2:
                        if (textBox1.Text.ToUpper() == "BURSA")
                        {
                            circularButton2.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton2.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 3:
                        if (textBox1.Text.ToUpper() == "CUMA")
                        {
                            circularButton3.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton3.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 4:
                        if (textBox1.Text.ToUpper() == "DİYARBAKIR")
                        {
                            circularButton4.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton4.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 5:
                        if (textBox1.Text.ToUpper() == "EDİRNE")
                        {
                            circularButton5.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton5.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 6:
                        if (textBox1.Text.ToUpper() == "FAYTON")
                        {
                            circularButton6.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton6.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 7:
                        if (textBox1.Text.ToUpper() == "GRAM")
                        {
                            circularButton7.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton7.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 8:
                        if (textBox1.Text.ToUpper() == "HANÇER")
                        {
                            circularButton8.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton8.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 9:
                        if (textBox1.Text.ToUpper() == "ISIRGAN OTU")
                        {
                            circularButton9.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton9.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 10:
                        if (textBox1.Text.ToUpper() == "JANDARMA")
                        {
                            circularButton10.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton10.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 11:
                        if (textBox1.Text.ToUpper() == "KUZEY KORE")
                        {
                            circularButton11.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton11.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 12:
                        if (textBox1.Text.ToUpper() == "LAZ")
                        {
                            circularButton12.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton12.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 13:
                        if (textBox1.Text.ToUpper() == "MART")
                        {
                            circularButton13.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton13.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 14:
                        if (textBox1.Text.ToUpper() == "NİSAN")
                        {
                            circularButton14.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton14.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 15:
                        if (textBox1.Text.ToUpper() == "OCTOBERFEST")
                        {
                            circularButton15.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton15.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 16:
                        if (textBox1.Text.ToUpper() == "PHUKET")
                        {
                            circularButton16.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton16.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 17:
                        if (textBox1.Text.ToUpper() == "RAMAZAN")
                        {
                            circularButton17.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton17.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 18:
                        if (textBox1.Text.ToUpper() == "SAMSUN")
                        {
                            circularButton18.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton18.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 19:
                        if (textBox1.Text.ToUpper() == "TAYLAND")
                        {
                            circularButton19.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton19.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 20:
                        if (textBox1.Text.ToUpper() == "URFA")
                        {
                            circularButton20.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton20.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 21:
                        if (textBox1.Text.ToUpper() == "VAR")
                        {
                            circularButton21.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton21.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;
                    case 22:
                        if (textBox1.Text.ToUpper() == "ZEYTİN")
                        {
                            circularButton22.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            textBox1.Text = "";
                        }
                        else
                        {
                            circularButton22.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            textBox1.Text = "";
                        }
                        break;



                }
            }
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi >= 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                int sayac = sayi--;
                lblSure.Text = sayac.ToString();
                if (sayac == 0)
                {
                    MessageBox.Show("Süre bitti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Enabled = false;
                }
            }
            


        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        int sayi = 90;
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "İleri";
            soruno++;
            timer1.Interval = 1000;
            timer1.Enabled = true;



            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin başkentinin adı?";
                circularButton1.BackColor = Color.Yellow;
                button2.Text = "A";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara bölgesindeki ilimiz?";
                circularButton2.BackColor = Color.Yellow;
                button2.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                circularButton3.BackColor = Color.Yellow;
                button2.Text = "C";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                circularButton4.BackColor = Color.Yellow;
                button2.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Türkiye'nin Yunanlara komşu olan ili?";
                circularButton5.BackColor = Color.Yellow;
                button2.Text = "E";

            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Adalarda hayvan haklarını ihlal eden ulaşım aracı?";
                circularButton6.BackColor = Color.Yellow;
                button2.Text = "F";

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Kilonun 1000'de biri?";
                circularButton7.BackColor = Color.Yellow;
                button2.Text = "G";

            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Hasan Sabbah ve fedailerinin kullandığı alet?";
                circularButton8.BackColor = Color.Yellow;
                button2.Text = "H";

            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Ellendiğinde kaşıntı yapan bitki?";
                circularButton9.BackColor = Color.Yellow;
                button2.Text = "I";

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Polis ve Asker karışımı?";
                circularButton10.BackColor = Color.Yellow;
                button2.Text = "J";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Dış dünyaya kendini kapayan atom bombası sahibi ülke?";
                circularButton11.BackColor = Color.Yellow;
                button2.Text = "K";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Karadenizde yoğunlukla yaşayan etnisite?";
                circularButton12.BackColor = Color.Yellow;
                button2.Text = "L";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Kapıdan baktırınca kazma kürek yaktıran ay?";
                circularButton13.BackColor = Color.Yellow;
                button2.Text = "M";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Ondan sonraki ay?";
                circularButton14.BackColor = Color.Yellow;
                button2.Text = "N";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Eylül ayının son hafta Almanya'da düzenlenen festival?";
                circularButton15.BackColor = Color.Yellow;
                button2.Text = "O";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Tayland'da bulunan turistik ada?";
                circularButton16.BackColor = Color.Yellow;
                button2.Text = "P";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                circularButton17.BackColor = Color.Yellow;
                button2.Text = "R";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Atatürk'ün çıkıp kurtuluş savaşını başlattığı ilimiz?";
                circularButton18.BackColor = Color.Yellow;
                button2.Text = "S";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Başkenti Bangkok olan Güney Asya ülkesi?";
                circularButton19.BackColor = Color.Yellow;
                button2.Text = "T";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Şanlı olan ilimiz";
                circularButton20.BackColor = Color.Yellow;
                button2.Text = "U";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "C# dilinde genel olarak kullanılan tür";
                circularButton21.BackColor = Color.Yellow;
                button2.Text = "V";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Akdeniz bölgesinde yetişen,yağından da faydalanılan meyve?";
                circularButton22.BackColor = Color.Yellow;
                button2.Text = "Z";

            }

        }

    }
}
