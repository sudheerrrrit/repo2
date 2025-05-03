using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Best_Notepad
{
    public partial class notepad1 : Form
    {
        //left side pr + - krny k lye hoti ha
        #region fields 
        //ye 3 viriable save k lye lye ha
        private bool isFileAlreadySave;
        private bool isFileDirty;
        private string currentOpenFileName;
       private FontDialog fontdialog = new FontDialog();  //format ma fontcolor ko apply krny k lye
        #endregion

        public notepad1()
        {
            InitializeComponent();
        }
        //3 br / / / ko ak sath likhny sy ye comments aty ha
        /// <summary>
        /// About Notepad with Hassan Malik ka all code ha nichy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// about notepad innformation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Right Reserved with Hassan ", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        /// <summary>
        /// New file open code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFileMaMethod();
        }

        private void newFileMaMethod()
        {
            //mainrichTextBox.Clear();
            //agr new p clilck kry to ye msg ay
            if (isFileDirty)
            {


                DialogResult result = MessageBox.Show("Do you want to save changes ? ", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                //yes no k lye code
                switch (result)
                {

                    case DialogResult.Yes:
                        savefilemanu();
                        break;

                    case DialogResult.No:

                        break;
                    case DialogResult.Cancel:
                        MessageBox.Show("Develop by Hassan Malik ","Go to New File", MessageBoxButtons.OK);
                        //undoKlyeMethod();
                        break;
                       
                }

            }

            //mehod ha ye right click kr k iski defination ma ja k dekh skty ha
            clearScreen(); //agr file ma kch ni ha to clearscreen ka jo khudsy method bnaya ha wo chly

            //ye save k lye kia ha k phly koi file ni ha r dirty b ni ha r open b ni ha koi file
            isFileAlreadySave = false;
            currentOpenFileName = "";

            EnableDisableUndoRedoProcessKaMethog(false);

            messagetoolStripStatusLabel.Text = "New Document is Created ";

        }


        /// <summary>
        /// exit application code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        /// <summary>
        /// open file code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenKlyeMethod(); 
        }

        private void OpenKlyeMethod()
        {
            //kse b file ko open krny k lye
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|MSWord Files (*.docx)|*.docx|PHP (*.php)|*.php";

            DialogResult result = openfiledialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openfiledialog.FileName) == ".txt")

                    mainrichTextBox.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.PlainText);

                //php ki file add krny k lye phly uper likhna pryga fr nichy ye 2 lines if condition k andr
                if (Path.GetExtension(openfiledialog.FileName) == ".php")
                    mainrichTextBox.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.PlainText);



                if (Path.GetExtension(openfiledialog.FileName) == ".rtf")
                    mainrichTextBox.LoadFile(openfiledialog.FileName, RichTextBoxStreamType.RichText);

                this.Text = Path.GetFileName(openfiledialog.FileName) + " - Notepad with Hassan Malik"; //file ka caption ma name dna jo b open kry
                //koi b file open kry to uska name b ajay

                //ye save k lye kia ha k phly koi file ni ha r dirty b ni ha r open b ni ha koi file
                isFileAlreadySave = true;
                isFileDirty = false;
                currentOpenFileName = openfiledialog.FileName;

                EnableDisableUndoRedoProcessKaMethog(false);

                messagetoolStripStatusLabel.Text = " File is Opened !";

            }

        }

        /// <summary>
        /// undo r redo k lye ak method bnaya ha 
        /// </summary>
        /// <param name="enable"></param>
        private void EnableDisableUndoRedoProcessKaMethog(bool enable)
        {
            undoToolStripMenuItem.Enabled = enable;
            redoToolStripMenuItem.Enabled = enable;
        }



        /// <summary>
        /// saveAs file code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {//save file code Call Method
            SaveAsFileKaMethod();

        }

        private void SaveAsFileKaMethod()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|MSWord Files (*.docx)|*.docx|PHP (*.php)|*.php";
            DialogResult result = savefiledialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(savefiledialog.FileName) == ".txt")
                    mainrichTextBox.SaveFile(savefiledialog.FileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(savefiledialog.FileName) == ".php")
                    mainrichTextBox.SaveFile(savefiledialog.FileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(savefiledialog.FileName) == ".rtf")
                    mainrichTextBox.SaveFile(savefiledialog.FileName, RichTextBoxStreamType.RichText);


                this.Text = Path.GetFileName(savefiledialog.FileName) + " -Notepad with Hassan Malik";

                //ye save k lye kia ha k phly koi file ni ha r dirty b ni ha r open b ni ha koi file
                isFileAlreadySave = true;
                isFileDirty = false;
                currentOpenFileName = savefiledialog.FileName;

            }
        }




        /// <summary>
        /// save file code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {//save file code method call
            savefilemanu();
        }

        private void savefilemanu()
        {
            if (isFileAlreadySave)//agr file phly he save ha to
            {
                //ismy sirf currentOpenFileName iska izafa kia ha baki porana code ha jo oper likha hooa ha

                if (Path.GetExtension(currentOpenFileName) == ".txt")
                    mainrichTextBox.SaveFile(currentOpenFileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(currentOpenFileName) == ".php")
                    mainrichTextBox.SaveFile(currentOpenFileName, RichTextBoxStreamType.PlainText);


                if (Path.GetExtension(currentOpenFileName) == ".rtf")
                    mainrichTextBox.SaveFile(currentOpenFileName, RichTextBoxStreamType.RichText);
                // this.Text = Path.GetFileName() + " -Notepad with Hassan Malik";
                isFileDirty = false;
            }
            else
            {

                if (isFileDirty)
                {
                    //right click kr k iski defination ko check kr skty ha
                    SaveAsFileKaMethod();

                }

                else
                {

                    clearScreen();


                }

            }
        }



        /// <summary>
        /// clearscreen code 
        /// </summary>
        private void clearScreen()
        {
            mainrichTextBox.Clear(); //phly clear kry dr nichy wala txt ko string m araha ha wo dikhay
            this.Text = "Untitled - Notepad with Hassan Malik";
            isFileDirty = false;
        }


        /// <summary>
        /// jb is application ko run kia jay to ye start ma null ho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            messagetoolStripStatusLabel.Text = " Normal Text File.. ";
            //ye save k lye kia ha k phly koi file ni ha r dirty b ni ha r open b ni ha koi file
             isFileAlreadySave = false;
             isFileDirty = false;
             currentOpenFileName = "";

            //YE WO NICHY JO CAPS HA USKY LYE HA

             if (Control.IsKeyLocked(Keys.CapsLock))
             {
                 capstoolStripStatusLabel.Text = " Caps ON";
             }
             else
             {
                 capstoolStripStatusLabel.Text = " Caps OFF";
             }

        }





        /// <summary>
        /// mainrichtextbox k lye ha ye
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainrichTextBox_TextChanged(object sender, EventArgs e)
        {
            isFileDirty = true; // k file ma kch ha
            undoToolStripMenuItem.Enabled = true; // jb ye ho to undo nzr ay wrna usko disable kia ta design ma left click kr k enable ko disable ki ta

            toolStripButton7.Enabled = true;
            //ye refresh klye ha
            undoToolStripMenuItem1.Enabled = true;
        }


        /// <summary>
        /// undo k lye ye code ha k phly mainrichtextbox.undo() ka method call ho r
        /// usky bad redo ka option true hojay yni nzr ay r undo disable hojay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoKlyeMethod();
        }

        private void undoKlyeMethod()
        {

            mainrichTextBox.Undo();
            redoToolStripMenuItem.Enabled = true;
            toolStripButton8.Enabled = true;
            toolStripButton7.Enabled = false;

            //yr refresh wali jga jo hoty ha usky llye
            undoToolStripMenuItem1.Enabled = false;
            redoToolStripMenuItem1.Enabled = true;

            undoToolStripMenuItem.Enabled = false;
            //jb ye undo ho tb redo b enable hojay
        }
        /// <summary>
        /// ye undo ka opposite ha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redoKlyemethod();
        }

        private void redoKlyemethod()
        {
            mainrichTextBox.Redo();
            redoToolStripMenuItem.Enabled = false;
            toolStripButton8.Enabled = false;
            toolStripButton7.Enabled = true;

            //yr refresh wali jga jo hoty ha usky llye
            undoToolStripMenuItem1.Enabled = true;
            redoToolStripMenuItem1.Enabled = false;

            undoToolStripMenuItem.Enabled = true;
        }

        //label pr apni website ka link dia ha
        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// login k name sy ak form bnaya ha usko yna object k zrye call kia ha 
        /// ye agr chlta ha to login page close ho k form1 wala page run hojay 
        /// r jb wo login wala page run hoga singnout agr krty ha to fr 
        /// login wala page close hojayga
        /// q k ye main page ha main page hide hota ha r andr wala page close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }



        /// <summary>
        /// selectall ka code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //select all easy ha ak he line ka code ha

            mainrichTextBox.SelectAll();
        }


        /// <summary>
        /// date time k lye code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //date time b ak he line ka code ha 

            mainrichTextBox.SelectedText = DateTime.Now.ToString();

        }

       

        //font ka kam strt hogya
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Bold);
           // mainrichTextBox.SelectionFont = new Font(mainrichTextBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //font style k lye ha ye ak ak line ma ak chz ho rhe ha jsy ye bold ka code ha
            FontKlyeMethod(FontStyle.Italic);
        }
        //method bnaya ha font ka
        private void FontKlyeMethod(FontStyle fontstyleVeriable)
        {

            mainrichTextBox.SelectionFont = new Font(mainrichTextBox.SelectionFont, fontstyleVeriable);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Underline);
           // mainrichTextBox.SelectionFont = new Font(mainrichTextBox.SelectionFont, FontStyle.Underline);
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Strikeout);
           // mainrichTextBox.SelectionFont = new Font(mainrichTextBox.SelectionFont, FontStyle.Strikeout);
        }

        private void normatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Regular);
        }


        /// <summary>
        /// format font k lye code instance veriable ma ak r chz private kr k dalni pryge  
        /// ak event k lye b programmming krni ha ismy/// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formatFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontKlyeMethod();
        }

        private void fontKlyeMethod()
        {
            // FontDialog fontdialog = new FontDialog() { 
            fontdialog.ShowColor = true;
            fontdialog.ShowApply = true;

            fontdialog.Apply += new System.EventHandler(fontdialog_apply);

            //  };
            // fontdialog.ShowColor = true;

            DialogResult result = fontdialog.ShowDialog(); //ye dialogresult khudsy agr na likha jay to uper sy copy krlyn

            if (result == DialogResult.OK)
            {
                if (mainrichTextBox.SelectionLength > 0)
                {
                    mainrichTextBox.SelectionFont = fontdialog.Font;
                    mainrichTextBox.SelectionColor = fontdialog.Color;
                }
                else
                {
                    //MessageBox.Show("please select first");
                }
            }
            else
            {


            }

        }

        private void fontdialog_apply(object sender, EventArgs e) {

            if (mainrichTextBox.SelectionLength > 0)
            {
                mainrichTextBox.SelectionFont = fontdialog.Font;
                mainrichTextBox.SelectionColor = fontdialog.Color;
            }
        
        }









        /// <summary>
        /// text ka color change krny k lye code
        /// ye dialogresult k lye mne uper sy dialogresult ko cupy kia hoa h
        /// uper yni isi page ma uper sy na k khe r sy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordialog = new ColorDialog();
            DialogResult result = colordialog.ShowDialog();

            if (result == DialogResult.OK)
            {

                if (mainrichTextBox.SelectionLength > 0)
                {

                    mainrichTextBox.SelectionColor = colordialog.Color;
                
                }
            
            }

        }

        private void newtoolStripButton_Click(object sender, EventArgs e)
        {
            newFileMaMethod();
          //  messagetoolStripStatusLabel.Text = "New Click.. ";
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenKlyeMethod();
            //messagetoolStripStatusLabel.Text = "Open Click.. ";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //save file code method call
            savefilemanu();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //save file code Call Method
            SaveAsFileKaMethod();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            undoKlyeMethod();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            redoKlyemethod();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

            FontKlyeMethod(FontStyle.Bold);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Italic);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Underline);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Strikeout);
        }

        private void toolStripButton12_Click_1(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Strikeout);
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            fontKlyeMethod();
        }

        private void mainrichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                capstoolStripStatusLabel.Text = " Caps ON";
            }
            else
            {
                capstoolStripStatusLabel.Text = " Caps OFF";
            }

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Refresh();


        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FontKlyeMethod(FontStyle.Bold);
        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Italic);
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Underline);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontKlyeMethod(FontStyle.Regular);
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            undoKlyeMethod();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            redoKlyemethod();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://allice9554.000webhostapp.com/");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainrichTextBox.SelectionLength > 0)
            {


                Clipboard.SetText(mainrichTextBox.SelectedText);
                mainrichTextBox.SelectedText = "";

            }
            //if(mainrichTextBox.SelectionLength >0)
           // mainrichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainrichTextBox.SelectionLength > 0)
            mainrichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                mainrichTextBox.SelectedText = Clipboard.GetText();
            }
           // mainrichTextBox.Paste();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (mainrichTextBox.SelectionLength > 0)
            {


                Clipboard.SetText(mainrichTextBox.SelectedText);
                mainrichTextBox.SelectedText = "";

            }
            //mainrichTextBox.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (mainrichTextBox.SelectionLength > 0)
            mainrichTextBox.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                mainrichTextBox.SelectedText = Clipboard.GetText();
            }
           // mainrichTextBox.Paste();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            if (mainrichTextBox.SelectionLength > 0)
            {


                Clipboard.SetText(mainrichTextBox.SelectedText);
                mainrichTextBox.SelectedText = "";

            }
            //mainrichTextBox.Cut();
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (mainrichTextBox.SelectionLength > 0)
            mainrichTextBox.Copy();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                mainrichTextBox.SelectedText = Clipboard.GetText();
            }
            //mainrichTextBox.Paste();
        }

        private void speachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SpeechForm sp = new SpeechForm();
            sp.Show();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SpeechForm sp = new SpeechForm();
            sp.Show();
           // if()
            messagetoolStripStatusLabel.Text = "SpeechBOx Start.. ";
        }

        private void speechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void messagetoolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //messagetoolStripStatusLabel.Text = " Start.. ";
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //SecondCalculator.mainForm m = new SecondCalculator.mainForm();
            //m.ShowDialog();
        }
    }
}
