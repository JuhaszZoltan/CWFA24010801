namespace LabirintusGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUI01 = new Label();
            cbxOszlop = new ComboBox();
            cbxSor = new ComboBox();
            btnLetrehozas = new Button();
            btnMentes = new Button();
            cbxIndex = new ComboBox();
            pnlMain = new Panel();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(24, 34);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(227, 21);
            lblUI01.TabIndex = 0;
            lblUI01.Text = "labirintus mérete [sor x oszlop]:";
            // 
            // cbxOszlop
            // 
            cbxOszlop.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOszlop.FormattingEnabled = true;
            cbxOszlop.Location = new Point(318, 31);
            cbxOszlop.Name = "cbxOszlop";
            cbxOszlop.Size = new Size(55, 29);
            cbxOszlop.TabIndex = 1;
            // 
            // cbxSor
            // 
            cbxSor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSor.FormattingEnabled = true;
            cbxSor.Location = new Point(257, 31);
            cbxSor.Name = "cbxSor";
            cbxSor.Size = new Size(55, 29);
            cbxSor.TabIndex = 1;
            // 
            // btnLetrehozas
            // 
            btnLetrehozas.Location = new Point(17, 78);
            btnLetrehozas.Name = "btnLetrehozas";
            btnLetrehozas.Size = new Size(234, 29);
            btnLetrehozas.TabIndex = 2;
            btnLetrehozas.Text = "induló labirintus létrehozása";
            btnLetrehozas.UseVisualStyleBackColor = true;
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(257, 78);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(154, 29);
            btnMentes.TabIndex = 2;
            btnMentes.Text = "labirintus mentése";
            btnMentes.UseVisualStyleBackColor = true;
            // 
            // cbxIndex
            // 
            cbxIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxIndex.FormattingEnabled = true;
            cbxIndex.Location = new Point(417, 78);
            cbxIndex.Name = "cbxIndex";
            cbxIndex.Size = new Size(55, 29);
            cbxIndex.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(12, 126);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(460, 423);
            pnlMain.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(pnlMain);
            Controls.Add(btnMentes);
            Controls.Add(btnLetrehozas);
            Controls.Add(cbxSor);
            Controls.Add(cbxIndex);
            Controls.Add(cbxOszlop);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Labirintus készítő";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private ComboBox cbxOszlop;
        private ComboBox cbxSor;
        private Button btnLetrehozas;
        private Button btnMentes;
        private ComboBox cbxIndex;
        private Panel pnlMain;
    }
}
