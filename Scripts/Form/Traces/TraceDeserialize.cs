using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MapToolV2.Scripts.Form.Traces
{
    public class TraceDeserialize : IDeserializeTrace
    {
        RichTextBox textBox;
       public TraceDeserialize(RichTextBox _textBox)
        {
            textBox = _textBox;
        }

        void IDeserializeTrace.Log(string message, MesssageType type)
        {
            switch (type)
            {
                case MesssageType.info:
                    LogMessage(message);
                    break;

                case MesssageType.error:
                    LogErrorMessage(message);
                    break;
                case MesssageType.warning:
                    LogWarningMessage(message);
                    break;
                default:
                    LogMessage(message);
                    break;
            }
        }


        private void LogMessage(string message) 
        {
            textBox.AppendText(message + Environment.NewLine);
            textBox.AppendText("---");
            textBox.AppendText(Environment.NewLine);
        }

        private void LogErrorMessage(string message) 
        {
            textBox.SelectionStart = textBox.TextLength;
            textBox.SelectionLength = 0;

            textBox.SelectionColor = Color.Red;
            textBox.AppendText(message + Environment.NewLine);
            textBox.SelectionColor = textBox.ForeColor;

        }
        private void LogWarningMessage(string message)
        {
            textBox.SelectionStart = textBox.TextLength;
            textBox.SelectionLength = 0;

            textBox.SelectionColor = Color.Orange;
            textBox.AppendText(message + Environment.NewLine);
            textBox.SelectionColor = textBox.ForeColor;

        }

    }
}
