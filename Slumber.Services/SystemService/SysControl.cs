namespace Slumber.Services.SystemService
{
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    public static class SysControl
    {
        #region Class methods
        public static void ShutDown()
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }
        public static void Restart()
        {
            Process.Start("shutdown.exe", "-r -t 00");
        }
        public static void Lock()
        {
            LockWorkStation();
        }
        #endregion

        #region Support Entities
        [DllImport("user32")]
        public static extern void LockWorkStation();
        #endregion
    }
}