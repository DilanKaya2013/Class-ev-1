using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEv_Click(object sender, EventArgs e)
        {
            double fiyat=Convert.ToDouble(btnEv.Text);
            int binaYasi = Convert.ToInt32(btnEv.Text);
            string isitma = Convert.ToString(btnEv.Text);
            string binaKat= Convert.ToString(btnEv.Text);
            string ilce= Convert.ToString(btnEv.Text);
            string asonsor= Convert.ToString(btnEv.Text);
            string yanginCikis= Convert.ToString(btnEv.Text);
            string otopark= Convert.ToString(btnEv.Text);
            int bulunduguKat=Convert.ToInt32(btnEv.Text);
            bool esyali= Convert.ToBoolean(btnEv.Text);
            string metrekare= Convert.ToString(btnEv.Text);
            int odaSayisi= Convert.ToInt16(btnEv.Text);
            string ilanTarihi= Convert.ToString(btnEv.Text);
            int banyoSayisi= Convert.ToInt32(btnEv.Text);
            string emlakTuru= Convert.ToString(btnEv.Text);
            string balkon=Convert.ToString(btnEv.Text);
            string bahce= Convert.ToString(btnEv.Text);
            string teras= Convert.ToString(btnEv.Text);
            string manzara= Convert.ToString(btnEv.Text);
            string semt= Convert.ToString(btnEv.Text);
            string evturu= Convert.ToString(btnEv.Text);


            Emlak emlak=new Emlak("33 milyon","3 yıl","Petek","6 katlı","Beşiktaş","var 2. katta","2.katta","var içerde","3.kat","evet","300","7 odalı","3 gün önce","3 tane banyo var (ebeveyn banyosu,çocuk banyosu,misafir banyosu)","boş","4"," 10.10 metrekare ,var","var","deniz manzalı ve beşiktaş stadyumuna bakan","akat","apartman ")




















        }
    }
}
