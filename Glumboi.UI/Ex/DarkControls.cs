using System.Linq;
using System.Windows.Forms;

namespace Glumboi.UI.Ex
{
    internal class DarkControls
    {
        private static void ChangeContextItems(ContextMenuStrip menuStrip)
        {
            foreach (ToolStripItem item in menuStrip.Items)
            {
                item.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                item.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        internal static void ChangeControlsToDark(Control control)
        {
            foreach (Button b in control.Controls.OfType<Button>())
            {
                b.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                b.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            
            foreach (TextBox t in control.Controls.OfType<TextBox>())
            {
                t.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                t.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            
            foreach (Label l in control.Controls.OfType<Label>())
            {
                l.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            }
            
            foreach (ComboBox c in control.Controls.OfType<ComboBox>())
            {
                c.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                c.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            } 
            
            foreach (ContextMenuStrip cms in control.Controls.OfType<ContextMenuStrip>())
            {
                ChangeContextItems(cms);

                cms.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                cms.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }

            control.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
        }

    }
}
