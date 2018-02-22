using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public class Figure
    {
        public int x, y, c;
        public void setXYC (int x, int y, int c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }
        public virtual void DoDraw( PaintEventArgs e)
        {
            // Pen pen = new Pen(Color.Red);
            // e.Graphics.DrawEllipse(pen, x,y,c,c );
        }
        private void Form1_Paint(Object sender, PaintEventArgs e)
        {
            
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
