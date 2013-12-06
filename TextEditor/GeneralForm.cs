using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class GeneralForm : Form
    {
        /*
         * сборка 1.0
         * сборка 1.1 * добавлен поиск, выводящий только результаты, удовлетворяющие запросу
         */
        Encoding enc = Encoding.UTF8;
        List<string> files = new List<string>();
        string[] BUFFER = new string[0];
        public GeneralForm()
        {
            InitializeComponent();
            toolStripComboBoxMaskDivision.Items.Add("от нумерации");//каждый пункт нумерации в отдельный файл
            toolStripComboBoxMaskDivision.Items.Add("от подстроки");//каждую строку, содержащую подстроку, считать началом следующего файла
            toolStripComboBoxMaskDivision.Text = "от подстроки";
        }

        void COPY()
        {
            BUFFER = richTextBoxGeneral.Lines;
        }

        void PASTE()
        {
            richTextBoxGeneral.Text = "";
            foreach (string s in BUFFER)
            {
                richTextBoxGeneral.Text += s + "\n";
            }
        }

        private void удалитьВсеАбзацыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxGeneral.Text = richTextBoxGeneral.Text.Replace("\n", "");
        }

        private void удалитьВсюТабуляциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxGeneral.Text = richTextBoxGeneral.Text.Replace("\t", "");
        }

        private void фоматироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxGeneral.SelectedText != "")
            { 
                richTextBoxGeneral.SelectedText = richTextBoxGeneral.SelectedText.Replace("\n", "");
                richTextBoxGeneral.SelectedText = richTextBoxGeneral.SelectedText.Replace("\t", "");
                richTextBoxGeneral.SelectedText = richTextBoxGeneral.SelectedText.Replace("¬", "");
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxGeneral.Text = "";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //filename = Application.StartupPath + "\\mySavedFiles\\" + ".txt";
                OpenFileDialog opendialog = openFileDialogGeneral;
                //savedialog.FileName = "C:\\Users\\Николай\\Music\\Core Attack - ";
                opendialog.Title = "Открыть";
                opendialog.CheckPathExists = true;
                opendialog.Filter =
                    "Текстовые файлы(*.txt)|*.txt|Cue (*.cue)|*.cue|PromoDJ Cue (*.pue)|*.pue|Playlist (*.m3u)|*.m3u|RTF (*.rtf)|*.rtf|Все файлы(*.*)|*.*";
                opendialog.ShowHelp = true;
                char[] sep = { '\\' };
                if (opendialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBoxGeneral.Text += opendialog.FileName + "\n";
                    richTextBoxGeneral.Text += File.ReadAllText(opendialog.FileName, enc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(richTextBoxGeneral.Text);
        }

        void save(string s)
        {
            try
            {
                //filename = Application.StartupPath + "\\mySavedFiles\\" + ".txt";
                SaveFileDialog savedialog = saveFileDialogGeneral;
                //savedialog.FileName = "C:\\Users\\Николай\\Music\\Core Attack - ";
                savedialog.Title = "Сохранить как ...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter =
                    "Текстовые файлы(*.txt)|*.txt|RTF (*.rtf)|*.rtf|Все файлы(*.*)|*.*";
                savedialog.ShowHelp = true;
                char[] sep = { '\\' };
                // If selected, save
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = savedialog.FileName.Remove(savedialog.FileName.Length - 4);
                    string strFilExtn = savedialog.FileName.Remove(0, savedialog.FileName.Length - 3);
                    if (strFilExtn.Equals("rtf"))
                    {
                        richTextBox1.Rtf.Insert(0, richTextBoxGeneral.Text);
                        File.WriteAllText(prefix.Text + fileName + postfix.Text + "." + strFilExtn, s);
                    }
                    else
                    {
                        File.WriteAllText(prefix.Text + fileName + postfix.Text + "." + strFilExtn, s);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
        }

        void saveAll(string[] arr)
        {
            try
            {
                //filename = Application.StartupPath + "\\mySavedFiles\\" + ".txt";
                SaveFileDialog savedialog = saveFileDialogGeneral;
                //savedialog.FileName = "C:\\Users\\Николай\\Music\\Core Attack - ";
                savedialog.Title = "Сохранить как ...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter =
                    "Текстовые файлы(*.txt)|*.txt|Все файлы(*.*)|*.*";
                savedialog.ShowHelp = true;
                char[] sep = { '\\' };
                // If selected, save
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        string fileName = savedialog.FileName.Remove(savedialog.FileName.Length - 4);
                        string strFilExtn = savedialog.FileName.Remove(0, savedialog.FileName.Length - 3);
                        string[] spl = fileName.Split('\\');
                        fileName = "";
                        if (использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Checked)
                        {
                            string s = arr[i].Split('\n')[0];
                            if (s.Length < 100)
                                fileName += modifString(prefix.Text + s + postfix.Text);
                            else
                                fileName += modifString(prefix.Text + s.Substring(0, 99) + postfix.Text);
                        }
                        else
                            for (int j = 0; j < spl.Length; j++)
                                if (j != spl.Length - 1)
                                    fileName += spl[j] + '\\';
                                else
                                    fileName += modifString(i + 1 + "-" + prefix.Text + spl[j] + postfix.Text);
                        File.WriteAllText(fileName + "." + strFilExtn, '\n' +  arr[i], enc);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
            }
        }

        string modifString(string s)
        {
            char[] c = {'?', ':', '/', '|', '\\', '"', '*', '>', '<', '\t', '\n', '\r'};
            while (s.IndexOfAny(c) != -1)
                s = s.Remove(s.IndexOfAny(c), 1);
            return s;
        }

        private void сохранитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAll(files.ToArray());
        }

        private void разбитьНаФайлыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            divisionFile();
        }
        //деление файла на подфайлы
        void divisionFile()
        {
            files.Clear();
            string str = "";
            bool first = true;
            foreach(string s in richTextBoxGeneral.Lines)
            {
                if (equalsMask(s))
                {
                    if (!first)
                    {
                        if (str != "")
                            files.Add(str);
                        str  = s + "\n";
                    }
                    else
                    {
                        str += s + "\n";
                        first = false;
                    }

                    
                }
                else
                    str += s + "\n";
            }
            if (str != "")
                files.Add(str);
        }
        //соответствие строки маске разбиения
        bool equalsMask(string s)
        {
            try
            {
                switch (toolStripComboBoxMaskDivision.Text)
                {
                    case "от нумерации":
                        {
                            int i = 0;
                            if (i < s.Length)
                                while (Char.IsDigit(s[i]))
                                {
                                    if (i + 1 < s.Length)
                                        i++;
                                    else
                                        break;
                                    if (s[i].Equals('.') || s[i].Equals(')') || s[i].Equals('-'))
                                        return true;
                                }
                        }
                        break;
                    case "от подстроки":
                        {
                            if (s.IndexOf(subs.Text) != -1)
                                return true;
                        }
                        break;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
                return false;
            }
        }

        private void использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Checked = !использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Checked;
        }

        private void кПрописнымБуквамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxGeneral.SelectedText = richTextBoxGeneral.SelectedText.ToLower();
        }

        private void показатьТолькоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            replaseSearch(search.Text);
        }

        //выводит результаты запроса, заменяя содержимое ричтекстбокса
        void replaseSearch(string request)
        {
            try{
                string[] arr = richTextBoxGeneral.Lines;
                richTextBoxGeneral.Text = "";
                foreach (string s in arr)
                {
                    s.Trim();
                    richTextBoxGeneral.Text = "";
                    long count = 0;
                    for (long i = 0; i < arr.Length; i++)
                    {
                        if (arr[i].IndexOf(request) != -1)
                            count++;
                    }
                    richTextBoxGeneral.Text += "\nНайдено " + count + " совпадений\n";
                    
                    if (!s.Equals(""))
                    {
                        richTextBoxGeneral.Text += "\n\n\n";
                        richTextBoxGeneral.Text += "request: " + s;
                        richTextBoxGeneral.Text += "\n\n\n";
                        int cou = 0;
                        for (long i = 0; i < arr.Length; i++)
                            if (cou < 20)
                            {
                                if (arr[i].IndexOf(s) != -1)
                                {
                                    richTextBoxGeneral.Text += arr[i] + "\n";
                                    cou++;
                                }
                            }
                            else
                                break;
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        void countAllEqualLines()
        {
            try
            {
                string[] arr = richTextBoxGeneral.Lines;
                List<string> list = new List<string>();
                List<long> listCount = new List<long>();
                richTextBoxGeneral.Text = "";
                for (long i = 0; i < arr.Length; i++)
                {
                    string s = arr[i].Split('-')[0];
                    if (!list.Contains(s) && s != "") 
                    {
                        list.Add(s);
                        listCount.Add(1);
                    }
                    else if (list.Contains(s))
                    {
                        int j = list.IndexOf(s);
                        if (j > 0 && j < listCount.Count)
                            listCount[list.IndexOf(s)]++;
                    }

                }
                Int64 c = Convert.ToInt64(count.Text);
                for (int i = 0; i < listCount.Count; i++)
                {
                    if (c < listCount[i])
                        richTextBoxGeneral.Text += list[i] + " встретился " + listCount[i] + " раз \n";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }

        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                replaseSearch(search.Text);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COPY();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PASTE();
        }

        private void найтиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxGeneral.SelectedText != "")
                replaseSearch(richTextBoxGeneral.SelectedText);
            
        }

        private void посчитатьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countAllEqualLines();
        }

        private void сравнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s1 = richTextBoxGeneral.Text;
            string s2 = richTextBox1.Text;
            s1 = s1.Replace("\n", "");
            s2 = s2.Replace("\n", "");
            s1 = s1.Replace("-", "");
            s2 = s2.Replace("-", "");
            string[] arr1 = s1.Split('\n');
            string[] arr2 = s2.Split('\n');

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].Trim().Equals(arr2[i].Trim()))
                {
                    MessageBox.Show("is equal");

                }

                else
                {
                    MessageBox.Show("is't equal");
                    richTextBoxGeneral.Text += "\n" + arr1[i];
                    richTextBox1.Text += "\n" + arr2[i];
                }
            }

        }

        private void разбитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string text = File.ReadAllText(@"C:\Users\Николай\Desktop\PPC 200\onlycode.txt");
                //File.WriteAllText(@"C:\Users\Николай\Desktop\PPC 200\onlycode.txt", text);
                text = text.Replace("\n", "");
                text = text.Replace("\r", "");
                text = text.Replace(" ", "");
                File.WriteAllText(@"C:\Users\Николай\Desktop\PPC 200\onlycode.txt", text);
                richTextBoxGeneral.Text = text.Replace("\n", "");
                countChars(text);
                divideArray(text, 16, "subs.txt");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            
        }

        void task200()
        {
            string[] arr = File.ReadAllLines("all16.txt");
            string[] arr2 = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++ )
            {
                for (int j = 0; j < arr[i].Length; j++)
                    if (!Char.IsDigit(arr[i][j]))
                        arr2[i] += arr[i][j];
            }
            File.WriteAllLines("replaceAllNumbers.txt", arr2);
        }

        private void вОбратномПорядкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxGeneral.Text = invertString(richTextBoxGeneral.Text);
        }
        //разворачивает строку наоборот
        string invertString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        //делит строку на строки равной длины и записывает всё в файл
        void divideArray(string s, int length, string path)
        {
            List<char[]> list = new List<char[]>();
            char[] chars = s.ToCharArray();
            int j = 0;
            char[] ch;
            for (int i = 0; i < chars.Length; i++)
            {
                ch = new char[length];
                while (j < length)
                {
                    if (i < chars.Length)
                        ch[j] = chars[i];
                    i++;
                    j++;
                }
                list.Add(ch);
                j = 0;
            }
            string[] arr = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
                //richTextBox1.Text += new string(list[i]) + "\n";
                arr[i] = new string(list[i]);
            File.WriteAllLines(path, arr);
        }




        //определяет сколько раз встретился каждый символ входной строки
        void countChars(string code)
        {
            List<char> arr = new List<char>();
            List<int> count = new List<int>();
            for (int i = 0; i < code.Length; i++)
            {
                if (arr.Contains(code[i]))
                    count[arr.IndexOf(code[i])]++;
                else
                {
                    arr.Add(code[i]);
                    count.Add(1);
                }
            }
            string s = "";
            s = "Общее количество символов = " + code.Length + "\n";
            for (int i = 0; i < arr.Count; i++)
            {
                s += String.Format("{0} встретилось {1} раз\n", arr[i], count[i]);
            }
            double l = 0;
            for (int i = 0; i < count.Count; i++)
                l += count[i];
            s += "Итого: " + l;
            richTextBox1.Text = s;
        }

        private void divLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pPC200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            task200();
        }

        private void удалитьДефисыВСерединеСловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = richTextBoxGeneral.Text;
            char last = '\n';
            char next;
            string newS = "";
            for (int i = 0; i < s.Length; i++ )
            {
                if (i + 1 < s.Length)
                {
                    next = s[i + 1];
                    if (s[i] == '-')
                    {
                        if (i != 0)

                            if (Char.IsLetter(last))
                            {
                                if (Char.IsLetter(next))
                                { }
                                else if (next == '\n')
                                { }
                                else
                                    newS += s[i];
                            }
                            else
                                newS += s[i];

                    }
                    else
                        newS += s[i];

                }
                last = s[i];

            }
            richTextBoxGeneral.Text = newS;
        }

        private void сделатьНормальноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = richTextBoxGeneral.Text;
            s = s.Replace("\n\n", "\n");

            richTextBoxGeneral.Text = s;
            
        }
    }
}
