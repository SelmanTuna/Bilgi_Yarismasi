namespace ders_11_bilgi_yarışması_
{
    public partial class YarismaEkrani : Form
    {
        public YarismaEkrani()
        {
            InitializeComponent();
        }
        int soruno;
        int doğru = 0;
        int yanlış = 0;
        int süre = 20;


        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button2.Text;

            if (label3.Text == label4.Text)
            {
                doğru++;
                label7.Text = doğru.ToString();

            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 20;
            label9.Text = süre.ToString();


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

           

            button5.Text = "İLERİ";

            soruno++;
            label2.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğmuştur?";
                button1.Text = "1980";
                button2.Text = "1880";
                button3.Text = "1881";
                button4.Text = "1934";

                label4.Text = "1881";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = " Türkiye kaç coğrafi bölgeye ayrılır?";
                button1.Text = "5";
                button2.Text = "4";
                button3.Text = "7";
                button4.Text = "8";

                label4.Text = "7";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiye nin yüzölçümü en büyük il hangisidir?";
                button1.Text = "Ankara";
                button2.Text = "Erzurum";
                button3.Text = "İstanbul";
                button4.Text = "Konya";

                label4.Text = "Konya";

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;



            label3.Text = button1.Text;

            if (label3.Text == label4.Text)
            {
                doğru++;
                label7.Text = doğru.ToString();

            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            timer1.Enabled = false;

            label3.Text = button3.Text;

            if (label3.Text == label4.Text)
            {
                doğru++;
                label7.Text = doğru.ToString();

            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button4.Text;

            if (label3.Text == label4.Text)
            {
                doğru++;
                label7.Text = doğru.ToString();

            }
            else
            {
                yanlış++;
                label8.Text = yanlış.ToString();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label9.Text);
            süre = süre - 1;
            label9.Text = süre.ToString();


            if (süre == 0)
            {
                timer1.Enabled = false;
                yanlış++;
                label8.Text = yanlış.ToString();

            }
        }
    }
}