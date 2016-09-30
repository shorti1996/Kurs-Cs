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
using System.Diagnostics;

namespace ListaElementowDowolnegoRodzaju
{
    public partial class MainForm : Form
    {
        List<Laptop> laptopList = new List<Laptop>();
        Laptop currentLaptop = new Laptop();
        bool clicked = false;
        int indexTemp= -1;

        public MainForm()
        {
            InitializeComponent();
            //-------------------------------------
            int counter = 0;
            string line;
            List<String> listLine = new List<string>();
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("Database.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                listLine = null;
                Laptop laptop = new Laptop();
                listLine = (line.Split(';').ToList());
                laptop.Brand = listLine[0];
                laptop.Model = listLine[1];
                laptop.Processor = listLine[2];
                laptop.Graphics = listLine[3];
                laptop.MemoryRAM = listLine[4];
                laptop.ImageSource = listLine[5];
                laptopList.Add(laptop);
                counter++;
            }
            dataGridViewLaptops.DataSource = laptopList;
            file.Close();
            dataGridViewLaptops.Columns[5].Visible = false;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();
            laptop = ReadLaptopFromTextBoxes();
            laptopList.Add(laptop);
            RefreshDataGridViewLaptops();
        }

        /// <summary>
        /// Refreshes dataGridVievLaptops
        /// </summary>
        private void RefreshDataGridViewLaptops()
        {
            dataGridViewLaptops.DataSource = null;
            dataGridViewLaptops.DataSource = laptopList;
            dataGridViewLaptops.Columns[5].Visible = false;
        }

        /// <summary>
        /// Read from laptop textboxes and return filled laptop of Laptop type
        /// </summary>
        /// <returns></returns>
        private Laptop ReadLaptopFromTextBoxes()
        {
            Laptop laptop = new Laptop();
            laptop.Brand = textBoxBrand.Text;
            laptop.Model = textBoxModel.Text;
            laptop.Processor = textBoxProcessor.Text;
            laptop.Graphics = textBoxGraphics.Text;
            laptop.MemoryRAM = textBoxRAM.Text;
            return laptop;
        }

        /// <summary>
        /// Fills textboxes with specified laptop data
        /// </summary>
        /// <param name="laptop"></param>
        private void FillLaptopTextBoxes(Laptop laptop)
        {
            textBoxBrand.Text = laptop.Brand;
            textBoxModel.Text = laptop.Model;
            textBoxProcessor.Text = laptop.Processor;
            textBoxGraphics.Text = laptop.Graphics;
            textBoxRAM.Text = laptop.MemoryRAM;
        }

        private void CellClickLaptop(object sender, DataGridViewCellEventArgs e)
        {
            //get data of selected item and set image
            if(dataGridViewLaptops.SelectedRows.Count != 0)
            {
                Laptop laptop = new Laptop();
                laptop = (Laptop)dataGridViewLaptops.SelectedRows[0].DataBoundItem;
                currentLaptop = laptop;
                FillLaptopTextBoxes(currentLaptop);
                try
                {
                    pictureBoxPreview.Image = Image.FromFile(currentLaptop.ImageSource);
                }
                catch (Exception)
                {
                    pictureBoxPreview.Image = null;
                }
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                indexTemp = laptopList.IndexOf(laptop);
                Debug.WriteLine(indexTemp);
            }
        }

        private void buttonChangeImage_Click(object sender, EventArgs e)
        {
            //prepare open dialogs
            if (currentLaptop == null) return;
            OpenFileDialog openFileDialogImage = new OpenFileDialog();
            FolderBrowserDialog folderBrowserDialogImage = new FolderBrowserDialog();
            openFileDialogImage.InitialDirectory = "c:\\";
            openFileDialogImage.Filter = "Images (*.png, *.jpg, *gif)|*.png;*.jpg;*gif|All files (*.*)|*.*";
            openFileDialogImage.FilterIndex = 2;
            openFileDialogImage.RestoreDirectory = true;
            //get file path and name
            List<String> fileNamePath = new List<string>();
            String sourceFileName = GetFileNameAndPath(openFileDialogImage);
            String destinationFileName = Path.GetFileName(sourceFileName);
            destinationFileName = "Images/" + destinationFileName;
            Debug.WriteLine(sourceFileName);
            Debug.WriteLine(destinationFileName);
            //try to copy or write if necessary
            try
            {
                System.IO.File.Copy(sourceFileName, destinationFileName);
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Obrazek zostanie nadpisany.");
                File.Delete(destinationFileName);
                System.IO.File.Copy(sourceFileName, destinationFileName);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            try
            {
                int index = laptopList.IndexOf(currentLaptop);
                laptopList[index] = currentLaptop;
                currentLaptop.ImageSource = destinationFileName;
                RefreshDataGridViewLaptops();
                pictureBoxPreview.Image = Image.FromFile(currentLaptop.ImageSource);
            }
            catch (Exception)
            {
                MessageBox.Show("Podmiana nie powiodła się.");
            }
        }

        /// <summary>
        /// Gets specified file name and path
        /// </summary>
        /// <param name="openFileDialogImage"></param>
        /// <returns></returns>
        private static String GetFileNameAndPath(OpenFileDialog openFileDialogImage)
        {
            String sourceFileName = null;
            try
            {
                if (openFileDialogImage.ShowDialog() == DialogResult.OK)
                {
                    sourceFileName = openFileDialogImage.FileName;
                    Debug.WriteLine(sourceFileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Couldn't open. Original error: " + ex.Message);
            }
            return sourceFileName;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewLaptops.SelectedRows.Count == 0) return;
            //state-base solution
            if (clicked == false)
            {
                clicked = true;
                //to prevent user from messing up
                dataGridViewLaptops.Enabled = false;
                groupBoxPreview.Enabled = false;
                buttonEdit.Text = "Zapisz";
                //indexTemp to further overwrite the same laptop
                indexTemp = laptopList.IndexOf(currentLaptop);
                currentLaptop = (Laptop)dataGridViewLaptops.SelectedRows[0].DataBoundItem;
            }
            else
            {
                clicked = false;
                //reenable controls
                dataGridViewLaptops.Enabled = true;
                groupBoxPreview.Enabled = true;
                buttonEdit.Text = "Edytuj";
                Laptop newLaptop = new Laptop();
                String tempImageSource = currentLaptop.ImageSource;
                currentLaptop = ReadLaptopFromTextBoxes();
                currentLaptop.ImageSource = tempImageSource;
                laptopList[indexTemp] = currentLaptop;
                RefreshDataGridViewLaptops();
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("Database.txt");
            System.IO.File.Create("Database.txt").Close();
            foreach(Laptop laptop in laptopList)
            {
                List<String> tempList = new List<String>();
                tempList.Add(laptop.Brand);
                tempList.Add(laptop.Model);
                tempList.Add(laptop.Processor);
                tempList.Add(laptop.Graphics);
                tempList.Add(laptop.MemoryRAM);
                tempList.Add(laptop.ImageSource);
                string temp = String.Join(";", tempList);
                Debug.WriteLine(temp);
                StreamWriter sr = new StreamWriter("Database.txt", true);
                sr.WriteLine(temp);
                sr.Close();
            }
            MessageBox.Show("Zapisano do pliku.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLaptops.SelectedRows.Count == 0) return;
            laptopList.RemoveAt(indexTemp);
            //remove empty entries in list
            laptopList.RemoveAll(laptop => String.IsNullOrEmpty(laptop.ToString()));
            RefreshDataGridViewLaptops();
        }
    }
}
