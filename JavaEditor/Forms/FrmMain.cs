using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JavaEditor.Core;

namespace JavaEditor {
    public partial class FrmMain : Form {

        private Style KeywordsStyle = (Style)new TextStyle(Brushes.Purple, (Brush)null, FontStyle.Bold);
        private Style VarStyle = (Style)new TextStyle(Brushes.Blue, (Brush)null, FontStyle.Regular);

        public FrmMain() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            // TODO
        }

        private void txtBox_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            //Beginning of Syntax Highlighting
            /*
            this.txtBox.Range.ClearStyle(this.KeywordsStyle, this.VarStyle);
            this.txtBox.Range.SetStyle(this.KeywordsStyle, "\\b(public|private|protected|void|int)");
            foreach (Range r in this.txtBox.GetRanges("\\b(int)\\s+(?<range>\\w+)\\b"))
            {
                this.txtBox.Range.SetStyle(this.VarStyle, "\\b" + r.Text + "\\b");
            }*/
        }

        private void runCodeBtn_Click(object sender, EventArgs e)
        {
            Compiler.run(txtBox.Text);
        }
    }
}
