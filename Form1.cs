using Microsoft.VisualBasic;

namespace deneme_winformapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, Dünya!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // labelin textini buton ile değiştirme ama butona bastığımızda kullanıcıdan veri alan bi pencere açılıp labele yazsın
            string a = Interaction.InputBox("Lütfen bir değer giriniz","Adınız","Boş",250,250);
            lbl_Adınız.Text = a;
            string b = "Merhaba, ";

        }
    }
}
