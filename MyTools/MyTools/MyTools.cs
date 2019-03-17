using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SautinSoft.PdfFocus;

namespace PictureSizeChange
{
    public partial class MyTools : Form
    {
        public MyTools()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {       //select images
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Image Files|*.jpg;*.png";
                    of.Multiselect = true;
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                    //add images to listbox
                        foreach (var i in of.FileNames)
                        {
                            lbxFile.Items.Add(i);
                        }
                        if (lbxFile.Items.Count > 0)
                        btnConvert.Enabled = true;                        
                    }                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {          
            try {             
                //change images size
                    if (!Directory.Exists("new_images")) Directory.CreateDirectory("new_images");
                    // SaveFileDialog sf = new SaveFileDialog();
                   
                    foreach (var i in lbxFile.Items)
                    {
                        Bitmap bmp = new Bitmap(Image.FromFile(i + ""), new Size(Convert.ToInt32(nudWid.Value), Convert.ToInt32(nudHeig.Value)));
                        bmp.Save("new_images\\" + Path.GetFileName(i + ""));
                    }
                    MessageBox.Show("Ok converted");
                Process.Start("new_images");
                lbxFile.Items.Clear();
                btnConvert.Enabled = false;
               
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  // select pdf files
            ofd.Filter = "PDF Files|*.pdf";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var i in ofd.FileNames)
                {
                    lbxFile.Items.Add(i);
                }
                if (lbxFile.Items.Count > 0) btnConvPdf.Enabled = true;
            }
            
        }

        private void btnConvPdf_Click(object sender, EventArgs e)
        { 
            if (!Directory.Exists("new_pdf")) Directory.CreateDirectory("new_Pdf");
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            foreach (var i in lbxFile.Items)
            {
                
                f.OpenPdf(i + "");
                f.ToWord(@"new_pdf\\" + Path.GetFileName(i + "")+".doc");
               
            }
            MessageBox.Show("Ok converted");
            lbxFile.Items.Clear();
            btnConvPdf.Enabled = false;
            Process.Start("new_Pdf");
          //  FileStream stream = File.Open("new_Pdf", FileMode.Open);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear listbox
            lbxFile.Items.Clear();
            btnConvert.Enabled = false;
            btnConvPdf.Enabled = false;
             
        }                
    }
}
