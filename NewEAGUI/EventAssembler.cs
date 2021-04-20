using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEAGUI
{
    public partial class EventAssembler : Form
    {

        String romFilepath = "";
        String scriptFilepath = "";
        String language = "FE8";
        bool buildTimes = false;
        bool outputSym = false;
        bool suppressMessages = false;
        bool suppressWarnings = false;
        bool noColors = false;
        bool errorWarnings = false;

        public EventAssembler()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //refresh custom language if necessary
            if (customLanguageButton.Checked) { language = customLanguageBox.Text; }

            String commandText = (" AA " + language + "\"-output:" + romFilepath + "\" " + "\"input:" + scriptFilepath + "\"");
            if (buildTimes) { commandText += " --build-times"; }
            if (outputSym) { commandText += "--nocash-sym"; }
            if (suppressMessages) { commandText += "--no-mess"; }
            if (suppressWarnings) { commandText += "--no-warn"; }
            if (noColors) { commandText += "--no-colored-log"; }
            if (errorWarnings) { commandText += "-werr"; }

            runEventAssembler(commandText);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void selectRomButton_Click(object sender, EventArgs e)
        {

            //open filepath dialog box
            using (OpenFileDialog romFileDialog = new OpenFileDialog())
            {

                romFileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                romFileDialog.Filter = "ROM files (*.gba)|*.gba|All files (*.*)|*.*";
                romFileDialog.FilterIndex = 0;
                romFileDialog.RestoreDirectory = true;

                if (romFileDialog.ShowDialog() == DialogResult.OK)
                {

                    romFilepath = romFileDialog.FileName;
                    romFilepathBox.Text = romFilepath;

                }
            }
        }

        private void selectScriptButton_Click(object sender, EventArgs e)
        {
            //open filepath dialog box
            using (OpenFileDialog scriptFileDialog = new OpenFileDialog())
            {

                scriptFileDialog.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                scriptFileDialog.Filter = "event files (*.event;*.txt)|*.event;*.txt|All files (*.*)|*.*";
                scriptFileDialog.FilterIndex = 0;
                scriptFileDialog.RestoreDirectory = true;

                if (scriptFileDialog.ShowDialog() == DialogResult.OK)
                {

                    scriptFilepath = scriptFileDialog.FileName;
                    scriptFilepathBox.Text = scriptFilepath;

                }
            }
        }

        private void buildOptionsChecklist_Click(object sender, EventArgs e)
        {

            buildTimes = buildOptionsChecklist.GetItemChecked(0);
            outputSym = buildOptionsChecklist.GetItemChecked(1);
            suppressMessages = buildOptionsChecklist.GetItemChecked(2);
            suppressWarnings = buildOptionsChecklist.GetItemChecked(3);
            noColors = buildOptionsChecklist.GetItemChecked(4);
            errorWarnings = buildOptionsChecklist.GetItemChecked(5);

            Console.WriteLine(buildTimes.ToString() + " " + outputSym.ToString() + " " + suppressMessages.ToString() + " " + suppressWarnings.ToString() + " " + noColors.ToString() + " " + errorWarnings.ToString());

        }

        private void fe6LanguageButton_Click(object sender, EventArgs e)
        {
            language = "FE6";
        }

        private void fe7LanguageButton_Click(object sender, EventArgs e)
        {
            language = "FE7";
        }

        private void fe8LanguageButton_Click(object sender, EventArgs e)
        {
            language = "FE8";
        }

        private void customLanguageButton_Click(object sender, EventArgs e)
        {
            language = customLanguageBox.Text;
        }

        private void runAssembleButton_Click(object sender, EventArgs e)
        {

            //refresh custom language if necessary
            if (customLanguageButton.Checked) { language = customLanguageBox.Text; }
            

            String commandText = (" A " + language + " \"-output:" + romFilepath + "\" " + "\"-input:" + scriptFilepath + "\"");
            if (buildTimes) { commandText += " --build-times"; }
            if (outputSym) { commandText += " --nocash-sym"; }
            if (suppressMessages) { commandText += " --no-mess"; }
            if (suppressWarnings) { commandText += " --no-warn"; }
            if (noColors) { commandText += " --no-colored-log"; }
            if (errorWarnings) { commandText += " -werr"; }

            runEventAssembler(commandText);


        }

        private void runEventAssembler(String commandText)
        {

            System.Diagnostics.Process runEA = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo runInfo = new System.Diagnostics.ProcessStartInfo();
            runInfo.FileName = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\ColorzCore.exe");
            runInfo.Arguments = commandText;
            runInfo.UseShellExecute = false;
            runInfo.RedirectStandardOutput = true;
            runInfo.RedirectStandardError = true;
            runInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            runInfo.CreateNoWindow = true;

            runEA.StartInfo = runInfo;

            StreamReader eaOutputStream;

            runEA.Start();
            eaOutputStream = runEA.StandardError;
            runEA.WaitForExit();

            Console.WriteLine(commandText);

            //start a message box containing the run output
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(eaOutputStream.ReadToEnd(), "Output", buttons);




        }
    }

}
