using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class clsMessageDialog
    {
        public static DialogResult Show(string Text, string Caption = "", MessageBoxButtons Button = MessageBoxButtons.OK,
            MessageBoxIcon Icon = MessageBoxIcon.None)
        {
            Guna2MessageDialog Message = new Guna2MessageDialog();

            Message.Style = MessageDialogStyle.Dark;

            Form actForm = Form.ActiveForm;

            if (actForm == null && Application.OpenForms.Count > 0)
                actForm.Parent = Application.OpenForms[Application.OpenForms.Count - 1];

            if (actForm != null)
                Message.Parent = actForm;

            Message.Caption = Caption;
            Message.Text = Text;

            switch (Button)
            {
                case MessageBoxButtons.YesNo:
                    {
                        Message.Buttons = MessageDialogButtons.YesNo;
                        break;
                    }

                case MessageBoxButtons.OKCancel:
                    {
                        Message.Buttons = MessageDialogButtons.OKCancel;
                        break;
                    }

                case MessageBoxButtons.YesNoCancel:
                    {
                        Message.Buttons = MessageDialogButtons.YesNoCancel;
                        break;
                    }

                default:
                    {
                        Message.Buttons = MessageDialogButtons.OK;
                        break;
                    }
            }


            switch (Icon)
            {
                case MessageBoxIcon.Error:
                    {
                        Message.Icon = MessageDialogIcon.Error;
                        break;
                    }

                case MessageBoxIcon.Information:
                    {
                        Message.Icon = MessageDialogIcon.Information;
                        break;
                    }

                case MessageBoxIcon.Warning:
                    {
                        Message.Icon=MessageDialogIcon.Warning;
                        break;
                    }

                case MessageBoxIcon.Question:
                    {
                        Message.Icon = MessageDialogIcon.Question;
                        break;
                    }

                case MessageBoxIcon.None:
                    {
                        Message.Icon = MessageDialogIcon.None;
                        break;
                    }
            }

            DialogResult Result = Message.Show();

            if (Button == MessageBoxButtons.OKCancel && Result == DialogResult.Yes)
                return DialogResult.OK;

            return Result;
        }

        public static DialogResult Show(string Text, string Caption, MessageBoxButtons Button,
            MessageBoxIcon Icon, MessageBoxDefaultButton DefaultButton)
        {
            return Show(Text, Caption, Button, Icon);
        }
    }
}
