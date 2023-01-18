using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogProjesi
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tmrSaniye.Enabled = true;
        }

        private void YeniBlog_Click(object sender,EventArgs e)
        {
            /*
            //frmMain içinden yaratma.
            frmBlog frm = new frmBlog();
            frm.MdiParent = this;
            frm.Show();
            */

            //frmBlog içinden yaratma
            (frmBlog.Yeni(this)).Show(); //frmBlog sınıfını çağırıp nesne oluşturmadan içinden bir form döndürüp mainden gösteriyoruz show ile.
            BlogSayi(frmBlog.AktifBlogSayisi);

            //lblAktifBlogSayisi.Text = "Blog Sayısı : " + frmBlog.AktifBlogSayisi; // Metod oluşturduğumuz için kullanılmayacak.
        }

        private void BlogKapat_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild == null)
            {
                MessageBox.Show("Önce bir blog sayfası açmanız gerekiyor.");
                return;
            }
            frmBlog frm = (frmBlog)this.ActiveMdiChild;
            //Burada frmBlog olarak cast ediyoruz çünkü gelecek olan forma frmBlog gibi davranmasını istiyoruz.Çünkü başka bloglarda olabilir.

            frm.Kapat(); // Bunun için metod oluşturuyoruz çünkü ilerde içine soru sordurmada ekleyebiliriz.Daha fazla kontrol elde edebilmek için.
                         //frm.Close(); // Bu şekildede yapılabilir.

            
        }

        private void BlogKaydet_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                MessageBox.Show("Önce bir blog sayfası açmanız gerekiyor.");
                return;
            }
            frmBlog frm = (frmBlog)this.ActiveMdiChild;
            frm.Kaydet();
        }

        public void AktifFormAta(string FormAdı)
        {
            this.lblAktifBlogTarihi.Text = FormAdı;
        }

        public void BlogSayi(int BlogSayi)
        {
            lblAktifBlogSayisi.Text = "Blog Sayısı : " + BlogSayi;
        }

        private void tmrSaniye_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
