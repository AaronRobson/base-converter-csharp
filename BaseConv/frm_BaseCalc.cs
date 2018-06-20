//#define TEST

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaseConv
{
    public partial class frm_BaseCalc : Form
    {
        BaseConvClass BC = new BaseConvClass();

        private void frm_Bas_Calc_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;   

#if TEST
            BaseConv.TestClass.RunTests(@"C:\", BC);
#endif
        }

        public frm_BaseCalc(string[] args2)
        {
            InitializeComponent();
            //Command_Line_Parsing(args2);
        }
        /*
        public void Command_Line_Parsing(string[] args3)
        {
            if (0 < args3.Length)
                if (args3[0] == "/swap")
                    Swap();
        }
        */
        private void Swap()
        {
            string temp = tbox_InBas.Text;
            tbox_InBas.Text = tbox_OutBas.Text;
            tbox_OutBas.Text = temp;
        }

        private void btn_Swap_Click(object sender, EventArgs e)
        {
            Swap();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            tbox_OutNum.Text = BC.BasCalc(tbox_InNum.Text, tbox_InBas.Text, tbox_OutBas.Text);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbox_InNum.Clear();
            tbox_InBas.Clear();
            tbox_OutNum.Clear();
            tbox_OutBas.Clear();
        }


        private void frm_Bas_Calc_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Escape) && !e.Shift)  // if Escape Key released while Shift Key is not pressed, Close Form
                this.Close();
        }
    }
}