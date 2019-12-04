namespace GoldenRectangle.Forms
{
    partial class HomeForm
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.calculatePage = new MetroSet_UI.Child.MetroSetTabPage();
            this.rectangleWidthTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.smallBoardsLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.generateButton = new MetroSet_UI.Controls.MetroSetButton();
            this.smallBoardsListView = new MetroSet_UI.Controls.MetroSetListBox();
            this.predictPage = new MetroSet_UI.Child.MetroSetTabPage();
            this.generateSolutionButton = new MetroSet_UI.Controls.MetroSetButton();
            this.resetButton = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.rectangleSizeTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.addBoxButton = new MetroSet_UI.Controls.MetroSetButton();
            this.boxSizeTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.outputListBox = new MetroSet_UI.Controls.MetroSetListBox();
            this.inputListBox = new MetroSet_UI.Controls.MetroSetListBox();
            this.metroSetTabControl1.SuspendLayout();
            this.calculatePage.SuspendLayout();
            this.predictPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1186, 20);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.Controls.Add(this.calculatePage);
            this.metroSetTabControl1.Controls.Add(this.predictPage);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(12, 103);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.Size = new System.Drawing.Size(1299, 690);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 1;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = true;
            // 
            // calculatePage
            // 
            this.calculatePage.BaseColor = System.Drawing.Color.White;
            this.calculatePage.Controls.Add(this.rectangleWidthTextBox);
            this.calculatePage.Controls.Add(this.smallBoardsLabel);
            this.calculatePage.Controls.Add(this.generateButton);
            this.calculatePage.Controls.Add(this.smallBoardsListView);
            this.calculatePage.ImageIndex = 0;
            this.calculatePage.ImageKey = null;
            this.calculatePage.Location = new System.Drawing.Point(4, 42);
            this.calculatePage.Name = "calculatePage";
            this.calculatePage.Size = new System.Drawing.Size(1291, 644);
            this.calculatePage.Style = MetroSet_UI.Design.Style.Light;
            this.calculatePage.StyleManager = null;
            this.calculatePage.TabIndex = 0;
            this.calculatePage.Text = "Generate Board";
            this.calculatePage.ThemeAuthor = "Narwin";
            this.calculatePage.ThemeName = "MetroLite";
            this.calculatePage.ToolTipText = null;
            // 
            // rectangleWidthTextBox
            // 
            this.rectangleWidthTextBox.AutoCompleteCustomSource = null;
            this.rectangleWidthTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rectangleWidthTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rectangleWidthTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rectangleWidthTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rectangleWidthTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rectangleWidthTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.rectangleWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rectangleWidthTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rectangleWidthTextBox.Image = null;
            this.rectangleWidthTextBox.Lines = null;
            this.rectangleWidthTextBox.Location = new System.Drawing.Point(3, 44);
            this.rectangleWidthTextBox.MaxLength = 32767;
            this.rectangleWidthTextBox.Multiline = false;
            this.rectangleWidthTextBox.Name = "rectangleWidthTextBox";
            this.rectangleWidthTextBox.ReadOnly = false;
            this.rectangleWidthTextBox.Size = new System.Drawing.Size(669, 53);
            this.rectangleWidthTextBox.Style = MetroSet_UI.Design.Style.Light;
            this.rectangleWidthTextBox.StyleManager = null;
            this.rectangleWidthTextBox.TabIndex = 4;
            this.rectangleWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rectangleWidthTextBox.ThemeAuthor = "Narwin";
            this.rectangleWidthTextBox.ThemeName = "MetroLite";
            this.rectangleWidthTextBox.UseSystemPasswordChar = false;
            this.rectangleWidthTextBox.WatermarkText = "Please enter the desired rectangle width";
            // 
            // smallBoardsLabel
            // 
            this.smallBoardsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.smallBoardsLabel.Location = new System.Drawing.Point(3, 176);
            this.smallBoardsLabel.Name = "smallBoardsLabel";
            this.smallBoardsLabel.Size = new System.Drawing.Size(467, 23);
            this.smallBoardsLabel.Style = MetroSet_UI.Design.Style.Light;
            this.smallBoardsLabel.StyleManager = null;
            this.smallBoardsLabel.TabIndex = 3;
            this.smallBoardsLabel.Text = "Small Boards";
            this.smallBoardsLabel.ThemeAuthor = "Narwin";
            this.smallBoardsLabel.ThemeName = "MetroLite";
            // 
            // generateButton
            // 
            this.generateButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.generateButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.generateButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.generateButton.HoverTextColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(1111, 119);
            this.generateButton.Name = "generateButton";
            this.generateButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateButton.NormalTextColor = System.Drawing.Color.White;
            this.generateButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.generateButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.generateButton.PressTextColor = System.Drawing.Color.White;
            this.generateButton.Size = new System.Drawing.Size(159, 47);
            this.generateButton.Style = MetroSet_UI.Design.Style.Light;
            this.generateButton.StyleManager = null;
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.ThemeAuthor = "Narwin";
            this.generateButton.ThemeName = "MetroLite";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // smallBoardsListView
            // 
            this.smallBoardsListView.BorderColor = System.Drawing.Color.LightGray;
            this.smallBoardsListView.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.smallBoardsListView.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.smallBoardsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.smallBoardsListView.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.smallBoardsListView.HoveredItemColor = System.Drawing.Color.DimGray;
            this.smallBoardsListView.ItemHeight = 30;
            this.smallBoardsListView.Location = new System.Drawing.Point(3, 212);
            this.smallBoardsListView.MultiSelect = false;
            this.smallBoardsListView.Name = "smallBoardsListView";
            this.smallBoardsListView.SelectedIndex = -1;
            this.smallBoardsListView.SelectedItem = null;
            this.smallBoardsListView.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.smallBoardsListView.SelectedItemColor = System.Drawing.Color.White;
            this.smallBoardsListView.SelectedValue = null;
            this.smallBoardsListView.ShowBorder = true;
            this.smallBoardsListView.ShowScrollBar = true;
            this.smallBoardsListView.Size = new System.Drawing.Size(1267, 414);
            this.smallBoardsListView.Style = MetroSet_UI.Design.Style.Light;
            this.smallBoardsListView.StyleManager = null;
            this.smallBoardsListView.TabIndex = 0;
            this.smallBoardsListView.ThemeAuthor = "Narwin";
            this.smallBoardsListView.ThemeName = "MetroLite";
            // 
            // predictPage
            // 
            this.predictPage.BaseColor = System.Drawing.Color.White;
            this.predictPage.Controls.Add(this.generateSolutionButton);
            this.predictPage.Controls.Add(this.resetButton);
            this.predictPage.Controls.Add(this.metroSetLabel3);
            this.predictPage.Controls.Add(this.rectangleSizeTextBox);
            this.predictPage.Controls.Add(this.metroSetLabel1);
            this.predictPage.Controls.Add(this.addBoxButton);
            this.predictPage.Controls.Add(this.boxSizeTextBox);
            this.predictPage.Controls.Add(this.metroSetDivider1);
            this.predictPage.Controls.Add(this.outputListBox);
            this.predictPage.Controls.Add(this.inputListBox);
            this.predictPage.ImageIndex = 0;
            this.predictPage.ImageKey = null;
            this.predictPage.Location = new System.Drawing.Point(4, 42);
            this.predictPage.Name = "predictPage";
            this.predictPage.Size = new System.Drawing.Size(1291, 644);
            this.predictPage.Style = MetroSet_UI.Design.Style.Light;
            this.predictPage.StyleManager = null;
            this.predictPage.TabIndex = 1;
            this.predictPage.Text = "Validate Board Pieces";
            this.predictPage.ThemeAuthor = "Narwin";
            this.predictPage.ThemeName = "MetroLite";
            this.predictPage.ToolTipText = null;
            // 
            // generateSolutionButton
            // 
            this.generateSolutionButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateSolutionButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateSolutionButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.generateSolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.generateSolutionButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.generateSolutionButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.generateSolutionButton.HoverTextColor = System.Drawing.Color.White;
            this.generateSolutionButton.Location = new System.Drawing.Point(455, 120);
            this.generateSolutionButton.Name = "generateSolutionButton";
            this.generateSolutionButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateSolutionButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.generateSolutionButton.NormalTextColor = System.Drawing.Color.White;
            this.generateSolutionButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.generateSolutionButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.generateSolutionButton.PressTextColor = System.Drawing.Color.White;
            this.generateSolutionButton.Size = new System.Drawing.Size(156, 36);
            this.generateSolutionButton.Style = MetroSet_UI.Design.Style.Light;
            this.generateSolutionButton.StyleManager = null;
            this.generateSolutionButton.TabIndex = 10;
            this.generateSolutionButton.Text = "Generate";
            this.generateSolutionButton.ThemeAuthor = "Narwin";
            this.generateSolutionButton.ThemeName = "MetroLite";
            this.generateSolutionButton.Click += new System.EventHandler(this.generateSolutionButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.resetButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.resetButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resetButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.resetButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.resetButton.HoverTextColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(4, 120);
            this.resetButton.Name = "resetButton";
            this.resetButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.resetButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.resetButton.NormalTextColor = System.Drawing.Color.White;
            this.resetButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.resetButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.resetButton.PressTextColor = System.Drawing.Color.White;
            this.resetButton.Size = new System.Drawing.Size(156, 36);
            this.resetButton.Style = MetroSet_UI.Design.Style.Light;
            this.resetButton.StyleManager = null;
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.ThemeAuthor = "Narwin";
            this.resetButton.ThemeName = "MetroLite";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.metroSetLabel3.Location = new System.Drawing.Point(677, 19);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(100, 31);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 8;
            this.metroSetLabel3.Text = "Output";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // rectangleSizeTextBox
            // 
            this.rectangleSizeTextBox.AutoCompleteCustomSource = null;
            this.rectangleSizeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rectangleSizeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rectangleSizeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rectangleSizeTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rectangleSizeTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rectangleSizeTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.rectangleSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rectangleSizeTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rectangleSizeTextBox.Image = null;
            this.rectangleSizeTextBox.Lines = null;
            this.rectangleSizeTextBox.Location = new System.Drawing.Point(677, 66);
            this.rectangleSizeTextBox.MaxLength = 32767;
            this.rectangleSizeTextBox.Multiline = false;
            this.rectangleSizeTextBox.Name = "rectangleSizeTextBox";
            this.rectangleSizeTextBox.ReadOnly = false;
            this.rectangleSizeTextBox.Size = new System.Drawing.Size(528, 39);
            this.rectangleSizeTextBox.Style = MetroSet_UI.Design.Style.Light;
            this.rectangleSizeTextBox.StyleManager = null;
            this.rectangleSizeTextBox.TabIndex = 7;
            this.rectangleSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rectangleSizeTextBox.ThemeAuthor = "Narwin";
            this.rectangleSizeTextBox.ThemeName = "MetroLite";
            this.rectangleSizeTextBox.UseSystemPasswordChar = false;
            this.rectangleSizeTextBox.WatermarkText = "Golden rectangle size";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.metroSetLabel1.Location = new System.Drawing.Point(4, 19);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 31);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 5;
            this.metroSetLabel1.Text = "Input";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // addBoxButton
            // 
            this.addBoxButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addBoxButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addBoxButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.addBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addBoxButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addBoxButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.addBoxButton.HoverTextColor = System.Drawing.Color.White;
            this.addBoxButton.Location = new System.Drawing.Point(166, 120);
            this.addBoxButton.Name = "addBoxButton";
            this.addBoxButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addBoxButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.addBoxButton.NormalTextColor = System.Drawing.Color.White;
            this.addBoxButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addBoxButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.addBoxButton.PressTextColor = System.Drawing.Color.White;
            this.addBoxButton.Size = new System.Drawing.Size(156, 36);
            this.addBoxButton.Style = MetroSet_UI.Design.Style.Light;
            this.addBoxButton.StyleManager = null;
            this.addBoxButton.TabIndex = 4;
            this.addBoxButton.Text = "Add";
            this.addBoxButton.ThemeAuthor = "Narwin";
            this.addBoxButton.ThemeName = "MetroLite";
            this.addBoxButton.Click += new System.EventHandler(this.addBoxButton_Click);
            // 
            // boxSizeTextBox
            // 
            this.boxSizeTextBox.AutoCompleteCustomSource = null;
            this.boxSizeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.boxSizeTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.boxSizeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.boxSizeTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.boxSizeTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.boxSizeTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.boxSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.boxSizeTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.boxSizeTextBox.Image = null;
            this.boxSizeTextBox.Lines = null;
            this.boxSizeTextBox.Location = new System.Drawing.Point(4, 66);
            this.boxSizeTextBox.MaxLength = 32767;
            this.boxSizeTextBox.Multiline = false;
            this.boxSizeTextBox.Name = "boxSizeTextBox";
            this.boxSizeTextBox.ReadOnly = false;
            this.boxSizeTextBox.Size = new System.Drawing.Size(453, 39);
            this.boxSizeTextBox.Style = MetroSet_UI.Design.Style.Light;
            this.boxSizeTextBox.StyleManager = null;
            this.boxSizeTextBox.TabIndex = 3;
            this.boxSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxSizeTextBox.ThemeAuthor = "Narwin";
            this.boxSizeTextBox.ThemeName = "MetroLite";
            this.boxSizeTextBox.UseSystemPasswordChar = false;
            this.boxSizeTextBox.WatermarkText = "Please enter the box size";
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.Location = new System.Drawing.Point(643, 19);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Vertical;
            this.metroSetDivider1.Size = new System.Drawing.Size(4, 626);
            this.metroSetDivider1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 2;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroLite";
            this.metroSetDivider1.Thickness = 1;
            // 
            // outputListBox
            // 
            this.outputListBox.BorderColor = System.Drawing.Color.LightGray;
            this.outputListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.outputListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.outputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outputListBox.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.outputListBox.HoveredItemColor = System.Drawing.Color.DimGray;
            this.outputListBox.ItemHeight = 30;
            this.outputListBox.Location = new System.Drawing.Point(677, 169);
            this.outputListBox.MultiSelect = false;
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.SelectedIndex = -1;
            this.outputListBox.SelectedItem = null;
            this.outputListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.outputListBox.SelectedItemColor = System.Drawing.Color.White;
            this.outputListBox.SelectedValue = null;
            this.outputListBox.ShowBorder = true;
            this.outputListBox.ShowScrollBar = true;
            this.outputListBox.Size = new System.Drawing.Size(618, 476);
            this.outputListBox.Style = MetroSet_UI.Design.Style.Light;
            this.outputListBox.StyleManager = null;
            this.outputListBox.TabIndex = 1;
            this.outputListBox.ThemeAuthor = "Narwin";
            this.outputListBox.ThemeName = "MetroLite";
            // 
            // inputListBox
            // 
            this.inputListBox.BorderColor = System.Drawing.Color.LightGray;
            this.inputListBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputListBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.inputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputListBox.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.inputListBox.HoveredItemColor = System.Drawing.Color.DimGray;
            this.inputListBox.ItemHeight = 30;
            this.inputListBox.Location = new System.Drawing.Point(3, 169);
            this.inputListBox.MultiSelect = false;
            this.inputListBox.Name = "inputListBox";
            this.inputListBox.SelectedIndex = -1;
            this.inputListBox.SelectedItem = null;
            this.inputListBox.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.inputListBox.SelectedItemColor = System.Drawing.Color.White;
            this.inputListBox.SelectedValue = null;
            this.inputListBox.ShowBorder = true;
            this.inputListBox.ShowScrollBar = true;
            this.inputListBox.Size = new System.Drawing.Size(608, 476);
            this.inputListBox.Style = MetroSet_UI.Design.Style.Light;
            this.inputListBox.StyleManager = null;
            this.inputListBox.TabIndex = 0;
            this.inputListBox.ThemeAuthor = "Narwin";
            this.inputListBox.ThemeName = "MetroLite";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 805);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Name = "HomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TCC Fibonacci";
            this.UseSlideAnimation = true;
            this.metroSetTabControl1.ResumeLayout(false);
            this.calculatePage.ResumeLayout(false);
            this.predictPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage calculatePage;
        private MetroSet_UI.Child.MetroSetTabPage predictPage;
        private MetroSet_UI.Controls.MetroSetListBox smallBoardsListView;
        private MetroSet_UI.Controls.MetroSetLabel smallBoardsLabel;
        private MetroSet_UI.Controls.MetroSetButton generateButton;
        private MetroSet_UI.Controls.MetroSetTextBox rectangleWidthTextBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox rectangleSizeTextBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetButton addBoxButton;
        private MetroSet_UI.Controls.MetroSetTextBox boxSizeTextBox;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetListBox outputListBox;
        private MetroSet_UI.Controls.MetroSetListBox inputListBox;
        private MetroSet_UI.Controls.MetroSetButton resetButton;
        private MetroSet_UI.Controls.MetroSetButton generateSolutionButton;
    }
}