namespace TextEditor
{
    partial class GeneralForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxGeneral = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.фоматироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кПрописнымБуквамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посчитатьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.count = new System.Windows.Forms.ToolStripTextBox();
            this.menuStripGeneral = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматированиеДокументаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеАбзацыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсюТабуляциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вОбратномПорядкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разбитьНаФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьТолькоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравнитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разбитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPC200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разбиениеНаФайлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маскаРазбиенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxMaskDivision = new System.Windows.Forms.ToolStripComboBox();
            this.subs = new System.Windows.Forms.ToolStripTextBox();
            this.префиксToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefix = new System.Windows.Forms.ToolStripTextBox();
            this.постфиксToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postfix = new System.Windows.Forms.ToolStripTextBox();
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogGeneral = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogGeneral = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.удалитьДефисыВСерединеСловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьНормальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripGeneral.SuspendLayout();
            this.menuStripGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxGeneral
            // 
            this.richTextBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxGeneral.ContextMenuStrip = this.contextMenuStripGeneral;
            this.richTextBoxGeneral.Location = new System.Drawing.Point(10, 28);
            this.richTextBoxGeneral.Name = "richTextBoxGeneral";
            this.richTextBoxGeneral.Size = new System.Drawing.Size(772, 389);
            this.richTextBoxGeneral.TabIndex = 0;
            this.richTextBoxGeneral.Text = "";
            // 
            // contextMenuStripGeneral
            // 
            this.contextMenuStripGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фоматироватьToolStripMenuItem,
            this.кПрописнымБуквамToolStripMenuItem,
            this.найтиВсеToolStripMenuItem,
            this.посчитатьВсеToolStripMenuItem});
            this.contextMenuStripGeneral.Name = "contextMenuStripGeneral";
            this.contextMenuStripGeneral.Size = new System.Drawing.Size(222, 92);
            // 
            // фоматироватьToolStripMenuItem
            // 
            this.фоматироватьToolStripMenuItem.Name = "фоматироватьToolStripMenuItem";
            this.фоматироватьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.фоматироватьToolStripMenuItem.Text = "Фоматировать";
            this.фоматироватьToolStripMenuItem.Click += new System.EventHandler(this.фоматироватьToolStripMenuItem_Click);
            // 
            // кПрописнымБуквамToolStripMenuItem
            // 
            this.кПрописнымБуквамToolStripMenuItem.Name = "кПрописнымБуквамToolStripMenuItem";
            this.кПрописнымБуквамToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.кПрописнымБуквамToolStripMenuItem.Text = "К прописным буквам";
            this.кПрописнымБуквамToolStripMenuItem.Click += new System.EventHandler(this.кПрописнымБуквамToolStripMenuItem_Click);
            // 
            // найтиВсеToolStripMenuItem
            // 
            this.найтиВсеToolStripMenuItem.Name = "найтиВсеToolStripMenuItem";
            this.найтиВсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.найтиВсеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.найтиВсеToolStripMenuItem.Text = "Найти все";
            this.найтиВсеToolStripMenuItem.Click += new System.EventHandler(this.найтиВсеToolStripMenuItem_Click);
            // 
            // посчитатьВсеToolStripMenuItem
            // 
            this.посчитатьВсеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.count});
            this.посчитатьВсеToolStripMenuItem.Name = "посчитатьВсеToolStripMenuItem";
            this.посчитатьВсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.F)));
            this.посчитатьВсеToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.посчитатьВсеToolStripMenuItem.Text = "Посчитать все";
            this.посчитатьВсеToolStripMenuItem.Click += new System.EventHandler(this.посчитатьВсеToolStripMenuItem_Click);
            // 
            // count
            // 
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 23);
            this.count.Text = "100";
            this.count.ToolTipText = "Количество повторений которых превышает заданное число";
            // 
            // menuStripGeneral
            // 
            this.menuStripGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.режимToolStripMenuItem});
            this.menuStripGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuStripGeneral.Name = "menuStripGeneral";
            this.menuStripGeneral.Size = new System.Drawing.Size(1023, 24);
            this.menuStripGeneral.TabIndex = 2;
            this.menuStripGeneral.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьВсёToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьВсёToolStripMenuItem
            // 
            this.сохранитьВсёToolStripMenuItem.Name = "сохранитьВсёToolStripMenuItem";
            this.сохранитьВсёToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сохранитьВсёToolStripMenuItem.Text = "Сохранить всё";
            this.сохранитьВсёToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВсёToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форматированиеДокументаToolStripMenuItem,
            this.разбитьНаФайлыToolStripMenuItem,
            this.показатьТолькоToolStripMenuItem,
            this.toolStripMenuItem1,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.сравнитьToolStripMenuItem,
            this.разбитьToolStripMenuItem,
            this.pPC200ToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // форматированиеДокументаToolStripMenuItem
            // 
            this.форматированиеДокументаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВсеАбзацыToolStripMenuItem,
            this.удалитьВсюТабуляциюToolStripMenuItem,
            this.вОбратномПорядкеToolStripMenuItem,
            this.удалитьДефисыВСерединеСловаToolStripMenuItem,
            this.сделатьНормальноToolStripMenuItem});
            this.форматированиеДокументаToolStripMenuItem.Name = "форматированиеДокументаToolStripMenuItem";
            this.форматированиеДокументаToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.форматированиеДокументаToolStripMenuItem.Text = "Форматирование";
            // 
            // удалитьВсеАбзацыToolStripMenuItem
            // 
            this.удалитьВсеАбзацыToolStripMenuItem.Name = "удалитьВсеАбзацыToolStripMenuItem";
            this.удалитьВсеАбзацыToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.удалитьВсеАбзацыToolStripMenuItem.Text = "Удалить все абзацы";
            this.удалитьВсеАбзацыToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеАбзацыToolStripMenuItem_Click);
            // 
            // удалитьВсюТабуляциюToolStripMenuItem
            // 
            this.удалитьВсюТабуляциюToolStripMenuItem.Name = "удалитьВсюТабуляциюToolStripMenuItem";
            this.удалитьВсюТабуляциюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.удалитьВсюТабуляциюToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.удалитьВсюТабуляциюToolStripMenuItem.Text = "Удалить всю табуляцию";
            this.удалитьВсюТабуляциюToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсюТабуляциюToolStripMenuItem_Click);
            // 
            // вОбратномПорядкеToolStripMenuItem
            // 
            this.вОбратномПорядкеToolStripMenuItem.Name = "вОбратномПорядкеToolStripMenuItem";
            this.вОбратномПорядкеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.вОбратномПорядкеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.вОбратномПорядкеToolStripMenuItem.Text = "В обратном порядке";
            this.вОбратномПорядкеToolStripMenuItem.Click += new System.EventHandler(this.вОбратномПорядкеToolStripMenuItem_Click);
            // 
            // разбитьНаФайлыToolStripMenuItem
            // 
            this.разбитьНаФайлыToolStripMenuItem.Name = "разбитьНаФайлыToolStripMenuItem";
            this.разбитьНаФайлыToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.разбитьНаФайлыToolStripMenuItem.Text = "Разбить на файлы";
            this.разбитьНаФайлыToolStripMenuItem.ToolTipText = "Разбивает содержимое текстового поля на файлы в соответствии с маской разбиения. " +
                "\r\nТребуется выполнить команду \"Сохранить всё\" для сохранения этих файлов!\r\n";
            this.разбитьНаФайлыToolStripMenuItem.Click += new System.EventHandler(this.разбитьНаФайлыToolStripMenuItem_Click);
            // 
            // показатьТолькоToolStripMenuItem
            // 
            this.показатьТолькоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search});
            this.показатьТолькоToolStripMenuItem.Name = "показатьТолькоToolStripMenuItem";
            this.показатьТолькоToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.показатьТолькоToolStripMenuItem.Text = "Показать только...";
            this.показатьТолькоToolStripMenuItem.Click += new System.EventHandler(this.показатьТолькоToolStripMenuItem_Click);
            // 
            // search
            // 
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 23);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // сравнитьToolStripMenuItem
            // 
            this.сравнитьToolStripMenuItem.Name = "сравнитьToolStripMenuItem";
            this.сравнитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.сравнитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.сравнитьToolStripMenuItem.Text = "Сравнить";
            this.сравнитьToolStripMenuItem.Click += new System.EventHandler(this.сравнитьToolStripMenuItem_Click);
            // 
            // разбитьToolStripMenuItem
            // 
            this.разбитьToolStripMenuItem.Name = "разбитьToolStripMenuItem";
            this.разбитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.разбитьToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.разбитьToolStripMenuItem.Text = "Разбить";
            this.разбитьToolStripMenuItem.Click += new System.EventHandler(this.разбитьToolStripMenuItem_Click);
            // 
            // pPC200ToolStripMenuItem
            // 
            this.pPC200ToolStripMenuItem.Name = "pPC200ToolStripMenuItem";
            this.pPC200ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pPC200ToolStripMenuItem.Text = "PPC 200";
            this.pPC200ToolStripMenuItem.Click += new System.EventHandler(this.pPC200ToolStripMenuItem_Click);
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разбиениеНаФайлыToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // разбиениеНаФайлыToolStripMenuItem
            // 
            this.разбиениеНаФайлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маскаРазбиенияToolStripMenuItem,
            this.префиксToolStripMenuItem,
            this.постфиксToolStripMenuItem,
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem});
            this.разбиениеНаФайлыToolStripMenuItem.Name = "разбиениеНаФайлыToolStripMenuItem";
            this.разбиениеНаФайлыToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.разбиениеНаФайлыToolStripMenuItem.Text = "Разбиение на файлы";
            // 
            // маскаРазбиенияToolStripMenuItem
            // 
            this.маскаРазбиенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxMaskDivision,
            this.subs});
            this.маскаРазбиенияToolStripMenuItem.Name = "маскаРазбиенияToolStripMenuItem";
            this.маскаРазбиенияToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.маскаРазбиенияToolStripMenuItem.Text = "Маска разбиения";
            this.маскаРазбиенияToolStripMenuItem.ToolTipText = "При нахождении этой подстроки в строке все предыдущие строки записываются в файл " +
                "и начинается накопление строк для очередного файла.";
            // 
            // toolStripComboBoxMaskDivision
            // 
            this.toolStripComboBoxMaskDivision.Name = "toolStripComboBoxMaskDivision";
            this.toolStripComboBoxMaskDivision.Size = new System.Drawing.Size(121, 23);
            // 
            // subs
            // 
            this.subs.Name = "subs";
            this.subs.Size = new System.Drawing.Size(100, 23);
            this.subs.Text = ".txt";
            this.subs.ToolTipText = "Подстрока для разбиения";
            // 
            // префиксToolStripMenuItem
            // 
            this.префиксToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prefix});
            this.префиксToolStripMenuItem.Name = "префиксToolStripMenuItem";
            this.префиксToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.префиксToolStripMenuItem.Text = "Префикс ";
            this.префиксToolStripMenuItem.ToolTipText = "Название каждого сохраненного файла будет содержать в начале этот префикс";
            // 
            // prefix
            // 
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(100, 23);
            // 
            // постфиксToolStripMenuItem
            // 
            this.постфиксToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postfix});
            this.постфиксToolStripMenuItem.Name = "постфиксToolStripMenuItem";
            this.постфиксToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.постфиксToolStripMenuItem.Text = "Постфикс";
            // 
            // postfix
            // 
            this.postfix.Name = "postfix";
            this.postfix.Size = new System.Drawing.Size(100, 23);
            this.postfix.ToolTipText = "Название каждого сохраненного файла будет содержать в конце этот постфикс";
            // 
            // использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem
            // 
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Checked = true;
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Name = "использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem";
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Text = "Имя по первой строке";
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.ToolTipText = "Файлы, на которые будет разбит текст текстового поля, будут именоваться также как" +
                " и первая строка каждого из них.";
            this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem.Click += new System.EventHandler(this.использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem_Click);
            // 
            // openFileDialogGeneral
            // 
            this.openFileDialogGeneral.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStripGeneral;
            this.richTextBox1.Location = new System.Drawing.Point(788, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(235, 390);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // удалитьДефисыВСерединеСловаToolStripMenuItem
            // 
            this.удалитьДефисыВСерединеСловаToolStripMenuItem.Name = "удалитьДефисыВСерединеСловаToolStripMenuItem";
            this.удалитьДефисыВСерединеСловаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.удалитьДефисыВСерединеСловаToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.удалитьДефисыВСерединеСловаToolStripMenuItem.Text = "Удалить дефисы в словах";
            this.удалитьДефисыВСерединеСловаToolStripMenuItem.Click += new System.EventHandler(this.удалитьДефисыВСерединеСловаToolStripMenuItem_Click);
            // 
            // сделатьНормальноToolStripMenuItem
            // 
            this.сделатьНормальноToolStripMenuItem.Name = "сделатьНормальноToolStripMenuItem";
            this.сделатьНормальноToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.сделатьНормальноToolStripMenuItem.Text = "Сделать нормально";
            this.сделатьНормальноToolStripMenuItem.Click += new System.EventHandler(this.сделатьНормальноToolStripMenuItem_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 418);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStripGeneral);
            this.Controls.Add(this.richTextBoxGeneral);
            this.MainMenuStrip = this.menuStripGeneral;
            this.Name = "GeneralForm";
            this.ShowIcon = false;
            this.Text = "TextEditor 1.0";
            this.contextMenuStripGeneral.ResumeLayout(false);
            this.menuStripGeneral.ResumeLayout(false);
            this.menuStripGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxGeneral;
        private System.Windows.Forms.MenuStrip menuStripGeneral;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGeneral;
        private System.Windows.Forms.OpenFileDialog openFileDialogGeneral;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGeneral;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разбиениеНаФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маскаРазбиенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMaskDivision;
        private System.Windows.Forms.ToolStripMenuItem префиксToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматированиеДокументаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеАбзацыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсюТабуляциюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фоматироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox prefix;
        private System.Windows.Forms.ToolStripMenuItem постфиксToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox postfix;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разбитьНаФайлыToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox subs;
        private System.Windows.Forms.ToolStripMenuItem использоватьПервуюСтрокуКакНаименованиеФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кПрописнымБуквамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьТолькоToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox search;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посчитатьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox count;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem сравнитьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem разбитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вОбратномПорядкеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPC200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьДефисыВСерединеСловаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьНормальноToolStripMenuItem;
    }
}

