using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VisorDeImagenes
{
    public partial class Form1 : Form
    {
        string V = "C:\\Users\\DELL\\Downloads\\VisorDeImagenes\\VisorDeImagenes\\Imagenes";
        private Bitmap originalImage;
        string imageDirectory = "C:\\Users\\DELL\\Downloads\\VisorDeImagenes\\VisorDeImagenes\\Imagenes";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            LoadImagesFromFolder();

           
            radioButton1.Text = "Ajustar";
            radioButton2.Text = "Zoom";
            radioButton3.Text = "Centrada";
            radioButton1.Checked = true;
        }

        private void LoadImagesFromFolder()
        {
            comboBox1.Items.Clear();

            try
            {
                if (!Directory.Exists(imageDirectory))
                {
                    MessageBox.Show("La carpeta de imágenes no existe en la ruta especificada.", "Error de ruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] files = Directory.GetFiles(imageDirectory);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (extension == ".jpg" || extension == ".png" || extension == ".jpg" || extension == ".jpg")
                    {
                        comboBox1.Items.Add(Path.GetFileName(file));
                    }
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron imágenes en la carpeta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las imágenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string imagePath = GetImagePath(comboBox1.SelectedItem.ToString());
            if (File.Exists(imagePath))
            {
                
                using (var tempImage = new Bitmap(imagePath))
                {
                    originalImage = new Bitmap(tempImage);
                }
                pictureBox1.Image = originalImage;
                ApplySettings();
            }
            else
            {
                MessageBox.Show("Archivo no encontrado: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                normalToolStripMenuItem.Checked = false;
                escalasDeGrisesToolStripMenuItem_.Checked = true;
                checkBox1.Checked = false;
                checkBox2.Checked = true;
                ApplySettings();
                checkBox2.AutoCheck = false;
                
            }
            else
            {
                checkBox2.AutoCheck = true;
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
            radioButton1.Checked = true;
            radioButton1.AutoCheck = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            toolStripCentrada.Checked = true;
            toolStripAjustar.Checked = false;
            toolStripZoom.Checked = false;
                ApplySettings();
            }
            else
            {
                radioButton1.AutoCheck = true;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                
                radioButton2.AutoCheck = false;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                radioButton3.Checked = false;
                toolStripCentrada.Checked = false;
                toolStripAjustar.Checked = true;
                toolStripZoom.Checked = false;
                ApplySettings();
            }
            else
            {
                radioButton2.AutoCheck = true;
            }
            
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

                radioButton3.AutoCheck = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
                toolStripCentrada.Checked = false;
                toolStripAjustar.Checked = false;
                toolStripZoom.Checked = true;
                ApplySettings();
            }
            else
            {
                radioButton3.AutoCheck = true;
            }
            
            
        }

        private void ApplySettings()
        {
            if (originalImage == null)
            {
                return;
            }

            
            if (checkBox2.Checked)
            {
                pictureBox1.Image = ConvertToGrayscale(originalImage);
            }
            else
            {
                pictureBox1.Image = originalImage;
            }

           
            if (radioButton1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (radioButton2.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private Bitmap ConvertToGrayscale(Bitmap original)
        {
            if (original == null)
            {
                return null;
            }

            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color pixelColor = original.GetPixel(i, j);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(pixelColor.A, grayScale, grayScale, grayScale);
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        private string GetImagePath(string imageName)
        {
            
            return Path.Combine(imageDirectory, imageName);
        }

        

        private void girar90ALaIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void girar90ALaDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Refresh();
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                try
                {
                    Clipboard.SetImage(pictureBox1.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < comboBox1.Items.Count - 1)
            {
                comboBox1.SelectedIndex++;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void toolStripNormal_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            toolStripNormal.Checked = true;
            toolStripEscalasGrises.Checked = false;
            ApplySettings();
        }

        private void toolStripEscalasGrises_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            toolStripEscalasGrises.Checked = true;
            toolStripNormal.Checked = false;
            checkBox1.Checked = false;
            ApplySettings();
        }

        private void toolStripCentrada_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            toolStripCentrada.Checked = true;
            toolStripAjustar.Checked = false;
            toolStripZoom.Checked = false;
            ApplySettings();
        }

        private void toolStripAjustar_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            radioButton3.Checked = false;
            toolStripCentrada.Checked = false;
            toolStripAjustar.Checked = true;
            toolStripZoom.Checked = false;
            ApplySettings();
        }

        private void toolStripZoom_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            toolStripCentrada.Checked = false;
            toolStripAjustar.Checked = false;
            toolStripZoom.Checked = true;
            ApplySettings();
        }

        
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            normalToolStripMenuItem.Checked = true;
            escalasDeGrisesToolStripMenuItem_.Checked = false;
            ApplySettings();
        }

        private void escalasDeGrisesToolStripMenuItem__Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem.Checked = false;
            escalasDeGrisesToolStripMenuItem_.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            ApplySettings();
        }

        private void centradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            ApplySettings();
        }

        private void ajustarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            ApplySettings();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            ApplySettings();
        }

       

        private void btnPrevious_Click_2(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex > 0)
            {
                comboBox1.SelectedIndex--;
            }
            else
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
        }

        private void btnFirst_Click_2(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btnLast_Click_2(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                normalToolStripMenuItem.Checked = true;
                escalasDeGrisesToolStripMenuItem_.Checked = false;
                checkBox1.Checked = true;
                checkBox2.Checked = false;
                checkBox1.AutoCheck = false;
                ApplySettings();
            }
            else
            {
                checkBox1.AutoCheck = true;
            }
        }
    }
}