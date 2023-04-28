using System.Drawing.Text;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void Cikar(string hastaAdi)
        {


            for (int i=0;  i<adSoyad.Length; i++)
            {
                if (adSoyad[i] == hastaAdi)
                {
                    adSoyad[i] = null;
                    
                }}    
        
        
        }
        private void Listele()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < adSoyad.Length; i++)
                if (adSoyad[i] != null)
                    listBox1.Items.Add(adSoyad[i]);
        }

        string[] adSoyad = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i=0; i<adSoyad.Length; i++)
            {
                if (adSoyad[i] == null)
                {
                    adSoyad[i] = textBox1.Text;
                    break;
                }
            }
            textBox1.Clear();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilmisOlan = listBox1.SelectedIndex;
            if (secilmisOlan == -1)
            {
                MessageBox.Show("Önce Çýkarýlacak Elemaný Seç");
                return;
            }
            Cikar(listBox1.SelectedItem.ToString());
            Listele();

        }
    }
}