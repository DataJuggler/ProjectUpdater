#region using statements


#endregion

namespace ProjectUpdater
{

    #region class FindAndReplaceItem
    /// <summary>
    /// This class is used to keep track of items to find in projects and the replacement value
    /// </summary>
    public class FindAndReplaceItem
    {

        #region Private Variables
        private string find;
        private string replace;
        #endregion

        #region Properties

            #region Find
            /// <summary>
            /// This property gets or sets the value for 'Find'.
            /// </summary>
            public string Find
            {
                get { return find; }
                set { find = value; }
            }
            #endregion
            
            #region Replace
            /// <summary>
            /// This property gets or sets the value for 'Replace'.
            /// </summary>
            public string Replace
            {
                get { return replace; }
                set { replace = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
