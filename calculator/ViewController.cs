using System;

using UIKit;

namespace calculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

        }

        bool clear = false;
        void CheckForClear()
        {
            if (clear)
                ResultBox.Text = "";
            clear = false;
        }



        partial void CalculateButton_TouchUpInside(UIButton sender)
        {
            try
            {
                ResignFirstResponder();
                ResultBox.Text = Calculator.getAnswer(ResultBox.Text).ToString();
                clear = true;
            }
            catch(Exception ex)
            {
                new UIAlertView("Error", ex.Message, null, "Ok", null).Show();
            }
            EnableButtons();

        }



        partial void PlusButton_TouchUpInside(UIButton sender)
        {
            ResultBox.Text += '+';

            //disable operation buttons, only allow two variables
            DisableButtons();
        }

        private void DisableButtons()
        {
            PlusButton.Enabled = false;
            MinusButton.Enabled = false;
            MultiplyButton.Enabled = false;
            DivideButton.Enabled = false;
        }

        private void EnableButtons()
        {
            PlusButton.Enabled = true;
            MinusButton.Enabled = true;
            MultiplyButton.Enabled = true;
            DivideButton.Enabled = true;
        }

        partial void MinusButton_TouchUpInside(UIButton sender)
        {
            ResultBox.Text += '-';
            DisableButtons();
        }

        partial void MultiplyButton_TouchUpInside(UIButton sender)
        {
            ResultBox.Text += '*';
            DisableButtons();
        }

        partial void DivideButton_TouchUpInside(UIButton sender)
        {
            ResultBox.Text += '/';
            DisableButtons();
        }

        partial void NineButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '9';
        }

        partial void EightButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '8';
        }

        partial void SevenButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '7';
        }

        partial void SixButton_TouchUpInside(UIButton sender)
        {
            ResultBox.Text += '6';
        }

        partial void FiveButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '5';
        }

        partial void FourButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '4';
        }

        partial void ThreeButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '3';
        }

        partial void TwoButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '2';
        }

        partial void OneButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '1';
        }

        partial void ZeroButton_TouchUpInside(UIButton sender)
        {
            CheckForClear();
            ResultBox.Text += '0';
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
