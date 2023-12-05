using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Graphics_lab5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//Get the path of specified file
				string filePath = openFileDialog1.FileName;

				//Read the contents of the file into a stream
				var fileStream = openFileDialog1.OpenFile();

				//using (StreamReader reader = new StreamReader(fileStream))
				//{
				//	fileContent = reader.ReadToEnd();
				//}

				pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
			}
		}
	}
}
