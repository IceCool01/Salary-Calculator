using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class UIHelper
    {
        private List<Label> labelsToClear;
        

        public UIHelper(List<Label> labelsToClear)
        {
            this.labelsToClear = labelsToClear;
            
        }

        public void ClearTextBoxesAndLabels(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "0";
                }
                else if (control is Label label && labelsToClear.Contains(label))
                {
                    label.Text = string.Empty;
                }
                else if (control.HasChildren)
                {
                    ClearTextBoxesAndLabels(control);
                }
            }
            
            
        }

        
    }
}
