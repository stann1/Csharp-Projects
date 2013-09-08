using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06.WebCalculator
{
    public partial class WebCalculator : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ViewState.Add("commands", new List<string>());
            }
        }
        
        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            IButtonControl clickedButton = (IButtonControl)sender;
            List<string> commands = (List<string>)this.ViewState["commands"];
            int firstNum = int.Parse(commands[0]);
            int secondNum = commands.Count > 2 ? int.Parse(commands[2]) : 0;
            string operation = commands[1];
            double? output = null;

            switch (operation)
            {
                case "+": output = firstNum + secondNum;
                    break;
                case "-": output = firstNum - secondNum;
                    break;
                case "*": output = firstNum * secondNum;
                    break;
                case "/": output = (double)firstNum / secondNum;
                    break;
                case "sqrt": output = Math.Sqrt(firstNum);
                    break;
                default: 
                    break;
            }

            if (output != null)
            {
                this.InputOutput.Text = output.ToString();
            }
            else
            {
                this.InputOutput.Text = "Not allowed operation!";
            }

            //reset the viewstate
            this.ViewState["commands"] = new List<string>();
        }

        protected void OnCommandAction(object sender, CommandEventArgs e)
        {
            IButtonControl clickedButton = (IButtonControl)sender;
            ((List<string>)this.ViewState["commands"]).Add(clickedButton.Text);
            this.InputOutput.Text = clickedButton.Text;
           
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            this.ViewState["commands"] = new List<string>();
            this.InputOutput.Text = "";
        }
    }
}