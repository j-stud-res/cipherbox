using System;

namespace cipherBox.Tools
{

    class Caeser
    {
        public enum Mode { None, LANG, TABLE };
        public enum ModeOption { None, ENG, BG, CHCP1251, ASCII, UTF8 }
        public int Shift { get; set; }
        private Mode _instanceMode;
        public Mode InstanceMode
        {
            get
            {
                return this._instanceMode;
            }
            set
            {
                this._instanceModeOption = ModeOption.None;
                this._instanceMode = value;
            }
        }

        private ModeOption _instanceModeOption;
        public ModeOption InstanceModeOption
        {
            get
            {
                return this._instanceModeOption;
            }
            set
            {
                if((this.InstanceMode == Mode.LANG && value > ModeOption.BG) ||
                    (this.InstanceMode == Mode.TABLE && value < ModeOption.CHCP1251))
                {
                    throw new InvalidOperationException("Invalid mode option for selected mode");
                }
                this._instanceModeOption = value;
            }
        }

        public Caeser()
        {
            this.Shift = 3;
        }

        public string Decode(string text)
        {
            return "Success Decoded";
        }

        public string Encode(string text)
        {
            return "Success Encoded";

        }

        public string BruteForce(string text)
        {
            throw new NotImplementedException();
        }
    }
}
