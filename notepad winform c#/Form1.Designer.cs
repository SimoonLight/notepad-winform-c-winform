namespace notepad_winform_c_
{
    partial class Form1
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
            main_txtbox = new RichTextBox();
            font_lbl = new Label();
            font_cmb = new ComboBox();
            size_lbl = new Label();
            size_cmb = new ComboBox();
            fontstyle_lbl = new Label();
            B_btn = new Button();
            U_btn = new Button();
            I_btn = new Button();
            alignment_lbl = new Label();
            L_btn = new Button();
            R_btn = new Button();
            C_btn = new Button();
            Color_lbl = new Label();
            color_cmb = new ComboBox();
            load_txtbox = new TextBox();
            save_txtbox = new TextBox();
            load_btn = new Button();
            save_btn = new Button();
            SuspendLayout();
            // 
            // main_txtbox
            // 
            main_txtbox.Location = new Point(2, 75);
            main_txtbox.Name = "main_txtbox";
            main_txtbox.Size = new Size(896, 363);
            main_txtbox.TabIndex = 0;
            main_txtbox.Text = "";
            // 
            // font_lbl
            // 
            font_lbl.AutoSize = true;
            font_lbl.Location = new Point(56, 9);
            font_lbl.Name = "font_lbl";
            font_lbl.Size = new Size(38, 20);
            font_lbl.TabIndex = 1;
            font_lbl.Text = "Font";
            // 
            // font_cmb
            // 
            font_cmb.FormattingEnabled = true;
            font_cmb.Location = new Point(12, 32);
            font_cmb.Name = "font_cmb";
            font_cmb.Size = new Size(126, 28);
            font_cmb.TabIndex = 2;
            font_cmb.SelectedIndexChanged += selected_font;
            // 
            // size_lbl
            // 
            size_lbl.AutoSize = true;
            size_lbl.Location = new Point(163, 9);
            size_lbl.Name = "size_lbl";
            size_lbl.Size = new Size(36, 20);
            size_lbl.TabIndex = 3;
            size_lbl.Text = "Size";
            // 
            // size_cmb
            // 
            size_cmb.FormattingEnabled = true;
            size_cmb.Location = new Point(144, 32);
            size_cmb.Name = "size_cmb";
            size_cmb.Size = new Size(76, 28);
            size_cmb.TabIndex = 4;
            size_cmb.SelectedIndexChanged += selected_size;
            // 
            // fontstyle_lbl
            // 
            fontstyle_lbl.AutoSize = true;
            fontstyle_lbl.Location = new Point(255, 9);
            fontstyle_lbl.Name = "fontstyle_lbl";
            fontstyle_lbl.Size = new Size(70, 20);
            fontstyle_lbl.TabIndex = 5;
            fontstyle_lbl.Text = "FontStyle";
            // 
            // B_btn
            // 
            B_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            B_btn.Location = new Point(246, 32);
            B_btn.Name = "B_btn";
            B_btn.Size = new Size(25, 29);
            B_btn.TabIndex = 6;
            B_btn.Text = "B";
            B_btn.UseVisualStyleBackColor = true;
            B_btn.Click += B_btn_Click;
            // 
            // U_btn
            // 
            U_btn.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            U_btn.Location = new Point(277, 32);
            U_btn.Name = "U_btn";
            U_btn.Size = new Size(25, 29);
            U_btn.TabIndex = 7;
            U_btn.Text = "U";
            U_btn.UseVisualStyleBackColor = true;
            U_btn.Click += U_btn_Click;
            // 
            // I_btn
            // 
            I_btn.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point);
            I_btn.Location = new Point(308, 32);
            I_btn.Name = "I_btn";
            I_btn.Size = new Size(21, 29);
            I_btn.TabIndex = 8;
            I_btn.Text = "I";
            I_btn.UseVisualStyleBackColor = true;
            I_btn.Click += I_btn_Click;
            // 
            // alignment_lbl
            // 
            alignment_lbl.AutoSize = true;
            alignment_lbl.Location = new Point(359, 8);
            alignment_lbl.Name = "alignment_lbl";
            alignment_lbl.Size = new Size(78, 20);
            alignment_lbl.TabIndex = 9;
            alignment_lbl.Text = "Alignment";
            // 
            // L_btn
            // 
            L_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            L_btn.Location = new Point(354, 32);
            L_btn.Name = "L_btn";
            L_btn.Size = new Size(25, 29);
            L_btn.TabIndex = 10;
            L_btn.Text = "L";
            L_btn.UseVisualStyleBackColor = true;
            L_btn.Click += L_btn_Click;
            // 
            // R_btn
            // 
            R_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            R_btn.Location = new Point(416, 32);
            R_btn.Name = "R_btn";
            R_btn.Size = new Size(25, 29);
            R_btn.TabIndex = 11;
            R_btn.Text = "R";
            R_btn.UseVisualStyleBackColor = true;
            R_btn.Click += R_btn_Click;
            // 
            // C_btn
            // 
            C_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            C_btn.Location = new Point(385, 31);
            C_btn.Name = "C_btn";
            C_btn.Size = new Size(25, 29);
            C_btn.TabIndex = 12;
            C_btn.Text = "C";
            C_btn.UseVisualStyleBackColor = true;
            C_btn.Click += C_btn_Click;
            // 
            // Color_lbl
            // 
            Color_lbl.AutoSize = true;
            Color_lbl.Location = new Point(512, 9);
            Color_lbl.Name = "Color_lbl";
            Color_lbl.Size = new Size(45, 20);
            Color_lbl.TabIndex = 13;
            Color_lbl.Text = "Color";
            // 
            // color_cmb
            // 
            color_cmb.FormattingEnabled = true;
            color_cmb.Location = new Point(468, 31);
            color_cmb.Name = "color_cmb";
            color_cmb.Size = new Size(135, 28);
            color_cmb.TabIndex = 14;
            color_cmb.SelectedIndexChanged += selected_color;
            // 
            // load_txtbox
            // 
            load_txtbox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            load_txtbox.Location = new Point(626, 6);
            load_txtbox.Name = "load_txtbox";
            load_txtbox.PlaceholderText = "Enter name and load file.";
            load_txtbox.Size = new Size(172, 25);
            load_txtbox.TabIndex = 15;
            // 
            // save_txtbox
            // 
            save_txtbox.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            save_txtbox.Location = new Point(626, 39);
            save_txtbox.Name = "save_txtbox";
            save_txtbox.PlaceholderText = "Tap to enter name and save.";
            save_txtbox.Size = new Size(172, 25);
            save_txtbox.TabIndex = 16;
            // 
            // load_btn
            // 
            load_btn.BackColor = SystemColors.AppWorkspace;
            load_btn.Location = new Point(804, 5);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(94, 29);
            load_btn.TabIndex = 17;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = false;
            load_btn.Click += load_btn_Click;
            // 
            // save_btn
            // 
            save_btn.BackColor = SystemColors.AppWorkspace;
            save_btn.Location = new Point(804, 40);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 18;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(save_btn);
            Controls.Add(load_btn);
            Controls.Add(save_txtbox);
            Controls.Add(load_txtbox);
            Controls.Add(color_cmb);
            Controls.Add(Color_lbl);
            Controls.Add(C_btn);
            Controls.Add(R_btn);
            Controls.Add(L_btn);
            Controls.Add(alignment_lbl);
            Controls.Add(I_btn);
            Controls.Add(U_btn);
            Controls.Add(B_btn);
            Controls.Add(fontstyle_lbl);
            Controls.Add(size_cmb);
            Controls.Add(size_lbl);
            Controls.Add(font_cmb);
            Controls.Add(font_lbl);
            Controls.Add(main_txtbox);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox main_txtbox;
        private Label font_lbl;
        private ComboBox font_cmb;
        private Label size_lbl;
        private ComboBox size_cmb;
        private Label fontstyle_lbl;
        private Button B_btn;
        private Button U_btn;
        private Button I_btn;
        private Label alignment_lbl;
        private Button L_btn;
        private Button R_btn;
        private Button C_btn;
        private Label Color_lbl;
        private ComboBox color_cmb;
        private TextBox load_txtbox;
        private TextBox save_txtbox;
        private Button load_btn;
        private Button save_btn;
    }
}
