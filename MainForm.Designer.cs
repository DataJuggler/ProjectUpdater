

#region using statements


#endregion

namespace ProjectUpdater
{

    #region class MainForm
    /// <summary>
    /// This is the designer for the main form
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.Button ConvertButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl ProjectsDirectoryControl;
        private ProgressBar Graph;
        private Label StatusLabel;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
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
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConvertButton = new DataJuggler.Win.Controls.Button();
            this.ProjectsDirectoryControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
            this.ConvertButton.ButtonText = "Convert";
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConvertButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ConvertButton.Location = new System.Drawing.Point(617, 102);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(144, 48);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ProjectsDirectoryControl
            // 
            this.ProjectsDirectoryControl.BackColor = System.Drawing.Color.Transparent;
            this.ProjectsDirectoryControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.ProjectsDirectoryControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.ProjectsDirectoryControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("ProjectsDirectoryControl.ButtonImage")));
            this.ProjectsDirectoryControl.ButtonWidth = 48;
            this.ProjectsDirectoryControl.DarkMode = false;
            this.ProjectsDirectoryControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.ProjectsDirectoryControl.Editable = true;
            this.ProjectsDirectoryControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.ProjectsDirectoryControl.Filter = null;
            this.ProjectsDirectoryControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectsDirectoryControl.HideBrowseButton = false;
            this.ProjectsDirectoryControl.LabelBottomMargin = 0;
            this.ProjectsDirectoryControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ProjectsDirectoryControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProjectsDirectoryControl.LabelText = "Directory:";
            this.ProjectsDirectoryControl.LabelTopMargin = 0;
            this.ProjectsDirectoryControl.LabelWidth = 100;
            this.ProjectsDirectoryControl.Location = new System.Drawing.Point(31, 38);
            this.ProjectsDirectoryControl.Name = "ProjectsDirectoryControl";
            this.ProjectsDirectoryControl.OnTextChangedListener = null;
            this.ProjectsDirectoryControl.OpenCallback = null;
            this.ProjectsDirectoryControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProjectsDirectoryControl.SelectedPath = null;
            this.ProjectsDirectoryControl.Size = new System.Drawing.Size(730, 32);
            this.ProjectsDirectoryControl.StartPath = null;
            this.ProjectsDirectoryControl.TabIndex = 1;
            this.ProjectsDirectoryControl.TextBoxBottomMargin = 0;
            this.ProjectsDirectoryControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.ProjectsDirectoryControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.ProjectsDirectoryControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectsDirectoryControl.TextBoxTopMargin = 0;
            this.ProjectsDirectoryControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(12, 218);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(749, 23);
            this.Graph.TabIndex = 2;
            this.Graph.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(12, 192);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(749, 23);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ProjectUpdater.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.ProjectsDirectoryControl);
            this.Controls.Add(this.ConvertButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Updater";
            this.ResumeLayout(false);

            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
