using System.Windows.Forms;

namespace WindowPane
{
    internal static class IndependentFunctions
    {
        #region Get Char from Key Event Arg
        internal static char GetChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }
        #endregion
        
    }
}
