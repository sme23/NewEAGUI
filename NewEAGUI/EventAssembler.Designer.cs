namespace NewEAGUI
{
    partial class EventAssembler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventAssembler));
            this.romFilepathBox = new System.Windows.Forms.TextBox();
            this.scriptFilepathBox = new System.Windows.Forms.TextBox();
            this.buildOptionsChecklist = new System.Windows.Forms.CheckedListBox();
            this.runAssembleButton = new System.Windows.Forms.Button();
            this.runOutputAsmButton = new System.Windows.Forms.Button();
            this.selectRomButton = new System.Windows.Forms.Button();
            this.selectScriptButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.fe6LanguageButton = new System.Windows.Forms.RadioButton();
            this.fe7LanguageButton = new System.Windows.Forms.RadioButton();
            this.fe8LanguageButton = new System.Windows.Forms.RadioButton();
            this.customLanguageButton = new System.Windows.Forms.RadioButton();
            this.customLanguageBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // romFilepathBox
            // 
            this.romFilepathBox.Location = new System.Drawing.Point(72, 12);
            this.romFilepathBox.Name = "romFilepathBox";
            this.romFilepathBox.Size = new System.Drawing.Size(203, 20);
            this.romFilepathBox.TabIndex = 0;
            // 
            // scriptFilepathBox
            // 
            this.scriptFilepathBox.Location = new System.Drawing.Point(72, 38);
            this.scriptFilepathBox.Name = "scriptFilepathBox";
            this.scriptFilepathBox.Size = new System.Drawing.Size(203, 20);
            this.scriptFilepathBox.TabIndex = 1;
            // 
            // buildOptionsChecklist
            // 
            this.buildOptionsChecklist.CheckOnClick = true;
            this.buildOptionsChecklist.FormattingEnabled = true;
            this.buildOptionsChecklist.Items.AddRange(new object[] {
            "Show build times",
            "Output no$ .sym file",
            "Suppress messages",
            "Suppress warnings",
            "No colored log",
            "Treat warnings as errors"});
            this.buildOptionsChecklist.Location = new System.Drawing.Point(9, 64);
            this.buildOptionsChecklist.Name = "buildOptionsChecklist";
            this.buildOptionsChecklist.Size = new System.Drawing.Size(141, 94);
            this.buildOptionsChecklist.TabIndex = 2;
            this.buildOptionsChecklist.SelectedIndexChanged += new System.EventHandler(this.buildOptionsChecklist_Click);
            // 
            // runAssembleButton
            // 
            this.runAssembleButton.Location = new System.Drawing.Point(113, 164);
            this.runAssembleButton.Name = "runAssembleButton";
            this.runAssembleButton.Size = new System.Drawing.Size(81, 24);
            this.runAssembleButton.TabIndex = 3;
            this.runAssembleButton.Text = "Assemble";
            this.runAssembleButton.UseVisualStyleBackColor = true;
            this.runAssembleButton.Click += new System.EventHandler(this.runAssembleButton_Click);
            // 
            // runOutputAsmButton
            // 
            this.runOutputAsmButton.Location = new System.Drawing.Point(12, 164);
            this.runOutputAsmButton.Name = "runOutputAsmButton";
            this.runOutputAsmButton.Size = new System.Drawing.Size(81, 24);
            this.runOutputAsmButton.TabIndex = 4;
            this.runOutputAsmButton.Text = "Output ASM";
            this.runOutputAsmButton.UseVisualStyleBackColor = true;
            this.runOutputAsmButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectRomButton
            // 
            this.selectRomButton.Location = new System.Drawing.Point(9, 13);
            this.selectRomButton.Name = "selectRomButton";
            this.selectRomButton.Size = new System.Drawing.Size(57, 19);
            this.selectRomButton.TabIndex = 5;
            this.selectRomButton.Text = "ROM";
            this.selectRomButton.UseVisualStyleBackColor = true;
            this.selectRomButton.Click += new System.EventHandler(this.selectRomButton_Click);
            // 
            // selectScriptButton
            // 
            this.selectScriptButton.Location = new System.Drawing.Point(9, 39);
            this.selectScriptButton.Name = "selectScriptButton";
            this.selectScriptButton.Size = new System.Drawing.Size(57, 19);
            this.selectScriptButton.TabIndex = 6;
            this.selectScriptButton.Text = "Script";
            this.selectScriptButton.UseVisualStyleBackColor = true;
            this.selectScriptButton.Click += new System.EventHandler(this.selectScriptButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // fe6LanguageButton
            // 
            this.fe6LanguageButton.AutoSize = true;
            this.fe6LanguageButton.Location = new System.Drawing.Point(215, 67);
            this.fe6LanguageButton.Name = "fe6LanguageButton";
            this.fe6LanguageButton.Size = new System.Drawing.Size(44, 17);
            this.fe6LanguageButton.TabIndex = 7;
            this.fe6LanguageButton.Text = "FE6";
            this.fe6LanguageButton.UseVisualStyleBackColor = true;
            this.fe6LanguageButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.fe6LanguageButton.Click += new System.EventHandler(this.fe6LanguageButton_Click);
            // 
            // fe7LanguageButton
            // 
            this.fe7LanguageButton.AutoSize = true;
            this.fe7LanguageButton.Location = new System.Drawing.Point(215, 90);
            this.fe7LanguageButton.Name = "fe7LanguageButton";
            this.fe7LanguageButton.Size = new System.Drawing.Size(44, 17);
            this.fe7LanguageButton.TabIndex = 8;
            this.fe7LanguageButton.Text = "FE7";
            this.fe7LanguageButton.UseVisualStyleBackColor = true;
            this.fe7LanguageButton.Click += new System.EventHandler(this.fe7LanguageButton_Click);
            // 
            // fe8LanguageButton
            // 
            this.fe8LanguageButton.AutoSize = true;
            this.fe8LanguageButton.Checked = true;
            this.fe8LanguageButton.Location = new System.Drawing.Point(215, 113);
            this.fe8LanguageButton.Name = "fe8LanguageButton";
            this.fe8LanguageButton.Size = new System.Drawing.Size(44, 17);
            this.fe8LanguageButton.TabIndex = 9;
            this.fe8LanguageButton.TabStop = true;
            this.fe8LanguageButton.Text = "FE8";
            this.fe8LanguageButton.UseVisualStyleBackColor = true;
            this.fe8LanguageButton.Click += new System.EventHandler(this.fe8LanguageButton_Click);
            // 
            // customLanguageButton
            // 
            this.customLanguageButton.AutoSize = true;
            this.customLanguageButton.Location = new System.Drawing.Point(215, 136);
            this.customLanguageButton.Name = "customLanguageButton";
            this.customLanguageButton.Size = new System.Drawing.Size(60, 17);
            this.customLanguageButton.TabIndex = 10;
            this.customLanguageButton.Text = "Custom";
            this.customLanguageButton.UseVisualStyleBackColor = true;
            this.customLanguageButton.Click += new System.EventHandler(this.customLanguageButton_Click);
            // 
            // customLanguageBox
            // 
            this.customLanguageBox.Location = new System.Drawing.Point(215, 158);
            this.customLanguageBox.Name = "customLanguageBox";
            this.customLanguageBox.Size = new System.Drawing.Size(60, 20);
            this.customLanguageBox.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EventAssembler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 190);
            this.Controls.Add(this.customLanguageBox);
            this.Controls.Add(this.customLanguageButton);
            this.Controls.Add(this.fe8LanguageButton);
            this.Controls.Add(this.fe7LanguageButton);
            this.Controls.Add(this.fe6LanguageButton);
            this.Controls.Add(this.selectScriptButton);
            this.Controls.Add(this.selectRomButton);
            this.Controls.Add(this.runOutputAsmButton);
            this.Controls.Add(this.runAssembleButton);
            this.Controls.Add(this.buildOptionsChecklist);
            this.Controls.Add(this.scriptFilepathBox);
            this.Controls.Add(this.romFilepathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventAssembler";
            this.Text = "Event Assembler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox romFilepathBox;
        private System.Windows.Forms.TextBox scriptFilepathBox;
        private System.Windows.Forms.CheckedListBox buildOptionsChecklist;
        private System.Windows.Forms.Button runAssembleButton;
        private System.Windows.Forms.Button runOutputAsmButton;
        private System.Windows.Forms.Button selectRomButton;
        private System.Windows.Forms.Button selectScriptButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RadioButton fe6LanguageButton;
        private System.Windows.Forms.RadioButton fe7LanguageButton;
        private System.Windows.Forms.RadioButton fe8LanguageButton;
        private System.Windows.Forms.RadioButton customLanguageButton;
        private System.Windows.Forms.TextBox customLanguageBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

