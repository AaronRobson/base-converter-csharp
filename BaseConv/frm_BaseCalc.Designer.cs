namespace BaseConv
{
    partial class frm_BaseCalc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BaseCalc));
            this.tbox_OutNum = new System.Windows.Forms.TextBox();
            this.tbox_OutBas = new System.Windows.Forms.TextBox();
            this.tbox_InBas = new System.Windows.Forms.TextBox();
            this.tbox_InNum = new System.Windows.Forms.TextBox();
            this.lab_In_Num = new System.Windows.Forms.Label();
            this.lab_In_Bas = new System.Windows.Forms.Label();
            this.lab_Out_Bas = new System.Windows.Forms.Label();
            this.lab_Out_Num = new System.Windows.Forms.Label();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_OutNum
            // 
            this.tbox_OutNum.Location = new System.Drawing.Point(5, 170);
            this.tbox_OutNum.Name = "tbox_OutNum";
            this.tbox_OutNum.ReadOnly = true;
            this.tbox_OutNum.Size = new System.Drawing.Size(225, 20);
            this.tbox_OutNum.TabIndex = 5;
            // 
            // tbox_OutBas
            // 
            this.tbox_OutBas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_OutBas.Location = new System.Drawing.Point(5, 100);
            this.tbox_OutBas.Name = "tbox_OutBas";
            this.tbox_OutBas.Size = new System.Drawing.Size(225, 20);
            this.tbox_OutBas.TabIndex = 2;
            // 
            // tbox_InBas
            // 
            this.tbox_InBas.AllowDrop = true;
            this.tbox_InBas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_InBas.Location = new System.Drawing.Point(5, 60);
            this.tbox_InBas.Name = "tbox_InBas";
            this.tbox_InBas.Size = new System.Drawing.Size(225, 20);
            this.tbox_InBas.TabIndex = 1;
            // 
            // tbox_InNum
            // 
            this.tbox_InNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_InNum.Location = new System.Drawing.Point(5, 20);
            this.tbox_InNum.Name = "tbox_InNum";
            this.tbox_InNum.Size = new System.Drawing.Size(225, 20);
            this.tbox_InNum.TabIndex = 0;
            // 
            // lab_In_Num
            // 
            this.lab_In_Num.AutoSize = true;
            this.lab_In_Num.Location = new System.Drawing.Point(5, 5);
            this.lab_In_Num.Name = "lab_In_Num";
            this.lab_In_Num.Size = new System.Drawing.Size(71, 13);
            this.lab_In_Num.TabIndex = 4;
            this.lab_In_Num.Text = "Input &Number";
            // 
            // lab_In_Bas
            // 
            this.lab_In_Bas.AutoSize = true;
            this.lab_In_Bas.Location = new System.Drawing.Point(5, 45);
            this.lab_In_Bas.Name = "lab_In_Bas";
            this.lab_In_Bas.Size = new System.Drawing.Size(58, 13);
            this.lab_In_Bas.TabIndex = 5;
            this.lab_In_Bas.Text = "&Input Base";
            // 
            // lab_Out_Bas
            // 
            this.lab_Out_Bas.AutoSize = true;
            this.lab_Out_Bas.Location = new System.Drawing.Point(5, 85);
            this.lab_Out_Bas.Name = "lab_Out_Bas";
            this.lab_Out_Bas.Size = new System.Drawing.Size(66, 13);
            this.lab_Out_Bas.TabIndex = 6;
            this.lab_Out_Bas.Text = "&Output Base";
            // 
            // lab_Out_Num
            // 
            this.lab_Out_Num.AutoSize = true;
            this.lab_Out_Num.Location = new System.Drawing.Point(5, 155);
            this.lab_Out_Num.Name = "lab_Out_Num";
            this.lab_Out_Num.Size = new System.Drawing.Size(79, 13);
            this.lab_Out_Num.TabIndex = 7;
            this.lab_Out_Num.Text = "Output Nu&mber";
            // 
            // btn_Swap
            // 
            this.btn_Swap.Location = new System.Drawing.Point(85, 128);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(65, 23);
            this.btn_Swap.TabIndex = 4;
            this.btn_Swap.Text = "&Swap";
            this.btn_Swap.UseVisualStyleBackColor = true;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.AutoSize = true;
            this.btn_Calc.Location = new System.Drawing.Point(10, 128);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(65, 23);
            this.btn_Calc.TabIndex = 3;
            this.btn_Calc.Text = "&Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(160, 128);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(65, 23);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "&Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_BaseCalc
            // 
            this.AcceptButton = this.btn_Calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(324, 276);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.btn_Swap);
            this.Controls.Add(this.lab_Out_Num);
            this.Controls.Add(this.lab_Out_Bas);
            this.Controls.Add(this.lab_In_Bas);
            this.Controls.Add(this.lab_In_Num);
            this.Controls.Add(this.tbox_InNum);
            this.Controls.Add(this.tbox_InBas);
            this.Controls.Add(this.tbox_OutBas);
            this.Controls.Add(this.tbox_OutNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_BaseCalc";
            this.Text = "Base Calculator";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Bas_Calc_KeyUp);
            this.Load += new System.EventHandler(this.frm_Bas_Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_OutNum;
        private System.Windows.Forms.TextBox tbox_OutBas;
        private System.Windows.Forms.TextBox tbox_InBas;
        private System.Windows.Forms.TextBox tbox_InNum;
        private System.Windows.Forms.Label lab_In_Num;
        private System.Windows.Forms.Label lab_In_Bas;
        private System.Windows.Forms.Label lab_Out_Bas;
        private System.Windows.Forms.Label lab_Out_Num;
        private System.Windows.Forms.Button btn_Swap;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Clear;
    }
}

