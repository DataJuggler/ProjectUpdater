

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.IO;

#endregion

namespace ProjectUpdater
{

    #region class MainForm
    /// <summary>
    ///This is the main form for this project
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {
        
        #region Private Variables
        private List<string> projectFiles;
        private List<FindAndReplaceItem> findAndReplaceItems;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region ConvertButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ConvertButton' is clicked.
            /// </summary>
            private void ConvertButton_Click(object sender, EventArgs e)
            {
                // Get the count
                int itemsToUpdate = ProjectFiles.Count * FindAndReplaceItems.Count;

                // Setup the graph
                Graph.Maximum = itemsToUpdate;

                // locals
                string fileText = "";
                int replacementsMade = 0;
                int replacementsThisFile = 0;

                // Iterate the collection of string objects
                foreach (string projectFile in ProjectFiles)
                {
                    // reset
                    replacementsThisFile = 0;

                    // Get all the text
                    fileText = File.ReadAllText(projectFile);

                    // Get the textLines
                    List<TextLine> lines = TextHelper.GetTextLines(fileText);

                    // Iterate the collection of TextLine objects
                    foreach (TextLine line in lines)
                    {
                        // Iterate the collection of FindAndReplaceItem objects
                        foreach (FindAndReplaceItem findAndReplaceItem in FindAndReplaceItems)
                        {
                            // if the line contains the text
                            if (line.Text.Contains(findAndReplaceItem.Find))
                            {
                                // Increment the value for replacementsMade
                                replacementsMade++;
                                replacementsThisFile++;

                                // Do the replacement
                                line.Text = line.Text.Replace(findAndReplaceItem.Find, findAndReplaceItem.Replace);
                            }
                        }
                    }

                    // if there were replacements this file
                    if (replacementsThisFile > 0)
                    {
                        // Get the newFileText
                        string newFileText = TextHelper.ExportTextLines(lines);

                        // Delete the file
                        File.Delete(projectFile);

                        // Write out the text
                        File.WriteAllText(projectFile, newFileText);
                    }
                    
                    // Add to the total
                    Graph.Value = Graph.Value + FindAndReplaceItems.Count;
                }

                // Show the number of replacements made and a finished message
                StatusLabel.Text = "Replacements Made: " + replacementsMade + ". Finished.";
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // store the directory
                string directory = text;

                // create a list of filterExtensions (we only want to load C# project files .csproj
                List<string> filterExtensions = new List<string>();
                filterExtensions.Add(".csproj");

                // get the projectFiles
                ProjectFiles = FileHelper.GetFilesRecursively(directory, ref projectFiles, filterExtensions);

                // If the ProjectFiles collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(ProjectFiles))
                {
                    // Show number of projects found
                    StatusLabel.Text = "Found Projects: " + ProjectFiles.Count + ". Ready.";

                    // Enabled
                    ConvertButton.Enabled = true;
                }
                else
                {
                    // Show no projects found
                    StatusLabel.Text = "Found Projects: 0.";

                    // Disabled
                    ConvertButton.Enabled = false;
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create a new collection of 'FindAndReplaceItem' objects.
                FindAndReplaceItems = new List<FindAndReplaceItem>();

                // target framework
                FindAndReplaceItem targetFramework = new FindAndReplaceItem();
                targetFramework.Find = "<TargetFramework>net5.0</TargetFramework>";
                targetFramework.Replace = "<TargetFramework>net6.0</TargetFramework>";

                // jsonPatch
                FindAndReplaceItem jsonPatch  = new FindAndReplaceItem();
                jsonPatch.Find = "Microsoft.AspNetCore.JsonPatch Version=\"5.0.3\"";
                jsonPatch.Replace = "Microsoft.AspNetCore.JsonPatch Version=\"6.0.0\"";

                // cachingExtraction
                FindAndReplaceItem cachingExtraction  = new FindAndReplaceItem();
                cachingExtraction.Find = "Microsoft.Extensions.Caching.Abstractions Version=\"5.0.0\" ";
                cachingExtraction.Replace = "Microsoft.Extensions.Caching.Abstractions Version=\"6.0.0\" ";

                // dataTierNet
                FindAndReplaceItem dataTierNet  = new FindAndReplaceItem();
                dataTierNet.Find = "DataTier.Net5";
                dataTierNet.Replace = "DataTier.Net6";

                // dataJugglerNet
                FindAndReplaceItem dataJugglerNet  = new FindAndReplaceItem();
                dataJugglerNet.Find = "DataJuggler.Net5";
                dataJugglerNet.Replace = "DataJuggler.Net6";

                // version
                FindAndReplaceItem version  = new FindAndReplaceItem();
                version.Find = "Version=\"2.5.6\"";
                version.Replace = "Version=\"6.0.0\"";

                // version2
                FindAndReplaceItem version2  = new FindAndReplaceItem();
                version2.Find = "Version=\"2.5.0\"";
                version2.Replace = "Version=\"6.0.0\"";

                // version3
                FindAndReplaceItem version3  = new FindAndReplaceItem();
                version3.Find = "Version=\"1.5.1\"";
                version3.Replace = "Version=\"6.0.0\"";

                // Add the items
                FindAndReplaceItems.Add(targetFramework);
                FindAndReplaceItems.Add(jsonPatch);
                FindAndReplaceItems.Add(cachingExtraction);
                FindAndReplaceItems.Add(dataTierNet);
                FindAndReplaceItems.Add(dataJugglerNet);
                FindAndReplaceItems.Add(version);
                FindAndReplaceItems.Add(version2);
                FindAndReplaceItems.Add(version3);

                // Setup the listener
                ProjectsDirectoryControl.OnTextChangedListener = this;
            }
            #endregion

        #endregion

        #region Properties

            #region FindAndReplaceItems
            /// <summary>
            /// This property gets or sets the value for 'FindAndReplaceItems'.
            /// </summary>
            public List<FindAndReplaceItem> FindAndReplaceItems
            {
                get { return findAndReplaceItems; }
                set { findAndReplaceItems = value; }
            }
            #endregion
            
            #region ProjectFiles
            /// <summary>
            /// This property gets or sets the value for 'ProjectFiles'.
            /// </summary>
            public List<string> ProjectFiles
            {
                get { return projectFiles; }
                set { projectFiles = value; }
            }
        #endregion

        #endregion
    }
    #endregion

}
