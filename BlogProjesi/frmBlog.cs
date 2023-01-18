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

namespace BlogProjesi
{
    public partial class frmBlog : TemelForm
    {
        public static int AktifBlogSayisi = 0;
        public frmBlog()
        {
            InitializeComponent();
        }

        static public frmBlog Yeni(frmMain main)
        {

            frmBlog.AktifBlogSayisi++;
            return new frmBlog()
            {
                MdiParent = main
            };
            
            
        }

        public void Kapat()
        {
            
            
            Close();
        }

        public void Kaydet ()
        {
            string dosyaDizin = @"C:\Ornek\";
            string dosyaAdı = this.Text + ".txt";

            FileStream fs = File.Create(dosyaDizin + dosyaAdı);
            var sr = new StreamWriter(fs);
            sr.WriteLine(textBox1.Text);
            sr.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Text; //Datetimepicker daki değeri bulunduğu formun text ine atıyor.
            frmMain main = (frmMain)this.MdiParent;
            main.AktifFormAta(this.Text);
        }

        private void frmBlog_Load(object sender, EventArgs e)
        {
            this.Text = dateTimePicker1.Text; // Bunuda çalıştığında direk atması için koyduk yokse datetimepicker ı değiştirmeden gösteriyordu.
            frmMain main = (frmMain)this.MdiParent; //Burada main forma ulaşmak için bir nesne çekiyoruz.
            main.AktifFormAta(this.Text);//Oluşturduğumuz nesnenin içinden Main formun metodunu çekiyoruz ve bu frmBlog un text ini mainin toolstrip ine atıyoruz.
        }

        private void frmBlog_Activated(object sender, EventArgs e)
        {
            frmMain main = (frmMain)this.MdiParent;
            main.AktifFormAta(this.Text);
            tmrKapat.Enabled = true;
        }

        private void frmBlog_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBlog.AktifBlogSayisi--;
            frmMain main = (frmMain)this.MdiParent;
            main.BlogSayi(frmBlog.AktifBlogSayisi);
        }

        private void tmrKapat_Tick(object sender, EventArgs e)
        {
            tmrKapat.Enabled = false;
            Kapat();
        }

        private void frmBlog_Deactivate(object sender, EventArgs e)
        {
            tmrKapat.Stop();
        }
    }
}
