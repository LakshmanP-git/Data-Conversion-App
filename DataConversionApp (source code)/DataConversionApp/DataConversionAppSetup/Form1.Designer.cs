namespace DataConversionApp
{
    partial class dataStorageConversion_frm
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
            convertFrom_grp = new GroupBox();
            terabit_rb = new RadioButton();
            gigabit_rb = new RadioButton();
            megabit_rb = new RadioButton();
            kilobit_rb = new RadioButton();
            byte_rb = new RadioButton();
            valueToConvert_txt = new TextBox();
            askForValue_lbl = new Label();
            convertTo_grp = new GroupBox();
            convert_btn = new Button();
            terabitConvert_rb = new RadioButton();
            gigabitConvert_rb = new RadioButton();
            megabitConvert_rb = new RadioButton();
            kilobitConvert_rb = new RadioButton();
            byteConvert_rb = new RadioButton();
            convertOutput_txt = new TextBox();
            askingDataSizeConvert_lbl = new Label();
            convertFrom_grp.SuspendLayout();
            convertTo_grp.SuspendLayout();
            SuspendLayout();
            // 
            // convertFrom_grp
            // 
            convertFrom_grp.Controls.Add(terabit_rb);
            convertFrom_grp.Controls.Add(gigabit_rb);
            convertFrom_grp.Controls.Add(megabit_rb);
            convertFrom_grp.Controls.Add(kilobit_rb);
            convertFrom_grp.Controls.Add(byte_rb);
            convertFrom_grp.Controls.Add(valueToConvert_txt);
            convertFrom_grp.Controls.Add(askForValue_lbl);
            convertFrom_grp.Location = new Point(42, 21);
            convertFrom_grp.Name = "convertFrom_grp";
            convertFrom_grp.Size = new Size(426, 300);
            convertFrom_grp.TabIndex = 0;
            convertFrom_grp.TabStop = false;
            convertFrom_grp.Text = "Convert From";
            // 
            // terabit_rb
            // 
            terabit_rb.AutoSize = true;
            terabit_rb.Location = new Point(31, 258);
            terabit_rb.Name = "terabit_rb";
            terabit_rb.Size = new Size(84, 19);
            terabit_rb.TabIndex = 6;
            terabit_rb.TabStop = true;
            terabit_rb.Text = "Terabit (Tb)";
            terabit_rb.UseVisualStyleBackColor = true;
            // 
            // gigabit_rb
            // 
            gigabit_rb.AutoSize = true;
            gigabit_rb.Location = new Point(31, 210);
            gigabit_rb.Name = "gigabit_rb";
            gigabit_rb.Size = new Size(89, 19);
            gigabit_rb.TabIndex = 5;
            gigabit_rb.TabStop = true;
            gigabit_rb.Text = "Gigabit (Gb)";
            gigabit_rb.UseVisualStyleBackColor = true;
            // 
            // megabit_rb
            // 
            megabit_rb.AutoSize = true;
            megabit_rb.Location = new Point(31, 165);
            megabit_rb.Name = "megabit_rb";
            megabit_rb.Size = new Size(98, 19);
            megabit_rb.TabIndex = 4;
            megabit_rb.TabStop = true;
            megabit_rb.Text = "Megabit (Mb)";
            megabit_rb.UseVisualStyleBackColor = true;
            // 
            // kilobit_rb
            // 
            kilobit_rb.AutoSize = true;
            kilobit_rb.Location = new Point(31, 123);
            kilobit_rb.Name = "kilobit_rb";
            kilobit_rb.Size = new Size(84, 19);
            kilobit_rb.TabIndex = 3;
            kilobit_rb.TabStop = true;
            kilobit_rb.Text = "Kilobit (Kb)";
            kilobit_rb.UseVisualStyleBackColor = true;
            // 
            // byte_rb
            // 
            byte_rb.AutoSize = true;
            byte_rb.Location = new Point(31, 77);
            byte_rb.Name = "byte_rb";
            byte_rb.Size = new Size(57, 19);
            byte_rb.TabIndex = 2;
            byte_rb.TabStop = true;
            byte_rb.Text = "Bit (B)";
            byte_rb.UseVisualStyleBackColor = true;
            // 
            // valueToConvert_txt
            // 
            valueToConvert_txt.Location = new Point(263, 28);
            valueToConvert_txt.Name = "valueToConvert_txt";
            valueToConvert_txt.Size = new Size(143, 23);
            valueToConvert_txt.TabIndex = 1;
            // 
            // askForValue_lbl
            // 
            askForValue_lbl.Location = new Point(6, 31);
            askForValue_lbl.Name = "askForValue_lbl";
            askForValue_lbl.Size = new Size(241, 31);
            askForValue_lbl.TabIndex = 0;
            askForValue_lbl.Text = "Enter the value to connect from then select the data size: ";
            // 
            // convertTo_grp
            // 
            convertTo_grp.Controls.Add(convert_btn);
            convertTo_grp.Controls.Add(terabitConvert_rb);
            convertTo_grp.Controls.Add(gigabitConvert_rb);
            convertTo_grp.Controls.Add(megabitConvert_rb);
            convertTo_grp.Controls.Add(kilobitConvert_rb);
            convertTo_grp.Controls.Add(byteConvert_rb);
            convertTo_grp.Controls.Add(convertOutput_txt);
            convertTo_grp.Controls.Add(askingDataSizeConvert_lbl);
            convertTo_grp.Location = new Point(507, 21);
            convertTo_grp.Name = "convertTo_grp";
            convertTo_grp.Size = new Size(426, 300);
            convertTo_grp.TabIndex = 7;
            convertTo_grp.TabStop = false;
            convertTo_grp.Text = "Convert To";
            // 
            // convert_btn
            // 
            convert_btn.Location = new Point(261, 123);
            convert_btn.Name = "convert_btn";
            convert_btn.Size = new Size(75, 23);
            convert_btn.TabIndex = 7;
            convert_btn.Text = "Convert";
            convert_btn.UseVisualStyleBackColor = true;
            convert_btn.Click += convert_btn_Click;
            // 
            // terabitConvert_rb
            // 
            terabitConvert_rb.AutoSize = true;
            terabitConvert_rb.Location = new Point(31, 258);
            terabitConvert_rb.Name = "terabitConvert_rb";
            terabitConvert_rb.Size = new Size(84, 19);
            terabitConvert_rb.TabIndex = 6;
            terabitConvert_rb.TabStop = true;
            terabitConvert_rb.Text = "Terabit (Tb)";
            terabitConvert_rb.UseVisualStyleBackColor = true;
            // 
            // gigabitConvert_rb
            // 
            gigabitConvert_rb.AutoSize = true;
            gigabitConvert_rb.Location = new Point(31, 210);
            gigabitConvert_rb.Name = "gigabitConvert_rb";
            gigabitConvert_rb.Size = new Size(89, 19);
            gigabitConvert_rb.TabIndex = 5;
            gigabitConvert_rb.TabStop = true;
            gigabitConvert_rb.Text = "Gigabit (Gb)";
            gigabitConvert_rb.UseVisualStyleBackColor = true;
            // 
            // megabitConvert_rb
            // 
            megabitConvert_rb.AutoSize = true;
            megabitConvert_rb.Location = new Point(31, 165);
            megabitConvert_rb.Name = "megabitConvert_rb";
            megabitConvert_rb.Size = new Size(98, 19);
            megabitConvert_rb.TabIndex = 4;
            megabitConvert_rb.TabStop = true;
            megabitConvert_rb.Text = "Megabit (Mb)";
            megabitConvert_rb.UseVisualStyleBackColor = true;
            // 
            // kilobitConvert_rb
            // 
            kilobitConvert_rb.AutoSize = true;
            kilobitConvert_rb.Location = new Point(31, 123);
            kilobitConvert_rb.Name = "kilobitConvert_rb";
            kilobitConvert_rb.Size = new Size(84, 19);
            kilobitConvert_rb.TabIndex = 3;
            kilobitConvert_rb.TabStop = true;
            kilobitConvert_rb.Text = "Kilobit (Kb)";
            kilobitConvert_rb.UseVisualStyleBackColor = true;
            // 
            // byteConvert_rb
            // 
            byteConvert_rb.AutoSize = true;
            byteConvert_rb.Location = new Point(31, 77);
            byteConvert_rb.Name = "byteConvert_rb";
            byteConvert_rb.Size = new Size(57, 19);
            byteConvert_rb.TabIndex = 2;
            byteConvert_rb.TabStop = true;
            byteConvert_rb.Text = "Bit (B)";
            byteConvert_rb.UseVisualStyleBackColor = true;
            // 
            // convertOutput_txt
            // 
            convertOutput_txt.Location = new Point(193, 164);
            convertOutput_txt.Name = "convertOutput_txt";
            convertOutput_txt.Size = new Size(216, 23);
            convertOutput_txt.TabIndex = 1;
            // 
            // askingDataSizeConvert_lbl
            // 
            askingDataSizeConvert_lbl.Location = new Point(6, 31);
            askingDataSizeConvert_lbl.Name = "askingDataSizeConvert_lbl";
            askingDataSizeConvert_lbl.Size = new Size(241, 31);
            askingDataSizeConvert_lbl.TabIndex = 0;
            askingDataSizeConvert_lbl.Text = "Select the data size to convert to: ";
            // 
            // dataStorageConversion_frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 401);
            Controls.Add(convertTo_grp);
            Controls.Add(convertFrom_grp);
            Name = "dataStorageConversion_frm";
            Text = "Data Storage Conversion";
            convertFrom_grp.ResumeLayout(false);
            convertFrom_grp.PerformLayout();
            convertTo_grp.ResumeLayout(false);
            convertTo_grp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox convertFrom_grp;
        private Label askForValue_lbl;
        private TextBox valueToConvert_txt;
        private RadioButton terabit_rb;
        private RadioButton gigabit_rb;
        private RadioButton megabit_rb;
        private RadioButton kilobit_rb;
        private RadioButton byte_rb;
        private GroupBox convertTo_grp;
        private RadioButton terabitConvert_rb;
        private RadioButton gigabitConvert_rb;
        private RadioButton megabitConvert_rb;
        private RadioButton kilobitConvert_rb;
        private RadioButton byteConvert_rb;
        private Label askingDataSizeConvert_lbl;
        private Button convert_btn;
        private TextBox convertOutput_txt;
    }
}
