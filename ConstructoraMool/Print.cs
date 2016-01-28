using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Novacode;

namespace Mool
{
	public partial class Print : Form
	{
		private DataTable collection = null;

		public delegate bool GeneratorFile();
		public GeneratorFile GenerateFile = null;
		public Print(DataTable collection)
		{
			InitializeComponent();
			this.collection = collection;
			GenerateFile += GenerateFileHandler;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GenerateFile();
		}

		private bool GenerateFileHandler()
		{
			return true;
		}
	}
}
