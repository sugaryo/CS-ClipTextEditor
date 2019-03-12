using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipTextEditor
{
    public partial class ToolForm : Form
    {
        public ToolForm()
        {
            InitializeComponent();
        }

        #region distinct
        private void btnDistinct_Click(object sender, EventArgs e)
        {
            try
            {
                this.Distinct();
            }
            catch (Exception ex)
            {
                this.txtAfter.Text = ex.StackTrace;
                MessageBox.Show(ex.Message);
            }
        }

        private void Distinct()
        {
            var text = Clipboard.GetText();
            var each = text.lines().distinct();

            var sb = new StringBuilder();
            string ln = "";
            foreach (string str in each)
            {
                sb.Append(ln);
                sb.Append(str);
                ln = "\r\n";
            }
            string s = sb.ToString();

            Clipboard.Clear();
            Clipboard.SetText(s);

            this.txtBefore.Text = text;
            this.txtAfter.Text = s;
        }
        #endregion

        #region sequential [tab]
        private void btnSequentialTab_Click(object sender, EventArgs e)
        {
            try
            {
                this.SequentialTab();
            }
            catch (Exception ex)
            {
                this.txtAfter.Text = ex.StackTrace;
                MessageBox.Show(ex.Message);
            }
        }

        private void SequentialTab()
        {
            var text = Clipboard.GetText();
            var each = text.lines().sequential();


            var sb = new StringBuilder();
            string ln = "";
            foreach (string str in each)
            {
                sb.Append(ln);
                sb.Append(str);
                ln = "\r\n";
            }
            string s = sb.ToString();


            Clipboard.Clear();
            Clipboard.SetText(s);

            this.txtBefore.Text = text;
            this.txtAfter.Text = s;
        }
        #endregion

        #region sort
        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sort();
            }
            catch (Exception ex)
            {
                this.txtAfter.Text = ex.StackTrace;
                MessageBox.Show(ex.Message);
            }
        }

        private void Sort()
        {
            var text = Clipboard.GetText();
            var each = text.lines().OrderBy(x => x);


            var sb = new StringBuilder();
            string ln = "";
            foreach (string str in each)
            {
                sb.Append(ln);
                sb.Append(str);
                ln = "\r\n";
            }
            string s = sb.ToString();


            Clipboard.Clear();
            Clipboard.SetText(s);

            this.txtBefore.Text = text;
            this.txtAfter.Text = s;
        }
        #endregion
    }
}
