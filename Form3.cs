using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kinoprokat.DataBase;

namespace Kinoprokat
{
    public partial class MovieEditor : Form
    {
        DBControl DB;
        public MovieEditor(DBControl db)
        {
            DB = db;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
