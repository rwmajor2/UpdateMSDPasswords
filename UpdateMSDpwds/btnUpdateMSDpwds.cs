using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.Carto;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace UpdateMSDpwds
{
    public class btnUpdateMSDpwds : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        [DllImport("user32.dll", EntryPoint = "FindWindowA")]
        static extern int FindWindow(string lpClassName, string lpWindowName);
        
        [DllImport("user32.dll", EntryPoint = "BringWindowToTop")]
        static extern long BringWindowToTop(long hwnd);

        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        public btnUpdateMSDpwds()
        {
        }

        protected override void OnClick()
        {
            try
            {
                int lngWindow = 0;
                lngWindow = FindWindow(null, "Update MSD Database Passwords");
                if (lngWindow > 0)
                {
                    BringWindowToTop(lngWindow);
                }
                else
                {
                    analyzeForm myform = new analyzeForm();
                    System.IntPtr myIntPtr = new IntPtr(ArcCatalog.Application.hWnd);
                    MyWrapper wrapper = new MyWrapper(myIntPtr);
                    myform.Show((System.Windows.Forms.IWin32Window)wrapper);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnUpdate()
        {
            Enabled = ArcCatalog.Application != null;
        }
    }

    /// <summary>
    /// This class implements IWin32Window that allows the custom form to stay
    /// on top of the ArcCatalog window at all times.
    /// </summary>
    public class MyWrapper : System.Windows.Forms.IWin32Window
    {
        private IntPtr m_myIntPtr;

        public MyWrapper(IntPtr myIntPr)
        {
            m_myIntPtr = myIntPr;
        }

        public System.IntPtr Handle
        {
            get
            {
                return m_myIntPtr;
            }
        }
    }
}
