using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RemoverByPattern
{
    public partial class RemoverByPattern : Form
    {
        public string argument;
        public RemoverByPattern()
        {
            InitializeComponent();
        }
        bool advanced = false;
        private void RemoverByPattern_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void RemoverByPattern_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Count() == 1 && System.IO.File.Exists(files[0]))
            {
                genremsult(files[0]);
            }
            else
            {
                label1.Text = "Please specify ONE existing pattern.";
            }
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a pattern.";
            ofd.InitialDirectory = Path.GetDirectoryName(argument);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(ofd.FileName))
                {
                    genremsult(ofd.FileName);
                }
                else
                {
                    label1.Text = "Please specify existing pattern.";
                }
            }
        }

        private void genremsult(string file)
        {
            if (System.IO.File.Exists($"{Path.GetDirectoryName(argument)}/rem-sult.txt")) { System.IO.File.Delete($"{Path.GetDirectoryName(argument)}/rem-sult.txt"); }
            System.IO.File.AppendAllText($"{Path.GetDirectoryName(argument)}/rem-sult.txt", "[////////////////////////////////////////////]\r\n\tRem-Sult from RemoverByPattern\r\n\t\t  By YideBN\r\n[////////////////////////////////////////////]\n\n");
            bool found = false;
            for (int i = 0; i < System.IO.File.ReadLines(argument).Count(); i++)
            {
                for (int m = 0; m < System.IO.File.ReadLines(file).Count(); m++)
                {
                    if (found != true)
                    {
                        if (!advanced)
                        {
                            if (System.IO.File.ReadLines(argument).ToArray()[i] == System.IO.File.ReadLines(file).ToArray()[m])
                            { found = true; }
                        }
                        else
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(System.IO.File.ReadLines(argument).ToArray()[i], System.IO.File.ReadLines(file).ToArray()[m], System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                            {
                                found = true;
                            }
                        }
                    }
                }
                if (found != true) {System.IO.File.AppendAllText($"{Path.GetDirectoryName(argument)}/rem-sult.txt", $"{System.IO.File.ReadLines(argument).ToArray()[i]}\n"); }; found = false;
            }
        }

        private void Advanced_CheckedChanged(object sender, EventArgs e)
        {
            advanced = Advanced.Checked;
        }
    }
}
