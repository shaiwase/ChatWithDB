using System.Drawing;
using System.Windows.Forms;

//This class intends to customized the tooltip used in MessageDbTable.cs class at calendar + search textboxes. 
namespace server_ui
{
   public  class CustomizedTooltip : ToolTip
    {
        /// <summary>
        /// Ctor for the customized tooltip.Sets background and foregrounds colors
        /// </summary>
        public CustomizedTooltip()
        {
            this.BackColor = Color.LightCyan;
            this.ForeColor = Color.BlueViolet;
            this.OwnerDraw = true; //Set to true to indicate this form application is the owner and not the operating system
            this.Draw += ToolTipCalendar; //Call the method as an event to use the defined settings at CTOR for this tooltip
        }

        /// <summary>
        /// Methods that set the properties from ctor to this tooltip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolTipCalendar(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground(); //set the background color
            e.DrawBorder(); //set the borders
            e.DrawText();//Display the text in the tipbox
         
        }
    }
}
