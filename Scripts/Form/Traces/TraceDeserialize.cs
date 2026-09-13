using VDBA.GameDataGetter.Interfaces;

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
                case MesssageType.Info:
                    LogMessage(message);
                    break;

                case MesssageType.Error:
                    LogErrorMessage(message);
                    break;
                case MesssageType.Warning:
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
